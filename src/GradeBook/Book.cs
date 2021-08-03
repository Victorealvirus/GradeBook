using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        List<double> grades = new List<double>();
        public string Name { get; set; }

        public Book(string name)
        {
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
                grades.Add(grade);
            else
                throw new ArgumentException($"Invalid {nameof(grade)}");
        }

        public Stats GetStats()
        {
            var stats = new Stats();

            foreach (var grade in grades)
            {
                stats.low = Math.Min(grade, stats.low);
                stats.high = Math.Max(grade, stats.high);
                stats.Avg += grade;
            }
            stats.Avg /= grades.Count();

            return stats;
            
        }
    }
}
