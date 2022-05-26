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
    public partial class CorrectUserData : Form
    {
        private int id_user { get; set; }
        private bool correct_acces { get; set; }
        private NpgsqlConnection connect;
        public CorrectUserData(int id)
        {
            InitializeComponent();
            connect = GetConnection();
            id_user = id;
            SendFormButton.Enabled = AgeTextBox.Enabled = FemaleRadio.Enabled = MaleRadio.Enabled = PatronymicTextBox.Enabled = SurnameTextBox.Enabled = NameTextBox.Enabled = false;
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
     

        // confirm password
        private void confirm_password_button_Click(object sender, EventArgs e)
        {
            OpenConnection();
            NpgsqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = $"Select user_name, user_surname, user_patronymic, user_age, user_gender from \"User\" as u,\"UserInformation\" as ui " +
                $"where u.id_user = ui.id_user and u.user_pass = '{PasswordTextBox.Text}' and u.id_user = {id_user}";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows) MessageBox.Show("Введен неверный пароль!");
            else 
            {
                MessageBox.Show("Пароль введен успешно!");
                SendFormButton.Enabled = AgeTextBox.Enabled = FemaleRadio.Enabled = MaleRadio.Enabled = PatronymicTextBox.Enabled = SurnameTextBox.Enabled = NameTextBox.Enabled = true;
                confirm_password_button.Enabled = PasswordTextBox.Enabled = false;
                while (reader.Read()) 
                {
                    NameTextBox.Text = reader.GetValue(0).ToString();
                    SurnameTextBox.Text = reader.GetValue(1).ToString();
                    PatronymicTextBox.Text = reader.GetValue(2).ToString();
                    AgeTextBox.Text = reader.GetValue(3).ToString();
                    bool g = (bool)reader.GetValue(4);
                    if (g) MaleRadio.Checked = true;
                    else FemaleRadio.Checked = true;
                }
            }
            CloseConnection();
        }

        // check correct data
        private bool CheckGender()
        {
            if ((FemaleRadio.Checked || MaleRadio.Checked) == false) throw new Exception("Выберете ваш пол!");
            if (FemaleRadio.Checked) return false;
            else return true;
        }
        private void CheckString(string str, string textboxname)
        {
            foreach (var i in str) if (!char.IsLetter(i)) throw new Exception($"Удалите из строки {textboxname} все цифры и спецсимволы");
            if (str.Length == 0) throw new Exception($"Введите данные в строку {textboxname}");
        }
        private int CheckAge()
        {
            int age;
            try { age = int.Parse(AgeTextBox.Text); }
            catch { throw new Exception("Введите корректные данные в поле возраста!"); }
            if (age < 1) throw new Exception("Возраст не может быть меньше 1!");
            return age;
        }

        private void SendFormButton_Click(object sender, EventArgs e)
        {
            OpenConnection();
            try
            {
                // check textboxed on correct data
                var g = CheckGender();
                CheckString(SurnameTextBox.Text, "Фамилии");
                CheckString(NameTextBox.Text, "имени");
                CheckString(PatronymicTextBox.Text, "отчества");
                var age = CheckAge();
                NpgsqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "update \"UserInformation\" set (user_name, user_surname, user_patronymic, user_age, user_gender) " +
                    $"= ('{NameTextBox.Text}','{SurnameTextBox.Text}','{PatronymicTextBox.Text}',{age},{g}) where id_user = {id_user}";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно изменены!");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            CloseConnection();
            this.Close();
        }

        // set visible for password
        private void PasswordIcon_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.UseSystemPasswordChar) PasswordTextBox.UseSystemPasswordChar = false;
            else PasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
