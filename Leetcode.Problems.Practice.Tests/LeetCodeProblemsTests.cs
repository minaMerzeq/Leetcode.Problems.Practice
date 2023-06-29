namespace Leetcode.Problems.Practice.Tests
{
    public class LeetCodeProblemsTests
    {
        private readonly LeetcodeProblems _problems;

        public LeetCodeProblemsTests()
        {
            _problems = new LeetcodeProblems();
        }

        [Fact]
        public void Merge_Test1()
        {
            int[] nums1 = { 4, 5, 6, 0, 0, 0 };
            int[] nums2 = { 1, 2, 3 };
            int m = 3, n = 3;
            int[] expectedResult = { 1, 2, 3, 4, 5, 6 };

            _problems.Merge(nums1, m, nums2, n);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void Merge_Test2()
        {
            int[] nums1 = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };
            int[] nums2 = { 1, 2, 2 };
            int m = 6, n = 3;
            int[] expectedResult = { -1, 0, 0, 1, 2, 2, 3, 3, 3 };

            _problems.Merge(nums1, m, nums2, n);

            Assert.Equal(expectedResult, nums1);
        }

        [Fact]
        public void RemoveElement_Test1()
        {
            int[] nums = { 2, 3, 4, 0, 50 };
            int val = 51;
            int[] expected = nums;

            int k = _problems.RemoveElement(nums, val);

            Assert.Equal(expected, nums);
            Assert.Equal(0, k);
        }

        [Fact]
        public void RemoveElement_Test2()
        {
            int[] nums = { 0, 2, 3, 1, 1, 2, 0, 2, 4 };
            int val = 99;
            int[] expected = { 0, 2, 3, 1, 1, 2, 0, 2, 4 };

            int k = _problems.RemoveElement(nums, val);

            Assert.Equal(expected, nums);
            Assert.Equal(9, k);
        }
    }
}