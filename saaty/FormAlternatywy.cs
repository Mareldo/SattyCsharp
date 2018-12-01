using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saaty
{
    public partial class FormAlternatywy : Form
    {
        private DataTable dt = new DataTable();
        private List<string> Alternatywy { get; set; }
        public double[,] AlternatywyTab { get; set; }
        private string Kryterium { get; set; }

        public FormAlternatywy(string Kryterium, List<string> Alternatywy)
        {
            this.Alternatywy = new List<string>(Alternatywy);
            InitializeComponent();
            labelKryterium.Text = Kryterium;
            dataGridView1.DataSource = dt;

            for (int i = 0; i < Alternatywy.Count; i++)
            {
                dt.Columns.Add(Alternatywy[i]);

            }

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            DataRow temp;
            for (int i = 0; i < Alternatywy.Count; i++)
            {
                temp = dt.NewRow();
                temp[i] = 1;
                dt.Rows.Add(temp);
            }

            for (int i = 0; i < this.Alternatywy.Count; i++)
            {
                this.dataGridView1.Rows[i].HeaderCell.Value = Alternatywy[i];
            }
        }



        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }

            GridFormValid valid = new GridFormValid(e.RowIndex,
                                                    e.ColumnIndex,
                                                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            if (valid.Valid())
            {
                dataGridView1.Rows[valid.Row].Cells[valid.Column].Value = valid.Value;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                dataGridView1.Rows[e.ColumnIndex].Cells[e.RowIndex].Value = "";
            }
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            AlternatywyTab = new double[Alternatywy.Count, Alternatywy.Count];

            for (int i = 0; i < Alternatywy.Count; i++)
            {
                for (int j = 0; j < Alternatywy.Count; j++)
                {
                    string value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    if (value == "")
                    {
                        MessageBox.Show("Wszystki pola muszą być pełne.");
                        return;
                    }
                    GridFormValid checkRegex = new GridFormValid(i, j, value);
                    checkRegex.checkIfCellIsRegex();

                    switch (checkRegex.Fractal)
                    {
                        case 1:
                            {
                                AlternatywyTab[i, j] = Double.Parse(value);
                                break;
                            }
                        case 2:
                            {
                                string[] split = value.Split(new char[] { '/' });

                                int a = int.Parse(split[0]);
                                int b = int.Parse(split[1]);

                                AlternatywyTab[i, j] = (double)a / b;
                                break;
                            }
                    }
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = Alternatywy[i];
            }
        }
    }
}
