class Program
{
    public static void Main(string[] args)
    {
        string filePath = "example.txt";

        // Writing to a file using FileStream
        FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate);
        string contentToWrite = "Hello, World!";
        byte[] bytesToWrite = System.Text.Encoding.UTF8.GetBytes(contentToWrite);
        fsWrite.Write(bytesToWrite, 0, bytesToWrite.Length);
        fsWrite.Close();

        // Reading from a file using FileStream
        FileStream fsRead = new FileStream(filePath, FileMode.Open);
        byte[] bytesToRead = new byte[1024];
        int bytesRead = fsRead.Read(bytesToRead, 0, bytesToRead.Length);
        string contentToRead = System.Text.Encoding.UTF8.GetString(bytesToRead, 0, bytesRead);
        Console.WriteLine("Content Read from File: " + contentToRead);
        fsRead.Close();
    }
}
