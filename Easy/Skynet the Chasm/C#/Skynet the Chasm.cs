using System;

class Player
{
    static void Main()
    {
        int lenghtOfRoad      = int.Parse(Console.ReadLine());
        int lenghtOfGap       = int.Parse(Console.ReadLine()); 
        int lenghtOfPlatform  = int.Parse(Console.ReadLine()); 

        while (true)
        {
            int motorbikeSpeed     = int.Parse(Console.ReadLine()); 
            int motorbikePosition  = int.Parse(Console.ReadLine()); 

            Console.WriteLine(
                motorbikePosition > lenghtOfRoad || motorbikeSpeed > lenghtOfGap + 1 ? "SLOW" :
                motorbikeSpeed < lenghtOfGap + 1 ? "SPEED" :
                motorbikePosition == lenghtOfRoad - 1 ? "JUMP" : "WAIT");
        }
    }
}