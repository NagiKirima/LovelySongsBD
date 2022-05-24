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
        private TextBox filtertext;
        public Filter(TextBox filter)
        {
            InitializeComponent();
            filtertext = filter;
        }

        public void InitializeDgw(List<string> list) 
        {
            foreach (var i in list)
                FilterDgw.Rows.Add(i, "Выбрать");
        }

        private void FilterDgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgw = (DataGridView)sender;
            var list_cells = dgw.Rows[e.RowIndex].Cells;
            filtertext.Text = list_cells[0].Value.ToString();
            this.Close();
        }
    }
}
