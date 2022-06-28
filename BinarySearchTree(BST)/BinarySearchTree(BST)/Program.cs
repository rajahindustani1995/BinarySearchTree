using BinarySearchTree_BST_;

namespace BinarySearchTree
{
    class Program
    {
        public static void Main(String [] args)
        {
            //UC-1
            //BinaryTree<int> binary1 = new BinaryTree<int>(56);
            //binary1.Insert(30);
            //binary1.Insert(70);
            //Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
            //binary1.Display();


            //UC-2
            BinaryTree<int> binary2 = new BinaryTree<int>(56);
            binary2.Insert(30);
            binary2.Insert(70);
            binary2.Insert(22);
            binary2.Insert(40);
            binary2.Insert(60);
            binary2.Insert(95);
            binary2.Insert(11);
            binary2.Insert(65);
            binary2.Insert(3);
            binary2.Insert(16);
            binary2.Insert(63);
            binary2.Insert(67);
            Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
            binary2.Display();
            binary2.Size();
        }
    }
}
