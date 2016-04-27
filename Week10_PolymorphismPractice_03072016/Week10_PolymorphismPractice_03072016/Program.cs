using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_PolymorphismPractice_03072016
{
    class Program
    {
        static void Main(string[] args)
        {
            Savings longTerm = new Savings();       //Instantiate a new Savings object

            //longTerm.deposit();         //called from the parent class, Account
            //longTerm.viewBalance();     //called from the parent class, Account
            //longTerm.withdraw();        //called from the child class, Savings because we overrode the base class method
            //longTerm.viewBalance();     //called from the parent class, Account

            Checking checkAcct = new Checking();

            //checkAcct.deposit();
            //checkAcct.viewBalance();
            //checkAcct.withdraw();
            //checkAcct.viewBalance();

            Reserve resAcct = new Reserve();

            resAcct.Balance = 500.00;
            resAcct.deposit();
            resAcct.viewBalance();
        
        }
    }
}
