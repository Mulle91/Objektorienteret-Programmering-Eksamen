using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator

	//This is some of the info about the car audi, that is a class witch inherts from Vehicle//
{
    class Audi : Vehicle
    {
        Vehicle vehicle;

       public void PartsOfCar()
        {
            wheels  = 4;
            doors   = 4;
            engine  = 1;

        }



        
    }
}
