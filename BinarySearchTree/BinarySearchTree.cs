using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //root node
        private Node child;
        private Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Add(int child)
        {
            Node node = new Node(child);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node parent = root;

                while (parent.leftChild != null || parent.rightChild != null)
                {
                    if (child <= parent.data)
                    {
                        parent.leftChild = node;
                    }
                    else if (child > node.data)
                    {
                        parent.rightChild = node;
                    }
                }
            }
        }
          
        public bool SearchTree(int x)
        {
            Node node = root;
            while (node != null)
            {
                if (node.data == x)
                {
                    break;
                }
                while (x < node.data)
                {
                    node = node.leftChild;
                    Console.WriteLine("moved left");
                }
                while (x > node.data)
                {
                    node = node.rightChild;
                    Console.WriteLine("moved right");
                }
            }
            if (node == null)
            {
                Console.WriteLine(x + " was not found in the tree");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.WriteLine(x + " was found in the tree");
                Console.ReadLine();
                return true;
            }
        }
    }
}
