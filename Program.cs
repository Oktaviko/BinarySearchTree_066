﻿using System;
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

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
