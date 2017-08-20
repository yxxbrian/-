using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] merged = new int[m + n];
            int index0 = 0, index1 = 0;
            for (int i = 0; i < m + n; i++)
            {
                if(index0<m && index1<n)
                {
                    if (nums1[index0] < nums2[index1])
                        merged[i] = nums1[index0++];
                    else
                        merged[i] = nums2[index1++];
                }
                else if (index0 < m && index1 >= n)
                {
                    merged[i] = nums1[index0++];
                }
                else if (index0 >= m && index1 < n)
                {
                    merged[i] = nums2[index1++];
                }
            }
            for (int i = 0; i < m + n; i++)
                nums1[i] = merged[i];

        }
    }
}
