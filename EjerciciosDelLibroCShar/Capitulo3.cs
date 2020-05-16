using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroCShar
{
    class Capitulo3
    {
        public void Ejercicio1()
        {
            int numero;
            Console.WriteLine("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            int par = numero % 2;
            if (par == 0)
            {
                Console.WriteLine("par");

            }
            else
            {
                Console.WriteLine("impar");
            }
            Console.ReadKey();

        }
        public void Ejercicio4()
        {
            int numero;
            Console.WriteLine("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
            Console.ReadKey();

        }
       public void Menu()
        {
            Console.WriteLine("Menu \n 1.Ejercicio 3.1 \n 2.Ejercicio 3.4");
            Console.Write("Elige una opcion: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio4();
                    break;
            }
        }
    }
}
