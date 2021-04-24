using System;

namespace ws_mid4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day,time,nset1=5,nset2=2,nset3=3;
            string set;
                day = int.Parse(Console.ReadLine());
                time = int.Parse(Console.ReadLine());
            do
            {
                set = Console.ReadLine();
                if (set == "Breakfast Set")
                {
                    if (time > 11 && day >= 1 && day <= 5)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    if (nset1 == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        nset1--;
                    }
                }
                else if (set == "Weekend Set")
                {
                    if (time > 11 && day >= 1 && day <= 5)
                    {
                        Console.WriteLine("Sorry your order is not available");
                    }
                    if (nset2 == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        nset2--;
                    }
                }
                else if (set == "Coffee")
                {
                    if (nset3 == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                    }
                    else
                    {
                        nset3--;
                    }
                }
                else if (set == "End") { }
                else
                {
                    Console.WriteLine("Please enter a valid menu");
                }
            } while (set != "End");
        }
    }
}
