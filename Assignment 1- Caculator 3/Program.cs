using System;

namespace Assignment_1__Caculator_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's startr caculate!");

            bool keepLooping = true;

            do
            {
                double num1 = AskUserForNumber();
                double num2 = AskUserForNumber();
                string operation = AskUserFor("one of following math operators + - * /");

                switch(operation)
                { 
                    case "+":
                        Console.WriteLine($"{num1} + {num2}={ Addition(num1, num2)}");
                    break;
                    case "-":
                        Console.WriteLine($"{num1} - {num2}={ Subtraction(num1, num2)}");
                    break;
                    case "*":
                        Console.WriteLine($"{num1} - {num2}={ Multiplactation(num1, num2)}");
                    break;
                    case "/":
                        Console.WriteLine($"{num1} - {num2}={ Division(num1, num2)}");
                    break;
                    default:
                        Console.WriteLine("Not a supported math operator.");
                    break;
                }

                Console.WriteLine("if you want to stop calculation type quit otherwise just hit enter.");
                if (Console.ReadLine().Equals("quit"))
                {
                    keepLooping = false;

                }
            } while (keepLooping);
        }
        static double Addition (double num1, double num2)
        {
            return num1 + num2;
        }
        static double Subtraction (double num1, double num2)
        {
            return num1 - num2;
        }
        static double Multiplactation (double num1,double num2)
        {
            return num1 * num2;
        }
        static double Division (double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("This calculator does not divide with zero numbers.\nResult will be shown as 0.");
                return 0;

            }
            else
            {
                return num1 / num2;
            }
            
        }
        static string AskUserFor (string what)
        {
            Console.WriteLine($"Please enter {what}:");
            return Console.ReadLine();
        }
        static double AskUserForNumber ()
        {
            double number = 0;
            bool noNumber;

            do
            {
                noNumber = true;
                try
                {
                    number = double.Parse(AskUserFor ("a number"));
                    noNumber = false;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Did not get any input.");
                }

                catch (OverflowException)
                {
                    Console.WriteLine("The number is too big.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Was unable to read the number.");
                }

            } while (noNumber);
            return number;
        }

    }
}
