class Animal
{
    // Single inheritance
    public void Eat(string animal)
    {
        Console.WriteLine($"{animal} is eating.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Multi level inheritance
class Reptile : Animal
{
    public void Crawl(string reptile)
    {
        Console.WriteLine($"{reptile} is crawling.");
    }
}

class Snake : Reptile
{
    public void Slither()
    {
        Console.WriteLine("Snake is slithering.");
    }
}

// Hierarchial inheritance
class Bird : Animal
{
    public void Fly(string bird)
    {
        Console.WriteLine($"{bird} is flying.");
    }
}

class Eagle : Bird
{
    public void Hunt()
    {
        Console.WriteLine("Eagle is hunting.");
    }
}

class Penguin : Bird
{
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Single inheritance
        Dog dog = new();
        dog.Eat("Dog");
        dog.Bark();
        Console.WriteLine("--------------------------------------------------");

        // Multi level inheritance
        Snake snake = new();
        snake.Eat("Snake");
        snake.Crawl("Snake");
        snake.Slither();
        Console.WriteLine("--------------------------------------------------");

        // Hierarchial inheritance
        Eagle eagle = new();
        eagle.Fly("Eagle");
        eagle.Hunt();
        eagle.Eat("Eagle");
        Console.WriteLine("--------------------------------------------------");
        Penguin penguin = new();
        penguin.Fly("Penguin");
        penguin.Swim();
        penguin.Eat("Penguin");
        Console.WriteLine("--------------------------------------------------");

    }
}
