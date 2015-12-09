using System;

class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int floors              = int.Parse(inputs[0]); // number of floors
        int width               = int.Parse(inputs[1]); // width of the area
        int turns               = int.Parse(inputs[2]); // maximum number of rounds
        int exitFloor           = int.Parse(inputs[3]); // floor on which the exit is found
        int exitPos             = int.Parse(inputs[4]); // position of the exit on its floor
        int totalClones         = int.Parse(inputs[5]); // number of generated clones
        int additionalElevators = int.Parse(inputs[6]); // ignore (always zero)
        int elevators           = int.Parse(inputs[7]); // number of elevators

        int[] exitsArray            = new int[floors]; // Array of elevator/exit positions

        for (int i = 0; i < elevators; i++)
        {
            inputs = Console.ReadLine().Split(' ');
            int elevatorFloor = int.Parse(inputs[0]); // floor on which this elevator is found
            int elevatorPos = int.Parse(inputs[1]); // position of the elevator on its floor

            exitsArray[elevatorFloor] = elevatorPos; // just adding the elevators
        }
        exitsArray[exitFloor] = exitPos; // adding the last floor with exit

        while (true)
        {
            inputs = Console.ReadLine().Split(' ');
            int cloneFloor      = int.Parse(inputs[0]); // floor of the leading clone
            int clonePos        = int.Parse(inputs[1]); // position of the leading clone on its floor
            string direction    = inputs[2]; // direction of the leading clone: LEFT or RIGHT

            if (cloneFloor == -1) // there is no clone to handle
            {
                Console.WriteLine("WAIT");
                continue;
            }

            if (direction == "RIGHT" && clonePos > exitsArray[cloneFloor] || direction == "LEFT" && clonePos < exitsArray[cloneFloor])
                Console.WriteLine("BLOCK");
            else
                Console.WriteLine("WAIT");
        }
    }
}