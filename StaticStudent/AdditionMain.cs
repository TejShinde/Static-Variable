using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class AdditionMain
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();

            Console.WriteLine(a.Add(5, 3));
            Console.WriteLine(a.Add(5.5, 3.3));
            Console.WriteLine(a.Add(1, 2, 3));
        }
    }
}
