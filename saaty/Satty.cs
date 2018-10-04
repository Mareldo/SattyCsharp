using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saaty
{
    class Satty
    {
        public double[,] Kryteria { get; set; }
        public List<double[,]> Alternatywy { get; set; }
        static double[] ri = new double[] { 0, 0, 0.52, 0.89, 1.11, 1.25, 1.35, 1.4, 1.45, 1.49};
        private bool weryfikacja = false;

        public Satty(double[,] Kryteria, List<double[,]> Alternatywy)
        {
            this.Kryteria = new double[Kryteria.GetLength(0), Kryteria.GetLength(1)];
            Array.Copy(Kryteria, 0, this.Kryteria, 0, Kryteria.Length);

            this.Alternatywy = new List<double[,]>(Alternatywy);
        }

        public bool Weryfikacja()
        {
            if (Kryteria.GetLength(0) != Kryteria.GetLength(1)) return false;
            if (Kryteria.GetLength(0) != Alternatywy.Count) return false;

            for(int i = 0; i < Alternatywy.Count; i++)
            {
                if (Alternatywy[i].GetLength(0) != Alternatywy[i].GetLength(1)) return false;

                for(int y = i + 1; y < Alternatywy.Count; y++)
                {
                    if (Alternatywy[i].GetLength(0) != Alternatywy[y].GetLength(0)) return false;
                }
            }

            weryfikacja = true;
            return true;
        }

        private List<double> ocena(double[,] tablica)
        {
            List<double> alfy = new List<double>();
            double temp;

            for(int i = 0; i < tablica.GetLength(0); i++)
            {
                temp = 1;
                for(int y = 0; y < tablica.GetLength(1); y++)
                {
                    temp *= tablica[i, y];
                }
                alfy.Add(Math.Pow(temp, 1.0/tablica.GetLength(0)));
            }

            double suma = alfy.Sum();

            for (int i = 0; i < alfy.Count; i++)
            {
                alfy[i] = alfy[i] / suma * tablica.GetLength(0);
            }
            
            return alfy;
        }

        private bool sprawdzanie(double[,] tablica, List<double> alfy)
        {
            List<double> spr = new List<double>();
            double temp;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                temp = 0;
                for (int y = 0; y < tablica.GetLength(1); y++)
                {
                    temp += tablica[y,i];
                }
                spr.Add(temp * alfy[i]);
            }

            double sum = (double)spr.Sum() / tablica.GetLength(0);

            double ci = (sum - tablica.GetLength(0)) / (double)(tablica.GetLength(0) - 1);
            if (ci > 0.1) return false;

            double cr = Math.Abs(ci/(double)ri[tablica.GetLength(0)]);
            if (cr > 0.1) return false;

            return true;
        }

        public List<double> Oceniaj()
        {
            if(!weryfikacja) { throw new Exception("Nie sprawdzono poprawności danych lub dane niepoprawne"); }

            List<double> alphaKryteria;

            List <List<double>> alphaAlternatywy= new List<List<double>>();

            alphaKryteria = new List<double>(ocena(Kryteria));

            foreach(var i in Alternatywy)
            {
                alphaAlternatywy.Add(ocena(i));
            }

            if (!sprawdzanie(Kryteria, alphaKryteria)) { return new List<double>(); }

            for(int i = 0; i < Alternatywy.Count; i++)
            {
                if (!sprawdzanie(Alternatywy[i], alphaAlternatywy[i])) { return new List<double>(); }
            }

            List<double> wyniki = new List<double>(new double[Alternatywy[1].GetLength(0)]);

            for(int i = 0; i < alphaKryteria.Count; i++)
            {
                for(int y = 0; y < alphaAlternatywy[i].Count; y++)
                {
                    wyniki[y] += alphaKryteria[i] * alphaAlternatywy[i][y];
                }
            }

            return wyniki;
        }

    }
}
