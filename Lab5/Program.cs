namespace Lab5;

class Animal //Step 1
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Cat : Animal //Step 2
{
  public override void animalSound()
    {
        Console.WriteLine("The cat says: meow.");
    }
}
class Dog : Animal 
{
  public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow.");
    }
}

class Program //Step 3
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();
        Animal myCat = new Cat();
        Animal myDog = new Dog();

        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();

    }
}
