using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_PolymorphismPractice_03072016
{
    class Checking : Account
    {
        public override void viewBalance()
        {
            Console.WriteLine("This is your checking balance.");
            base.viewBalance();
        }

        public override void deposit()
        {
            base.deposit();
            if (Balance > 500.00)
            {
                Console.WriteLine("You have enough money in your checking account to purchase a bike.");
            }
        }
    }
}
