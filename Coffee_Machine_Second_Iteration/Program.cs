using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_Second_Iteration
{
    class Program
    {
        static void Main(string[] args)
        {


            Order O = new Order('J',' ', 2, true);
            Console.WriteLine(O.ToString());
            Console.WriteLine(O.GetAndCheckMoneyRecivied(0.71));
            Console.ReadKey();
    
        }
    }
}
