using System;
using System.IO;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Adwait's grade book");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quit");
                var input = Console.ReadLine();
                if(input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            var stats = book.GetStats();

            using (var writer = File.AppendText($"{book.Name}.txt"))
            {
                writer.WriteLine($"The highest grade is {stats.high}");
                writer.WriteLine($"The lowest grade is {stats.low}");
                writer.WriteLine($"The average grade is {stats.Avg:N2}");
                writer.WriteLine($"The Letter grade is {stats.Letter}");
            }
        }
    }
}
