using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsraelObakpolorTestSolution
{
    public class TestAnswer
    {
       public static int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return 0;

            int rob = 0; // Max money if robbing current house
            int skip = 0; // Max money if skipping current house

            foreach (int num in nums)
            {
                int temp = rob; // Store the current value of rob
                rob = skip + num; // Rob the current house, adding money from the skipped house
                skip = Math.Max(skip, temp); // Update skip to be the maximum of the two options
            }

            return Math.Max(rob, skip);
        }

    }
}
