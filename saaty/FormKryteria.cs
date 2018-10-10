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
    public partial class FormKryteria : Form
    {
        private DataTable dt = new DataTable();
        private List<string> Kryteria { get; set; }
        public FormKryteria(List<string> Kryteria)
        {
            this.Kryteria = new List<string>(Kryteria);
            InitializeComponent();
            dataGridView1.DataSource = dt;

            foreach(string i in Kryteria)
            {
                dt.Columns.Add(i);
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



    }
}
