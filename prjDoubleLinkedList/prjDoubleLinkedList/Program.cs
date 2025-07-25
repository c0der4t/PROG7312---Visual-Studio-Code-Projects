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
            Console.WriteLine("Head node value: "+Head.Value);
            Console.WriteLine("Next node value: " +newNode.Value);
            Console.WriteLine("Total nodes: " +CountNode(Head));

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

        }

        public static Node GetFirst(Node middle)
        {
           
        }

        public static void FindNodePrintAll(Node current)
        {
            //find inside the list and indicate that spot and show whole list
        }
    }
}
