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
    public partial class UserWindow : Form
    {
        private NpgsqlConnection connect;
        private Filter filterform;
        public UserWindow(string login)
        {
            InitializeComponent();
            filterform = new Filter(FilterTextBox);
            filterform.Hide();
            connect = GetConnection();
            login_label.Text = login;
            UpdatePlaylistData();
        }


        private void OutputErrorMessageBox(string error)
        {
            MessageBox.Show(error);
        }


        // connection methods
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Username=listener_pg;Database=Cursach;Port=5432;Password=listener;");
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


        // filter any information
        private void FilterButton_Click(object sender, EventArgs e)
        {
            try { CheckFilter(); }
            catch (Exception a) { OutputErrorMessageBox(a.Message); return; }

            OpenConnection();
            // get list with filters
            var req1 = "select musician_name from \"Musician\"";
            var req2 = "select distinct style_name from \"Style\"";
            List<string> list;
            if (CheckFilter()) list = GetListWithFilter(req1);
            else list = GetListWithFilter(req2);

            // open dialog form
            this.Hide();
            filterform = new Filter(FilterTextBox);
            filterform.InitializeDgw(list);
            filterform.ShowDialog();

            // fill first table
            if (CheckFilter())
            {
                var req = $"select s.id_song, song_name, musician_name from \"Musician\" as m " +
                    $"join \"SongMusician\" as sm on m.id_musician = sm.id_musician and musician_name = '{FilterTextBox.Text}'" +
                    $"join \"Song\" as s on sm.id_song = s.id_song order by song_name";
                FillAllSongDgw(req);
            }
            else
            {
                var req = $"select \"Song\".id_song, song_name, style_name from \"Song\",\"Style\"" +
                    $"where \"Song\".id_song = \"Style\".id_song and \"Style\".style_name = '{FilterTextBox.Text}' " +
                    $"order by song_name";
                FillAllSongDgw(req);
            }
            this.Show();
            CloseConnection();
        }
        private bool CheckFilter() 
        {
            if ((MusicianRadioButton.Checked || StyleRadioButton.Checked) == false) throw new Exception("Нужно выбрать фильтр!");
            if (MusicianRadioButton.Checked) return true;
            else return false;
        }
        private List<string> GetListWithFilter(string req) 
        {
            var result = new List<string>();
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = req;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    result.Add(reader.GetValue(0).ToString());
            reader.Close();
            return result;
        }
        private void FillAllSongDgw(string req) 
        {
            this.AllSongDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = req;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read()) 
                {
                    var id = reader.GetValue(0);
                    var name = reader.GetValue(1);
                    var filter = reader.GetValue(2);
                    AllSongDgw.Rows.Add(id, name, filter, "Выбрать");
                }
            reader.Close();
        }


        // work with user playlist
        private int GetUserId(string login) // get id in users by login
        {
            NpgsqlCommand find_id_bylogin = connect.CreateCommand();
            NpgsqlDataReader dr;
            find_id_bylogin.CommandText = $"Select id_user from \"User\" where user_log = \'{login}\'";
            dr = find_id_bylogin.ExecuteReader();
            var id = -1;
            if (dr.HasRows)
                while (dr.Read())
                    id = (int)dr.GetValue(0);
            dr.Close();
            return id;
        }
        private void UpdatePlaylistData() 
        {
            SendDgw.Rows.Clear();
            OpenConnection();
            var req = "select s.id_song, id_user, song_name, song_mark from \"Playlist\" as p, \"Song\" as s " +
                $"where s.id_song = p.id_song and id_user = {GetUserId(login_label.Text)} order by song_mark DESC";
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = req;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                {
                    var id_song = reader.GetValue(0);
                    var id_user = reader.GetValue(1);
                    var song_name = reader.GetValue(2);
                    var mark = reader.GetValue(3);
                    SendDgw.Rows.Add(id_song, id_user, song_name, mark, "Удалить");
                }
            reader.Close();
            CloseConnection();
        }
        private bool isConsist(int id_song) 
        {
            for (var i = 0; i < SendDgw.Rows.Count; i++)
                if (SendDgw.Rows[i].Cells[0].Value != null && (int)SendDgw.Rows[i].Cells[0].Value == id_song)
                    return true;
            return false;
        }
        private void AllSongDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Выбрать")
            {
                OpenConnection();
                var cells = dgw.Rows[e.RowIndex].Cells;
                if (SendDgw.Rows.Count == 5) MessageBox.Show("Нельзя выбрать более 5 песен!");
                else
                {
                    if (isConsist((int)cells[0].Value))
                        MessageBox.Show("Такой трек уже есть в вашем плейлисте!");
                    else SendDgw.Rows.Add(cells[0].Value, GetUserId(login_label.Text), cells[1].Value, 5 - SendDgw.Rows.Count, "Удалить");
                }
                CloseConnection();
            }
        }
        private void SendDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Удалить")
            {
                for (var i = e.RowIndex; i < dgw.Rows.Count; i++)
                    if (dgw.Rows[i].Cells[3].Value != null)
                        dgw.Rows[i].Cells[3].Value = (int)dgw.Rows[i].Cells[3].Value + 1;
                dgw.Rows.RemoveAt(e.RowIndex);
            }
        }


        // save playlist
        private void AddSongInPlaylist(int id_song, int id_user, int mark) 
        {
            var req = "insert into \"Playlist\" (id_song, id_user, song_mark) " +
                $"values ({id_song}, {id_user}, {mark})";
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = req;
            cmd.ExecuteNonQuery();
        }
        private void SaveSongButton_Click(object sender, EventArgs e)
        {
            if (SendDgw.Rows.Count < 5) 
            {
                MessageBox.Show("Для сохранения выберите 5 песен!");
                return;
            }
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = $"delete from \"Playlist\" where id_user = {GetUserId(login_label.Text)}";
            cmd.ExecuteNonQuery();
            for (var i = 0; i < SendDgw.Rows.Count; i++) 
            {
                if (SendDgw.Rows[i].Cells[0].Value != null)
                {
                    var id_song = (int)SendDgw.Rows[i].Cells[0].Value;
                    var id_user = (int)SendDgw.Rows[i].Cells[1].Value;
                    var mark = (int)SendDgw.Rows[i].Cells[3].Value;
                    AddSongInPlaylist(id_song, id_user, mark);
                }
            }
            CloseConnection();
            MessageBox.Show("Плейлист успешно сохранен!");
        }


        // correct user data form
        private void FixUserDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OpenConnection();
            var newform = new CorrectUserData(GetUserId(login_label.Text));
            newform.ShowDialog();
            CloseConnection();
            this.Show();
        }
    }
}
