using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1047
{
    class Student: IComparable
    {
        public int varsta;
        private string nume;
        private float medie;

        public Student()
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
        }

        public Student(int v, string n, float m)
        {
            this.varsta = v;
            this.nume = n;
            this.medie = m;
        }

        public Student(Student s)
        {
            this.varsta = s.varsta;
            this.nume = s.nume;
            this.medie = s.medie;
        }

        public string Nume
        {
            get { return nume; }
            set { if(value!=null) nume = value; }
        }

        public float Medie { get => medie; set => medie = value; }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are varsta {1} si media {2}",
                nume, varsta, medie);
        }

        public override string ToString()
        {
            return "Studentul " + nume + " are varsta " + varsta +
                " si media " + medie;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.medie < s.medie)
                return -1;
            else
                if (this.medie > s.medie)
                return 1;
            else
                return 0;
        }
    }
}
