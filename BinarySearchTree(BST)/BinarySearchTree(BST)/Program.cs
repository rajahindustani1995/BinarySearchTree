using BinarySearchTree_BST_;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(String [] args)
        {
            BinaryTree<int> binary1 = new BinaryTree<int>(56);
            binary1.Insert(30);
            binary1.Insert(70);
            Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
            binary1.Display();
        }
    }
}
