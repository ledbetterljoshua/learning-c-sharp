using System;
using Xunit;

namespace GradeBook.BookTests
{
    public class BookTests
    {
        [Fact]
        public void BookStatistics()
        {
            var book = new Book("test");

            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStatistics();

            Assert.Equal(90.5, result.Highest, 1);
            Assert.Equal(77.3, result.Lowest, 1);
            Assert.Equal(85.6, result.Average, 1);
        }
    }
}
