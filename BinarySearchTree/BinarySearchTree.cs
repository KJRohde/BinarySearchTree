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
        private Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void CreateTree()
        {
            Console.Write("Please enter number of nodes in the tree");
            int numberNodes = int.Parse(Console.ReadLine());
            if(numberNodes == 0)
            {
                return;
            }
            for (int i = 1; i<= numberNodes; i++)
            {
                Console.WriteLine("Please enter an element to add to the tree");
                int data = int.Parse(Console.ReadLine());
                MakeChild(data);
            }
        }
        public void InsertRoot(int data)
        {
            Node temp = new Node(data);
            temp = root;
        }
       public void MakeChild(int data)
        {
            Node node;
            Node temp = new Node(data);
            node = root;
            while(node.leftChild != null && temp.data <= root.data)
            {
                node = node.leftChild;
            }
            node.leftChild = temp;
            while(node.rightChild != null && temp.data > root.data)
            {
                node = node.rightChild;
            }
            node.rightChild = temp;
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
                }
                while (x > node.data)
                {
                    node = node.rightChild;
                }
            }
            if (node == null)
            {
                Console.WriteLine(x + " was not found in the tree");
                return false;
            }
            else
            {
                Console.WriteLine(x + " was found in the tree");
                return true;
            }
        }
    }
}
