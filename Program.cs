using System;

namespace ClaseChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero = int.MaxValue;


            //checked: comprobacion de operaciones aritmeticas en numeros enteros
            //{
            //    entero++;
            //}

            entero = checked(entero++);

            Console.WriteLine(entero);
            Console.ReadLine();

        }
    }
}
