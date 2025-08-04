Queue<string> numbers = new Queue<string>();
numbers.Enqueue("One");
numbers.Enqueue("Two");
numbers.Enqueue("Three");
numbers.Enqueue("Four");
numbers.Enqueue("Five");


foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}

System.Console.WriteLine("Count: " + numbers.Count);

// Dequeue the first item
string firstItem = numbers.Dequeue();
System.Console.WriteLine("Dequeued: " + firstItem);

// Peek allows us to look at how is next in the queue
string nextItem = numbers.Peek();
System.Console.WriteLine("Next item to dequeue: " + nextItem);

System.Console.WriteLine($"Was four found in the queue? {numbers.Contains("Four")}");

numbers.Clear();