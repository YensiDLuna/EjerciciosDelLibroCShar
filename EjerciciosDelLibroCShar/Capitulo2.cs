using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibroCShar
{
   public class Capitulo2
    {
       public void Ejercicio1()
        {
            float Lado;
            Console.WriteLine("Digite la longitud de los lados: ");
            Lado = float.Parse(Console.ReadLine());
            Lado = Lado * Lado * Lado;
            Console.WriteLine("El Perimetro es: " + Lado);
            Console.ReadKey();
        }
        public void Ejercicio3()
        {
            float grado, radianes;
            Console.WriteLine("Digite la temperatura en grado: ");
            grado = float.Parse(Console.ReadLine());
            radianes = grado * ((float)Math.PI / 180);
            Console.WriteLine("La temperatura en radianes es: " + radianes);
            Console.ReadKey();


        }
        public void Ejercicio5()
        {
            float dolar, euros, taza;
            Console.WriteLine("Digite la taza del dia: ");
            taza = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad de dolar a cambiar : ");
            dolar = float.Parse(Console.ReadLine());
            euros = taza * dolar;
            Console.WriteLine(dolar + " dolar son: " + euros + " euros ");
            Console.ReadKey();

        }
       public void Menu()
        {
            Console.WriteLine("Menu \n 1.Ejercicio 2.1 \n 2.Ejercicio 2.3 \n 3.Ejercicio 2.5 ");
            Console.Write("Elige una opcion: ");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Ejercicio1();
                    break;
                case 2:
                    Ejercicio3();
                    break;
                case 3:
                    Ejercicio5();
                    break;
            }
        }
    }
}
