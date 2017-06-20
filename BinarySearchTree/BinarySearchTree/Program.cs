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
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.Add(12);
            newTree.Add(45);
            newTree.Add(34);
            newTree.Add(23);
            newTree.Add(3);
            newTree.Add(14);
            newTree.Add(27);
            newTree.Add(65);

            newTree.Search(65);
            newTree.Display();

        }
    }
}
