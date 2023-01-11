using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Stack And Queue Data Structure ");
            Console.WriteLine("\n1:Create stack \n2.Peek and Pop from Stack\n3.Create Queue ");        
            int option = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            Queue queue = new Queue();
            switch (option)        
            {
                case 1://UC1 Create stack
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    Console.WriteLine("-------------------------------------");
                    stack.Display();
                    break;

                case 2://UC2 Peek and Pop stack
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    Console.WriteLine("-------------------------------------");
                    stack.IsEmpty();
                    break;

                case 3://UC3 Create Queue
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    Console.WriteLine("-------------------------------------");
                    queue.Display();
                    break;

                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
