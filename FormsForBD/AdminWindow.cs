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
                    MusicianDgw.Rows.Add(id, name, "Применить", "Удалить");
                }
            reader.Close();
        }
        private void AddMusicianBtn_Click(object sender, EventArgs e)
        {
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
            OpenConnection();
            var dgw = (DataGridView)sender;
            if (e.ColumnIndex == 2) //save
            {
                var newname = dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
                var id_musician = (int)dgw.Rows[e.RowIndex].Cells[0].Value;
                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = $"select * from \"Musician\" where musician_name = '{newname}'";
                NpgsqlDataReader reader = cmd.ExecuteReader();
                var ok = reader.HasRows;
                reader.Close();
                if (!ok)
                {
                    NpgsqlCommand updatecmd = connect.CreateCommand();
                    updatecmd.CommandText = $"update \"Musician\" set musician_name = '{newname}' where id_musician = {id_musician}";
                    updatecmd.ExecuteNonQuery();
                    MessageBox.Show("Изменения успешно сохранены!");
                    UpdateMusicianGrid();
                }
                else MessageBox.Show("Исполнитель с таким именем уже существует!");
            }
            if (e.ColumnIndex == 3) //delete
            {
                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = $"delete from \"Musician\" where id_musician = {(int)dgw.Rows[e.RowIndex].Cells[0].Value}";
                cmd.ExecuteNonQuery();
                UpdateMusicianGrid();
            }
            CloseConnection();
        }
    }
}
