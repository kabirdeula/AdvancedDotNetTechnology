class Program
{
    public static void Main(string[] args)
    {
        FileStream fileInput = new FileStream("C:\\Users\\kabir\\test.txt", FileMode.OpenOrCreate);
        fileInput.WriteByte(12);
        fileInput.WriteByte(6);
        fileInput.WriteByte(30);
        fileInput.Close();

        FileStream fileOutput = new FileStream("C:\\Users\\kabir\\test.txt", FileMode.OpenOrCreate);
        int i = 0;
        Console.WriteLine("The contents of File are: ");
        while ((i = fileOutput.ReadByte()) != -1)
        {
            Console.WriteLine(i);
        }
        fileOutput.Close();
    }
}