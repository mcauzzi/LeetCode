namespace LeetCodeTests;

public class MedianTwoArrayTests
{
    [Theory]
    [InlineData(new[] {1, 3}, new[] {2}, 2.0)]
    [InlineData(new[] {1, 2}, new[] {3, 4}, 2.5)]
    public void Test(int[] nums1, int[] nums2, double expected)
    {
        var impl = new LeetCode.MedianTwoArrays();
        var result = impl.FindMedianSortedArrays(nums1, nums2);
        Assert.Equal(expected, result);
    }
}