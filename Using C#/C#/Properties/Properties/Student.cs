using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Student
    {
        // attributes should be private
        private int id;
        private string name;
        private double cgpa;

        public Student()
        {
        }

        // initialize using Setter functions is good practice
        public Student(int id, string name, double cgpa)
        {
            this.Id = id;
            this.Name = name;
            this.Cgpa = cgpa;
        }

        // Property with get and set accessors 
        // naming convention should be Pascal Case and the same name of field
        public int Id {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Cgpa
        {
            get { return this.cgpa; }
            set
            {
                if (value < 0 || value > 4) this.cgpa = -1;
                else this.cgpa = value;
            }
        }

        private string FindGrade()
        {
            if (this.Cgpa < 0) return "Invalid";
            else if (this.Cgpa >= 3) return "A+";
            else if (this.Cgpa >= 2) return "B+";
            else if (this.Cgpa >= 1) return "C+";
            else return "D+";
        }

        public void Print()
        {
            Console.WriteLine("Student's ID: {0}", this.Id);
            Console.WriteLine("Student's Name: {0}", this.Name);
            Console.WriteLine("Student's CGPA: {0}", this.Cgpa);
            Console.WriteLine("{0}'s Grade: {1}\n", this.Name, this.FindGrade());
        }
    }
}