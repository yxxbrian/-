using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 旋转数组
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        class Solution
        {
            public int minNumberInRotateArray(int[] rotateArray) 
            {
                if (rotateArray.Length == 0)
                    return 0;
                int left = 0;
                int right = rotateArray.Length - 1;
                return getMin(rotateArray, left, right);
            }

            private int getMin(int[] rotateArray, int left, int right)
            {
                if (left == right)
                    return rotateArray[left];
                else if (left == right - 1)
                {
                    if (rotateArray[left] < rotateArray[right])
                        return rotateArray[left];
                    else
                        return rotateArray[right];
                }
                else
                {
                    int mid = (left + right) / 2;
                    if (rotateArray[left] > rotateArray[mid])
                        return getMin(rotateArray, left, mid);
                    else
                        return getMin(rotateArray, mid, right);
                }
            }


            /*
             int res = 0;
            for(int i=rotateArray.Length-1;i>0;i--)
            {
                if (rotateArray[i - 1] > rotateArray[i])
                {
                    res = i;
                    break;
                }
            }
            return rotateArray[res];
             */

            /*
            public int minNumberInRotateArray(int[] rotateArray)
            {
                // write code here
                if (rotateArray.Length == 0)
                    return 0;
                int smallIndex = getSmallIndex(rotateArray);
                int[] res = new int[rotateArray.Length];
                int newIndex = 0;
                for (int i = smallIndex; i < rotateArray.Length; i++)
                {
                    res[newIndex++] = rotateArray[i];
                }
                for (int i = 0; i < smallIndex; i++)
                {
                    res[newIndex++] = rotateArray[i];
                }
                return res;
            }
            */
            int getSmallIndex(int[] intArray)
            {
                int index = 0;
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (intArray[i] < index)
                        index = i;
                }
                return index;
            }

        }
        
    }
}
