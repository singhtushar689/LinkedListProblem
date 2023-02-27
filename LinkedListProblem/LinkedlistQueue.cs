using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedlistQueue
    {
        //public Node front;
        public Node head;
        public Node tail;
        public LinkedlistQueue()
        {
            this.head = null;
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if(tail == null)
            {
                tail = node;
                head = node;
            }
            else
            {
                node.next = tail;
                tail = node;
            }
            Console.WriteLine($"{data} is added in the queue");
        }
        public void Dequeue()
        {
            if(tail == null)
            {
                if(tail.next  == null)
                {
                    tail = null;
                }
                else
                {
                    Node temp = tail;
                    while(temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                    head = temp;
                }
            }
            Display();
        }
        public void Display()
        {
            if (tail != null)
            {
                Node temp = tail;
                Console.WriteLine("\n The Queue: ");
                while (temp != null)
                {
                    Console.WriteLine($"{temp.data}");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Queue Is Empty");
            }
            Console.WriteLine( );
        }
    }
}
