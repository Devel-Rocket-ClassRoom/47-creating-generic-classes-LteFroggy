using System;

SimpleQueue<int> queInt = new SimpleQueue<int>(3);
queInt.Enqueue(10);
queInt.Enqueue(20);
queInt.Enqueue(30);
Console.WriteLine($"=== int 큐 (용량 : 3) ===");
Console.WriteLine($"Enqueue : 10, 20, 30");
Console.WriteLine($"Count : {queInt.Count}, IsFull : {queInt.IsFull}");
queInt.Enqueue(40);
Console.WriteLine($"Peak : {queInt.Peek()}");
Console.WriteLine($"Dequeue : {queInt.Dequeue()}");
Console.WriteLine($"Dequeue : {queInt.Dequeue()}");
Console.WriteLine($"Count : {queInt.Count}, IsFull : {queInt.IsFull}");
Console.WriteLine();

SimpleQueue<string> queStr = new SimpleQueue<string>(2);
queStr.Enqueue("Hello");
queStr.Enqueue("World");
Console.WriteLine($"=== string 큐 (용량 : 2)");
Console.WriteLine($"Enqueue : Hello, World");
Console.WriteLine($"Dequeue : {queStr.Dequeue()}");
Console.WriteLine($"Dequeue : {queStr.Dequeue()}");
Console.WriteLine($"Dequeue : {queStr.Dequeue()}");
Console.WriteLine($"IsEmpty : {queStr.IsEmpty}");
Console.WriteLine();

