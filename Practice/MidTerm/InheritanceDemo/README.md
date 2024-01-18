# Inheritance in C# - Animal Hierarchy

This C# program demonstrates different types of inheritance within an animal hierarchy. The program defines classes representing various animals, showcasing examples of single, multi-level, and hierarchical inheritance.

## Classes and Inheritance Types

### Single Inheritance
- **Animal**: Base class representing a generic animal. It has a method `Eat` to display eating behavior.

#### Derived Class
- **Dog**: Inherits from `Animal` and adds a method `Bark` to represent dog-specific behavior.

### Multi-level Inheritance
- **Reptile**: Inherits from `Animal` and adds a method `Crawl` to represent reptile-specific behavior.

#### Derived Class
- **Snake**: Inherits from `Reptile` and adds a method `Slither` to represent snake-specific behavior.

### Hierarchical Inheritance
- **Bird**: Inherits from `Animal` and adds a method `Fly` to represent bird-specific behavior.

#### Derived Classes
- **Eagle**: Inherits from `Bird` and adds a method `Hunt` to represent eagle-specific behavior.
- **Penguin**: Inherits from `Bird` and adds a method `Swim` to represent penguin-specific behavior.

## Program Execution
1. **Single Inheritance Example**
    - Creates an instance of `Dog`.
    - Demonstrates the `Eat` method inherited from the base class and the `Bark` method specific to the `Dog` class.

2. **Multi-level Inheritance Example**
    - Creates an instance of `Snake`.
    - Demonstrates the `Eat` method inherited from the base class, the `Crawl` method inherited from the `Reptile` class, and the `Slither` method specific to the `Snake` class.

3. **Hierarchical Inheritance Examples**
    - Creates instances of `Eagle` and `Penguin`.
    - Demonstrates the `Eat` method inherited from the base class, the `Fly` method inherited from the `Bird` class, and the `Hunt` method specific to the `Eagle` class.
    - Demonstrates the `Swim` method specific to the `Penguin` class.

## Usage
```bash
dotnet run
```

## Source Code

```csharp
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
```

## Output

```bash
Dog is eating.
Dog is barking.
--------------------------------------------------
Snake is eating.
Snake is crawling.
Snake is slithering.
--------------------------------------------------
Eagle is flying.
Eagle is hunting.
Eagle is eating.
--------------------------------------------------
Penguin is flying.
Penguin is swimming.
Penguin is eating.
--------------------------------------------------
```

Feel free to explore and modify the program for your understanding or integration into larger projects. The source code is well-commented to explain each inheritance example.