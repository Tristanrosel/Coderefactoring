using System;

public class Kata
{
    public static int[][] BitPlane(int[][] image, int plane)
    {
        int numRows = image.Length;
        int numCols = image[0].Length;
        int[][] bitPlane = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            bitPlane[i] = new int[numCols];
            for (int j = 0; j < numCols; j++)
            {
                bitPlane[i][j] = GetBit(image[i][j], plane);
            }
        }

        return bitPlane;
    }

    private static int GetBit(int value, int plane)
    {
        return (value >> plane) & 1;
    }

    public static void Main(string[] args)
    {
        int[][] image = new int[][] { new int[] { 0, 63 }, new int[] { 127, 255 } };
        int plane = 3;
        int[][] result = BitPlane(image, plane);

        Console.WriteLine("Bit plane " + plane + ":");
        foreach (var row in result)
        {
            Console.WriteLine(string.Join(", ", row));
            Console.ReadLine();
        }
    }
}
