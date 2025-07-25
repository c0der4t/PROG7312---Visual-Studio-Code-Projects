using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDoubleLinkedList
{
     class Blob
    {
        public Node Head;
        public void Add(int number)
        {
            if(number == null)
            {
                return;
            }
            else if (Head == null)
            {
                Head = new Node(number);
                return;
            }
            else
            {
                Node n = new Node(number); 
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                n.previous = current;
                current.next = n;
            }
        }
    }
}
