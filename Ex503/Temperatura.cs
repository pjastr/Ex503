using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex503
{
    class Temperatura : IComparable
    {
        private double wartosc;

        public Temperatura(double wart) //konstruktor
        {
            this.wartosc = wart;
        }

        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            Temperatura other = obj as Temperatura;  //traktowanie obj jako typ Temperatura
            if (other != null)
            {
                if (other.wartosc < this.wartosc)
                {
                    return 1;
                }
                else if (other.wartosc == this.wartosc)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
                throw new ArgumentException("Objekt nie jest temperaturą"); //wyrzucenie wyjątku
        }

        public override string ToString()  //przesłonięcie metody (aby można było wypisać na konsoli)
        {

            return this.wartosc.ToString();
        }
    }
}
