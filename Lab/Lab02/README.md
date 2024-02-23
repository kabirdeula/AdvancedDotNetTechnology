# Multithreading and Thread Synchronization Example

## Description
This C# program demonstrates multithreading and thread synchronization using the `Monitor` class for synchronization. It creates two threads, each printing numbers from 1 to 5. Access to the shared method `PrintNumbers` is synchronized using a lock to ensure thread safety.

## Instructions
1. Run the program.
2. Two threads, "Thread 1" and "Thread 2", will be started.
3. Each thread will print numbers from 1 to 5, with their respective thread names prefixed to each number.

## Usage
```bash
dotnet run
```

## Source Code
```csharp
using System;
using System.Threading;

class Program
{
    static object lockObject = new object();

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers);

        thread1.Start("Thread 1");
        thread2.Start("Thread 2");
    }

    static void PrintNumbers(object threadName)
    {
        lock (lockObject)
        {
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{threadName}: {i}");

                Thread.Sleep(100);
            }
        }
    }
}
```

## Example Output
```bash
Thread 1: 1
Thread 1: 2
Thread 1: 3
Thread 1: 4
Thread 1: 5
Thread 2: 1
Thread 2: 2
Thread 2: 3
Thread 2: 4
Thread 2: 5
```

Each thread prints its name followed by numbers from 1 to 5. Access to the `PrintNumbers` method is synchronized using a lock, ensuring that only one thread executes the method at a time, preventing interleaved output.