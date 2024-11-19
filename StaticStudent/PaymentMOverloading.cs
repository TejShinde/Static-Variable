using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class PaymentMOverloading
    {
        public PaymentMOverloading() { }
        public static void payBill(double amt)
        {
            Console.WriteLine($"Bill amount (no discount):" +amt);
        }
        public static void payBill(double amt,string mode)
        {
            double discount = amt * 0.15;
            double finalAmt = amt - discount;
            Console.WriteLine($"Bill amount after 15% discount for paying by" +mode+":"+finalAmt);
        }
    }
}
