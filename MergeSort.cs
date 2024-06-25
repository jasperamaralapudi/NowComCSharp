class MergeSort
{
    public void mergeSort()
    {
        int[] arr = { 54, 79, 58, 7, 42, 23, 91, 3, 74, 38, 67, 46, 18, 61, 32, 86, 14, 28 };
        int n = arr.Length;
        int[] tempArray = new int[n];

        mergeSortRecursive(arr, tempArray, 0, n - 1);

        foreach (int i in arr)
            Console.Write(i + " ");
    }

    private void mergeSortRecursive(int[] array, int[] tempArray, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            mergeSortRecursive(array, tempArray, left, mid);
            mergeSortRecursive(array, tempArray, mid + 1, right);
            merge(array, tempArray, left, mid, right);
        }
    }

    private void merge(int[] array, int[] tempArray, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        for (int m = left; m <= right; m++)
        {
            tempArray[m] = array[m];
        }

        while (i <= mid && j <= right)
        {
            if (tempArray[i] <= tempArray[j])
            {
                array[k] = tempArray[i];
                i++;
            }
            else
            {
                array[k] = tempArray[j];
                j++;
            }
            k++;
        }

        while (i <= mid)
        {
            array[k] = tempArray[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            array[k] = tempArray[j];
            j++;
            k++;
        }
    }
}
