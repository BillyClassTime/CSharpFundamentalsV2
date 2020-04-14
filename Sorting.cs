using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable 1591
/*
1 . Escriba un programa Sharp de C- para ordenar una lista de elementos mediante la ordenación de shell.
Solución:
*/
namespace src
{
    public class SortShell
    {
        static void MainSortShell(string[] args)
        {
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int n;

            n = arr.Length;
            Console.WriteLine("Original Array Elements :");
            show_array_elements(arr);
            shellSort(arr, n);
            Console.WriteLine("\nSorted Array Elements :");
            show_array_elements(arr);
        }

        static void shellSort(int[] arr, int array_size)
        {
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
        }

        static void show_array_elements(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");

        }
    }
}
/*
2 - Escriba un programa C # Sharp para ordenar una lista de elementos usando la ordenación Bogosort.
Solución:
*/

class Bogo_sort
{
    static void MainBegoSort(string[] args)
    {
        List<int> list = new List<int>() { 2, 1, 3, 0 };
        Console.WriteLine("Sorting...");
        BogoSort(list, true, 5);
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    static void BogoSort(List<int> list, bool announce, int delay)
    {
        int iteration = 0;
        while (!IsSorted(list))
        {
            if (announce)
            {
                Print_Iteration(list, iteration);
            }
            if (delay != 0)
            {
                System.Threading.Thread.Sleep(Math.Abs(delay));
            }
            list = Remap(list);
            iteration++;
        }

        Print_Iteration(list, iteration);
        Console.WriteLine();
        Console.WriteLine("Bogo_sort completed after {0} iterations.", iteration);
    }

    static void Print_Iteration(List<int> list, int iteration)
    {
        Console.Write("Bogo_sort iteration {0}: ", iteration);
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
            if (i < list.Count)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    static bool IsSorted(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] > list[i + 1])
            {
                return false;
            }
        }

        return true;
    }

    static List<int> Remap(List<int> list)
    {
        int temp;
        List<int> newList = new List<int>();
        Random r = new Random();

        while (list.Count > 0)
        {
            temp = (int)r.Next(list.Count);
            newList.Add(list[temp]);
            list.RemoveAt(temp);
        }
        return newList;
    }
}
/*
3 - Escriba un programa Sharp de C # para ordenar una lista de elementos usando Bubble sort.
Solución:
*/
public class Bubble_Sort
{
    public static void MainBubleSort(string[] args)
    {
        int[] a = { 3, 0, 2, 5, -1, 4, 1 };
        int t;
        Console.WriteLine("Original array :");
        foreach (int aa in a)
            Console.Write(aa + " ");
        for (int p = 0; p <= a.Length - 2; p++)
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                }
            }
        }
        Console.WriteLine("\n" + "Sorted array :");
        foreach (int aa in a)
            Console.Write(aa + " ");
        Console.Write("\n");

    }
}
/*
4 - Escriba un programa Sharp de C # para ordenar una lista de elementos usando el orden de conteo.
Solución:
*/
public class Counting_sort
{
    public static void MainCountingSort()
    {
        int[] array = new int[10]
        {
    2, 5, -4, 11, 0, 8, 22, 67, 51, 6
        };

        Console.WriteLine("\n" + "Original array :");
        foreach (int aa in array)
            Console.Write(aa + " ");

        int[] sortedArray = new int[array.Length];

        // find smallest and largest value
        int minVal = array[0];
        int maxVal = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < minVal) minVal = array[i];
            else if (array[i] > maxVal) maxVal = array[i];
        }

        // init array of frequencies
        int[] counts = new int[maxVal - minVal + 1];

        // init the frequencies
        for (int i = 0; i < array.Length; i++)
        {
            counts[array[i] - minVal]++;
        }

        // recalculate
        counts[0]--;
        for (int i = 1; i < counts.Length; i++)
        {
            counts[i] = counts[i] + counts[i - 1];
        }

        // Sort the array
        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[counts[array[i] - minVal]--] = array[i];
        }

        Console.WriteLine("\n" + "Sorted array :");
        foreach (int aa in sortedArray)
            Console.Write(aa + " ");
        Console.Write("\n");

    }
}
/*
5 - Escriba un programa C # Sharp para ordenar una lista de elementos usando la ordenación de montón.
Solución:
*/
public class Heap_sort
{
    public static void MainHeapSort(string[] args)
    {
        int[] mykeys = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

        //double[] mykeys = new double[] {2.22, 0.5, 2.7, -1.0, 11.2};

        //string[] mykeys = new string[] {"Red", "White", "Black", "Green", "Orange"};

        Console.WriteLine("\nOriginal Array Elements :");
        printArray(mykeys);

        heapSort(mykeys);

        Console.WriteLine("\n\nSorted Array Elements :");
        printArray(mykeys);
        Console.WriteLine("\n");
    }

