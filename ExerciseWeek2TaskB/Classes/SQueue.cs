using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Murtatha Hussein
// MMU ID: 21432516
namespace ExerciseWeek2TaskB.Classes
{
    internal class SQueue
    {
        private readonly int maxsizeQueue = 20;
        private string[] saveQueue;
        private int head = 0; // will strat from 0 
        private int tail = 0;// nothing have been saved queue is empty 
        private int numOfCust; 

        public SQueue()
        {
            saveQueue = new string[maxsizeQueue];
        }

        public SQueue(int size)
        {
            maxsizeQueue = size;
            saveQueue = new string[maxsizeQueue];
        }
        // max size of queue 
        // save queue will hold out the queue data 
        public void Enqueue(string value)
        {
            /*check if customer in queue are equal to max queue
            if yes means queue is full
            if no means add customer to the queue
             */
            if (numOfCust != maxsizeQueue)   
            {
                numOfCust++;
                saveQueue[tail++] = value;
                /*if (tail == maxsizeQueue)
                {
                we trying to save element in save array and if conditon does it will count number of customer 
                
                    tail = 0;
                }  */
            }
        }

        public string Dequeue()
        {
            numOfCust--;
            string dequeueValue = saveQueue[head++];
            /*if (head == maxsizeQueue)
            {
                head = 0;
            cheking number of items or cutsomer and increase head value by 1 

            }
            */
            return dequeueValue;
        }

        public string peek()
        {
            return saveQueue[head];
        }

        public bool IsEmpty()
        {
            return numOfCust == 0;
        }

        public bool IsFull()
        {
            return numOfCust == maxsizeQueue;
        }

        public int countQueue()
        {
            return numOfCust;
        }

        public string[] queueData()
        {
            string[] data = new string[maxsizeQueue];
            for (int i = 0; i < countQueue(); i++)
            {
                data[i] = saveQueue[head];
            }
            return data;
            // we are reading data and storing them in string array looping will read queu data, transfering data from array to another array 
            // second array is used for display purpose 
        }

    }
}
