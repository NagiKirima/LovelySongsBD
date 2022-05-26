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
    public partial class AdminResultsForm : Form
    {
        private NpgsqlConnection connect;
        public AdminResultsForm(NpgsqlConnection connect)
        {
            InitializeComponent();
            this.connect = connect;
            OpenConnection();
            UpdateDiscDgw();
            UpdateSongDiscDgw();
            CloseConnection();
        }


        // connection methods
        private static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(@"Server=localhost;Username=admin_pg;Database=Cursach;Port=5432;Password=admin;");
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


        // all results and raiting methods
        private void UpdatePlayListDgw(string date) 
        {
            PlaylistDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            if (FilterRaitingTextBox.Text == "")
            {
                cmd.CommandText = "SELECT \"Song\".id_song, \"UserInformation\".id_user, user_surname, user_name, user_patronymic, user_age, user_gender, song_name, song_mark FROM \"Playlist\" " +
                    "JOIN \"Song\" on \"Playlist\".id_song = \"Song\".id_song " +
                    "JOIN \"UserInformation\" on \"Playlist\".id_user = \"UserInformation\".id_user " +
                    $"where playlist_date = '{date}'" +
                    "order by user_surname asc, user_name asc, user_patronymic asc, song_mark desc ";
            }
            else 
            {
                var list = FilterRaitingTextBox.Text.Split(';');
                if (list[0] != "-")
                {
                    bool g = false;
                    if (list[0] == "m") g = true;
                    cmd.CommandText = "SELECT \"Song\".id_song, \"UserInformation\".id_user, user_surname, user_name, user_patronymic, user_age, user_gender, song_name, song_mark FROM \"Playlist\" " +
                        "JOIN \"Song\" on \"Playlist\".id_song = \"Song\".id_song " +
                        "JOIN \"UserInformation\" on \"Playlist\".id_user = \"UserInformation\".id_user " +
                        $"where playlist_date = '{date}' and user_gender = {g} and user_age {list[1]} {list[2]} " +
                        "order by user_surname asc, user_name asc, user_patronymic asc, song_mark desc ";
                }
                else 
                {
                    cmd.CommandText = "SELECT \"Song\".id_song, \"UserInformation\".id_user, user_surname, user_name, user_patronymic, user_age, user_gender, song_name, song_mark FROM \"Playlist\" " +
                        "JOIN \"Song\" on \"Playlist\".id_song = \"Song\".id_song " +
                        "JOIN \"UserInformation\" on \"Playlist\".id_user = \"UserInformation\".id_user " +
                        $"where playlist_date = '{date}' and user_age {list[1]} {list[2]} " +
                        "order by user_surname asc, user_name asc, user_patronymic asc, song_mark desc ";
                }
            }
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
                while (r.Read()) 
                {
                    var id_song = (int)r.GetValue(0);
                    var id_user = (int)r.GetValue(1);
                    var surname = r.GetValue(2).ToString();
                    var name = r.GetValue(3).ToString();
                    var patr = r.GetValue(4).ToString();
                    var age = (int)r.GetValue(5);
                    var g = (bool)r.GetValue(6);
                    var s_name = r.GetValue(7).ToString();
                    var mark = (int)r.GetValue(8);
                    PlaylistDgw.Rows.Add(id_song, id_user, surname, name, patr, age, g, s_name, mark);
                }
            r.Close();
        }
        private void UpdateRaitingDgw(string date) 
        {
            RaitingDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            if (FilterRaitingTextBox.Text == "")
            {
                cmd.CommandText = "select s.id_song, song_name, count(*), avg(song_mark), p.playlist_date from \"Playlist\" as p, \"Song\" as s where p.id_song = s.id_song " +
                    $"and p.playlist_date = '{date}' " +
                    "group by s.id_song, p.playlist_date order by count desc, avg desc, song_name asc";
            }
            else 
            {
                var list = FilterRaitingTextBox.Text.Split(';');
                if (list[0] != "-")
                {
                    bool g = false;
                    if (list[0] == "m") g = true;
                    cmd.CommandText = "select s.id_song, song_name, count(*), avg(song_mark), p.playlist_date from \"Playlist\" as p, \"Song\" as s, \"UserInformation\" as u " +
                        $"where p.id_song = s.id_song and p.playlist_date = '{date}' and p.id_user = u.id_user and u.user_gender = {g} " +
                        $"and u.user_age {list[1]} {list[2]} " +
                        "group by s.id_song, p.playlist_date order by count desc, avg desc, song_name asc";
                }
                else
                {
                    cmd.CommandText = "select s.id_song, song_name, count(*), avg(song_mark), p.playlist_date from \"Playlist\" as p, \"Song\" as s, \"UserInformation\" as u " +
                        $"where p.id_song = s.id_song and p.playlist_date = '{date}' and p.id_user = u.id_user and u.user_age {list[1]} {list[2]} " +
                        "group by s.id_song, p.playlist_date order by count desc, avg desc, song_name asc";
                }
            }
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
                while (r.Read())
                {
                    var id_song = (int)r.GetValue(0);
                    var song_name = r.GetValue(1).ToString();
                    var count = int.Parse(r.GetValue(2).ToString());
                    var avg = float.Parse(r.GetValue(3).ToString());
                    var p_date = r.GetValue(4).ToString();
                    RaitingDgw.Rows.Add(id_song, song_name, count, avg, p_date, FilterRaitingTextBox.Text);
                }
            r.Close();
        }
        private void FilterDateButton_Click(object sender, EventArgs e)
        {
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"select distinct playlist_date from \"Playlist\"";
            NpgsqlDataReader r = cmd.ExecuteReader();
            List<string> dates = new List<string>(); // get dates
            if (r.HasRows)
                while (r.Read())
                    dates.Add(r.GetValue(0).ToString()); ;
            r.Close();

            this.Hide();
            var filter = new Filter(DateTextBox);
            filter.InitializeDgw(dates);
            filter.ShowDialog();
            this.Show();
            CloseConnection();
        }
        private void ChoiceFilterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RaitingFilterForm(FilterRaitingTextBox);
            form.ShowDialog();
            this.Show();
        }
        private void clear_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FilterRaitingTextBox.Text = "";
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (DateTextBox.Text == "")
            {
                MessageBox.Show("Выберите дату!");
                return;
            }
            OpenConnection();
            UpdatePlayListDgw(DateTextBox.Text);
            UpdateRaitingDgw(DateTextBox.Text);
            CloseConnection();
        }


        // disc methods
        private void UpdateDiscDgw() 
        {
            DiscDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select * from \"Disc\"";
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
                while (r.Read()) 
                {
                    var id = int.Parse(r.GetValue(0).ToString());
                    var date = r.GetValue(1).ToString();
                    var filter = r.GetValue(2).ToString();
                    DiscDgw.Rows.Add(id, date, filter, "Удалить");
                }
            r.Close();
        }
        private void UpdateSongDiscDgw() 
        {
            SongDiscDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "select d.id_disc, s.id_song, song_name, disc_date, disc_filter from \"SongDisc\" as sd " +
                "join \"Disc\" as d on sd.id_disc = d.id_disc " +
                "join \"Song\" as s on s.id_song = sd.id_song " +
                "order by disc_date desc, d.id_disc asc";
            NpgsqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
                while (r.Read())
                {
                    var id_d = (int)r.GetValue(0);
                    var id_s = (int)r.GetValue(1);
                    var name = r.GetValue(2).ToString();
                    var date = r.GetValue(3).ToString();
                    var filter = r.GetValue(4).ToString();
                    SongDiscDgw.Rows.Add(id_d, id_s, name, date, filter);
                }
            r.Close();
        }
        private void AddDiscButton_Click(object sender, EventArgs e)
        {
            if (RaitingDgw.Rows.Count < 5) 
            {
                MessageBox.Show("Рейтинг пуст!");
                return;
            }
            var date = RaitingDgw.Rows[0].Cells[4].Value.ToString();
            var filter = RaitingDgw.Rows[0].Cells[5].Value.ToString();
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"insert into \"Disc\" (disc_date, disc_filter) values ('{date}', '{filter}')";
            try { cmd.ExecuteNonQuery(); }
            catch 
            {
                MessageBox.Show($"Пластинка {date}, {filter} уже существует");
                CloseConnection();
                return;
            }

            cmd.CommandText = $"select id_disc from \"Disc\" where disc_date = '{date}' and disc_filter = '{filter}'";
            NpgsqlDataReader r = cmd.ExecuteReader();
            int id_disc = -1;
            if (r.HasRows)
                while (r.Read())
                    id_disc = int.Parse(r.GetValue(0).ToString());
            r.Close();

            for (var i = 0; i < 5; i++) 
            {
                cmd.CommandText = $"insert into \"SongDisc\" (id_disc, id_song) values ({id_disc}, {(int)RaitingDgw.Rows[i].Cells[0].Value})";
                cmd.ExecuteNonQuery();
            }
            UpdateDiscDgw();
            UpdateSongDiscDgw();
            CloseConnection();
        }
        private void DiscDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Удалить") 
            {
                OpenConnection();
                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = $"delete from \"Disc\" where id_disc = {int.Parse(dgw.Rows[e.RowIndex].Cells[0].Value.ToString())}";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пластинка успешно удалена!");
                UpdateDiscDgw();
                UpdateSongDiscDgw();
                CloseConnection();
            }
        }
    }
}
