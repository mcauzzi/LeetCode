namespace LeetCode;

public class MedianTwoArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var mergedArrays = nums1.Concat(nums2).ToArray();
        Array.Sort(mergedArrays);
        var totalLength = mergedArrays.Length;
        var middleIndex = totalLength / 2;
        if (totalLength % 2 == 0)
        {
            return (mergedArrays[middleIndex] + mergedArrays[middleIndex - 1]) / 2.0;
        }

        return mergedArrays[middleIndex];
    }
}