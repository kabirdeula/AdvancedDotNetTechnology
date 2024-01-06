# Lab 02 - FileStream Implementation

## Description
This C# program demonstrates basic file input and output operations using the FileStream class. It writes a string to a file and then reads the content back from the file. The file is created or opened as needed.

## Instructions
1. Run the program.
2. The program will create or open a file named "example.txt" in the current working directory.
3. It writes the string "Hello, World!" to the file using FileStream.
4. It then reads the content from the file using FileStream and displays it on the console.

## Usage
```bash
dotnet run
```

## File Path
The file path is set to "example.txt" by default. You can modify the `filePath` variable to specify a different file path or name.

```csharp
string filePath = "example.txt";
```

## File Writing
The program uses FileStream to write content to the file.

```csharp
FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate);
string contentToWrite = "Hello, World!";
byte[] bytesToWrite = System.Text.Encoding.UTF8.GetBytes(contentToWrite);
fsWrite.Write(bytesToWrite, 0, bytesToWrite.Length);
fsWrite.Close();
```

## File Reading
The program uses FileStream to read content from the file.

```csharp
FileStream fsRead = new FileStream(filePath, FileMode.Open);
byte[] bytesToRead = new byte[1024];
int bytesRead = fsRead.Read(bytesToRead, 0, bytesToRead.Length);
string contentToRead = System.Text.Encoding.UTF8.GetString(bytesToRead, 0, bytesRead);
Console.WriteLine("Content Read from File: " + contentToRead);
fsRead.Close();
```

## Source Code
```csharp
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
```

## Example
```bash
Content Read from File: Hello, World!
```

Feel free to modify the program to suit your specific file I/O needs.