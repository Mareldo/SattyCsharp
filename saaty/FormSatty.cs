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
    public partial class FormSatty : Form
    {
        public List<string> Alternatywy { get; set; }
        public List<string> Kryteria { get; set; }

        public FormSatty()
        {
            InitializeComponent();
            this.Hide();

            FormKonfiguracja formKonfig = new FormKonfiguracja();
            formKonfig.ShowDialog();
            if(formKonfig.DialogResult != DialogResult.OK) { this.Close(); }
            Alternatywy = new List<string>(formKonfig.Alternatywy);
            Kryteria = new List<string>(formKonfig.Kryteria);

            FormKryteria formKryteria = new FormKryteria(Kryteria);
            formKryteria.ShowDialog();
            if(formKryteria.DialogResult != DialogResult.OK) { this.Close(); }
        }
    }
}
