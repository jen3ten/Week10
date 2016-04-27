using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_PolymorphismPractice_03072016
{
    class Savings : Account         //A derived class of Account
    {
        //The savings account will not allow a withdrawal unless the balance is greater than $300
        public override void withdraw()
        {
            if (Balance > 300.00)
            {
                double currentAvailable = Balance - 300.00;         //Client only has balance over $300 available for withdrawal
                Console.WriteLine("Current available for withdrawal: ${0}", currentAvailable);
                base.withdraw();
            }   
            else
            {
                Console.WriteLine("Current balance must be greater than $300.00 to withdraw.");
            }
        }
    }
}
