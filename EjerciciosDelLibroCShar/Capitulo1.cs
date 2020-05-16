using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroCShar
{
    class Capitulo1
    {
        void Ejercicio1()
        {
            Console.WriteLine("Yensi De Luna");
            Console.ReadKey();

        }

        void Ejercico2()
        {
            Console.WriteLine("Yensi De Luna");
            Console.WriteLine("Matricual es:\n 2015-0181");
            Console.WriteLine("Carrera: \n Ing. en Sistemas");
            Console.ReadKey();
        }
       public void Menu()
        {
            Console.WriteLine("Menu \n 1.Ejercicio 1.1 \n 2.Ejercicio 1.5");
            Console.Write("Elige una opcion: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercico2();
                    break;
            }
        }
    }
}
