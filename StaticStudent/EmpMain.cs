using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class EmpMain
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Employee emp1 = new Employee(1, "Tejal", 50000);
            Employee emp3 = new Employee("Megha");

            emp.display();
            emp1.display();
            emp3.display();
        }
    }
}
