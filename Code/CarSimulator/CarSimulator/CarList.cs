using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class CarList

		//Here i have maked my list fo cars//
    {
        private string ListOfcars;

        public CarList (string ListOfCars)
        {
            this.ListOfcars = ListOfCars;
        }

        public string HereIsAllOfTheCars()
        {
            return ListOfcars + "\n" + "Audi" + "\n" + "Seat" + "\n" + "Mercedes";
        }


        public string CarsDe
        {
            get { return ListOfcars; }
            set { ListOfcars = value; }
        }

    }
}
