using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class EmployeeStatic
    {
        private int id;
        private string name;
        private double basic, hra, da, pf, gross;
        private static int count;

        //static variable
        // 1. it does not have access specifier
        // 2. this constructor calles only once, for the first object creatation. first static 
        // constructor get executed & then rest other constructor get executed.
        //3. can not have parameters to static constructor in C#
        static EmployeeStatic()
        {
            count = 0;  // count=102
        }

        // constructor
        public EmployeeStatic(string nm, double bs)
        {
            count++;
            id = count;
            name = nm;
            basic = bs;
        }
        // calculate emp salary
        public void CalculateSalary()
        {
            hra = basic * 0.40; // 40% of basic salary
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        // display emp details
        public string Print()
        {
            return $"Id = {id} , Name {name}, Gross salary ={gross}";
        }

        // static method

        public static int EmpCount()
        {
            return count;
        }
    }

}

