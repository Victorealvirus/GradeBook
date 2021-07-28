using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Book
    {
        List<double> grades = new List<double>();
        string name;

        public Book(string name)
        {
            this.name = name;
        }
        public void AddGrades(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStats()
        {            
            Console.WriteLine($"The highest grade in {name} is {grades.Max()}");
            Console.WriteLine($"The lowest grade in {name} is {grades.Min()}");
            Console.WriteLine($"The average grade in {name} is {grades.Average()}");
        }
    }
}
