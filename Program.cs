// Skeleton program for Queue class
using System;
class Program
{

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
        private int maxSize;
        private int numItems;
        private int front;
        private int rear;
        private int[] queueContents;

        // constructor (one argument)
        public Queue(int size)
        {
            front = 0;
            rear = -1;
            numItems = 0;
            maxSize = size;
            queueContents = new int[maxSize];
        }

        // method to add to queue
        public void Enqueue(int item)
        {
            if (!IsFull())
            {
                rear = (rear+1)%maxSize;
                queueContents[rear] = item;
                numItems++;
            }
            else
            {
                Console.WriteLine("Queue is full!");
            }
        }

        // method to remove from queue
        public int Dequeue()
        {
            if (!IsEmpty())
            {
                int deQueuedValue = queueContents[front];
                front = (front+1)%maxSize;
                numItems--;
                return deQueuedValue;
            }
            else
            {
                Console.WriteLine("Queue is empty!");
                return 0;
            }
        }

        // method to check if queue is full
        private bool IsFull()
        {
            return numItems == maxSize;
        }

        // method to check if queue is empty
        private bool IsEmpty()
        {
            return numItems == 0;
        }

        public void Display()
        {
            for (int i = 0; i < maxSize; i++)
            {
                Console.Write($"{i}: {queueContents[i]}");
                if (i == front)
                {
                    Console.Write("<-- front");
                }
                if (i == rear)
                {
                    Console.Write("<-- rear");
                }
                Console.WriteLine();
            }
        }
    }