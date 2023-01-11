using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class Queue
    {
        public Node head;
        public void Enqueue(int item)           //Creating enqueue method 
        {
            Node new_node = new Node(item);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new_node;
            }
            Console.WriteLine("{0} is Enqueue into Queue", new_node.data);
        }
        public void Dequeue()           //Creating Dequeue
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            Console.WriteLine("Dequeue value : {0}", this.head.data);
            this.head = this.head.next;
        }
        public void IsEmpty()
        {
            while (this.head != null)
            {
                Dequeue();
            }
        }
        public void Display()           //Creating display method
        {
            Node temp = this.head;

            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
