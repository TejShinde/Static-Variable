using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class StaticStudent
    {
        // Data members
        private int rollNo;
        private string name;
        private double totalMarks, percentage;
        private static int count;

        // Static constructor
        // 1. It does not have access specifier.
        // 2. This constructor is called only once, when the first object is created.
        // 3. Static constructors cannot have parameters in C#.
        static StaticStudent()
        {
            count = 0; // Initializing the count for student roll numbers.
        }

        // Parameterized constructor
        public StaticStudent(string nm, double marks)
        {
            count++; // Increment the count for each new student.
            rollNo = count; // Assigning a roll number to the student.
            name = nm;
            totalMarks = marks;
        }

        // Calculate percentage
        public void CalculatePercentage(double maxMarks)
        {
            percentage = (totalMarks / maxMarks) * 100; // Calculate percentage based on max marks
        }

        // Display student details
        public string Print()
        {
            return $"Roll No = {rollNo}, Name = {name}, Percentage = {percentage:F2}%"; // :F2 formats to 2 decimal places
        }

        // Static method to return the number of Student objects created
        public static int StudentCount()
        {
            return count;
        }
    }
}
