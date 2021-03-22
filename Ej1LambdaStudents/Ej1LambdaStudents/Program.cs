using System;


namespace Ej1LambdaStudents
{
    public delegate bool Comparacion(int element);

    public class Estudiante
    {
        public String Nombre { get; set; }
        public int Nota { get; set; }
    }


    public class Curso
    {
        private Estudiante[] students = new Estudiante[5];
        public void Cargar(int posicion, Estudiante student)
        {
            students[posicion] = student;
        }

        public void ImprimirEstudiantes()
        {
            foreach (var student in students)
            {
                Console.WriteLine("Nombre: " + student.Nombre + "  Nota: " + student.Nota);
            }
                
        }

        public void ImprimirSi(Comparacion comparacion)
        {
            foreach (var student in students)
                if (comparacion(student.Nota))
                {
                    Console.WriteLine("Nombre: " + student.Nombre + "  Nota: " + student.Nota);
                }
                    
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Curso c1 = new Curso();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa el nombre del estudiante "+ (i+1) +" : ");
                string nameS = Console.ReadLine();
                Console.WriteLine("Ingresa la nota del estudiante " + (i + 1) + " : ");
                int notaS = int.Parse(Console.ReadLine());
                c1.Cargar(i, new Estudiante
                {
                    Nombre = nameS,
                    Nota = notaS
                });
            }

            Console.WriteLine("\nListado completo de estudiantes");
            c1.ImprimirEstudiantes();
            Console.WriteLine("\nListado completo de estudiantes con nota mayor o igual a 51");
            c1.ImprimirSi((nota) => nota >= 51);
            Console.WriteLine("\nListado completo de estudiantes que tienen de nota 50");
            c1.ImprimirSi((nota) => nota == 50);

            Console.ReadKey();
        }
    }
}


