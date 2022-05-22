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
    public partial class Authorization : Form
    {
        private NpgsqlConnection connect;
        public Authorization()
        {
            InitializeComponent();
            this.Text = "Авторизация";
            connect = GetConnection();
        }

        // output error
        private void OutputErrorMessageBox(string error) 
        {
            MessageBox.Show(error);
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



        private bool Entry(string login, string password)
        {
            if (connect.State != ConnectionState.Closed)
            {
                NpgsqlCommand find_login_pass = connect.CreateCommand();
                NpgsqlDataReader dr;
                find_login_pass.CommandText = $"Select id_user, user_log, user_pass from \"User\" where user_log = \'{login}\' and user_pass = \'{password}\'";
                dr = find_login_pass.ExecuteReader();
                return dr.HasRows;
            }
            OutputErrorMessageBox("Нет соединения c сервером!");
            return false;
        }



        // button clicks events
        private void TryEntryButton_Click(object sender, EventArgs e)
        {
            OpenConnection();
            if (Entry(LoginTextBox.Text, PasswordTextBox.Text))
            {
                var adminwindow = new AdminWindow();
                adminwindow.ShowDialog();
            }
            else
            {
                if(connect.State != ConnectionState.Closed) OutputErrorMessageBox("Логин или пароль введены неправильно!");
                CloseConnection();
            }
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var regwindow = new Registration();
            regwindow.ShowDialog();
        }
    }
}
