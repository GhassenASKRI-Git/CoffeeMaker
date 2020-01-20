using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_Second_Iteration
{
    public class Order :Drink
    { 
        public int QteOfSugar { get; set; }
        public bool WithStick { get; set; }
        public char IsExtraHotDrink { get; set; }
        public string MessageToDisplay { get; set; }



        public Order(char DrinkType, char IsExtraHotDrink, int QteOfSugar, bool WithStick):base(DrinkType)
        {
            
            this.QteOfSugar = QteOfSugar;
            this.WithStick = WithStick;
            this.IsExtraHotDrink = IsExtraHotDrink;

            
            

        } 

       

        public string GetAndCheckMoneyRecivied(double MoneyRecivied)
        {
            Drink D = new Drink(DrinkType);
            if (MoneyRecivied < D.DrinkPrice) 
            {
                MessageToDisplay = "You don't have enougth money";
                
            }
            else
            {
                MessageToDisplay = "Your Command it will be prepared ....";
               
            }
            return MessageToDisplay;
        }



        public override string ToString()
        {

            string sugarPluralTerminology = "";
            string stickExistance = "";
            sugarPluralTerminology = QteOfSugar > 1 ? " sugars" : " sugar";
            stickExistance = WithStick == true ? "a stick" : " no stick";

            Drink D = new Drink(DrinkType);

            if (DrinkType == ' ')
                {
                MessageToDisplay = "You have to choose a drink ";
                }

            if ((D.WithAStick == false)|| (D.WithSugar == false))
            {
                MessageToDisplay = "Your order is : " + D.DrinkFullName;
            }
            else if (IsExtraHotDrink == 'h')
                {
                MessageToDisplay = "Your order is : an extra hot " + D.DrinkFullName + " with " + QteOfSugar + "" + sugarPluralTerminology + " and " + stickExistance;
                }
            else
                { 
                MessageToDisplay = "Your order is : " + D.DrinkFullName + " with " + QteOfSugar + "" + sugarPluralTerminology + " and " + stickExistance;
                }

            return MessageToDisplay;

        }
    }

}

   
   

