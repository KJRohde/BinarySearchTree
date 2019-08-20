using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        //root node
        private Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void Add(int data)
        {
            Node node = new Node(data);
            if (root == null)
            {
                root = new Node(data);
            }
            else
            {
                Node parent = root;
                while (true)
                {
                    if (node.data <= parent.data)
                    {
                        if (parent.leftChild == null)
                        {
                            parent.leftChild = new Node(data);
                            break;
                        }
                        else
                        {
                            parent = parent.leftChild;
                        }
                    }
                    if (node.data > parent.data)
                    {
                        if (parent.rightChild == null)
                        {
                            parent.rightChild = new Node(data);
                            break;
                        }
                        else
                        {
                            parent = parent.rightChild;
                        }
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
                    Console.WriteLine(x + " was found in the tree");
                    Console.ReadLine();
                    return true;
                }
                else if (x < node.data)
                {
                    node = node.leftChild;
                    Console.WriteLine("moved left");
                }
                else if (x > node.data)
                {
                    node = node.rightChild;
                    Console.WriteLine("moved right");
                }
            }
            Console.WriteLine(x + " was not found in the tree");
            Console.ReadLine();
            return false;
        }
    }
}
