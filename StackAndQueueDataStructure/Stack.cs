using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class Stack
    {
        public Node top;
        public Stack()
        {
            this.top = null;
        }
        public  void Push(int newData)  //Push the data in stack
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("Node {0} pushed to stack", newData);
        }
        public  void Display()    //Display the data of stack
        {
            Node temp = this.top;

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
