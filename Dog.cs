using System;

public class Dog : Animal
{
    public string Breed;

    public Dog(string dogName, int dogAge, string dogBreed, bool showConstructor = false)
        : base(dogName, dogAge, showConstructor)
    {
        Breed = dogBreed;

        if (showConstructor)
        {
            Console.WriteLine("Dog constructor");
        }
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} brings the ball back!");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name}: Woof!");
    }
}