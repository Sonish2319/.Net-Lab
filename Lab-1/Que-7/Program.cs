using System;

// Base class
class Ball_game
{
    // Virtual method
    public virtual void Play()
    {
        Console.WriteLine("Playing a Ball_game.");
    }
}

// Derived class overriding the Play method
class Football : Ball_game
{
    public override void Play()
    {
        Console.WriteLine("Playing a Football.");
    }
}

// Derived class overriding the Play method
class Basketball : Ball_game
{
    public override void Play()
    {
        Console.WriteLine("Playing a Basketball.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of derived classes
        Ball_game Ball_game1 = new Football();
        Ball_game Ball_game2 = new Basketball();

        // Calling the Play method on both instances
        Ball_game1.Play(); // Output: Playing a Football.
        Ball_game2.Play(); // Output: Playing a Basketball.
    }
}
