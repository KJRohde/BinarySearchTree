using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree testTree = new BinarySearchTree();

            testTree.Add(100);
            testTree.Add(42);
            testTree.Add(115);
            testTree.Add(27);
            testTree.Add(65);
            testTree.Add(87);
            testTree.Add(131);
            testTree.Add(121);
            testTree.Add(75);

            testTree.SearchTree(69);
        }
    }
}
