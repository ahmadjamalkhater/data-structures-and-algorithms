public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    public Node Head { get; set; }

    public int KthFromEnd(int k)
    {
        if (Head == null)
        {
            throw new Exception("The linked list is empty.");
        }

        if (k < 0)
        {
            throw new Exception("Invalid value for k.");
        }

        Node slowPtr = Head;
        Node fastPtr = Head;

        // Move the fast pointer k nodes ahead of the slow pointer
        for (int i = 0; i < k; i++)
        {
            if (fastPtr.Next != null)
            {
                fastPtr = fastPtr.Next;
            }
            else
            {
                throw new Exception("The linked list does not have k nodes.");
            }
        }

        // Move both pointers until the fast pointer reaches the end
        while (fastPtr.Next != null)
        {
            slowPtr = slowPtr.Next;
            fastPtr = fastPtr.Next;
        }

        return slowPtr.Value;
    }
}
