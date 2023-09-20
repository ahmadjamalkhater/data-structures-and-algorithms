using Tree_intersection;



namespace tree_intersection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // إنشاء الأشجار
            TreeNode tree1 = new TreeNode(1);
            tree1.Left = new TreeNode(2);
            tree1.Right = new TreeNode(3);

            TreeNode tree2 = new TreeNode(2);
            tree2.Left = new TreeNode(1);
            tree2.Right = new TreeNode(4);

            // استخدام الدالة tree_intersection للعثور على القيم المشتركة
            HashSet<int> commonValues = TreeIntersection.tree_intersection(tree1, tree2);

            // طباعة القيم المشتركة
            Console.WriteLine("Common values between trees:");
            foreach (var value in commonValues)
            {
                Console.WriteLine(value);
                

            }

        }
    }
}
