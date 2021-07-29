using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    public class Book
    {
        List<double> grades = new List<double>();
        public string Name;

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

            switch(stats.Avg)
            {
                case var d when d >= 90.0:
                    stats.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    stats.Letter = 'B';
                    break;

                case var d when d >= 70.0:
                    stats.Letter = 'C';
                    break;

                case var d when d >= 60.0:
                    stats.Letter = 'D';
                    break;

                default:
                    stats.Letter = 'F';
                    break;
            }

            return stats;
            
        }
    }
}
