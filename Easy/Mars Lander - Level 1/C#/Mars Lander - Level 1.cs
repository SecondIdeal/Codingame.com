using System;

class Player
{
    static void Main()
    {
        int[] inputs;
        int numberOfSurfacePoints = int.Parse(Console.ReadLine()); // used to draw the surface of Mars
        for (int i = 0; i < numberOfSurfacePoints; i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int surfaceCoordinateX = inputs[0]; // 0 to 6999
            int surfaceCoordinateY = inputs[1]; // 0 to 2999
        }

        while (true)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int landerCoordinateX   = inputs[0]; // in meters
            int landerCoordinateY   = inputs[1]; // in meters
            int horizontalSpeed     = inputs[2]; // in m/s, can be negative
            int verticalSpeed       = inputs[3]; // in m/s, can be negative
            int fuelRemainig        = inputs[4]; // in liters
            int rotationAngle       = inputs[5]; // in degrees (-90 to 90)
            int thrustPower         = inputs[6]; // 0 to 4

            Console.WriteLine("0 " + ((Math.Abs(verticalSpeed) > 39) ? "4" : "0"));
        }
    }
}