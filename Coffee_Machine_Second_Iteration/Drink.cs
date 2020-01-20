using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_Second_Iteration
{
    public class Drink
    {
        public char DrinkType { get; set; }
        public double DrinkPrice { get; set; }
        public bool CanBeExtraHot { get;set; }
        public string DrinkFullName { get; set; }
        public bool WithAStick { get; set; }
        public bool WithSugar { get; set; }

        public Drink(char DrinkType)
        {
            this.DrinkType = DrinkType;
            if (this.DrinkType == 'C')
            {
                DrinkPrice = 0.6;
                CanBeExtraHot = true;
                DrinkFullName = "Coffee";
                WithAStick = true;
                WithSugar = true;
            }
            else if (this.DrinkType == 'H')
            {
                DrinkPrice = 0.4;
                CanBeExtraHot = true;
                DrinkFullName = "Chocolate";
                WithAStick = true;
                WithSugar = true;
            } else if (this.DrinkType == 'T')
            {
                DrinkPrice = 0.5;
                CanBeExtraHot = true;
                DrinkFullName = "Tea";
                WithAStick = true;
                WithSugar = true;
            }
            else if (this.DrinkType == 'J')
            {
                DrinkPrice = 0.6;
                CanBeExtraHot = false;
                DrinkFullName = "Orange Juice";
                WithAStick = false;
                WithSugar = false;
            }

        }
    }
}
