System.Collections.Queue BCADQue = new System.Collections.Queue();

BCADQue.Enqueue("Ali");
BCADQue.Enqueue("Jess");
BCADQue.Enqueue("Chris");

System.Console.WriteLine("Queue Count: " + BCADQue.Count);

System.Console.WriteLine("Values:");
PrintValues(BCADQue);
BCADQue.Enqueue("Ali");
PrintValues(BCADQue);

BCADQue.Dequeue();

// Dequeue pulls the first in first out person that's next to be removed
System.Console.WriteLine(BCADQue.Dequeue().ToString());
PrintValues(BCADQue);

void PrintValues(System.Collections.Queue que)
{
    foreach (var item in que)
    {
        System.Console.WriteLine(item);
    }
}