using System;
using System.Collections.Generic;
using System.Text;

namespace Rovy_Assignment_6._3_Call_Center
{
    internal class Node // This class represents a node in the linked list for the call queue
    {
        public String CallerName;// The name of the caller in the call queue
        public Node Next;// Reference to the next node in the linked list
        //
        public Node(string callerName)// Constructor to initialize the node with the caller's name
        {
            CallerName = callerName;// Initialize the caller's name
            Next = null; // Initialize next reference to null
        }
    }
}
