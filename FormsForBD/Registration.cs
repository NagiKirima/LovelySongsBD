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
    public partial class Registration : Form
    {
        private NpgsqlConnection connect;
        public Registration()
        {
            InitializeComponent();
            connect = GetConnection();
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


        // get correct user data
        private void CheckLogin(string login) 
        {
            if (!login.Contains(' '))
            {
                NpgsqlCommand find_login_pass = connect.CreateCommand();
                NpgsqlDataReader dr;
                find_login_pass.CommandText = $"Select * from \"User\" where user_log = \'{login}\'";
                dr = find_login_pass.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    throw new Exception("Такой пользователь уже существует!");
                }
                dr.Close();
            }
            else throw new Exception("Уберите пробелы из строки логина!");
        }
        private void CheckPassword() 
        {
            if (PasswordTextBox.Text.Contains(' ')) throw new Exception("Пароль должен быть без пробелов!");
            if (PasswordTextBox.Text.Length < 8) throw new Exception("Пароль должен быть длиннее 8 символов!");
            if (PasswordTextBox.Text.Length > 30) throw new Exception("Пароль должен быть короче 30 символов!");
        }
        private bool CheckGender() 
        {
            if ((FemaleRadio.Checked || MaleRadio.Checked) == false) throw new Exception("Выберете ваш пол!");
            if (FemaleRadio.Checked) return false;
            else return true;
        }
        private void CheckString(string str, string textboxname) 
        {
            foreach (var i in str) if (!char.IsLetter(i)) throw new Exception($"Удалите из строки {textboxname} все цифры и спецсимволы");
            if(str.Length == 0) throw new Exception($"Введите данные в строку {textboxname}");
        }
        private int CheckAge() 
        {
            int age;
            try { age = int.Parse(AgeTextBox.Text); }
            catch { throw new Exception("Введите корректные данные в поле возраста!"); }
            if (age < 1) throw new Exception("Возраст не может быть меньше 1!");
            return age;
        }

        // click button event
        private void SendFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenConnection();
                CheckLogin(LoginTextBox.Text);
                CheckPassword();
                var g = CheckGender();
                CheckString(SurnameTextBox.Text, "Фамилии");
                CheckString(NameTextBox.Text, "имени");
                CheckString(PatronymicTextBox.Text, "отчества");
                var age = CheckAge();
                AddUser(NameTextBox.Text, SurnameTextBox.Text, PatronymicTextBox.Text, age.ToString(), g.ToString());

                MessageBox.Show("Регистрация прошла успешно!");
            }
            catch (Exception a) 
            {
                MessageBox.Show(a.Message);
                CloseConnection();
                return;
            }
            CloseConnection();
            this.Close();
        }
        private void AddUser(string name, string sname, string patr, string age, string gender) 
        {
            // add user in users
            var req1 = $"insert into \"User\" (user_log, user_pass) values (\'{LoginTextBox.Text}\',\'{PasswordTextBox.Text}\')";
            NpgsqlCommand command = connect.CreateCommand();
            command.CommandText = req1;
            command.ExecuteNonQuery();

            // get id in users
            var req2 = $"select id_user from \"User\" where user_log = \'{LoginTextBox.Text}\'";
            string id = "";
            command.CommandText = req2;
            NpgsqlDataReader dr = command.ExecuteReader();
            if (dr.HasRows)
                while (dr.Read())
                    id = dr.GetValue(0).ToString();
            dr.Close();

            // add data in userinformation
            var req3 = $"insert into \"UserInformation\" (user_name, user_surname, user_patronymic," +
                $"user_age, user_gender, id_user) values (\'{name}\',\'{sname}\',\'{patr}\'," +
                $"{age},\'{gender}\',{id})";
            command.CommandText = req3;
            command.ExecuteNonQuery();
        }

        // set visible for password
        private void PasswordIcon_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar) PasswordTextBox.UseSystemPasswordChar = false;
            else PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
