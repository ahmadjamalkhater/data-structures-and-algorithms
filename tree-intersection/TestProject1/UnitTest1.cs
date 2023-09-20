using Tree_intersection;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TreeIntersection_Should_Return_Common_Values()
        {
            // Arrange
            TreeNode tree1 = new TreeNode(1);
            tree1.Left = new TreeNode(2);
            tree1.Right = new TreeNode(3);

            TreeNode tree2 = new TreeNode(2);
            tree2.Left = new TreeNode(1);
            tree2.Right = new TreeNode(4);

            // Act
            HashSet<int> commonValues = TreeIntersection.tree_intersection(tree1, tree2);

            // Assert
            Assert.Contains(1, commonValues); // 1 is a common value between the trees
            Assert.Contains(2, commonValues); // 2 is a common value between the trees
            Assert.DoesNotContain(3, commonValues); // 3 is not a common value
            Assert.DoesNotContain(4, commonValues); // 4 is not a common value
            Assert.Equal(2, commonValues.Count); // There should be two common values
        }

        [Fact]
        public void TreeIntersection_Should_Return_Empty_Set_When_No_Common_Values()
        {
            // Arrange
            TreeNode tree1 = new TreeNode(1);
            tree1.Left = new TreeNode(2);
            tree1.Right = new TreeNode(3);

            TreeNode tree2 = new TreeNode(4);
            tree2.Left = new TreeNode(5);
            tree2.Right = new TreeNode(6);

            // Act
            HashSet<int> commonValues = TreeIntersection.tree_intersection(tree1, tree2);

            // Assert
            Assert.Empty(commonValues); // The trees have no common values, so the result should be an empty set
        }

        [Fact]
        public void TreeIntersection_Should_Return_Empty_Set_When_One_Tree_Is_Null()
        {
            // Arrange
            TreeNode tree1 = null;

            TreeNode tree2 = new TreeNode(2);
            tree2.Left = new TreeNode(1);
            tree2.Right = new TreeNode(4);

            // Act
            HashSet<int> commonValues = TreeIntersection.tree_intersection(tree1, tree2);

            // Assert
            Assert.Empty(commonValues); // One of the trees is null, so the result should be an empty set
        }
    }
}