    private static void heapSort<T>(T[] array) where T : IComparable<T>
    {
        int heapSize = array.Length;

        buildMaxHeap(array);

        for (int i = heapSize - 1; i >= 1; i--)
        {
            swap(array, i, 0);
            heapSize--;
            sink(array, heapSize, 0);
        }
    }

    private static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
    {
        int heapSize = array.Length;

        for (int i = (heapSize / 2) - 1; i >= 0; i--)
        {
            sink(array, heapSize, i);
        }
    }

    private static void sink<T>(T[] array, int heapSize, int toSinkPos) where T : IComparable<T>
    {
        if (getLeftKidPos(toSinkPos) >= heapSize)
        {
            // No left kid => no kid at all
            return;
        }
        int largestKidPos;
        bool leftIsLargest;

        if (getRightKidPos(toSinkPos) >= heapSize || array[getRightKidPos(toSinkPos)].CompareTo(array[getLeftKidPos(toSinkPos)]) < 0)
        {
            largestKidPos = getLeftKidPos(toSinkPos);
            leftIsLargest = true;
        }
        else
        {
            largestKidPos = getRightKidPos(toSinkPos);
            leftIsLargest = false;
        }

        if (array[largestKidPos].CompareTo(array[toSinkPos]) > 0)
        {
            swap(array, toSinkPos, largestKidPos);

            if (leftIsLargest)
            {
                sink(array, heapSize, getLeftKidPos(toSinkPos));

            }
            else
            {
                sink(array, heapSize, getRightKidPos(toSinkPos));
            }
        }

    }

    private static void swap<T>(T[] array, int pos0, int pos1)
    {
        T tmpVal = array[pos0];
        array[pos0] = array[pos1];
        array[pos1] = tmpVal;
    }

    private static int getLeftKidPos(int parentPos)
    {
        return (2 * (parentPos + 1)) - 1;
    }

    private static int getRightKidPos(int parentPos)
    {
        return 2 * (parentPos + 1);
    }

    private static void printArray<T>(T[] array)
    {

        foreach (T t in array)
        {
            Console.Write(' ' + t.ToString() + ' ');
        }

    }
}

/*
6 - Escriba un programa C # Sharp para ordenar una lista de elementos usando el método de inserción.
Solución:
*/
class CommonInsertion_Sort
{
    static void MainCommonInsertionSort(string[] args)
    {
        int[] numbers = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
        Console.WriteLine("\nOriginal Array Elements :");
        PrintIntegerArray(numbers);
        Console.WriteLine("\nSorted Array Elements :");
        PrintIntegerArray(InsertionSort(numbers));
        Console.WriteLine("\n");
    }

    static int[] InsertionSort(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray;
    }
    public static void PrintIntegerArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i.ToString() + "  ");
        }
    }

    public static int[] InsertionSortByShift(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int j;
            var insertionValue = inputArray[i];
            for (j = i; j > 0; j--)
            {
                if (inputArray[j - 1] > insertionValue)
                {
                    inputArray[j] = inputArray[j - 1];
                }
            }
            inputArray[j] = insertionValue;
        }
        return inputArray;
    }

}

