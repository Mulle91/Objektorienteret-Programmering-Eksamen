using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Car

		//Here is what happens in the start of the program//
    {

        private string ShopName;


        public Car(string ShopName)
        {
            this.ShopName = ShopName;
        }

        public string Welcome()
        {
            return "Hello and Welcome to " + ShopName + " Here is the list of the cars we have in stock";
        }

        public string ShopDe
        {
            get { return ShopName; }
            set { ShopName = value; }
        }

    }
}
