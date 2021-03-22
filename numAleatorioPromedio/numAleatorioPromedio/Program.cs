using System;

namespace numAleatorioPromedio
{
    delegate double Promedio(int fin, int cantNum);
    class Program
    {
        static void Main(string[] args)
        {
            int fin, cantNum;
            Console.WriteLine("Ingrese cantidad de numeros random: ");
            cantNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros random seran de 0 a : ");
            fin = int.Parse(Console.ReadLine());

            Promedio prom = delegate (int fin, int cantNum)
            {
                Console.WriteLine("Los numeros aleatorios son: ");
                int suma = 0;
                Random rnd = new Random();
                

                for (int i = 0; i < cantNum; i++)
                {
                    var value = rnd.Next(0, fin);
                    Console.WriteLine(value);
                    suma += value;
                }
                double promedio = (double)suma / (double)cantNum;
                return Math.Round(promedio,2);
            };

            Console.WriteLine("El promedio es: "+ prom(fin, cantNum));
            Console.ReadKey();
        }
    }
}
