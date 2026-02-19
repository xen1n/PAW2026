using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Sem1PAW_1047
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta:");
            int varsta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numele este {0}, varsta este {1}", nume, varsta);*/

            int[] v1 = new int[4] { 1, 2, 3, 4 };
            int[] v2 = v1;
            v1[1] = 100;
            for (int i = 0; i < v2.Length; i++)
                Console.Write("{0} ", v2[i]);

            //deep copy - var 1
            int[] v3 = new int[v1.Length];
            for (int i = 0; i < v1.Length; i++)
                v3[i] = v1[i];
            v1[1] = 200;
            Console.WriteLine("Afisare v3");
            for (int i = 0; i < v3.Length; i++)
                Console.Write("{0} ", v3[i]);

            //deep copy - var 2
            int[] v4 = (int[])v1.Clone();
            v1[1] = 300;
            Console.WriteLine("Afisare v4");
            for (int i = 0; i < v4.Length; i++)
                Console.Write("{0} ", v4[i]);

            Console.WriteLine("Afisare mat1");
            int[,] mat1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for(int i=0;i<mat1.GetLength(0);i++)
            {
                for (int j = 0; j < mat1.GetLength(1); j++)
                    Console.Write("{0} ", mat1[i, j]);
                Console.WriteLine();
            }

            int[][] mat2 = new int[3][];
            mat2[0] = new int[2] { 10, 20 };
            mat2[1] = new int[3] { 30, 40, 50 };
            mat2[2] = new int[4] { 60, 70, 80, 90 };
            Console.WriteLine("Afisare mat2");
            for (int i = 0; i < mat2.Length; i++)
            {
                for (int j = 0; j < mat2[i].Length; j++)
                    Console.Write("{0} ", mat2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(23, "Dorel", 9.5f);
            Student s3 = s2; //shallow copy
            Student s4 = new Student(s2);

            s3.Nume = "Maricica";
            s3.afisare();
            Console.WriteLine(s2.ToString());

            Student[] vs = new Student[4] { s1, s2, s3, s4 };
            for (int i = 0; i < vs.Length; i++)
                Console.WriteLine(vs[i]);
            foreach (Student s in vs)
                Console.WriteLine(s);

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);

            for (int i = 0; i < listaStud.Count; i++)
                Console.WriteLine(listaStud[i]);

            ArrayList listaStud2 = new ArrayList();
            listaStud2.Add(s3);
            listaStud2.Add(s4);

            for (int i = 0; i < listaStud2.Count; i++)
                Console.WriteLine(listaStud2[i]);

            listaStud2.Sort();
        }
    }
}
