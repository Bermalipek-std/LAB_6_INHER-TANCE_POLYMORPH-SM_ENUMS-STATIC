using System;
public class Animal
{
    public string Name;
    public int Age;

    public Animal(string animalName, int animalAge, bool showConstructor = false)
    {
        Name = animalName;
        Age = animalAge;

        if (showConstructor)
        {
            Console.WriteLine("Animal constructor");
        }
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some sound");
    }
}