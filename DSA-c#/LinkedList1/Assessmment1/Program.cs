// See https://aka.ms/new-console-template for more information
Solution solution = new Solution();

var image = new int[3][]
{
    new int[] {1, 1, 0},
    new int[] {1, 0, 1},
    new int[] {0, 0, 0}
};


var flippedInvertedImage = solution.FlipAndInvertImage(image);


Console.WriteLine();


public class Solution
{
    public int[][] FlipAndInvertImage(int[][] image)
    {
        int numRows = image.Length;
        int numCols = image[0].Length;

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols / 2; col++)
            {
                int temp = image[row][col];
                image[row][col] = image[row][numCols - col - 1];
                image[row][numCols - col - 1] = temp;
            }

            for (int col = 0; col < numCols; col++)
            {
                image[row][col] = 1 - image[row][col];
            }
        }

        return image;
    }
}