using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_PolymorphismPractice_03072016
{
    abstract class Account      //There will be no objects created of this class
    {
        private double balance;
        
        public double Balance { get; set; }

        public virtual void withdraw()      //This is a virtual method; It can be overridden by a derived class and use polymorphism
        {
            Console.WriteLine("How much would you like to withdraw?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance - amount;
        }

        public virtual void deposit()               //This is not a virtual method
        {
            Console.WriteLine("How much would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());
            Balance = Balance + amount;
        }

        public virtual void viewBalance()
        {
            Console.WriteLine(Balance);
        }
    }
}
