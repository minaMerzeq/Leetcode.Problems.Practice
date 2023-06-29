namespace Leetcode.Problems.Practice.Tests
{
    public class LeetcodeProblems
    {
        public LeetcodeProblems()
        {
        }

        /// <summary>
        /// // Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        /// https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&envId=top-interview-150
        /// </summary>
        /// <param name="nums1">array1 sorted in non-decreasing order</param>
        /// <param name="m"></param>
        /// <param name="nums2">array2 sorted in non-decreasing order</param>
        /// <param name="n"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> nums1List = nums1.ToList();
            int p = m > 0 ? m - 1 : 0;
            bool inserted;
            for (int i = 0; i < n; i++)
            {
                inserted = false;
                for (int j = p; j >= 0; j--)
                {
                    if (nums2[i] < nums1List[j])
                    {
                        if (inserted)
                        {
                            nums1List[j + 1] = nums1List[j];
                            nums1List[j] = nums2[i];
                        }
                        else
                        {
                            nums1List.Insert(j, nums2[i]);
                            p = m + i;
                            inserted = true;
                        }
                    }
                    else if (j == m + i && nums1List[j] == 0)
                    {
                        nums1List[j] = nums2[i];
                        p = m + i;
                        break;
                    }
                    else if (j + 1 < m + n && nums1List[j + 1] == 0)
                    {
                        nums1List[j + 1] = nums2[i];
                        p = m + i;
                        break;
                    }
                    else
                        break;
                }
            }
            for (int i = 0; i < m + n; i++)
                nums1[i] = nums1List[i];
        }
        #region Refactored Merge
        public class MergeSortedArray
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int lastIndex = m + n - 1;
                int nums1Index = m - 1;
                int nums2Index = n - 1;

                while (nums2Index >= 0)
                {
                    if (nums1Index >= 0 && nums2[nums2Index] < nums1[nums1Index])
                    {
                        nums1[lastIndex] = nums1[nums1Index];
                        nums1Index--;
                    }
                    else
                    {
                        nums1[lastIndex] = nums2[nums2Index];
                        nums2Index--;
                    }
                    lastIndex--;
                }
            }
        }
        #endregion

        /// <summary>
        /// Remove all accurance of an element from array
        /// https://leetcode.com/problems/remove-element/submissions/977845687/?envType=study-plan-v2&envId=top-interview-150
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int k = nums.Length;
            if (val > 50)
                return k;

            var lastIndex = k - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (nums[i] == val)
                {
                    for (int j = i; j <= lastIndex; j++)
                    {
                        if (j + 1 <= lastIndex)
                            nums[j] = nums[j + 1];
                        else
                            nums[j] = 0;
                    }
                    k--;
                }
            }
            return k;
        }
        #region Refactored RemoveElement
        public class ArrayManipulator
        {
            public int RemoveElement(int[] nums, int val)
            {
                int length = nums.Length;
                int currentIndex = 0;

                while (currentIndex < length)
                {
                    if (ShouldRemoveElement(nums, currentIndex, val))
                    {
                        SwapWithLastElement(nums, currentIndex, length);
                        length--;
                    }
                    else
                    {
                        currentIndex++;
                    }
                }

                return length;
            }

            private bool ShouldRemoveElement(int[] nums, int index, int val)
            {
                return nums[index] == val;
            }

            private void SwapWithLastElement(int[] nums, int currentIndex, int length)
            {
                nums[currentIndex] = nums[length - 1];
            }
        }
        #endregion
    }
}