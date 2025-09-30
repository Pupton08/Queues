// Skeleton program for Queue class
using System;
class Program
{
    static void Main()
        static void Main(string[] args)
        {
            // declare an empty queue of size 10
            Queue testQueue = new Queue(10);

            // declare variables for user responses
            int response;
            int value;

            // main loop

            do
            {
                // show menu and (crudely) validate response
                do
                {
                    testQueue.Display();
                    Console.WriteLine("1: Add item");
                    Console.WriteLine("2: Remove item");
                    Console.WriteLine("0: Quit");
                    response = Convert.ToInt32(Console.ReadLine());
                } while (response < 0 || response > 2);

                // call appropriate queue methods based on response
                if (response == 1)
                {
                    Console.WriteLine("Enter an integer value to add: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    testQueue.Enqueue(value);
                }
                else if (response == 2)
                {
                    value = testQueue.Dequeue();
                    Console.WriteLine("Removed {0} from queue.", value);
                }
            }
            // finish if 0 is chosen
            while (response != 0);
        } // end Main


    } // end Program class

    public class Queue     
    {
        // attributes
        // maxSize;
        // numItems;
        // front;
        // rear;
        // array queueContents;

        // constructor (one argument)
        public Queue(int size)
        {
    
        }

        // method to add to queue
        public void Enqueue(int item)
        {

        }

        // method to remove from queue
        public int Dequeue()
        {

        }

        // method to check if queue is full
        private bool IsFull()
        {

        }

        // method to check if queue is empty
        private bool IsEmpty()
        {

        }

        public void Display()
        {

        }
    }
}

