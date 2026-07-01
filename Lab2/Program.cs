using System.Collections;

namespace Lab2;

class Program
{
    static void Main(string[] args)
    {
        //Step 1
        int a = 10;
        int b = 5;
        int c = 15;
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);
        Console.WriteLine("c: " + c);
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < c: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a > b || a > c" + (a > b || a > c));

        //Step 2
        bool isRaining = true;
        bool haveUmbrella = false; 
        if (haveUmbrella && !isRaining)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }

        //Step 3
        Console.WriteLine("How old are you?");
        int UserAge = Convert.ToInt32(Console.ReadLine());
        if (UserAge < 5)
        {
            Console.WriteLine("Ticket is free!");
        }
        else if (UserAge >= 5 && UserAge <= 12)
        {
            Console.WriteLine("Child ticket: $5");
        }
        else if (UserAge >= 13 && UserAge <= 64)
        {
            Console.WriteLine("Standard Ticket: $10");
        }
        else
        {
            Console.WriteLine("Senior ticket: $6");
        }

        //Step 4
        Console.WriteLine("Enter the day of the week (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break; 
        }
        }

    }

