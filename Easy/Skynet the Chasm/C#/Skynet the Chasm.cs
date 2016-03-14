using System;

class Player
{
    static void Main()
    {
        int road        = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap         = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform    = int.Parse(Console.ReadLine()); // the length of the landing platform.

        while (true)
        {
            int speed       = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int position    = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            Console.WriteLine(
                position > road || speed > gap + 1 ? "SLOW" : 
                speed < gap + 1 ? "SPEED" : 
                position == road - 1 ? "JUMP" : "WAIT");
        }
    }
}