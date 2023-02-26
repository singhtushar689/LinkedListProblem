using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted in the Linkedlist", node.data);
        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine("{0} is added into linked list", newNode.data);
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            Console.WriteLine("LinkedList is: ");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        public void Append(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is added into linked list", newNode.data);
            }
        }
        public void Display1()
        {
            Console.WriteLine("\nDisplaying all nodes");
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void InsertNode(int data, int afterNum)
        {
            Node node = new Node(data);
            Node temp = head;
            while (temp.data != afterNum)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
            Console.WriteLine("Node {0} inserted after {1}.", data, afterNum);
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            this.head = this.head.next;
            Console.WriteLine("First element is deleted successfully");
        }
        public void RemoveAtLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                Node lastNode = this.head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("The last node is deleted successfully");
            }
        }
        public void Search(int searchData)
        {
            int count = 0;
            Node tempNode = this.head;
            if (tempNode == null)
                Console.WriteLine("Linke list is empty");
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.data.Equals(searchData))
                    {
                        count++;
                    }
                    tempNode = tempNode.next;
                }
            }
            if (count > 0)
                Console.WriteLine(searchData + " data found " + count + ": time ");
            else
                Console.WriteLine(" Data not found");
        }

    }
}
