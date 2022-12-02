using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            // use this when you want to refer to the object that is currently being operated on
            this.name = name;
            var csvHelper = new CsvHelper.ConvertFromStringArgs();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            // this is saying use highGrade to find the lowest number, then in the foreach loop using highGrade use the Math.Max to find the highest number in (highGrade and number).
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            foreach (var grade in grades)
            {
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
                result.Average += grade;                
            }
            // use the divide equals
            result.Average /= grades.Count;
            return result;
        }

        private List<double> grades;
        private string name;
    }
}
