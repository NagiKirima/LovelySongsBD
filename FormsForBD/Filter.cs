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
    public partial class Filter : Form
    {
        private UserWindow window;
        public Filter(UserWindow wind)
        {
            InitializeComponent();
            window = wind;
        }

        public void InitializeDgw(List<string> list) 
        {
            foreach (var i in list)
                FilterDgw.Rows.Add(i, "Выбрать");
        }
        public void ResetDgw() 
        {
            FilterDgw.Rows.Clear();
        }

        private void FilterDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            var list_cells = dgw.Rows[e.RowIndex].Cells;
            window.FilterTextBox.Text = list_cells[0].Value.ToString();
            this.ResetDgw();
            this.Close();
        }
    }
}