/*
7 - Escriba un programa Sharp de C # para ordenar una lista de elementos usando Ordenar por combinación.
Solución:
*/
class Merge_sort
{
    static void MainMergeSort(string[] args)
    {
        List<int> unsorted = new List<int>();
        List<int> sorted;

        Random random = new Random();

        Console.WriteLine("Original array elements:");
        for (int i = 0; i < 10; i++)
        {
            unsorted.Add(random.Next(0, 100));
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();

        sorted = MergeSort(unsorted);

        Console.WriteLine("Sorted array elements: ");
        foreach (int x in sorted)
        {
            Console.Write(x + " ");
        }
        Console.Write("\n");
    }


    private static List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1)
            return unsorted;

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int middle = unsorted.Count / 2;
        for (int i = 0; i < middle; i++)  //Dividing the unsorted list
        {
            left.Add(unsorted[i]);
        }
        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }

    private static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                {
                    result.Add(left.First());
                    left.Remove(left.First());      //Rest of the list minus the first element
                }
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left.First());
                left.Remove(left.First());
            }
            else if (right.Count > 0)
            {
                result.Add(right.First());

                right.Remove(right.First());
            }
        }
        return result;
    }
}
/*
8 - Escriba un programa C # Sharp para ordenar una lista de elementos usando la ordenación por permutación.
Solución:
// https://bit.ly/2ABDdUZ
*/
class SortPerm
{
    private static void Swap(ref char a, ref char b)
    {
        if (a == b) return;

        a ^= b;
        b ^= a;
        a ^= b;
    }

    public static void GetPer(char[] list)
    {
        int x = list.Length - 1;
        GetPer(list, 0, x);
    }

    private static void GetPer(char[] list, int k, int m)
    {
        if (k == m)
        {
            {
                Console.WriteLine(list);
            }


        }
        else
            for (int i = k; i <= m; i++)
            {
                Swap(ref list[k], ref list[i]);
                GetPer(list, k + 1, m);
                Swap(ref list[k], ref list[i]);
            }
    }

    static void MainSortPerm()
    {
        string str = "ABC";
        char[] arr = str.ToCharArray();
        GetPer(arr);
    }
}
/*
9 - Escriba un programa C # Sharp para ordenar una lista de elementos usando la clasificación rápida.
Solución:
*/
class QuickSort
{
    private static void Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }

    }
    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
    static void MainQuickSort(string[] args)
    {
        int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

        Console.WriteLine("Original array : ");
        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();

        Quick_Sort(arr, 0, arr.Length - 1);

        Console.WriteLine();
        Console.WriteLine("Sorted array : ");

        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine();
    }
}
/*
10 - Escriba un programa C # Sharp para ordenar una lista de elementos usando el algoritmo de ordenación Radix.
Solución:
*/
class RadixSort
{
    static void Sort(int[] arr)
    {
        int i, j;
        int[] tmp = new int[arr.Length];
        for (int shift = 31; shift > -1; --shift)
        {
            j = 0;
            for (i = 0; i < arr.Length; ++i)
            {
                bool move = (arr[i] << shift) >= 0;
                if (shift == 0 ? !move : move)
                    arr[i - j] = arr[i];
                else
                    tmp[j++] = arr[i];
            }
            Array.Copy(tmp, 0, arr, arr.Length - j, j);
        }
    }
    static void MainQuickSort(string[] args)
    {

        int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
        Console.WriteLine("\nOriginal array : ");
        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }

        Sort(arr);
        Console.WriteLine("\nSorted array : ");
        foreach (var item in arr)
        {
            Console.Write(" " + item);
        }
        Console.WriteLine("\n");
    }
}
/*
11 - Escriba un programa C # Sharp para ordenar una lista de elementos utilizando el algoritmo de selección.
Solución:
*/
class SelectionSort
{
    static void MainSelectionSort(string[] args)
    {
        Selection_Sort selection = new Selection_Sort(10);
        selection.Sort();
    }
}

class Selection_Sort
{
    private int[] data;
    private static Random generator = new Random();
    //Create an array of 10 random numbers
    public Selection_Sort(int size)
    {
        data = new int[size];
        for (int i = 0; i < size; i++)
        {
            data[i] = generator.Next(20, 90);
        }
    }

    public void Sort()
    {
        Console.Write("\nSorted Array Elements :(Step by Step)\n\n");
        display_array_elements();
        int smallest;
        for (int i = 0; i < data.Length - 1; i++)
        {
            smallest = i;

            for (int index = i + 1; index < data.Length; index++)
            {
                if (data[index] < data[smallest])
                {
                    smallest = index;
                }
            }
            Swap(i, smallest);
            display_array_elements();
        }

    }

    public void Swap(int first, int second)
    {
        int temporary = data[first];
        data[first] = data[second];
        data[second] = temporary;
    }

    public void display_array_elements()
    {
        foreach (var element in data)
        {
            Console.Write(element + " ");
        }
        Console.Write("\n\n");
    }
}