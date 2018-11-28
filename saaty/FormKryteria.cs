using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saaty
{
    public partial class FormKryteria : Form
    {
        private DataTable dt = new DataTable();
        private List<string> Kryteria { get; set; }
        public FormKryteria(List<string> Kryteria)
        {
            this.Kryteria = new List<string>(Kryteria);
            InitializeComponent();
            dataGridView1.DataSource = dt;

            for (int i = Kryteria.Count - 1; i >= 0; i--)
            {
                dt.Columns.Add(Kryteria[i]);

            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataRow temp;
            for (int i = 0; i < Kryteria.Count; i++)
            {
                temp = dt.NewRow();
                temp[i] = 1;
                dt.Rows.Add(temp);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].HeaderCell.Value = i;
            }
        }

        

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex < 0 || e.RowIndex < 0) { return; }

            GridFormValid valid = new GridFormValid(e.RowIndex,
                                                    e.ColumnIndex,
                                                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            if(valid.Valid())
            {
                dataGridView1.Rows[valid.Row].Cells[valid.Column].Value = valid.Value;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                dataGridView1.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = "";
            }
        }
    }
}
