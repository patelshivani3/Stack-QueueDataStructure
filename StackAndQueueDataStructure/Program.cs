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
            Console.WriteLine("\n1:Create stack \n2.Peek and Pop from Stack");        
            int option = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
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

                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
