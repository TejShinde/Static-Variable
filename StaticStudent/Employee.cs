using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class Employee
    {
        private int id;
        private string name;
        private double salary;

        public Employee()
        {
            id = 0;
            name = " ";
            salary = 0;
        }
        public Employee(string name)
        {
            //id = 0;
            this.name = name;
            //salary = 0;
        }

        public Employee(int id,string name,double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine($"ID:{id},Name:{name},Salary:{salary}");
        }
    }
}
