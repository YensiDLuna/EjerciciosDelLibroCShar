using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroCShar
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo1 c1 = new Capitulo1();
            Capitulo2 c2 = new Capitulo2();
            Capitulo3 c3 = new Capitulo3();

            Console.WriteLine("Menu \n 1.capitulo 1  \n 2.capitulo 2 \n 3.capitulo 3 ");
            Console.Write("Elige una opcion: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                   c1.Menu();
                    break;
                case 2:
                    c2.Menu();
                    break;
                case 3:
                    c3.Menu();
                    break;
            }

        }

    }
}
