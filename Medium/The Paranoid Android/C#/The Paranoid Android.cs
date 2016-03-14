using System;

class Player
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int numberOfFloors      = inputs[0];
        int areaWidth           = inputs[1]; 
        int maxNumberOfRounds   = inputs[2]; 
        int exitFloor           = inputs[3]; 
        int exitPosition        = inputs[4]; 
        int totalClones         = inputs[5]; 
        int additionalElevators = inputs[6]; // ignore (always zero)
        int numberOfElevators   = inputs[7]; 

        int[] exitsArray = new int[numberOfFloors]; // Array of elevator/exit positions
        exitsArray[exitFloor] = exitPosition;

        for (int i = 0; i < numberOfElevators; i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int elevatorFloor       = inputs[0]; 
            int elevatorPosition    = inputs[1];

            exitsArray[elevatorFloor] = elevatorPosition;
        }
        
        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');
            int leadingCloneFloor        = int.Parse(input[0]); 
            int leadingClonePosition     = int.Parse(input[1]); 
            string leadingCloneDirection = input[2]; // LEFT or RIGHT

            if (leadingCloneFloor == -1) // If is no clone to handle
            {
                Console.WriteLine("WAIT");
                continue;
            }

            Console.WriteLine(
                leadingCloneDirection == "RIGHT" && leadingClonePosition > exitsArray[leadingCloneFloor] || 
                leadingCloneDirection == "LEFT" && leadingClonePosition < exitsArray[leadingCloneFloor] ? 
                "BLOCK" : "WAIT");
        }
    }
}