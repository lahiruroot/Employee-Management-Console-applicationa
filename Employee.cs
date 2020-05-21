using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employee
    {
        double travelAllowance, performanceincentive, MS;
        public void salary(double BS,double NL,double YS)
        {
            if(NL<=3)
            {
                performanceincentive = BS * 0.2;
            }
            else
            {
                performanceincentive = BS * 0.05;
            }

            if(YS>5)
            {
                travelAllowance = 10000;

            }
            else if(YS>3)
            {
                travelAllowance = 5000;

            }
            else
            {
                travelAllowance = 2500;
            }
            MS = BS + performanceincentive + travelAllowance;
            Console.WriteLine("Congrats your monthly salary is " + MS);
            Console.ReadKey();
        }

    }
}
