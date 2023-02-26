using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Problems");
            LinkedList linkedList = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option Given Below: \n 1.Add SimpleLinkedList \n 2.Create LinkedList By AddingElements" +
                    "\n 3.Append \n 4.Insert Element \n 5.Delete the node \n 6. Delete Last Node \n 7.Search Node \n 8.Create Stack");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Append(56);
                        linkedList.Append(30);
                        linkedList.Append(70);
                        linkedList.Display1();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertNode(30, 56);
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.Display();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveAtLast();
                        linkedList.Display();
                        break;
                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Search(30);
                        break;
                    case 8:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    default:
                        Console.WriteLine("Please Enter Right option");
                        break;
                }
            }
        }
    }
}
