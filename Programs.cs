using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Shaz's grade book.");
            book.AddGrade(89.9);
            book.AddGrade(79.2);
            book.AddGrade(88.4);
            book.AddGrade(47.6);

            var stats = book.GetStatistics();
            Console.WriteLine($"This is the highest grade: {stats.High}");
            Console.WriteLine($"This is the lowest grade: {stats.Low}");
            Console.WriteLine($"The average is: {stats.Average:N1}");

            Console.ReadLine();
        }
  
