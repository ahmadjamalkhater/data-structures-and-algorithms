using Xunit;

namespace Stack_QueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void Push_Stack_Success()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();

            // Act
            stack.Push(10);

            // Assert

            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Push_MultipleValues_Stack_Success()
        {
            // Arrange
            Stack<string> stack = new Stack<string>();

            // Act
            stack.Push("ahmad");
            stack.Push("jamal");
            stack.Push("khater");

            // Assert

            Assert.Equal("Ali", stack.Peek());
        }

        [Fact]
        public void Pop_Stack_Success()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(7);

            // Act
            int poppedValue = stack.Pop();

            // Assert
            Assert.Equal(7, poppedValue);
        }

        [Fact]
        public void Peek_Stack_Success()
        {
            // Arrange
            Stack<string> stack = new Stack<string>();
            stack.Push("Ammar");
            stack.Push("Yousof");

            // Act
            string topValue = stack.Peek();

            // Assert
            Assert.Equal("Yousof", topValue);
        }

        [Fact]
        public void EmptyStack_PopOrPeek_Exception()
        {
            // Arrange
            Stack<int> stack = new Stack<int>();

            // Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Fact]
        public void Enqueue_Queue_Success()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();

            // Act
            queue.Enqueue(10);

            // Assert

            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void Enqueue_MultipleValues_Queue_Success()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();

            // Act
            queue.Enqueue("Ammar");
            queue.Enqueue("Yousof");
            queue.Enqueue("Ali");

            // Assert

            Assert.Equal("Ammar", queue.Peek());
        }

        [Fact]
        public void Dequeue_Queue_Success()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);

            // Act
            int dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal(10, dequeuedValue);
        }

        [Fact]
        public void Peek_Queue_Success()
        {
            // Arrange
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ammar");
            queue.Enqueue("Yousof");

            // Act
            string frontValue = queue.Peek();

            // Assert
            Assert.Equal("Ammar", frontValue);
        }


        [Fact]
        public void EmptyQueue_DequeueOrPeek_Exception()
        {
            // Arrange
            Queue<int> queue = new Queue<int>();

            // Assert
            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }
    }
}