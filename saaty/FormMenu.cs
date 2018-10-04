using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace saaty
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            double[,] kryteria = { { 1, 1/7.0, 1/3.0, 3, 1/5.0},
                          { 7, 1, 5, 9, 3},
                          { 3, 1/5.0, 1, 5, 1/3.0},
                          { 1/3.0, 1/9.0, 1/5.0, 1, 1/7.0},
                          { 5, 1/3.0, 3, 7, 1} };

            List<double[,]> alternatywy = new List<double[,]>();

            alternatywy.Add(new double[,] { { 1, 1/3.0, 1/5.0},
                                             { 3, 1, 1/3.0},
                                             { 5, 3, 1} });
            alternatywy.Add(new double[,] { { 1, 1/3.0, 3},
                                             { 3, 1, 5},
                                             { 1/3.0, 1/5.0, 1} });
            alternatywy.Add(new double[,] { { 1, 1/3.0, 3},
                                             { 3, 1, 7},
                                             { 1/3.0, 1/7.0, 1} });
            alternatywy.Add(new double[,] { { 1, 1/7.0, 1/3.0},
                                             { 7, 1, 5},
                                             { 3, 1/5.0, 1} });
            alternatywy.Add(new double[,] { { 1, 3, 1/5.0},
                                             { 1/3.0, 1, 1/7.0},
                                             { 5, 7, 1} });


            Satty satty = new Satty(kryteria, alternatywy);
            satty.Weryfikacja();
            List<double> wyniki = new List<double>(satty.Oceniaj());
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonWyjdz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
