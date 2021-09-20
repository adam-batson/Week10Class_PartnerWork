using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops
{
    public class ForLoop
    {
        /// <summary>
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0) return null;

            var number = arr[0];

            for(var i = 1; i < arr.Length; i++)
            {
                if (number > arr[i]) number = arr[i];
            }

            return number;
        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)
        {
            if (arr.Length == 0) return null;

            var number = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (number < arr[i]) number = arr[i];
            }

            return number;
        }

        /// <summary>
        /// Return highest number in jagged array
        /// </summary>
        /// <param name="arr">System.Int32[][]</param>
        /// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
        public int? GetHighest(int[][] arr)
        {
            if (arr.Length == 0 || arr == null) return null;

            int? number = null;

            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr[i].Length; j++)
                {
                    if (number == null || number < arr[i][j]) number = arr[i][j];
                }
            }
            return number;
        }
    }
}
