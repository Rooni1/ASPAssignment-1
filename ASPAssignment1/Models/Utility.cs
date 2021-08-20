using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPAssignment2.Models
{
    public class Utility
    {
        public float MyTemperature { set; get;  }


        public string Checkfever(float MyTemperature)
        {

            string myTem = "";
            
            if (MyTemperature > 39)
            {
                myTem = "You have high fever";

            }
            if (MyTemperature == 38)
            {
                myTem = "Your body temperature is normal";

            }
            if (MyTemperature > 38 && MyTemperature < 39)
            {
                myTem = "You have fever";
            }
            if (MyTemperature > 37 && MyTemperature < 38)
            {
                myTem = "You have low fever";
            }



            else if (MyTemperature < 37)
            {
                myTem = "Your body temperature is low";
            }
            
            return myTem;

        }
    }

}
