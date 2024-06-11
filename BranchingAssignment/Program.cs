using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting max units 
            int weightBox = 50;
            int heightBox = 50;
            int lengthBox = 50;
            int widthBox = 50;

            //welcome message
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");

            //user prompted to enter weight
            Console.WriteLine("Please enter the weight: ");
            int weightPackage = Convert.ToInt32(Console.ReadLine());

            //if the weight is greater than 50, display error message. end program.
            if (weightPackage >= weightBox)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                Environment.Exit(0);
            }

            //if weight is good, proceed with entering other measurements
            else if (weightPackage < weightBox)
            {

                //user prompted to enter width
                Console.WriteLine("Please enter the width: ");
                int widthPackage = Convert.ToInt32(Console.ReadLine());

                //user prompted to enter height
                Console.WriteLine("Please enter the height: ");
                int heightPackage = Convert.ToInt32(Console.ReadLine());

                //user promoted to enter length
                Console.WriteLine("Please enter the length: ");
                int lengthPackage = Convert.ToInt32(Console.ReadLine());


                //creating box results and converting to currency. 
                Console.WriteLine("You're estmiated shipping cost is listed below:");
                int boxResult1 = (((widthPackage * heightPackage) * lengthPackage) * weightBox / 100);

                if (boxResult1 >= 6250000)
                {
                    Console.WriteLine("Your package is too large to ship with Package Express, have a nice day!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                else if ( boxResult1 < 6250000)
                {
                    Decimal boxResults1 = Convert.ToDecimal(boxResult1);
                    Console.WriteLine("$" + boxResult1);
                    Console.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}