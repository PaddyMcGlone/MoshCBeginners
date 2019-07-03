using System;
using System.Linq;

namespace ArraysAndLists
{
    class MainClass
    {
        public static void OutputMessage(int[] array)
        {
            Console.WriteLine(string.Join("-", array.Select(n => Convert.ToString(n))));
        }

        public static void Main(string[] args)
        {

            // The clear method
            var items = new int[] { 1, 2, 3, 4, 5 };
            Array.Clear(items, 0, 2);
            OutputMessage(items);
                        
            var moreItems = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Clear(moreItems,0,moreItems.Length);
            OutputMessage(moreItems);            

            // The copy method
            var newItems = new int[] { 1, 2, 3, 4, 5 };
            var copiedItems = new int[3];

            Array.Copy(newItems, copiedItems, 3);
            OutputMessage(copiedItems);

            // Sorting an array
            var myUnsortedArray = new int[] { 7, 6, 5, 1, 23, 9 };
            Array.Sort(myUnsortedArray);
            OutputMessage(myUnsortedArray);
        }
    }
}
