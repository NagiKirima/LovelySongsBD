using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace FormsForBD
{
    public partial class AdminWindow : Form
    {
        private NpgsqlConnection connect;
        public AdminWindow()
        {
            InitializeComponent();
            connect = GetConnection();
            OpenConnection();
            UpdateMusicianGrid();
            UpdateSongGrid();
            CloseConnection();
        }
        // connection methods
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Username=postgres;Database=Cursach;Port=5432;Password=ranopi125;");
        }
        private void OpenConnection()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
            }
            catch
            {
                CloseConnection();
            }
        }
        private void CloseConnection()
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
        }


        // registrate new user
        private void RegistrateUserPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var reg = new Registration();
            reg.ShowDialog();
            this.Show();
        }

        // entry like a user
        private bool CheckLogin(string login) 
        {
            bool is_entry = false;
            if (login.Contains(' ')) return is_entry;
            OpenConnection();
            try
            {
                NpgsqlCommand find_login = connect.CreateCommand();
                NpgsqlDataReader dr;
                find_login.CommandText = $"Select id_user from \"User\" where user_log = \'{login}\'";
                dr = find_login.ExecuteReader();
                is_entry = dr.HasRows;
                dr.Close();
            }
            catch { }
            CloseConnection();
            return is_entry;
        }
        private void EntryUserButton_Click(object sender, EventArgs e)
        {
            if (UserLoginTextBox.TextLength == 0) MessageBox.Show("Введите логин!");
            else
            {
                if (CheckLogin(UserLoginTextBox.Text))
                {
                    this.Hide();
                    var reg = new UserWindow(UserLoginTextBox.Text);
                    reg.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Такого пользователя не существует!");
            }
        }


        // musician crud methods
        private void UpdateMusicianGrid() 
        {
            MusicianDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Musician\" order by musician_name";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    var id = (int)reader.GetValue(0);
                    var name = (string)reader.GetValue(1);
                    MusicianDgw.Rows.Add(id, name, "Применить");
                }
            reader.Close();
        }
        private void AddMusicianBtn_Click(object sender, EventArgs e)
        {
            if (MusicianNameTextBox.Text == "") { MessageBox.Show("Введите данные в строку имени музыканта!"); return; }
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Musician\" where musician_name = '{MusicianNameTextBox.Text}'";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Такой исполнитель уже существует!");
                reader.Close();
            }
            else
            {
                reader.Close();
                NpgsqlCommand cmd2 = connect.CreateCommand();
                cmd.CommandText = $"insert into \"Musician\" (musician_name) values ('{MusicianNameTextBox.Text}')";
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Исполнитель {MusicianNameTextBox.Text} успешно добавлен!");
                UpdateMusicianGrid();
            }
            CloseConnection();
        }
        private void MusicianDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Применить") //save
            {
                OpenConnection();
                var newname = dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
                var id_musician = (int)dgw.Rows[e.RowIndex].Cells[0].Value;
                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = $"select * from \"Musician\" where id_musician = {id_musician}";
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string prevname = null;
                    while (reader.Read()) prevname = (string)reader.GetValue(1);
                    reader.Close();
                    if (prevname != newname)
                    {
                        NpgsqlCommand updatecmd = connect.CreateCommand();
                        updatecmd.CommandText = $"update \"Musician\" set musician_name = '{newname}' where id_musician = {id_musician}";
                        updatecmd.ExecuteNonQuery();
                        MessageBox.Show("Изменения успешно сохранены!");
                        UpdateMusicianGrid();
                    }
                    else MessageBox.Show("Изменений не было!");
                }
                else reader.Close();
                CloseConnection();
            }
        }


        // song crud methods
        private void UpdateSongGrid() 
        {
            SongDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Song\" order by song_name";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    var id = (int)reader.GetValue(0);
                    var name = (string)reader.GetValue(1);
                    var len = (int)reader.GetValue(2);
                    SongDgw.Rows.Add(id, name, len, "Применить");
                }
            reader.Close();
        }
        private void AddSongButton_Click(object sender, EventArgs e)
        {
            if (SongNameTextBox.Text == "") { MessageBox.Show("Введите данные в строку имени трека!"); return; }
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Song\" where song_name = '{SongNameTextBox.Text}'";
            NpgsqlDataReader r = cmd.ExecuteReader();
            var ok = r.HasRows;
            r.Close();
            if (ok) MessageBox.Show("Трек с таким названием уже существует!");
            else 
            {
                NpgsqlCommand addcmd = connect.CreateCommand();
                addcmd.CommandText = $"insert into \"Song\" (song_name) values ('{SongNameTextBox.Text}')";
                addcmd.ExecuteNonQuery();
                MessageBox.Show("Трек успешно добавлен!");
                UpdateSongGrid();
            }
            CloseConnection();
        }
        private void SongDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenConnection();
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Применить") //save
            {
                OpenConnection();
                var newname = dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
                var id_song = (int)dgw.Rows[e.RowIndex].Cells[0].Value;
                var newlen = int.Parse(dgw.Rows[e.RowIndex].Cells[2].Value.ToString());

                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = $"select * from \"Song\" where id_song = {id_song}";
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    string prevname = null;
                    int prevlen = -1;
                    while (reader.Read())
                    {
                        prevname = (string)reader.GetValue(1);
                        prevlen = (int)reader.GetValue(2);
                    }
                    reader.Close();
                    if (prevname != newname && prevlen == newlen) // new name
                    {
                        NpgsqlCommand updatecmd = connect.CreateCommand();
                        updatecmd.CommandText = $"update \"Song\" set song_name = '{newname}' where id_song = {id_song}";
                        updatecmd.ExecuteNonQuery();
                        MessageBox.Show("Изменения успешно сохранены!");
                        UpdateSongGrid();
                    }
                    else if (prevname == newname && prevlen != newlen) // new len
                    {
                        NpgsqlCommand updatecmd = connect.CreateCommand();
                        updatecmd.CommandText = $"update \"Song\" set song_len = '{newlen}' where id_song = {id_song}";
                        updatecmd.ExecuteNonQuery();
                        MessageBox.Show("Изменения успешно сохранены!");
                        UpdateSongGrid();
                    }
                    else if (prevname != newname && prevlen != newlen) // new len and name
                    {
                        NpgsqlCommand updatecmd = connect.CreateCommand();
                        updatecmd.CommandText = $"update \"Song\" set song_name = '{newname}', song_len = {newlen} where id_song = {id_song}";
                        updatecmd.ExecuteNonQuery();
                        MessageBox.Show("Изменения успешно сохранены!");
                        UpdateSongGrid();
                    }
                    else
                    {
                        MessageBox.Show($"Изменений не было!");
                    }
                }
                else reader.Close();
                CloseConnection();
            }
        }

        // songmusician crud methods
        // choice song
        private void ChoiceSongButton_Click(object sender, EventArgs e)
        {
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Song\" order by id_song";
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                var result = new List<KeyValuePair<int, string>>();
                while (r.Read()) result.Add(new KeyValuePair<int, string>((int)r.GetValue(0), (string)r.GetValue(1)));
                r.Close();
                this.Hide();
                AddSongMusicianForm form = new AddSongMusicianForm(this, song_label);
                form.InitializeDgw(result);
                form.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Треки отсутствуют!");
            r.Close();
            CloseConnection();
        }
        //choice musician
        private void ChoiceMusicianButton_Click(object sender, EventArgs e)
        {

            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select * from \"Musician\" order by id_musician";
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                var result = new List<KeyValuePair<int, string>>();
                while (r.Read()) result.Add(new KeyValuePair<int, string>((int)r.GetValue(0), (string)r.GetValue(1)));
                r.Close();
                this.Hide();
                AddSongMusicianForm form = new AddSongMusicianForm(this, musician_label);
                form.InitializeDgw(result);
                form.ShowDialog();
                this.Show();
            }
            else MessageBox.Show("Исполнители отсутствуют!");
            r.Close();
            CloseConnection();
        }
    }
}
