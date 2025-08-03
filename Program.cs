using System;

class Program
{
    static void Main(string[] args)
    {
        // ===== Inheritance =====
        Console.WriteLine("== Inheritance and Method Overriding ==");
        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();
        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.WriteLine();

        // ===== Abstract Classes =====
        Console.WriteLine("== Abstract Classes and Methods ==");
        Shape circle = new Circle(3.5);
        Shape rectangle = new Rectangle(4, 5);
        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}");

        Console.WriteLine();

        // ===== Interfaces =====
        Console.WriteLine("== Interfaces ==");
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();
        car.Move();
        bicycle.Move();
    }
}
