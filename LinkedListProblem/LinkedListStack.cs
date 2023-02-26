using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class LinkedListStack
    {
        public Node top;
        LinkedList linkedList = new LinkedList();
        public LinkedListStack()
        {
            this.top = null;
        }

        public void Peek(int data)
        {
            Node node = new Node(data);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine(data);
        }

        public void Display()
        {
            Node temp = this.top;
            Console.Write("stack is ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, deleting is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
            Console.WriteLine("The stack is empty");
        }
    }
}
