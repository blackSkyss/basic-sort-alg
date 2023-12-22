namespace sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Program!!!");
            var ints = new List<int>() { 2, 5, 8, 9, 4 };
            Console.WriteLine($"Before sorting: {string.Join(", ", ints)}\n");

            // insertion sort
            Console.WriteLine("-----Sorting Insertion-----");
            (List<int>, string) insertionSort = AlgSort.InsertionSort(ints);
            Console.WriteLine($"After sorting with insertion alg: {string.Join(", ", insertionSort.Item1)}");
            Console.WriteLine($"Time to run is: {insertionSort.Item2}\n");

            // selection sort
            Console.WriteLine("-----Sorting Selection-----");
            (List<int>, string) selectionSort = AlgSort.SelectionSort(ints);
            Console.WriteLine($"After sorting with selection alg: {string.Join(", ", selectionSort.Item1)}");
            Console.WriteLine($"Time to run is: {selectionSort.Item2}\n");

            // bubble sort
            Console.WriteLine("-----Sorting Bubble-----");
            (List<int>, string) bubbleSort = AlgSort.BubbleSort(ints);
            Console.WriteLine($"After sorting with bubble alg: {string.Join(", ", bubbleSort.Item1)}");
            Console.WriteLine($"Time to run is: {bubbleSort.Item2}");
        }
    }
}