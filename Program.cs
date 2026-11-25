using System;

Console.WriteLine("****************************************************************\n");
Console.WriteLine("PART 1 - Inheritance");

Dog karabas = new Dog("Karabas", 3, "Kangal");
karabas.Eat();
karabas.Fetch();
Console.WriteLine($"{karabas.Name} ({karabas.Breed}), {karabas.Age} years old");

Console.WriteLine("\n****************************************************************\n");
Console.WriteLine("PART 2 - Constructors");

Dog constructorExample = new Dog("Karabas", 3, "Kangal", showConstructor: true);
constructorExample.Eat();
constructorExample.Fetch();


Console.WriteLine("\n****************************************************************\n");
Console.WriteLine("PART 3 - Polymorphism");

Animal[] animals = { karabas, new Cat("Tekir", 2) };

foreach (Animal animal in animals)
{
    animal.MakeSound();
}

Console.WriteLine("\n****************************************************************\n\n");