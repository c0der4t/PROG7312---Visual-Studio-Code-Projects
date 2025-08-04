namespace prjPriorityQueue {

    public class queue
    {

        public item[] pr = new item[1000000];
        public int size = -1;

        public void enqueue(int value, int priority)
        {
            size++;
            pr[size] = new item
            {
                value = value,
                priority = priority
            };
            
        }

        public int peek()
        {
            int HighestPriority = int.MinValue;
            int iPos = -1;

            for (int i = 0; i <= size; i++)
            {
                if (HighestPriority == pr[i].priority && iPos > -1 && pr[iPos].value < pr[i].value)
                {
                    HighestPriority = pr[i].priority;
                    iPos = i;
                }
                else if (HighestPriority < pr[i].priority)
                {
                    HighestPriority = pr[i].priority;
                    iPos = i;
                }
            }
            return iPos;
        }

        public void dequeue() {
            int iPost = peek();
            for (int i = 0; i < size; i++)
            {
                pr[i] = pr[i + 1];
            }
            size--;
        }
    }
}

