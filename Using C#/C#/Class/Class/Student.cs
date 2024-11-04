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

        // we should create an empty constructor if we need it and also declare a parameterized constructor
        public Student() 
        {
        }

        // initialize using Setter functions is good practice
        public Student(int id, string name, double cgpa)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetCgpa(cgpa);
        }


        // we should use getter and setter function to read/write data
        public void SetId(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        // we can validate input before set
        public void SetCgpa(double cgpa)
        {
            if (cgpa >= 0 && cgpa <= 4) this.cgpa = cgpa;
            else this.cgpa = -1;
        }

        public double GetCgpa() 
        {
            return this.cgpa; 
        }

        public void Print()
        {
            Console.WriteLine("Student's ID: {0}", this.GetId());
            Console.WriteLine("Student's Name: {0}", this.GetName());
            Console.WriteLine("Student's CGPA: {0}", this.GetCgpa());
        }
    }
}
