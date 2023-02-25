using System;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Option Given Below: \n 1.Add SimpleLinkedList \n 2.Create LinkedList By AddingElements" +
                    "\n 3.Append \n 4.Insert Element");
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
                    default:
                        Console.WriteLine("Please enter right option");
                        break;
                }
            }
        }
    }
}
