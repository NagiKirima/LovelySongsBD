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


        // choice data for result playlist
        private void UpdatePlayListDgw(string date) 
        {
            PlaylistDgw.Rows.Clear();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT \"Song\".id_song, \"UserInformation\".id_user, user_surname, user_name, user_patronymic, user_age, user_gender, song_name, song_mark FROM \"Playlist\" " +
                "JOIN \"Song\" on \"Playlist\".id_song = \"Song\".id_song " +
                "JOIN \"UserInformation\" on \"Playlist\".id_user = \"UserInformation\".id_user " +
                $"where playlist_date = '{date}'" +
                "order by user_surname asc, user_name asc, user_patronymic asc, song_mark desc ";
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
            UpdatePlayListDgw(DateTextBox.Text);
            CloseConnection();
        }
    }
}
