using Money.Money;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {

        static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("\t\t    Hello! This is your wallet.\n\t\tPlease enter your amount of money:(Press Enter)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Enter the number of hryvnia");
            int hryvnia = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of cents");
            int cents = Int32.Parse(Console.ReadLine());
            var money1 = new Grivna(hryvnia, cents);
            try
            {
                while (flag)
                {
                    if (money1 < 0)
                    {
                        throw new Bankruptcy($"You are bankrupt!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\tMENU");
                        money1.howMuch();
                        Console.WriteLine("Select the following operation" +
                            "\n1. Add to your money any amount." +
                            "\n2. Take away from your money any amount." +
                            "\n3. Divide your sum by any integer." +
                            "\n4. Multiply to your money any integer." +
                            "\n5. Subtract one penny from your amount." +
                            "\n6. Add one penny to your amount." +
                            "\n7. Compare the two sums for equality." +
                            "\n8. Exit.");
                        int value = Int32.Parse(Console.ReadLine());
                        switch (value)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the number of hryvnias in the amount you want to add");
                                    int hryvniaPlus = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the number of cents in the amount you want to add");
                                    int centsPlus = Int32.Parse(Console.ReadLine());
                                    var moneyPlus = new Grivna(hryvniaPlus, centsPlus);
                                    var Sum = money1 + moneyPlus;
                                    money1 = Sum;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 2:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the amount of hryvnia in the amount you want to take away");
                                    int hryvniaMinus = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the amount of cents in the amount you want to take away");
                                    int centsMinus = Int32.Parse(Console.ReadLine());
                                    var moneyMinus = new Grivna(hryvniaMinus, centsMinus);
                                    var Min = money1 - moneyMinus;
                                    money1 = Min;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 3:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the number you want to divide your amount");
                                    int delitel = Int32.Parse(Console.ReadLine());
                                    var Del = money1 / delitel;
                                    money1 = Del;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 4:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the number you want to multiply your amount");
                                    int mult = Int32.Parse(Console.ReadLine());
                                    var Mul = money1 * mult;
                                    money1 = Mul;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 5:
                                {
                                    Console.Clear();
                                    money1--;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 6:
                                {
                                    Console.Clear();
                                    money1++;
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 7:
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the number of hryvnias to the amount you want to compare");
                                    int hryvniaEqual = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the number of cents to the amount you want to compar");
                                    int centsEqual = Int32.Parse(Console.ReadLine());
                                    var moneyEqual = new Grivna(hryvniaEqual, centsEqual);
                                    if (money1 == moneyEqual)
                                    {
                                        Console.WriteLine("Amounts equal!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Amounts are not equal");
                                    }
                                    Console.WriteLine("Operation completed.(Press Enter)");
                                    Console.ReadKey();
                                }
                                break;
                            case 8:
                                {
                                    flag = false;
                                }
                                break;
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("You are bankrupt!");
            }
        }
    }
}
