/*
Author: Diego Fernandez
Date: 1/31/2023
Description: This program will allow you to enter an integer then specify for even or odd, and as a result the even/odd numbers 
between 0 and the specified number will return
*/
namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false;
            while (!done)
            {
                try
                {
                    Console.Write("Enter an integer value between 1 and 100: ");
                    int input = int.Parse(Console.ReadLine());
                    if (input >= 0 && input <= 100)
                    {
                        Console.Write("Even or Odd series? ");
                        string series = Console.ReadLine();
                        if (series == "Even")
                        {
                            Console.WriteLine("You have selected the" + series + " series.The numbers between 1 and " + input + " are: ");
                            for (int i = 2; i <= input; i = i + 2)
                            {
                                Console.WriteLine(i.ToString());
                            }
                        }
                        else if (series == "Odd")
                        {
                             Console.WriteLine("You have selected the" + series +
                            " series. The numbers between 1 and " + input + " are:");
                            int i = 0; //counter variable
                            int odd = 1;
                            do
                            {
                                Console.WriteLine(odd);
                                i++;
                                odd = 2 * i + 1;
                            }
                            while (odd < input);
                            Console.WriteLine("You have selected the" + series + " series.The numbers between 1 and " + input + " are: ");
                            for (int r = 1; r <= input; r = r + 2)
                            {
                                Console.WriteLine(r.ToString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please, try again and specify the series type: \"Even\" or \"Odd\"");
                        }
                    }
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Please, enter an integer value");
                }
            }
        }
    }
}