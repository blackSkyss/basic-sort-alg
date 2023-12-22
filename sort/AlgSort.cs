using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort
{
    public static class AlgSort
    {
        // [2, 5, 8, 9, 4]
        // [0, 1, 2, 3, 4]
        // insertion
        public static (List<int>, string) InsertionSort(List<int> ints)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            #region logic
            for (var i = 1; i < ints.Count; i++)
            {
                Console.WriteLine($"---i:{i}---");
                var j = i;
                while (j > 0 && ints[j - 1] > ints[j])
                {
                    Console.WriteLine($"i:{i}, j:{j}");
                    (ints[j], ints[j - 1]) = (ints[j - 1], ints[j]);
                    j -= 1;
                }
            }
            #endregion

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            return (ints, elapsedTime.TotalMilliseconds.ToString());
        }

        // [2, 5, 8, 9, 4]
        // [0, 1, 2, 3, 4]
        // selection
        public static (List<int>, string) SelectionSort(List<int> ints)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            #region logic
            for (var i = 0; i < ints.Count - 1; i++)
            {
                Console.WriteLine($"---i:{i}---");
                var min = i;
                for (var j = i + 1; j < ints.Count; j++)
                {
                    Console.WriteLine($"i:{i}, j:{j}");
                    if (ints[j] < min) min = j;
                }

                if (min != i) (ints[i], ints[min]) = (ints[min], ints[i]);
            }
            #endregion

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            return (ints, elapsedTime.TotalMilliseconds.ToString());
        }

        // [2, 5, 8, 9, 4]
        // [0, 1, 2, 3, 4]
        // bubble
        public static (List<int>, string) BubbleSort(List<int> ints)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            #region logic
            for (var i = 0; i < ints.Count; i++)
            {
                Console.WriteLine($"---i:{i}---");
                for (var j = 0; j < ints.Count - 1 - i; j++)
                {
                    Console.WriteLine($"i:{i}, j:{j}");
                    if (ints[j] > ints[j + 1]) (ints[j], ints[j + 1]) = (ints[j + 1], ints[j + 1]);
                }
            }
            #endregion

            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            return (ints, elapsedTime.TotalMilliseconds.ToString());
        }
    }
}
