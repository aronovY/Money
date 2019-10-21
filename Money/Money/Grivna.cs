using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money.Money
{
    class Grivna
    {
        private int gri { get; set; }// гривна
        private int kop { get; set; } // копейка

        public Grivna()
        {
            gri = 0;
            kop = 0;
        }

        public Grivna(int g, int k)
        {
            gri = g;
            kop = k % 100;
        }

        public void howMuch()
        {
            Console.WriteLine($"You have {gri} hryvnia and {kop} cents.");
        }

        public static Grivna operator +(Grivna m1, Grivna m2)
        {

            int sumKop = m1.kop + m2.kop;
            int sumGri = m1.gri + m2.gri;
            if (sumKop > 100)
            {
                sumKop = sumKop % 100;
                sumGri++;
            }
            if (new Grivna(sumGri,sumKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(sumGri, sumKop);
            }

        }

        public static Grivna operator -(Grivna m1, Grivna m2)
        {

            int minKop = m1.kop - m2.kop;
            int minGri = m1.gri - m2.gri;
            if (minKop < 0)
            {

                minKop = (100 - (m2.kop - m1.kop));
                minGri--;

            }
            if (new Grivna(minGri, minKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(minGri, minKop);

            }
        }

        public static Grivna operator ++(Grivna m1)
        {

            int plusKop = m1.kop + 1;
            int plusGri = m1.gri;
            if (plusKop == 100)
            {
                plusKop = 0;
                plusGri++;

            }
            if (new Grivna(plusGri, plusKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(plusGri, plusKop);
            }
        }

        public static Grivna operator --(Grivna m1)
        {
            int minusKop = m1.kop - 1;
            int minusGri = m1.gri;
            if (minusKop < 0)
            {
                minusKop = 99;
                minusGri--;

            }
            if (new Grivna(minusGri, minusKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(minusGri, minusKop);
            }

        }

        public static bool operator !=(Grivna m1, Grivna m2)
        {
            if (m1.gri == m2.gri && m1.kop == m2.kop)
                return false;
            else
                return true;

        }

        public static bool operator ==(Grivna m1, Grivna m2)
        {

            if (m1.gri == m2.gri && m1.kop == m2.kop)
                return true;
            else
                return false;

        }

        public static Grivna operator *(Grivna m1, int value)
        {

            int multiKop = (m1.kop * value) % 100;
            int multiGri = m1.gri * value + ((m1.kop * value) / 100);
            if (new Grivna(multiGri, multiKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(multiGri, multiKop);
            }
        }

        public static Grivna operator /(Grivna m1, int value)
        {

            int divGri = m1.gri / value;
            double konv = (m1.kop / value) + (Convert.ToDouble(m1.gri) / Convert.ToDouble(value)) * 100;
            int divKop = Convert.ToInt32(konv);
            if (new Grivna(divGri, divKop) < 0)
            {
                throw new Bankruptcy($"You are bankrupt!");
            }
            else
            {
                return new Grivna(divGri, divKop);
            }
        }
        public static bool operator <(Grivna m1, int value)
        {
            if (m1.gri < value)
                return true;
            else
                return false;
        }
        public static bool operator >(Grivna m1, int value)
        {
            if (m1.gri < value)
                return false;
            else
                return true;
        }
    }
}
