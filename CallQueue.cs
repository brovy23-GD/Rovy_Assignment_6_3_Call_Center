using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Rovy_Assignment_6._3_Call_Center
{
    internal class CallQueue
    {
        private Node front; //Head of the queue
        private Node rear; //Tail of the queue
        private int count; // Number of callers in the queue

        public CallQueue() // Constructor to initialize the call queue
        {
            front = null; // Initialize front to null
            rear = null; // Initialize rear to null
            count = 0; // Initialize count to 0
        }
        public bool IsEmpty() // Method to check if the queue is empty
        {
            return count == 0; // Return true if count is 0, indicating the queue is empty
        }
        //
        public void Enqueue(string callerName)
        {
            var newNode = new Node(callerName); // Create a new node with the caller's name
            if (IsEmpty())
            {
                front = newNode; // If the queue is empty, set both front and rear to the new node
                rear = newNode; // Set rear to the new node

            }
            else
            {
                rear.Next = newNode;// Link the current rear node to the new node
                rear = newNode; // Update rear to the new node

            }
            count++; //Increase the count of callers in the queue

        }
        public string Dequeue()// Method to remove and return caller from front of queue
        {
            if (IsEmpty())
            {

                throw new InvalidOperationException("Queue is empty!"); // Throw an exception if the queue is empty
            }
            var frontNode = front; // Store the current front node
            var caller = frontNode.CallerName; // Get the caller's name from the front node

            front = front.Next; // Move the front pointer to the next node
            count--; // Decrease the count of callers in the queue

            if(IsEmpty())
            {
                rear = null; // If the queue is now empty, set rear to null
            }
            return caller; // Return the caller's name that was dequeued
        }
        public string Peek() // Method to return the caller at the front of the queue without removing them
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty!"); // Throw an exception if the queue is empty
            }
            return front.CallerName; // Return the caller's name at the front of the queue
        }
        public void DisplayQueue() // Method to display the current callers in the queue
        {
            if (IsEmpty())
            {
                Console.WriteLine("The call queue is empty!"); // Display a message if the queue is empty
                return;
            }
            var current = front; // Start from the front of the queue
            Console.WriteLine("Current Call Queue:"); // Display a header for the call queue
            while (current != null) // go through the queue until the end
            {
                Console.WriteLine($"- {current.CallerName}"); // Display each caller's name in the queue
                current = current.Next; // Move to the next node in the queue
            }

        }
        
    }

}
