using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    public class Student
    {
        private readonly List<float> AllGrades = new();
        private string _FullName { get; set; }
        public Student(string fullName)
        {
            _FullName = fullName;
        }

        public void AddGrade(float degree)
        {
            if ((degree >= 0 && degree <= 100))
                AllGrades.Add(degree);
            else
                Console.WriteLine("Range must be from 1 to 100");
        }

        public void ShowAllData()
        {
            Console.WriteLine($"Full Name : {_FullName}");
            Console.WriteLine($"Min value : {AllGrades.Min()}");
            Console.WriteLine($"AVG value : {AllGrades.Average()}");
            Console.WriteLine($"Max value : {AllGrades.Max()}");
        }

    }
}