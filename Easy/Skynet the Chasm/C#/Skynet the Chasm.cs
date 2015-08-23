using System;

class Player
{
    static void Main(string[] args)
    {
        int road = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int gap = int.Parse(Console.ReadLine()); // the length of the gap.
        int platform = int.Parse(Console.ReadLine()); // the length of the landing platform.

        bool hasJumped = false;

        while (true)
        {
            int speed = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int position = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            if (hasJumped)
            {
                Console.WriteLine("SLOW");
            }
            else if (position == (road - 1))
            {
                Console.WriteLine("JUMP");
                hasJumped = true;
            }
            else if (speed == (gap + 1))
            {
                Console.WriteLine("WAIT");
            }
            else if (speed > (gap + 1))
            {
                Console.WriteLine("SLOW");
            }
            else
            {
                Console.WriteLine("SPEED");
            }
        }
    }
}