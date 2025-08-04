namespace prjPriorityLinkedListQueue
{
    class Queues
    {
        public QPNode node = new QPNode();
        public QPNode newNode(int iData, int irATTING)
        {
            QPNode temp = new QPNode();
            temp.data = iData;
            temp.rATING = irATTING;
            temp.next = null;
            return temp;
        }

        public int peek(QPNode head)
        {
            return head.data;
        }

        public QPNode pop(QPNode head)
        {
            return head.next;
        }

        public QPNode push(QPNode head, int iData, int irATTING)
        {
            QPNode start = head;
            QPNode temp = newNode(iData, irATTING);
            if (head.rATING < irATTING)
            {
                temp.next = head;
                head = temp;
            }
            else
            {
                while (start.next != null && start.next.rATING > irATTING)
                {
                    start = start.next;
                }
                temp.next = start.next;
                start.next = temp;
            }

            return head;
        }

        public int isEmpty(QPNode head)
        {
            return head == null ? 1 : 0;
        }
   
    }
}