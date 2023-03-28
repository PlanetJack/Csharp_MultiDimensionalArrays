using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_dimensionalArray
{
    internal class Program
    { 
      /// <summary>
      /// Enhanced if statements
      /// Date : 28 Mar 2023
      /// </summary>
      /// Multi Dimensional Array Example(다차원 배열)
      /// <param name="Jack"></param>

        static void Main(string[] args)
        {
            // declare 2D Array
            string[,] matrix;

            // 3D Array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                { 1, 2, 3 },    //row 0
                { 4, 5, 6 },    //row 1
                { 7, 8, 9 }     //row 2
            };


            // 3D Array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" }, //
                    {"010", "011" },
                    {"Hi there", "What's up?" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"Another one", "Last entry" }
                }
            };

            string[,] array2DString = new string[3, 2]
            {
                { "one", "two"},
                {"three", "four" },
                {"five", "six" }
            };

            array2DString[1, 1] = "chicken";

            // Rank returns the amount of dimensions
            int dimensions = array2DString.Rank;

            int[,] array2D2 = { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("The value is {0}", dimensions);
            Console.ReadKey();
        }
    }
}

