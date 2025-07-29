using System.Text;

namespace prjDoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blob blobGen = new Blob();
            blobGen.Add(6);
            blobGen.Add(5);
            blobGen.Add(4);
            blobGen.Add(3);
            blobGen.Add(2);
            blobGen.Add(1);
            blobGen.Add(0);
            Node Head = blobGen.Head;
            Node newNode = Head.next.next.next.next; // Get the 4th node 
            Console.WriteLine("Head node value: " + Head.Value);
            Console.WriteLine("Next node value: " + newNode.Value);
            Console.WriteLine("Total nodes: " + CountNode(Head));
            Console.WriteLine("The previous Node: " + Getlast(Head).Value);
            Console.WriteLine("The first node = " + GetFirst(newNode).Value);
            Console.WriteLine("The size of the list is {0}", CountNode(Head));
            FindNodePrintAll(newNode);

        }

        public static int CountNode(Node Head)
        {
            int count = 1;
            Node Current = Head;
            while (Current.next != null)
            {
                Current = Current.next;
                count++;
            }
            return count;
        }

        //methods for hw
        //1. get last method
        //2. GetFirst method
        //3. FindNodePrintAll method

        public static Node Getlast(Node Head)
        {
            Node last = Head;
            while (last.next != null)
            {
                last = last.next;
            }
            return last; //returns the last node and add .Value to show the value
        }


        public static Node GetFirst(Node middle)
        {
            // Start from the given node, assumed to be somewhere in the middle of the list
            Node first = middle;

            // Go backwards through the list until reaching the first node (which has no previous)
            while (first.previous != null)
            {
                first = first.previous; // Move to the previous node
            }
            // Return the head node
            return first;
        }



        public static void FindNodePrintAll(Node current)
        {
            //find inside the list and indicate that spot and show whole list
            if (current == null)
            {
                if (current == null)
                {
                    Console.WriteLine("Number {0} not found in the list",
                        current.Value);
                    return;
                }
                StringBuilder result = new StringBuilder("(" +
                    current.Value + ")");
                Node NodeP = current.previous;
                while (NodeP != null)
                {
                    result.Insert(0, NodeP.Value + " ");
                    NodeP = NodeP.previous;
                }

                current = current.next;
                while (current != null)
                {
                    result.Append(" " + current.Value);
                    current = current.next;
                }
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}
