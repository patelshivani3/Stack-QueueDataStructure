using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueDataStructure
{
    internal class Node
    {
        public int data;        
        public Node next;
        public Node(int data)       //Creating Parameterized constructor
        {
            this.data = data;
            this.next = null;
        }
    }
}
