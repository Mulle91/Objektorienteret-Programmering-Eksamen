using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Option

		//This is a list of options//
    {
        private string ListOfOptions;

        public Option (string ListOfOptions)
        {
            this.ListOfOptions = ListOfOptions;
        }

        public string HereIsOptionsList()
        {
            return ListOfOptions + "\n" + "Pres 1 to see a list of all the cars we have"  + "\n" + "Pres 2 to do something" + "\n" + "Pres 3 to do something";
        }

       

        public string OptionDe
        {
            get { return ListOfOptions; }
            set { ListOfOptions = value; }
        }

		internal bool PartsOfCar()
		{
			throw new NotImplementedException();
		}
	}
}
