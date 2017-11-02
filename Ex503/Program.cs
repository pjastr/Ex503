using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex503
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(new Temperatura(21.1));
            lista.Add(new Temperatura(-3));
            lista.Add(new Temperatura(12.8));
            lista.Add(new Temperatura(-5.3));
            lista.Sort();
            foreach(var element in lista)
            {
                Console.WriteLine(element.ToString());
            }
            Console.ReadKey();
        }
    }
}
