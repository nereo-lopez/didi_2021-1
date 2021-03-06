using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Index : MonoBehaviour
{

    void Start()
    {
        int [] nums = {2,7,11,15};
        int [] toSum = nums;
        int target = 9;
        
        sumaNums(nums,toSum,target);
        
    }

    public int sumaNums(int [] nums, int [] toSum, int target)
    {
        int res=0;

        for (int i=0;i<nums.Length;i++)
        {
            for(int j=0;j<toSum.Length;j++)
            {
                res=nums[i]+toSum[j];
                if(res==target)
                {                
                    Debug.Log("["+i+"]");
                }

            }
        }

        return 0;
        
    }

    //Time Complexity: 
}

