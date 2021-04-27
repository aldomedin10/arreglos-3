using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglos3
{
    class Program
    {
        

       //obtener el promedio de la materia de quimica y fisica y sacar el promedio mas alto de las 2 materia

        private float[] quimica;
        private float[] fisica;
        private float[] promFinal;
        private string[] alumnos;


        public void Calificaciones()
        {
            alumnos = new string[5] { "Pablo", "Luis", "Rodolfo", "Ana", "Gabriela" };

            quimica = new float[5];

            fisica = new float[5];

            //calificacion de quimica

            Console.WriteLine("     calificaciones de quimica: \n");
            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("la calificacion de " + alumnos[x] + ": ");

                String gradeCaptureQuimica = Console.ReadLine();

                quimica[x] = float.Parse(gradeCaptureQuimica);
            }
            Console.Clear();

            //calificacion para la segunda materia

            Console.WriteLine("     calificaciones de fisica: \n");

            for (int x = 0; x < alumnos.Length; x++)
            {
                Console.WriteLine("la calificacion de " + alumnos[x] + ": ");

                String gradeCaptureFisica = Console.ReadLine();

                fisica[x] = float.Parse(gradeCaptureFisica);
            }

            Console.Clear();
        }
        public void calcularPromedio()
        {
            promFinal = new float[5];

            float maxGrade = 0;
            float totalQuimica = 0;
            float totalFisica = 0;

            Console.WriteLine("     calificacion de alumnos: \n");
            for (int i = 0; i < alumnos.Length; i++)
            {
                promFinal[i] = (quimica[i] + fisica[i]) / 2;
                if (promFinal[i] >= maxGrade)
                {
                    maxGrade = promFinal[i];
                }

                Console.WriteLine("Alumno: " + alumnos[i] + "  |  Quimica: " + quimica[i] + "  |  Fisica: " + fisica[i] + "  |  Su promedio General es: " + promFinal[i]);

            }


            for (int i = 0; i < quimica.Length; i++)
            {
                totalQuimica = totalQuimica + quimica[i];
            }

            for (int i = 0; i < fisica.Length; i++)
            {
                totalFisica = totalFisica + fisica[i];
            }
            Console.WriteLine("\n");

            Console.WriteLine("     promedio general de la materia: \n");

            Console.WriteLine("Promedio de la materia de Quimica: " + totalQuimica / 5 + "\nPromedio de la materia de Fisica: " + totalFisica / 5);

            Console.WriteLine("\n");
            Console.WriteLine("     materia con mayor promedio es: \n");

            if (totalQuimica > totalFisica)
            {
                Console.WriteLine("Materia: Quimica");
            }
            else
            {
                Console.WriteLine("Materia: Fisica");
            }


        }


        static void Main(string[] args)
        {
            Program grades = new Program();
            grades.Calificaciones();
            grades.calcularPromedio();
            Console.ReadKey();
        }
    }
}