using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Ugro Sayed";
            s1.Cgpa = 2.96;
            s1.Print();

            Student s2 = new Student(1, "Abd Ulllah", 4.96);
            s2.Print();
        }
    }
}