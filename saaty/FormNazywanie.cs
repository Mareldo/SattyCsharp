using MaterialSkin.Controls;
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
    public partial class FormNazywanie : Form
    {
        int alternatywy;
        int kryteria;
        public List<string> Alternatywy;
        public List<string> Kryteria;

        private void dodajPole(int x, int y, string textBoxName, string labelName, string labelText)
        {
            MaterialLabel lbl = new MaterialLabel();
            lbl.Name = labelName;
            lbl.Text = labelText;
            lbl.AutoSize = true;
            lbl.Depth = 0;
            lbl.Font = new System.Drawing.Font("Roboto", 11F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            lbl.MouseState = MaterialSkin.MouseState.HOVER;
            lbl.Size = new System.Drawing.Size(108, 19);
            lbl.Location = new System.Drawing.Point(x, y);

            this.Controls.Add(lbl);


            TextBox txt = new TextBox();
            txt.Location = new System.Drawing.Point(x + 115, y);
            txt.Name = textBoxName;
            txt.Size = new System.Drawing.Size(100, 20);

            this.Controls.Add(txt);
        }

        public FormNazywanie(int alternatywy, int kryteria)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.No;
            for(int i = 3; i < alternatywy; i++)
            {
                dodajPole(12, 91 + (26 * (i - 3)), "textBoxAlternatywa" + (i + 1), "labelAlternatywa" + (i + 1), "Alternatywa " + (i + 1));
            }

            for (int i = 3; i < kryteria; i++)
            {
                dodajPole(245, 91 + (26 * (i - 3)), "textBoxKryterium" + (i + 1), "labelKryterium" + (i + 1), "Kryterium " + (i + 1));
            }

            this.alternatywy = alternatywy;
            this.kryteria = kryteria;
            Alternatywy = new List<string>();
            Kryteria = new List<string>();
            for (int i = 0; i < alternatywy; i++)
            {
                Alternatywy.Add("0");
            }
            for (int i = 0; i < kryteria; i++)
            {
                Kryteria.Add("0");
            }
        }

        private void buttonDalej_Click(object sender, EventArgs e)
        {
            string valAlternatywy = @"textBoxAlternatywa[1-9]";
            string valKryteria = @"textBoxKryterium[1-9]";

            Match matchAlternatywy;
            Match matchKryteria;

            foreach (Control i in this.Controls)
            {
                matchAlternatywy = Regex.Match(i.Name, valAlternatywy);
                if(matchAlternatywy.Success)
                {
                    char lastChar = i.Name[i.Name.Length - 1];
                    int lastIndex = int.Parse(lastChar.ToString()) - 1;
                    Alternatywy[lastIndex] = i.Text;
                    continue;
                }

                matchKryteria = Regex.Match(i.Name, valKryteria);
                if (matchKryteria.Success)
                {
                    char lastChar = i.Name[i.Name.Length - 1];
                    int lastIndex = int.Parse(lastChar.ToString()) - 1;
                    Kryteria[lastIndex] = i.Text;
                }
            }

            bool temp = false;
            for (int i = 0; i < Alternatywy.Count - 1; i++)
            {
                for (int j = i + 1; j < Alternatywy.Count; j++)
                {
                    if(Alternatywy[i] == Alternatywy[j]) temp = true;
                }
            }

            for (int i = 0; i < Kryteria.Count - 1; i++)
            {
                for (int j = i + 1; j < Kryteria.Count; j++)
                {
                    if (Kryteria[i] == Kryteria[j]) temp = true;
                }
            }

            if(temp)
            {
                MessageBox.Show("Nazwy muszą być unikalne.");
                Alternatywy = new List<String>();
                Kryteria = new List<String>();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
