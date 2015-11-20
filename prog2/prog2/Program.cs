using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double days, rate, salary, sss, pag, phil, net, bonus, td;
            int choice;
            char ans, like;

            do
            {
                td = 0;
                net = 0;
                sss = 0;
                pag = 0;
                phil = 0;

                Console.Clear();
                Console.Write("Enter total number of days: ");
                days = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter rate per day: ");
                rate = Convert.ToDouble(Console.ReadLine());

                salary = days * rate;
                Console.Write("The salary is: " + salary);

                do
                {
                    like = 'N';
                    Console.Write("\n MENU: ");
                    Console.Write("\n1: Compute total deduction: ");
                    Console.Write("\n2: Compute netpay: ");
                    Console.Write("\n3: Compute bonus: ");
                    Console.Write("\nEnter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());


                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("\n SSS: ");
                                sss = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n PagIbig: ");
                                pag = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\n PhilHealth: ");
                                phil = Convert.ToInt32(Console.ReadLine());

                                td = sss + pag + phil;
                                Console.Write("\n Total Deduction is: " + td);
                                like = 'Y';
                                break;
                            }
                        case 2:
                            {
                                net = salary - td;
                                Console.Write("\n Netpay is: " + net);
                                break;
                            }
                        case 3:
                            {
                                td = sss + pag + phil;

                                if (net <= 1 && net <= 5000)
                                {
                                    bonus = 500;
                                    Console.Write(" Bonus is: " + bonus);
                                }
                                if (net > 5000 && net <= 20000)
                                {
                                    bonus = net * .25;
                                    Console.Write(" Bonus is: " + bonus);
                                }
                                if (net > 20000)
                                {
                                    bonus = net * .5;
                                    Console.Write(" Bonus is: " + bonus);
                                }
                                break;
                            }
                        default:
                            {
                                Console.Write("\n  Wrong Input ! ");
                                break;
                            }

                    }

                    Console.Write("\n Do you want to back to MENU? [Y/N]: ");
                    like = Convert.ToChar(Console.ReadLine());

                } while (like == 'Y' || like == 'y');
                Console.Write("Ok");

                Console.Write("\n Do you want to continue? [Y/N]: ");
                ans = Convert.ToChar(Console.ReadLine());

            } while (ans == 'Y' || ans == 'y');
            Console.Write("\n Exit ! ");
            Console.ReadKey();
        }


    }
}
