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
        public double[,] KryteriaTab { get; set; }
        public List<double[,]> AlternetywyTab { get; set; }

        public FormSatty()
        {
            InitializeComponent();
            this.Hide();
            try
            {
                pobranieIlosciOrazNazwKryteriowIAlternatyw();

                uzupelnienieTablicyKryteriow();

                uzupelnienieListyZAlternatywami();
            }
            catch(ArgumentNullException)
            {
                Environment.Exit(0);
            }

            obliczanieSatty(out List<double> wyniki);

            this.ShowDialog();
            if (wyniki[0] == 0) { MessageBox.Show("Błąd w wyliczeniu. Podaj dane jeszcze raz."); return; }

            labelKryterium1.Text = Kryteria[0];
            labelKryterium2.Text = Kryteria[1];
            labelKryterium3.Text = Kryteria[2];

            labelWynik1.Text = wyniki[0].ToString("N2");
            labelWynik2.Text = wyniki[1].ToString("N2");
            labelWynik3.Text = wyniki[2].ToString("N2");

            labelKryteriumWynik.Text = Kryteria[wyniki.IndexOf(wyniki.Max())];
            
            
        }

        public FormSatty(List<string> Kryteria, List<double> Wyniki)
        {
            InitializeComponent();

            labelKryterium1.Text = Kryteria[0];
            labelKryterium2.Text = Kryteria[1];
            labelKryterium3.Text = Kryteria[2];

            labelWynik1.Text = Wyniki[0].ToString("N2");
            labelWynik2.Text = Wyniki[1].ToString("N2");
            labelWynik3.Text = Wyniki[2].ToString("N2");

            labelKryteriumWynik.Text = Kryteria[Wyniki.IndexOf(Wyniki.Max())];
            this.ShowDialog();
        }

        private void obliczanieSatty(out List<double> wyniki)
        {
            wyniki = null;
            Satty satty = new Satty(KryteriaTab, AlternetywyTab);
            if(!satty.Weryfikacja()) return;
            wyniki = new List<double>(satty.Oceniaj());
        }

        private void pobranieIlosciOrazNazwKryteriowIAlternatyw()
        {
            FormKonfiguracja formKonfig = new FormKonfiguracja();
            formKonfig.ShowDialog();
            if (formKonfig.DialogResult != DialogResult.OK) { this.Close(); }
            Alternatywy = new List<string>(formKonfig.Alternatywy);
            Kryteria = new List<string>(formKonfig.Kryteria);
        }

        private void uzupelnienieTablicyKryteriow()
        {
            FormKryteria formKryteria = new FormKryteria(Kryteria);
            formKryteria.ShowDialog();
            if (formKryteria.DialogResult != DialogResult.OK) { this.Close(); }
            KryteriaTab = formKryteria.KryteriaTab.Clone() as double[,];
        }

        private void uzupelnienieListyZAlternatywami()
        {
            AlternetywyTab = new List<double[,]>();
            for (int i = 0; i < Kryteria.Count; i++)
            {
                FormAlternatywy formAlt = new FormAlternatywy(Kryteria[i], Alternatywy);
                formAlt.ShowDialog();
                if (formAlt.DialogResult != DialogResult.OK) { this.Close(); }
                AlternetywyTab.Add(formAlt.AlternatywyTab.Clone() as double[,]);
            }
        }

        private void buttonWyjdz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
