using System;

class Program
{
    static void Main()
    {
        AnimalShelter shelter = new AnimalShelter();

        // Enqueue some animals
        Animal cat1 = new Animal { Species = "cat", Name = "Whiskers" };
        Animal dog1 = new Animal { Species = "dog", Name = "Buddy" };
        shelter.Enqueue(cat1);
        shelter.Enqueue(dog1);

        // Dequeue a cat
        Animal adoptedCat = shelter.Dequeue("cat");
        Console.WriteLine($"Adopted Cat: {adoptedCat.Name}");

        // Dequeue a dog
        Animal adoptedDog = shelter.Dequeue("dog");
        Console.WriteLine($"Adopted Dog: {adoptedDog.Name}");
    }
}
