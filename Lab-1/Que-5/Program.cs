// Single Inheritance

// using System;

// // Base class
// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating.");
//     }
// }

// // Derived class inheriting from Animal
// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking.");
//     }
// }

// class Sonish
// {
//     static void Main(string[] args)
//     {
//         Dog dog = new Dog();
//         dog.Eat(); 
//         dog.Bark(); 
//     }
// }


// Multilevel Inheritance

// using System;


// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("Animal is eating.");
//     }
// }


// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("Dog is barking.");
//     }
// }


// class Labrador : Dog
// {
//     public void Play()
//     {
//         Console.WriteLine("Labrador is playing.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Labrador dog = new Labrador();
//         dog.Eat();
//         dog.Bark();
//         dog.Play();
//     }
// }


//Hierarchical inheritance
using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

// Derived class 1 inheriting from Animal
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Derived class 2 inheriting from Animal
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Eat();
        dog.Bark();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();
    }
}
