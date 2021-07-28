using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Adwait's grade book");
            book.AddGrades(89.1);
            book.AddGrades(90.5);
            book.AddGrades(77.5);

            book.ShowStats();
        }
    }
}
