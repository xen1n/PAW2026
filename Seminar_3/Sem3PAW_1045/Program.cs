using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            int[] v2 = { 7, 8, 9 };
            Student s2 = new Student(100, 'M', 21, "Dorel", v2);
            Student s3 = (Student)s2.Clone();
            s3.Nume = "Gigel";
            int[] v3 = { 9, 10 };
            s3.Note = v3;
            s3 += 10;
            s3 = 7 + s3;
            //s2 = s3 + 10;
            Console.WriteLine(s1[3]);
            s1[3] = 10;

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            foreach (Student s in listaStud)
                Console.WriteLine(s);
        }
    }
}
