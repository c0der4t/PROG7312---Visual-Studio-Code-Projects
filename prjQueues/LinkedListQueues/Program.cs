using LinkedListQueues;

Queues q = new Queues();
q.enqueue(10);
q.enqueue(20);
q.enqueue(30);
q.enqueue(40);

q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();
q.dequeue();

System.Console.WriteLine($"Front item is " + (q.front != null ? "empty" : q.front.Key));