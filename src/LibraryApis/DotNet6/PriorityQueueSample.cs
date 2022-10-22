// The sample is adopted from: https://code-maze.com/csharp-priority-queue/
namespace LibraryApis.DotNet6;

public static class PriorityQueueSample
{
    public static void Run()
    {
        var messages = new List<(string, int)>
        {
            ("Message 1", 3),
            ("Message 2", 1),
            ("Message 3", 2),
            ("Message 4", 2),
            ("Message 5", 3)
        };

        var queue = new PriorityQueue<string, int>(messages);
        Console.WriteLine($"    Queue capacity: {queue.Count}");

        queue.EnsureCapacity(10);
        queue.Enqueue("Message 6", 1);

        var dequeuedMessage = queue.EnqueueDequeue("Message 7", 2);
        Console.WriteLine($"    Adding new message caused a dequeue of {dequeuedMessage}");

        Console.WriteLine("    Dequeuing:");
        while (queue.Count > 0)
        {
            Console.WriteLine($"      - {queue.Dequeue()}");
        }
    }
}
