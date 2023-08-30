using System;
using Xunit;
using TestProject1;
using cc26;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestInsertionSorting()
        {
            int[] unsortedArray = { 8, 4, 23, 42, 16, 15 };
            int[] expectedSortedArray = { 4, 8, 15, 16, 23, 42 };

            int[] sortedArray = Insertions.InsertionSorting(unsortedArray);

            Assert.Equal(expectedSortedArray, sortedArray);
        }

        [Fact]
        public void TestInsertionSortingWithNegativeNumbers()
        {
            int[] unsortedArray = { 20, 18, 12, 8, 5, -2 };
            int[] expectedSortedArray = { -2, 5, 8, 12, 18, 20 };

            int[] sortedArray = Insertions.InsertionSorting(unsortedArray);

            Assert.Equal(expectedSortedArray, sortedArray);
        }

        [Fact]
        public void TestInsertionSortingWithDuplicateNumbers()
        {
            int[] unsortedArray = { 5, 12, 7, 5, 5, 7 };
            int[] expectedSortedArray = { 5, 5, 5, 7, 7, 12 };

            int[] sortedArray = Insertions.InsertionSorting(unsortedArray);

            Assert.Equal(expectedSortedArray, sortedArray);
        }
    }
}
