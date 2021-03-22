using System;

namespace Ej2LamdbaString
{
    delegate bool Delegado(char caracter);

    class Program
    {
        public static string Filtrar(string cadena, Delegado delegado)
        {
            string newCadena = "";
            foreach (var caracter in cadena)
                if (delegado(caracter))
                    newCadena += caracter;
            return newCadena.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase: ");
            var cadena = Console.ReadLine();

            Console.WriteLine("Cadena: " + cadena);
            var vocales = Program.Filtrar(cadena, caracter => caracter == 'a' || caracter == 'e' ||
                                          caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                                          caracter == 'A' || caracter == 'E' || caracter == 'I' || 
                                          caracter == 'O' || caracter == 'U');
            Console.WriteLine("Las vocales que tiene la cadena son: " + vocales);

            var dig = Program.Filtrar(cadena, caracter => char.IsDigit(caracter));
            Console.WriteLine("Los digitos que tiene la cadena son: " + dig);

            var caracMin = Program.Filtrar(cadena, caracter => char.IsLower(caracter));
            Console.WriteLine("Los caracteres minusculas que tiene la cadena son: " + caracMin);

            var caracNum = Program.Filtrar(cadena, caracter => char.IsLetter(caracter) || char.IsNumber(caracter));
            Console.WriteLine("Los caracteres y numeros que tiene la cadena son: " + caracNum);
            Console.ReadKey();
        }
    }
}
