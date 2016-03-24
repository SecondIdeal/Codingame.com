using System;

class Player
{
    static void Main()
    {
        int[] inputs;
        int numberOfSurfacePoints = int.Parse(Console.ReadLine()); // used to draw the surface of Mars

        int[] xSurfacePointsArray = new int[numberOfSurfacePoints];
        int[] ySurfacePointsArray = new int[numberOfSurfacePoints];

        for (int i = 0; i < numberOfSurfacePoints; i++)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            xSurfacePointsArray[i] = inputs[0]; // 0 to 6999
            ySurfacePointsArray[i] = inputs[1]; // 0 to 2999
        }

        int[] landingPositions = GetLandingPositions(xSurfacePointsArray, ySurfacePointsArray);

        int yLandingFirstPosition = landingPositions[0];
        int yLandingSecondPosition = landingPositions[1];

        int xLandingFirstPosition = landingPositions[2];
        int xLandingSecondPosition = landingPositions[3];

        int startFuelRemainig = 0; // fuel optimisation
        bool firstStep = true;

        while (true)
        {
            inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int landerCoordinateX = inputs[0]; // in meters
            int landerCoordinateY = inputs[1]; // in meters
            int horizontalSpeed = inputs[2]; // in m/s, can be negative
            int verticalSpeed = inputs[3]; // in m/s, can be negative
            int fuelRemainig = inputs[4]; // in liters
            int rotationAngle = inputs[5]; // in degrees (-90 to 90)
            int thrustPower = inputs[6]; // 0 to 4

            if (firstStep)
            {
                startFuelRemainig = fuelRemainig;
                firstStep = false;
            }

            thrustPower = 4;
            if (landerCoordinateX > xLandingSecondPosition)
            {
                rotationAngle = 23;
                if (horizontalSpeed > 20)
                    rotationAngle = 23;
                if (horizontalSpeed > 40)
                    rotationAngle = 30;
                if (horizontalSpeed < -20)
                    rotationAngle = -23;
                if (horizontalSpeed < -40)
                    rotationAngle = -30;
            }
            else if (landerCoordinateX < xLandingFirstPosition)
            {
                rotationAngle = -23;
                if (horizontalSpeed > 20)
                    rotationAngle = 23;
                if (horizontalSpeed > 40)
                    rotationAngle = 30;
                if (horizontalSpeed < -20)
                    rotationAngle = -23;
                if (horizontalSpeed < -40)
                    rotationAngle = -30;
            }
            else
            {
                if (horizontalSpeed > 10)
                    rotationAngle = 23;
                else if (horizontalSpeed < -10)
                    rotationAngle = -23;
                else
                    rotationAngle = 0;
            }

            thrustPower = 0;
            if (verticalSpeed <= -20 || horizontalSpeed < -20 || horizontalSpeed > 20 || (startFuelRemainig > 950 && Math.Abs(landerCoordinateX - xLandingSecondPosition) > Math.Abs(landerCoordinateY - yLandingSecondPosition)))
                thrustPower = 4;
            if (verticalSpeed > 10)
                thrustPower = 0;

            Console.WriteLine(rotationAngle + " " + thrustPower);
        }
    }

    static int[] GetLandingPositions(int[] xPositions, int[] yPositions)
    {
        int[] result = new int[4];

        int indexOfSearchedFirstValue = int.MaxValue;
        for (int i = 0; i < yPositions.Length - 1; i++)
        {
            if (yPositions[i] == (yPositions[i + 1]))
                indexOfSearchedFirstValue = i;
        }
        int indexOfSearchedSecondValue = indexOfSearchedFirstValue + 1;

        result[0] = yPositions[indexOfSearchedFirstValue];
        result[1] = yPositions[indexOfSearchedSecondValue];

        result[2] = xPositions[indexOfSearchedFirstValue];
        result[3] = xPositions[indexOfSearchedSecondValue];

        return result;
    }
}