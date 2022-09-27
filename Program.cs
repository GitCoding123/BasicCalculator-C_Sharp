using System;

namespace Calculator {

    class Program {

        static void Main(string[] args) {

            double num1 = 0;
            double num2 = 0;
            double ans = 0;
            string s1;
            string s2;

            Console.WriteLine("Welcome to the calculator!\n");

            while (true)
            {
                printMenu();
                string choice = Console.ReadLine();



                if (choice == "5")
                {
                    Console.WriteLine("Thank you for using the calculator!");
                    Environment.Exit(0);
                }

                Console.WriteLine("Please choose the first number:\n");
                s1 = Console.ReadLine();
                num1 = Convert.ToDouble(s1);

                Console.WriteLine("Please choose the second number:\n");
                s2 = Console.ReadLine();
                num2 = Convert.ToDouble(s2);

                performOperation(choice, num1, num2, ans);

                //Console.WriteLine("The answer is: " + performOperation(choice, num1, num2, ans));
            }

        

        static void printMenu() {
            Console.WriteLine("Please choose an option:\n1.) Addition\n2.) Subtraction\n3.) Multiplication\n4.) Division\n5.) Quit");
        }

        static void performOperation(string choice, double num1, double num2, double ans)
            {
                switch (choice)
                {
                    case "1":
                        ans = num1 + num2;
                        Console.WriteLine(num1 + " + " + num2 + " = " + ans);
                        break;
                    case "2":
                        ans = num1 - num2;
                        Console.WriteLine(num1 + " - " + num2 + " = " + ans);
                        break;
                    case "3":
                        ans = num1 * num2;
                        Console.WriteLine(num1 + " * " + num2 + " = " + ans);
                        break;
                    case "4":
                        ans = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + ans);
                        break;
                    default:
                        Console.WriteLine("This is default, returning...");
                        break;
                }

            }

        }

    }



}


