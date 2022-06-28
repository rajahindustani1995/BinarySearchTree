using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_BST_
{
    internal class BinaryTree<T>where T : IComparable<T>
    {
        public T NodeData { get; set; }

        //For left subtee
        public BinaryTree<T> LeftTree { get; set; }

        //For right subtree
        public BinaryTree<T> RightTree { get; set; }

        public BinaryTree(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }

        
        public static int leftCount = 0, rightCount = 0;

        
        public void Insert(T item)
        {
            T currentNodeValue = NodeData;

            
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                //if left subtree is null
                if (LeftTree == null)
                {
                    //put item in the left subtree
                    LeftTree = new BinaryTree<T>(item);
                }
                //if left subtree is not null
                else
                {
                    //recursive Insert method call on left subtree
                    LeftTree.Insert(item);
                }
            }

            
            else
            {
                //if right subtree is null
                if (RightTree == null)
                {
                    //then put item in right subtree's root/parent node
                    RightTree = new BinaryTree<T>(item);
                }
                //if right subtree is not null
                else
                {
                    //recursive Insert method call on right subtree
                    RightTree.Insert(item);
                }
            }
        }

        
        public void Display()
        {
            //if left subtree is not null
            if (LeftTree != null)
            {
                //left subtree is not null here therefore increment the node count of left subtree i.e. leftCount++
                leftCount++;

                //then call display method recursively on left subtree
                LeftTree.Display();
            }

            
            Console.Write(NodeData.ToString() + " ");

            
            if (RightTree != null)
            {
                //right subtree is not null here therefore increment the node count of right subtree i.e. rightCount++
                rightCount++;

                //call display method recursively on right subtree
                RightTree.Display();
            }
        }

        
        public void Size()
        {
            //prints left subtree count + right subtree count + 1 (for root node)
            Console.WriteLine("\nSize of the BST is : " + (1 + leftCount + rightCount));
        }
    }
}
