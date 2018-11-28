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
            this.DialogResult = DialogResult.No;
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            int Alternatywy;
            int Kryteria;
            if (!int.TryParse(textBoxAlternatywy.Text, out Alternatywy)) { MessageBox.Show("Niepoprawna liczba alternatyw."); return; }
            if (!int.TryParse(textBoxKryteria.Text, out Kryteria)) { MessageBox.Show("Niepoprawna liczba kryterióww."); return; }

            if ((Kryteria < 3) || (Alternatywy < 3)) { MessageBox.Show("Minimalna ilosc alternatyw i kryteriów to 3."); return; }
            if ((Kryteria > 9) || (Alternatywy > 9)) { MessageBox.Show("Maksymalna ilosc alternatyw i kryteriów to 9."); return; }

            FormNazywanie formNaz = new FormNazywanie(Alternatywy, Kryteria);
            formNaz.ShowDialog();

            if(formNaz.DialogResult != DialogResult.OK) { this.Close(); }

            this.Alternatywy = new List<string>(formNaz.Alternatywy);
            this.Kryteria = new List<string>(formNaz.Kryteria);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
