using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position

        while (true)
        {
            string directionX = "";
            if (LX > TX) { TX++; directionX = "E"; } else if (LX < TX) { TX--; directionX = "W"; }

            string directionY = "";
            if (LY > TY) { TY++; directionY = "S"; } else if (LY < TY) { TY--; directionY = "N"; }

            Console.WriteLine((directionY) + (directionX));
        }
    }
}