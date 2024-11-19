using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStudent
{
    internal class PaymentMain
    {
        static void Main(string[] args)
        {
            PaymentMOverloading payment = new PaymentMOverloading();
            PaymentMOverloading.payBill(1000);
            PaymentMOverloading.payBill(1000, "credit card");
        }
    }
}
