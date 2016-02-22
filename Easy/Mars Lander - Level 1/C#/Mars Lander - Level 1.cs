using System;

class Player
{
    static void Main()
    {
        int[] inputs;
        int surfaceN = int.Parse(Console.ReadLine()); // the number of points used to draw the surface of Mars.
        for (int i = 0; i < surfaceN; i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int landX = inputs[0]; // X coordinate of a surface point. (0 to 6999)
            int landY = inputs[1]; // Y coordinate of a surface point. By linking all the points together in a sequential fashion, you form the surface of Mars.
        }

        while (true)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int X = inputs[0];
            int Y = inputs[1];
            int hSpeed = inputs[2]; // the horizontal speed (in m/s), can be negative.
            int vSpeed = inputs[3]; // the vertical speed (in m/s), can be negative.
            int fuel = inputs[4]; // the quantity of remaining fuel in liters.
            int rotate = inputs[5]; // the rotation angle in degrees (-90 to 90).
            int power = inputs[6]; // the thrust power (0 to 4).

            Console.WriteLine("0 " + ((Math.Abs(vSpeed) > 39) ? "4" : "0"));
        }
    }
}