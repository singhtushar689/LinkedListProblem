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
            LinkedList linkedList = new LinkedList();
            Console.WriteLine("Welcome to LinkedList Problems");
            bool flag = true;
            while (flag) 
            {
                Console.WriteLine("Enter Option Given Below: \n 1. Add SimpleLinkedList");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    default:
                        Console.WriteLine("Enter any Valid Option");
                        break;
                }
            }
            


        }
    }
}
