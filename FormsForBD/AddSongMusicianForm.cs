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
    public partial class AddSongMusicianForm : Form
    {
        private AdminWindow window;
        private Label label;
        public AddSongMusicianForm(AdminWindow window, Label label)
        {
            InitializeComponent();
            this.window = window;
            this.label = label;
        }
        public void InitializeDgw(List<KeyValuePair<int, string>> list)
        {
            foreach (var i in list)
                ChoiceDgw.Rows.Add(i.Key, i.Value, "Выбрать");
        }

        private void ChoiceDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            if (dgw.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "Выбрать")
            {
                label.Text = dgw.Rows[e.RowIndex].Cells[0].Value.ToString() + " - " + dgw.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Close();
            }
        }
    }
}
