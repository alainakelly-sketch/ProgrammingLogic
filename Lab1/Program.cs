namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        //Step 1
        /* Alaina Kelly
        Title: [IT-1050 - Lab 1]. */
       
        //Step 2
        Console.WriteLine("Alaina Kelly, IT 1050- Lab1");
        string lang = "python"; 
        int fav = 6;
        double num = 3.00D;
        bool myBool = true;
       
        //Step 3
        Console.WriteLine("My favorite programming language is " + lang);
        Console.WriteLine("My favorite number is " + fav);
        Console.WriteLine("I have written " + num + " programs");
        Console.WriteLine("It is " + myBool + " that I have some programming experience, but not much");
       
        //Step 4
        const string mySchool = "Ohio State"; 
        Console.WriteLine("I go to The " + mySchool + " University");
        
        //Step 5
        double myDouble = 9.78;
        int myInt = (int) myDouble; 
        bool myBoo = false;
        Console.WriteLine("Double: " + myDouble);
        Console.WriteLine("Integer: " + myInt);
        Console.WriteLine("String: " + Convert.ToString(myInt));
        Console.WriteLine("Bool: " + Convert.ToString(myBoo));
       
        //Step 6
        Console.WriteLine("Enter your username: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter your age");
        int UserInt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your username is " + userName + " and your age is " + UserInt);
       
        //Step 7 
        int num1 = 4;
        int num2 = 6;
        Console.WriteLine("num1 = " + num1);
        Console.WriteLine("num2 = " + num2);
        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));
        Console.WriteLine("Addition (num2 + 10): " + (num2 + 10));
        Console.WriteLine("Subtraction (num2 - 2): " + (num2 - 2));
        Console.WriteLine("Multiplication (num2 * 3): " + (num2 * 3));
        Console.WriteLine("Division (num2 / 2): " + (num2 / 2));
        Console.WriteLine("Modulus (num2 % 2): " + (num2 % 2));
       
        //Step 8
        float myFloat = 1.123456789F;
        double myDub = 1.123456789D; 
        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("Double: " + myDub);
       
        //Step 9
        int ten = 10;
        ten++;
        Console.WriteLine("After Increment: " + ten);
        ten--;
        Console.WriteLine("After Decrement: " + ten);
    }
}
