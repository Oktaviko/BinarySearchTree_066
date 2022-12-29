using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_066
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;
        //Constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*A node class consist of three things, the information, reference to the right child, and refferences to the left child */
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Initializing ROOT to null*/
        }
        public void insert(string element)/*Insert a Node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null)/*Check if the Node to be inserted already inserted or not*/
            {
                Console.WriteLine(currentNode"Duplicate words not allowed");
                return;
            }
            else /*If the specified node is not present*/
            {
                tmp = new Node(element, null, null);/*Creates a Node*/
                if (parent == null) /*If the trees is empty*/
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent. leftchild = tmp
                }   
                else
                {
                    parent.rightchild = tmp;
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
