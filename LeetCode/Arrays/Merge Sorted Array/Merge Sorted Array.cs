public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {

     for (int i=m+n-1; i>=0; i--)   
     {
        if(n == 0)
        {
            break;
        }

        int maxValue = nums2[n-1];
        if(m > 0)
        {
            if(nums1[m-1] > maxValue)
            {
                maxValue = nums1[m-1];
                m--;
            }            
            else
            {
                n--;
            }
        }
        else
        {
            n--;
        }
        nums1[i] = maxValue;
     }
    }
}