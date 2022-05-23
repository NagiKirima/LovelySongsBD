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


        // check correct login and password in users
        private bool Entry(string login, string password)
        {
            if (connect.State != ConnectionState.Closed)
            {
                NpgsqlCommand find_login_pass = connect.CreateCommand();
                NpgsqlDataReader dr;
                find_login_pass.CommandText = $"Select id_user, user_log, user_pass from \"User\" where user_log = \'{login}\' and user_pass = \'{password}\'";
                dr = find_login_pass.ExecuteReader();
                var is_entry = dr.HasRows;
                dr.Close();
                return is_entry;
            }
            OutputErrorMessageBox("Нет соединения c сервером!");
            return false;
        }
        private bool IsAdmin(string login) 
        {
            var req = $"select \"User\".id_user from \"User\",\"Admin\" where \"User\".id_user = \"Admin\".id_user and \"User\".user_log = '{login}'";
            NpgsqlCommand cmd = connect.CreateCommand(); cmd.CommandText = req;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            var is_admin = reader.HasRows;
            reader.Close();
            return is_admin;
        }


        // button clicks events
        private void TryEntryButton_Click(object sender, EventArgs e)
        {
            OpenConnection();
            if (Entry(LoginTextBox.Text, PasswordTextBox.Text))
            {
                if (IsAdmin(LoginTextBox.Text))
                {
                    this.Hide();
                    var adminwindow = new AdminWindow();
                    adminwindow.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    var userwindow = new UserWindow(LoginTextBox.Text);
                    userwindow.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                if(connect.State != ConnectionState.Closed) OutputErrorMessageBox("Логин или пароль введены неправильно!");
            }
            CloseConnection();
        }
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            var regwindow = new Registration();
            this.Hide();
            regwindow.ShowDialog();
            this.Show();
        }

        // set visible for password
        private void PasswordIcon_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar) PasswordTextBox.UseSystemPasswordChar = false;
            else PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
