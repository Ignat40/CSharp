using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace ExamPrep;

public class SeachAndSort
{

    // IComparable: for sorting.
    // IEquatable:  for equality checks.

        // CompareTo -> compare two obecjts and retrun a value 
        //              indicating whether the instance preceds, follows 
        //              or occurs in the same position in the sort order as the specified obejct. 

        // Equals -> Checks if two objects are exaclty the same. 

        

    // The Array Class: 
        // • Indenxing is Highly Efficinet but cannot be later resized
        // hence the lack of static Resize Method. 

        // • The RANK property -> represents the number of dimensions of the array.


    /*

    // Depth-First Search (DFS): Edge-based technique. It uses Stack data structure and performs two stages,
                                 First visited vertices are pushed into the stack,
                                 and second if there are no vertices then visited vertices are popped.         

    // Breadth-First Search (BFS): Vertex-based technique for findin. the shortest part in a graph.
                                   It uses Queue data structure that follows "first-in-first-out".
                                   One vertex in selected at a time when visited and marked then its adjacent 
                                   are visited and stored in the queue. It's slower that DFS/
    
    
    */

   


    // Inefficient for large arrays 
    public static int[] BubbleSort(int[] arr)
    {
        // Takes the first and adjacent elemts 
        // and swaps them if needed. 

        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }

        return arr;

        // Space Complexity: O(1); Requires a single additinal space that hold the temp value
        // Time Complexity: O(N^2); as the two nested loops. 
    }


    // Inefficient for large arrays 
    public static int[] InsertionSort(int[] arr)
    {

        // Sorts a list of elements by taking each element and
        // adding it to the correct position in the list.

        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }

        return arr;

        // Space and Time Complexity: O(1); sorts all the elemts in place. 
        // Average-case & Worst-case Complexity: O(N^2);
    }


    // QuickSort is used in the Array.Sort()

    public static int[] QuickSort(int[] array, int leftIndex, int rightIndex)
    {
        var i = leftIndex;
        var j = rightIndex;
        var pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }

            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        if (leftIndex < j)
            QuickSort(array, leftIndex, j);
        if (i < rightIndex)
            QuickSort(array, i, rightIndex);
        return array;

        // Space Complexity: O(log N);
        // Average Time Complexity: O(N log N)
        // Worst Time Complexity: O(N^2);
    }


    // It offers superior performance in distributed computing environments. 
    public static int[] MergeSort(int[] arr, int left, int right)
    {
        // Merge sort starts by dividing the input array into two halves. 
        // The algorithm recursively calls itself for each of those halves until there are no half-arrays to divide during the sorting process. 
        // Conquer: the algorithm sorts and merges the sub-arrays in this step to return an array whose values are sorted. 

        if (left < right)
        {
            int middle = left + (right - left) / 2;
            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);
            MergeArray(arr, left, middle, right);
        }
        return arr;

        // Time Complexity: O(N * log N)
        // Space Complexity: O(N); 
    }

    public static void MergeArray(int[] array, int left, int middle, int right)
    {
        var leftArrayLength = middle - left + 1;
        var rightArrayLength = right - middle;
        var leftTempArray = new int[leftArrayLength];
        var rightTempArray = new int[rightArrayLength];
        int i, j;
        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = array[left + i];
        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = array[middle + 1 + j];
        i = 0;
        j = 0;
        int k = left;
        while (i < leftArrayLength && j < rightArrayLength)
        {
            if (leftTempArray[i] <= rightTempArray[j])
            {
                array[k++] = leftTempArray[i++];
            }
            else
            {
                array[k++] = rightTempArray[j++];
            }
        }
        while (i < leftArrayLength)
        {
            array[k++] = leftTempArray[i++];
        }
        while (j < rightArrayLength)
        {
            array[k++] = rightTempArray[j++];
        }
    }

    public static int[] HeapSort(int[] array, int size)
    {
        // It Uses Binary Heap Data Structure

        if (size <= 1)
            return array;
        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Heapify(array, size, i);
        }
        for (int i = size - 1; i >= 0; i--)
        {
            var tempVar = array[0];
            array[0] = array[i];
            array[i] = tempVar;
            Heapify(array, i, 0);
        }

        return array;

        // Space Complexity: O(N);
        // Average Time Complexity: O(log N )
    }

    private static void Heapify(int[] array, int size, int index)
    {
        var largestIndex = index;
        var leftChild = 2 * index + 1;
        var rightChild = 2 * index + 2;
        if (leftChild < size && array[leftChild] > array[largestIndex])
        {
            largestIndex = leftChild;
        }
        if (rightChild < size && array[rightChild] > array[largestIndex])
        {
            largestIndex = rightChild;
        }
        if (largestIndex != index)
        {
            var tempVar = array[index];
            array[index] = array[largestIndex];
            array[largestIndex] = tempVar;
            Heapify(array, size, largestIndex);
        }
    }


}