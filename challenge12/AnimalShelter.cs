using System;
using System.Collections.Generic;

public class AnimalShelter
{
    private Queue<Animal> dogsQueue;
    private Queue<Animal> catsQueue;

    public AnimalShelter()
    {
        dogsQueue = new Queue<Animal>();
        catsQueue = new Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
        if (animal.Species == "dog")
        {
            dogsQueue.Enqueue(animal);
        }
        else if (animal.Species == "cat")
        {
            catsQueue.Enqueue(animal);
        }
        else
        {
            throw new ArgumentException("Invalid species. Only 'dog' or 'cat' are allowed.");
        }
    }

    public Animal Dequeue(string pref)
    {
        if (pref == "dog" && dogsQueue.Count > 0)
        {
            return dogsQueue.Dequeue();
        }
        else if (pref == "cat" && catsQueue.Count > 0)
        {
            return catsQueue.Dequeue();
        }

        // If pref is not "dog" or "cat", or the corresponding queue is empty, return null.
        return null;
    }
}

public class Animal
{
    public string Species { get; set; }
    public string Name { get; set; }
}
