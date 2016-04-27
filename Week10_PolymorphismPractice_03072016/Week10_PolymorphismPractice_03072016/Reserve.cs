using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_PolymorphismPractice_03072016
{
    class Reserve : Account 
    {
        //Reserve account cannot have a balance that is greater than 3000.00

        public override void deposit()
        {
            Console.WriteLine("You have a balance of ${0} in your RESERVE account", Balance);
            double depositLimit = 3000.00 - Balance;
            Console.WriteLine("You can deposit up to ${0}.", depositLimit);
            base.deposit();
            if (Balance > 3000)
            {
                Console.WriteLine("You deposited too much.  You will be penalized.");
            }
        }
    }
}
