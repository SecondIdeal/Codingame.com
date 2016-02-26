using System;

class Player
{
    static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int totalNodes  = inputs[0]; // The total number of nodes in the level, including the gateways
        int numberLinks = inputs[1]; // The number of links
        int numberExits = inputs[2]; // The number of exit gateways

        int[,] linksArray = new int[numberLinks, 2];

        for (int i = 0; i < numberLinks; i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            // Defines a link between these nodes
            linksArray[i, 0] = inputs[0]; 
            linksArray[i, 1] = inputs[1];
        }

        int[] exitIndex = new int[numberExits];

        for (int i = 0; i < numberExits; i++)
            exitIndex[i] = int.Parse(Console.ReadLine()); // The index of a gateway node

        // Sorting
        for (int i = 0; i < numberLinks; i++)
        {
            for (int k = 0; k < numberExits; k++)
            {
                if (linksArray[i, 1] == exitIndex[k])
                {
                    // Changing positions
                    int temp = linksArray[i, 1]; // Copy the first position's element
                    linksArray[i, 1] = linksArray[i, 0]; // Assign to the second element
                    linksArray[i, 0] = temp; // Assign to the first element
                }
            }
        }

        while (true)
        {
            int agentIndex = int.Parse(Console.ReadLine()); // The index of the node on which the Skynet agent is positioned this turn
            bool AgentIsNear = false; // Agent is near to exit
            
            // If agent is near to exit - let's close connection between him and exit
            for (int i = 0; i < numberLinks; i++) // Going through all links
            {
                bool breakLoop = false;
                for (int k = 0; k < numberExits; k++) // Going through all exits
                {
                    if (exitIndex[k] == linksArray[i, 0] && agentIndex == linksArray[i, 1])
                    {
                        Console.WriteLine(exitIndex[k] + " " + agentIndex);
                        linksArray[i, 0] = -1;
                        AgentIsNear = true;
                        breakLoop = true;
                        break;
                    }
                }
                if (breakLoop) break;
            }

            // Else close connection
            if (!AgentIsNear)
            {
                for (int i = 0; i < numberLinks; i++)
                {
                    bool breakLoop = false; 
                    for (int k = 0; k < numberExits; k++)
                    {
                        if (linksArray[i, 0] == exitIndex[k])
                        {
                            Console.WriteLine(exitIndex[k] + " " + linksArray[i, 1]);
                            linksArray[i, 0] = -1;
                            breakLoop = true;
                            break;
                        }
                    }
                    if (breakLoop) break;
                }
            }
        }
    }
}