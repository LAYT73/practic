namespace labs;

public class MergeSortStep
{
    private int[] array;
    private int mergeSize;

    public MergeSortStep(int[] inputArray)
    {
        array = new int[inputArray.Length];
        Array.Copy(inputArray, array, inputArray.Length);
        mergeSize = 1;
    }

    public int[] GetArray()
    {
        int[] resultArray = new int[array.Length];
        Array.Copy(array, resultArray, array.Length);
        return resultArray;
    }

    public bool NextStep()
    {
        bool sorted = true;

        for (int i = 0; i < array.Length; i += 2 * mergeSize)
        {
            int mid = Math.Min(i + mergeSize, array.Length);
            int end = Math.Min(i + 2 * mergeSize, array.Length);
            if (mid < end)
            {
                Merge(i, mid, end);
                sorted = false;
            }
        }

        mergeSize *= 2;
        return sorted;
    }

    private void Merge(int left, int mid, int right)
    {
        int[] temp = new int[right - left];
        int i = left, j = mid, k = 0;

        while (i < mid && j < right)
        {
            if (array[i] <= array[j])
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }

        while (i < mid)
        {
            temp[k++] = array[i++];
        }

        while (j < right)
        {
            temp[k++] = array[j++];
        }

        Array.Copy(temp, 0, array, left, temp.Length);
    }
}
