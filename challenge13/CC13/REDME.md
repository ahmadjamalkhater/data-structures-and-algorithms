# Multi-Bracket Validation

## Whiteboard
Multi-Bracket Validation Whiteboard

![CC13WB](./CC13/CC13WB)

## Problem Summary

The task is to write a function called `validate_brackets` that takes a string as input and determines whether the brackets in the string are balanced. The function should return a boolean value representing whether the brackets are balanced or not.

There are three types of brackets to consider:
- Round Brackets: `()`
- Square Brackets: `[]`
- Curly Brackets: `{}`

## Example

**Input**
{}(){}

**Output**
True


## Approach and Efficiency

To solve this problem, we can use a stack and a queue. We iterate through the input string, and whenever we encounter an opening bracket (i.e., `{`, `(`, `[`), we push it onto the stack and enqueue it in the queue. When we encounter a closing bracket (i.e., `}`, `)`, `]`), we check if it matches the corresponding opening bracket. If it does, we pop the opening bracket from the stack and dequeue it from the queue. If it doesn't match, the brackets are unbalanced, and we return false. After processing all brackets, we check if both the stack and queue are empty. If they are, it means all brackets are balanced, and we return true; otherwise, we return false.

The time complexity of this solution is O(n), where n is the length of the input string, as we iterate through the entire string once. The space complexity is O(n) as well, as in the worst case, we may need to store all opening brackets in both the stack and the queue.

## Solution

Here is the C# implementation of the `validate_brackets` function:

```csharp
using System;
using System.Collections.Generic;

public class BracketValidation
{
    public static bool ValidateBrackets(string input)
    {
        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
                queue.Enqueue(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0 || queue.Count == 0)
                    return false;

                char openBracket = stack.Pop();
                char correspondingOpenBracket = GetCorrespondingOpenBracket(c);

                if (openBracket != correspondingOpenBracket)
                    return false;

                queue.Dequeue();
            }
        }

        return stack.Count == 0 && queue.Count == 0;
    }

    private static char GetCorrespondingOpenBracket(char closingBracket)
    {
        switch (closingBracket)
        {
            case ')':
                return '(';
            case ']':
                return '[';
            case '}':
                return '{';
            default:
                throw new ArgumentException("Invalid closing bracket");
        }
    }
}


