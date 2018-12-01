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
        public double[,] KryteriaTab { get; private set; }
        public FormKryteria(List<string> Kryteria)
        {
            this.Kryteria = new List<string>(Kryteria);
            InitializeComponent();
            dataGridView1.DataSource = dt;

            for (int i = 0; i < Kryteria.Count; i++)
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
            }
        }
        
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex < 0 || e.RowIndex < 0) { return; }

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

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            KryteriaTab = new double[Kryteria.Count,Kryteria.Count];

            for (int i = 0; i < Kryteria.Count; i++)
            {
                for(int j = 0; j < Kryteria.Count; j++)
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
                            KryteriaTab[i, j] = Double.Parse(value);
                            break;
                        }
                        case 2:
                        {
                            string[] split = value.Split(new char[] { '/' });

                            int a = int.Parse(split[0]);
                            int b = int.Parse(split[1]);

                            KryteriaTab[i, j] = (double)a / b;
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
                dataGridView1.Rows[i].HeaderCell.Value = Kryteria[i];
            }
        }
    }
}
