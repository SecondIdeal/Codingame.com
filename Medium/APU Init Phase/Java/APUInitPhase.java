import java.util.*;

class Player {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int width = in.nextInt(); // the number of cells on the X axis
        in.nextLine();
        int height = in.nextInt(); // the number of cells on the Y axis
        in.nextLine();

        int[][] gridArray = new int[width][height];

        for (int i = 0; i < height; i++) {
            String line = in.nextLine(); // width characters, each either 0 or .

            char[] letters = line.toCharArray();

            for (int k = 0; k < width; k++)
                gridArray[k][i] = (letters[k] == '0' ? 0 : -1);
        }

        // From left to right
        for (int coordY = 0; coordY < height; coordY++)
        {
            for (int coodinX = 0; coodinX < width; coodinX++)
            {
                if (gridArray[coodinX][coordY] == 0)
                {
                    //Horizontal
                    int coordXR = -1; int coordYR = -1; // Coordinate of the node on the right
                    int n = coodinX + 1;
                    while (n < width)
                    {
                        if (coordXR == -1 && coordYR == -1 && gridArray[n][coordY] == 0)
                        {
                            coordXR = n;
                            coordYR = coordY;
                        }
                        n++;
                    }

                    // Vertical
                    int coordXB = -1; int coordYB = -1; // Coordinate of the node at the bottom
                    int m = coordY + 1;
                    while (m < height)
                    {
                        if (coordXB == -1 && coordYB == -1 && gridArray[coodinX][m] == 0)
                        {
                            coordXB = coodinX;
                            coordYB = m;
                        }
                        m++;
                    }
                    System.out.println(coodinX + " " + coordY + " " + coordXR + " " + coordYR + " " + coordXB + " " + coordYB);
                }
            }
        }
    }
}