// Problem 1
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//Problem 2
for (int i = 1; i <= 20; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

//Problem 3
int n = 5;
while (n > 0)
{
    Console.WriteLine(n);
    n--;
}

//Problem 4
int m = 10;
while (m <= 1000)
{ 
    Console.WriteLine(m);
    m = m + 10;
}

//Problem 5
string [] seasons = {"Spring", "Summer", "Fall", "Winter"};
foreach (string i in seasons)
{
    Console.WriteLine("Season: " + i);
}

//Problem 6
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.Write("Enter a number (1-7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber >= 1 && dayNumber <= 7)
{
    Console.WriteLine("The day is " + days[dayNumber - 1]);
}
else
{
    Console.WriteLine("Invalid input.");
}

//Problem 7
string [] books = {"The Women", "Hunger Games", "Silent Patient"};
string [] authors ={"Kristen Hanna", "Suzanne Collins", "Alex Michaelides"};
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine(books[i] + " by " + authors[i]);
}

//Probelm 8
int [] integers = {32, 89, 100, 8, 68};
Array.Sort(integers);
foreach (int i in integers)
{
  Console.WriteLine("The temperature is " + i + " degrees.");
}
Console.WriteLine("Lowest temperature: " + integers[0]);
Console.WriteLine("Highest temperature: " + integers[integers.Length - 1]);

//Problem 9
int [] num = { 5, 4, 3, 2, 1 };
Array.Reverse(num);
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}