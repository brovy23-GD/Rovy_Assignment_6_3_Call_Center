namespace Rovy_Assignment_6._3_Call_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the CallQueue
            CallQueue callQueue = new CallQueue();
            Console.WriteLine("---Call Center Simulation ---");

            // Simulate adding callers to the queue
            Console.WriteLine("Adding callers to the queue...");
            callQueue.Enqueue("Bobby");// Caller 1
            callQueue.Enqueue("Allie");// Caller 2
            callQueue.Enqueue("Aubrey");// Caller 3
            callQueue.Enqueue("Brooke");// Caller 4

            Console.WriteLine(0);// Display the number of callers in the queue
            callQueue.DisplayQueue();// Display the current queue

            Console.WriteLine($"\nNext caller to be taken: {callQueue.Peek()}");// Display the next caller to be taken

            Console.WriteLine($"\nServing the next caller: {callQueue.Dequeue()}");// Serve the next caller and display their name
            Console.WriteLine($"Served: {callQueue.Dequeue()}");// Serve the next caller and display their name
            Console.WriteLine($"Served: {callQueue.Dequeue()}");// Serve the next caller and display their name

            Console.WriteLine();// Display the number of callers in the queue after serving some callers
            callQueue.DisplayQueue();// Display the current queue after serving some callers

            if (callQueue.IsEmpty()) // Check if the queue is empty and display a message
            {
                // If the queue is empty, display a message
                Console.WriteLine("\nNext caller to be taken will be: {callQueue.Peek()}");

            }
            Console.WriteLine("\nNo more callers in the queue. All callers have been served.");// Display a message indicating that all callers have been served
            Console.WriteLine("\nEnd of Call Center Simulation.");// Display a message indicating the end of the simulation

            Console.WriteLine("\nPress ENTER to exit ...");// Prompt the user to press ENTER to exit
            Console.ReadLine();// Wait for the user to press ENTER before closing the console






        }
    }
}
