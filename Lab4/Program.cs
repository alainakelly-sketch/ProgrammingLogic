using System;
using System.Drawing;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details.
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
    //Problem 1
     public void Start()
    {
        Console.WriteLine("The car is starting.");
    }
    //Problem 2
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }
    //Problem 3
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }
    //Problem 4
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine("The car has been repainted " + newColor + ".");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        myCar.Display(); // Calling the Display method
        myCar.Start(); //Problem 1
        myCar.Drive(5); //Problem 2
        //Problem 3
        string description = myCar.GetDescription();
        Console.WriteLine(description);
        //Problem 4
        myCar.Repaint("Red");
        myCar.Display();
    }
}

//Problem 1

