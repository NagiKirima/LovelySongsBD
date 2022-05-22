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
            Text = "Регистраиця";
        }



        // get correct user data
        private void CheckLogin() 
        {
        
        }
        private void CheckPassword() 
        {
            if (PasswordTextBox.Text.Contains(' ')) throw new Exception("Пароль должен быть без пробелов!");
            if (PasswordTextBox.Text.Length < 8) throw new Exception("Пароль должен быть длиннее 8 символов!");
            if (PasswordTextBox.Text.Length > 30) throw new Exception("Пароль должен быть короче 30 символов!");
        }
        private void CheckGender() 
        {
            if ((FemaleRadio.Checked || MaleRadio.Checked) == false) throw new Exception("Выберете ваш пол!");
        }
        private void CheckFioString(string str, string textboxname) 
        {
            foreach (var i in str) if (!char.IsLetter(i)) throw new Exception($"Удалите из строки {textboxname} все цифры и спецсимволы");
            if(str.Length == 0) throw new Exception($"Введите данные в строку {textboxname}");
        }
        private void SendFormButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckLogin();
                CheckPassword();
                CheckGender();
                CheckFioString(SurnameTextBox.Text, "Фамилии");
                CheckFioString(NameTextBox.Text, "имени");
                CheckFioString(PatronymicTextBox.Text, "отчества");
            }

            catch (Exception a) 
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
