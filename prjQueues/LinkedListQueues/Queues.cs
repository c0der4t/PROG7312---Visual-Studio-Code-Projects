namespace LinkedListQueues
{

    class Queues
    {
        public QNode front, rear;

        public Queues()
        {
            front = rear = null;
        }


        // We generate a new Qnode
        // If there are no nodes in the queue, we set the first and rear
        // node to the new node
        // subsequent sets will add the new node to the end of the queue and set the
        // rear position entry to that new node. However, we tell the previous last
        // node about the new last node first
        public void enqueue(int key)
        {
            QNode temp = new QNode(key);

            if (rear == null)
            {
                front = rear = temp;
                return;
            }

            rear.next = temp;
            rear = temp;
        }

        public void dequeue()
        {
            if (front == null)
            {
                return;
            }

            front = front.next;

            if (front == null)
            {
                rear = null;
            }
        }
    }
}