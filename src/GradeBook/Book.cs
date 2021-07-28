using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        List<double> grades = new List<double>();
        string Name;

        public Book(string name)
        {
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Stats GetStats()
        {
            var stats = new Stats();
            stats.Avg = 0.0;
            stats.high = double.MinValue;
            stats.low = double.MaxValue;

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
