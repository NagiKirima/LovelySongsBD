using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsForBD
{
    public partial class RaitingFilterForm : Form
    {
        private TextBox textbox;
        public RaitingFilterForm(TextBox textbox)
        {
            InitializeComponent();
            this.textbox = textbox;
            MaleRadio.Checked = true;
            MoreRadio.Checked = true;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string gender = ""; string symbol = ""; int age = 0;

            if (MaleRadio.Checked) gender = "m";
            else if (FemaleRadio.Checked) gender = "f";
            else gender = "-";

            if (MoreRadio.Checked) symbol = ">";
            else if (LessRadio.Checked) symbol = "<";
            else symbol = "=";

            try { age = int.Parse(AgeTextBox.Text); }
            catch { MessageBox.Show("Введите корректный возраст!"); return; }
            if (age < 0) { MessageBox.Show("Возраст не может быть меньше 0!"); return; }

            textbox.Text = $"{gender};{symbol};{age}";
            this.Close();
        }
    }
}
