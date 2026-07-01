using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Graph
{

    // Using Depth First Search (DFS) to implement the flood fill algorithm
    internal class FloodFillAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="image">input array</param>
        /// <param name="sr">starting row</param>
        /// <param name="sc">starting column</param>
        /// <param name="newColor">new color</param>
        /// <returns></returns>
        public int[][] FloodFill(int[][] image, int row, int col, int newColor)
        {
            image = [[1, 1, 1], [1, 1, 0], [1, 0, 1]];
            row = 1; col = 1; newColor = 2;


            // Get the color value of the existing.
            int originalColor = image[row][col];

            if (originalColor != newColor)  // If the starting pixel's color is different from the new color, we need to perform the flood fill
            {
                // Call the DFS function to perform the flood fill
                DFS(image, row, col, originalColor, newColor);
            }

            return image; // If the starting pixel's color is the same as the new color, we can return the original image without any changes
        }


        private void DFS(int[][] image, int row, int col, int originalColor, int newColor)
        {
            if (row < 0 || col < 0) return;  // If the current pixel is out of bounds, we can return immediately to avoid accessing invalid indices in the image array.

            if (row >= image.Length || col >= image[0].Length) return; // If the current pixel is out of bounds, we can return immediately to avoid accessing invalid indices in the image array.

            if (image[row][col] != originalColor // If current is not original color(1), change color.
               || image[row][col] == newColor   //if current is alredy changed, then we can skip it to avoid infinite loop
                ) return;

            image[row][col] = newColor; // Change the color of the current pixel to the new color

            DFS(image, row + 1, col, originalColor, newColor); //  Botton
            DFS(image, row - 1, col, originalColor, newColor); //  Top
            DFS(image, row, col + 1, originalColor, newColor); //  Right
            DFS(image, row, col - 1, originalColor, newColor); //  Left
        }
    }
}
