# PseudoQueue

This repository contains the implementation of a PseudoQueue class in C#. The PseudoQueue class is designed to simulate a queue data structure using two stacks.

## Challenge Description

The challenge was to implement a PseudoQueue class that provides the functionality of a queue using two stacks. The class should have an `Enqueue` method to add elements to the queue and a `Dequeue` method to remove and return elements from the queue.

## Whiteboard Process

The whiteboard image below shows the initial design of the PseudoQueue class and the approach used to implement the `Enqueue` and `Dequeue` methods.

![Whiteboard](./challenge11/1.png)

## Approach & Efficiency

The approach used in the PseudoQueue class is to maintain two stacks: `stack1` and `stack2`. When an element is enqueued, it is pushed onto `stack1`. When an element is dequeued, the elements from `stack1` are transferred to `stack2` in reverse order, and then the top element of `stack1` is popped and returned. This approach ensures that the elements are dequeued in the same order they were enqueued.

The time complexity of the `Enqueue` method is O(1) because pushing an element onto a stack takes constant time. The time complexity of the `Dequeue` method is O(n) in the worst case, where n is the number of elements in the queue. This is because transferring the elements from `stack1` to `stack2` requires iterating over all the elements in `stack1`.

The space complexity of the PseudoQueue class is O(n), where n is the number of elements in the queue. This is because both `stack1` and `stack2` can potentially hold all the elements.

## Solution

To run the code and see examples of the PseudoQueue in action, you can follow these steps:

1. Clone the repository.
2. Open the solution in a C# compatible IDE such as Visual Studio.
3. Navigate to the `Program.cs` file under the `challenge11` namespace.
4. Inside the `Main` method, you will find an example usage of the PseudoQueue.
5. Run the program.

Here is an example of how the PseudoQueue can be used:

```csharp
PseudoQueue<int> pseudoQueue = new PseudoQueue<int>();
pseudoQueue.Enqueue(10);
pseudoQueue.Enqueue(15);
pseudoQueue.Enqueue(20);

int value = pseudoQueue.Dequeue(); // Returns 10
Console.WriteLine(value);

value = pseudoQueue.Dequeue(); // Returns 15
Console.WriteLine(value);

//This will output:

10
15
