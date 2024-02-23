class Program
{
    static object lockObject = new object();

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(PrintNumbers!);
        Thread thread2 = new Thread(PrintNumbers!);

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