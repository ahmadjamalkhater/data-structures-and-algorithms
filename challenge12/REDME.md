# First-in, First-out Animal Shelter

## Description
In this challenge, we are tasked with implementing an animal shelter that holds only dogs and cats. The shelter operates using a first-in, first-out approach. We need to create a class called "AnimalShelter" with two main methods: `Enqueue` and `Dequeue`.

- `Enqueue`: This method takes an animal (either a dog or a cat) and adds it to the shelter. The animal must have a `Species` property that is either "dog" or "cat" and a `Name` property that is a string.

- `Dequeue`: This method takes a preference (either "dog" or "cat") and returns the oldest animal of that preference from the shelter. If the preference is not "dog" or "cat," the method returns null.

## Whiteboard Process
![12challenge](./challenge12/12)

## Approach & Efficiency
For the `Enqueue` method, we simply add the animal to the end of the shelter queue, resulting in a time complexity of O(1).

For the `Dequeue` method, we need to search for the oldest animal of the given preference, which may require iterating through the shelter queue. In the worst case, this could take O(n) time, where n is the number of animals in the shelter.

Overall, the space complexity is O(n) because we use a queue to store the animals.

## Solution
To run the code, follow these steps:

1. Create an instance of the AnimalShelter class.
2. Use the `Enqueue` method to add animals to the shelter.
3. Use the `Dequeue` method to retrieve the oldest animal based on the preference.

Here is an example of how to use the AnimalShelter class:

```csharp
// Create an instance of the AnimalShelter
AnimalShelter shelter = new AnimalShelter();

// Enqueue some animals
shelter.Enqueue(new Animal("dog", "Buddy"));
shelter.Enqueue(new Animal("cat", "Whiskers"));
shelter.Enqueue(new Animal("dog", "Max"));

// Dequeue an animal with preference "dog"
Animal dog = shelter.Dequeue("dog");
Console.WriteLine(dog.Name); // Output: Buddy

// Dequeue an animal with preference "cat"
Animal cat = shelter.Dequeue("cat");
Console.WriteLine(cat.Name); // Output: Whiskers
