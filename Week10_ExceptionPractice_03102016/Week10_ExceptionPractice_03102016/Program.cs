using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10_ExceptionPractice_03102016
{
    class Program
    {
        static void Main(string[] args)
        {
            //firstMethod();

            //System.Console.WriteLine(new Program().Foo()); //why "new Program().Foo()"? Research this construct -- constructing new object in same class and chaining Foo method. Unusual and simply tricky.
            //System.Console.ReadLine();

            secondMethod();

        }

        static void firstMethod()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                string numberText = Console.ReadLine();
                int number = int.Parse(numberText);
                Console.WriteLine("Your number is " + number);
            }

            catch (FormatException objectName)
            {
                Console.WriteLine("That is not a valid number");
                Console.WriteLine();
                //Console.WriteLine(objectName.Message);
                //Console.WriteLine();
                //Console.WriteLine(objectName.Source);
                //Console.WriteLine();
                //Console.WriteLine(objectName.StackTrace);
                //Console.WriteLine(objectName.TargetSite);
                Console.WriteLine(objectName.Data);
            }

            finally
            {
                Console.WriteLine("Thanks for playing!");
            }

            Console.WriteLine("This is at the end of the block.");
        }

        static void secondMethod()
        {
            try
            {
                Console.Write("Enter a number and I will determine its square root: ");
                string userEntry = Console.ReadLine();
                double number = double.Parse(userEntry);
                double sqRoot = Math.Sqrt(number);
                Console.WriteLine("The square root is {0:f3}.", sqRoot);
            }

            catch (FormatException notNumber)
            {
                Console.WriteLine("That was not a number...so...");
            }

            catch(Exception ex)
            {
                Console.WriteLine("This is some sort of exception....so....");
            }

            finally
            {
                Console.WriteLine("Thanks for playing.");
            }
        }

        string Foo()
        {
            try
            {
                throw new System.Exception("An Exception");
                System.Console.Write("Inside Try");             //this will not execute
            }
            catch (System.Exception ex)
            {
                return "HERE - " + ex.Message + " yep.";        //the return happens last
            }
            finally
            {
                System.Console.Write("Finally");               //This happens before the return in the catch statement
            }
            return "Outside Try";

        }

    }
}
