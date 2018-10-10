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
    public partial class FormKonfiguracja : Form
    {
        private DataTable dt = new DataTable();

        public List<string> Alternatywy { get; set; }
        public List<string> Kryteria { get; set; }

        

        public FormKonfiguracja()
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "";
            dataGridView.Columns.Add(col);

            Alternatywy = new List<string>();
            Kryteria = new List<string>();
        }

        private void buttonAddAlt_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 9) { MessageBox.Show("Maksymalna liczba alternatyw to 9."); return; }
            dt.Rows.Add();
            dataGridView.Rows[dataGridView.Rows.Count-1].HeaderCell.Value = textBoxAlt.Text;

            Alternatywy.Add(textBoxAlt.Text);
        }

        private void buttonAddKryt_Click(object sender, EventArgs e)
        {
            if(dataGridView.Columns.Count == 9) { MessageBox.Show("Maksymalna liczba kryteriów to 9."); return; }
            DataGridViewColumn col = new DataGridViewTextBoxColumn();

            if (dataGridView.Columns[0].HeaderText == "")
            {
                dataGridView.Columns[0].HeaderText = textBoxKryt.Text;
            }
            else
            {
                col.HeaderText = textBoxKryt.Text;
                dataGridView.Columns.Add(col);
            }

            Kryteria.Add(textBoxKryt.Text);
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if((dataGridView.Rows.Count < 3) || (dataGridView.Columns.Count < 3)) { MessageBox.Show("Muszą być co najmniej 3 kryteria i 3 alternatywy."); return; }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
