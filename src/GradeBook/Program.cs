using System;

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

            Console.WriteLine($"The highest grade is {stats.high}");
            Console.WriteLine($"The lowest grade is {stats.low}");
            Console.WriteLine($"The average grade is {stats.Avg:N2}");
            Console.WriteLine($"The Letter grade is {stats.Letter}");
        }
    }
}
