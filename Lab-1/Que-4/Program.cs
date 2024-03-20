


// In C#, an indexer is a special type of property that allows 
// instances of a class or struct to be indexed as if they were arrays. Indexers enable objects to be accessed using array syntax, 
// providing a more intuitive and convenient way to work with collections of data.

using System;

class Anime
{
    private string[] names = new string[10];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Anime anime = new Anime();
        anime[0] = "Naruto";
        anime[1] = "One Piece";
        anime[2] = "Death Note";
        anime[3] = "Solo Leveling";
        anime[4] = "Vinland saga";
        anime[4] = "AOT";

        Console.WriteLine("Anime 2: " + anime[2]);
        Console.WriteLine("Anime 3: " + anime[3]);
        Console.WriteLine("Anime 4: " + anime[4]);
        Console.WriteLine("Anime 7: " + anime[7]);
    
}
}