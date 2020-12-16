using System;

namespace CodingChallenge
{
    public class Program
    {
        static void Main()
        {
            Program objProgram = new Program();
            try
            {
                Console.WriteLine("Please enter array width:");
                int w = objProgram.Input();
                Console.WriteLine("Please enter array height:");
                int l = objProgram.Input();
                if (w <= 0 || l <= 0)
                {
                    Console.WriteLine("Please try with array length greater than zero.");
                    return;
                }
                if (w != l)
                {
                    Console.WriteLine("Please try with n x n array.");
                    return;
                }
                int[,] array = new int[w, l];
                Console.WriteLine("Please enter array");
                for (int i = 0; i < w; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        array[i, j] = Int32.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Entered Array:");
                objProgram.PrintArray(w, l, array);
                int[,] rotatedArray = objProgram.RotateArray(w, l,array);
                Console.WriteLine("Rotated Array:");
                objProgram.PrintArray(w, l, rotatedArray);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occured. Please check if you have entered correct integer value.");
            }
        }
        /// <summary>
        /// Method to get input
        /// </summary>
        /// <returns></returns>
        public int Input()
        {
            string width = Console.ReadLine();
            int w = 0;
            while (!int.TryParse(width, out w))
            {
                Console.WriteLine("Please enter valid integer value");
                width = Console.ReadLine();
            }
            return w;
        }
        /// <summary>
        /// Method to roate an array 
        /// </summary>
        /// <param name="width">width</param>
        /// <param name="height">height</param>
        /// <param name="values">integer values</param>
        /// <returns>rotated array</returns>
        public int[,] RotateArray(int width, int height, int[,] values)
        {
            try
            {
                int[,] retArray = new int[width, height];
                if (width == 0 || height == 0)
                {
                    return retArray;
                }
                else
                {
                    for (int i = 0; i < width; ++i)
                    {
                        for (int j = 0; j < height; ++j)
                        {
                            retArray[i, j] = values[width - j - 1, i];
                        }
                    }
                }
                return retArray;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        /// <summary>
        /// Method to print the array
        /// </summary>
        /// <param name="w">width</param>
        /// <param name="l">height</param>
        /// <param name="array">array to print</param>
        public void PrintArray(int w, int l, int[,] array)
        {
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    Console.Write(string.Format("{0} ", array[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
