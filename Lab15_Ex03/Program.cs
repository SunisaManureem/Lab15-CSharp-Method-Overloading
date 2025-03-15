using System;

class Program
{
    static void Main()
    {
        var animalA = new Dog();
        var animalB = new Fish();
        var animalC = new Bird();

        animalA.Move();
        animalB.Move();
        animalC.Move();
    }
}

class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Move successfully.");
    } 
}

class Dog : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: Running on the ground.");
        base.Move();  // Calls the base class's Move method
    }
}

class Fish : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: Swimming in the water.");
        base.Move();  // Calls the base class's Move method
    }
}

class Bird : Animal
{
    public override void Move()
    {
        Console.WriteLine($"{this.GetType().Name}: Flying in the air.");
        base.Move();  // Calls the base class's Move method
    }
}