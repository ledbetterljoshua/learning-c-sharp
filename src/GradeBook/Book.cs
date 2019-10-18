using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        List<double> grades;
        double highestGrade = double.MinValue;
        double lowestGrade = double.MaxValue;
        public string name;

        private Boolean gradeIsValid(double grade)
        {
            if (grade > 100 || grade < 0)
            {
                System.Console.WriteLine($"{grade} is not valid");
                return false;
            }
            return true;
        }

        private Double calcAverageGrade()
        {
            double res = 0.0;
            foreach (double grade in this.grades)
            {
                System.Console.WriteLine(grade);
                res += grade;
            }
            System.Console.WriteLine($"RES: {res}");
            return res / this.grades.Count;
        }

        //constructor
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            if (this.gradeIsValid(grade))
            {
                grades.Add(grade);
                var h = this.highestGrade;
                var l = this.lowestGrade;
                this.highestGrade = Math.Max(grade, h);
                this.lowestGrade = Math.Min(grade, l);
            }
        }
        public Statistics GetStatistics()
        {
            System.Console.WriteLine($"name: {this.name}");
            System.Console.WriteLine($"highest: {this.highestGrade}");
            System.Console.WriteLine($"lowest: {this.lowestGrade}");
            System.Console.WriteLine($"average: {this.calcAverageGrade()}");

            var result = new Statistics();
            result.Highest = this.highestGrade;
            result.Lowest = this.lowestGrade;
            result.Average = this.calcAverageGrade();
            return result;
        }
    }
}