using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public Node leftChild;
        public int data;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
        }
       
        public int Search(Node node, int n)
        {
            if (node == null)
            {
                return 0;
            }
            else if (node.data == n)
            {
                return n;
            }
            else if (node.data < n)
            {
                return Search(node.rightChild, n);
            }
            else if (node.data > n)
            {
                return Search(node.leftChild, n);
            }
            else
            {
                return 0;
            }
        }
        public void Display(Node n)
        {
            if (n == null)
                return;

            Display(n.leftChild);
            Console.WriteLine(" " + n.data);
            Display(n.rightChild);
        }
    }
}
