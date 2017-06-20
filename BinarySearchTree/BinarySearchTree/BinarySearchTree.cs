using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private Node root;
        public int count { get; private set; }

        public BinarySearchTree()
        {
            root = null;
            count = 0;
        }
        
        public bool DefineEmptyRoot()
        {
            return root == null;
        }
        public void Add(int n)
        {
            if (DefineEmptyRoot())
            {
                root = new Node(n);
                count++;
            }
            else if (root.rightChild == null && root.rightChild == null)
            {
                Node nextRoot = new Node(n);
                AddData(root, n);
            }
            else if (root.rightChild != null)
            {
                Node nextRoot = root.rightChild;
                AddData(nextRoot, n);
            }
            else if (root.leftChild != null)
            {
                Node nextRoot = root.leftChild;
                AddData(nextRoot, n);
            }
            else
            {
                if (n > root.leftChild.data && n < root.rightChild.data)
                {
                    AddData(root.leftChild.rightChild, n);
                }
                if (n > root.leftChild.data && n > root.rightChild.data)
                {
                    AddData(root.rightChild.rightChild, n);
                }
                if (n < root.leftChild.data)
                {
                    AddData(root.leftChild.rightChild, n);
                }
                else if (n > root.rightChild.data)
                {
                    AddData(root.rightChild.rightChild, n);
                }
                else
                {
                    Console.WriteLine("Cannot add the same value twice.");
                }
            }


        }
        public Node AddData(Node node, int data)
        {
            if (node == null)
            {
                count++;
                return new Node(data);
            }
            else if (node.data < data)
            {
                node.rightChild = new Node(data);
                count++;
                return root;
            }
            else if (node.data > data)
            {
                node.leftChild = new Node(data);
                count++;
                return root;
            }
            else
            {
                Console.WriteLine("Cannot add the same value twice.");
                return node;
            }
        }
        public void Search(int s)
        {
            if (root.Search(root, s) == 0)
            {
                Console.WriteLine("no value");
            }
            else
            {
                Console.WriteLine(root.Search(root, s));
            }
        }
        public void Display()
        {
            if (!DefineEmptyRoot())
            {
                root.Display(root);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("nothing to show");
                Console.ReadLine();
            }
        }
    }
}
