
using CC27;
using MergeSort;
namespace TestMergeSort
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestForReverseSorted()
        {
            int[] Arry = { 20, 18, 12, 8, 5, -2 };
            int[] Arry2 = MargeSorts.MargeSorting(Arry);
            int[] Expected = { -2, 5, 8, 12, 18, 20 };
            Assert.Equal(Expected, Arry2);
        }
        [Fact]
        public void TestForFewuniques()
        {
            int[] Arry = { 5, 12, 7, 5, 5, 7 };
            int[] Arry2 = MargeSorts.MargeSorting(Arry);
            int[] Expected = { 5, 5, 5, 7, 7, 12 };
            Assert.Equal(Expected, Arry2);
        }
        [Fact]
        public void TestForNearlysorted()
        {
            int[] Arry = { 2, 3, 5, 7, 13, 11 };
            int[] Arry2 = MargeSorts.MargeSorting(Arry);
            int[] Expected = { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(Expected, Arry2);
        }
    }
}