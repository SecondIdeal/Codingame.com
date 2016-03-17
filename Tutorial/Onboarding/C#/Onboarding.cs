using System;

class Player
{
    static void Main()
    {
        while (true)
        {
            string enemy1Name   = Console.ReadLine();
            int enemy1Distance  = int.Parse(Console.ReadLine());
            string enemy2Name   = Console.ReadLine();
            int enemy2Distance  = int.Parse(Console.ReadLine()); 

            Console.WriteLine((enemy1Distance < enemy2Distance) ? enemy1Name : enemy2Name);
        }
    }
}