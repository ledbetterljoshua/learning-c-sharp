using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("thingie");
            book.AddGrade(80.1);
            book.AddGrade(0.1);
            book.AddGrade(1.1);
            book.AddGrade(23.1);
            book.AddGrade(-23.1);
            book.AddGrade(123.1);
            book.GetStatistics();
        }
    }
}
