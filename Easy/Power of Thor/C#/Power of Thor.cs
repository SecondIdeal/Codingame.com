using System;

class Player
{
    static void Main()
    {
        var inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Light X position, Light Y position, Thor X position, Thor Y position
        for (int x = inputs[0] - inputs[2], y = inputs[1] - inputs[3]; ; Console.WriteLine((0 != y ? 0 < y-- ? "S" : "N" : "") + (0 != x ? 0 < x-- ? "E" : "W" : ""))) ;
    }
}