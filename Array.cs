using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int [] nums = {8,1,2,2,3};
        int [] output = NumbersLessThan(nums);
        foreach (var num in output)
        {
            Debug.Log(num);
        }

    }

    // Update is called once per frame
    private int[] NumbersLessThan(int[] nums)
    {

        int [] copyArray;
        int aux=0;
        copyArray = nums;

        for(int i=0; i<nums.Length;i++)
        {
            for(int j=0;j<copyArray.Length;j++)
            {
                if(nums[i] > copyArray[j])
                {
                    aux++;
                    j++;
                }
                else
                    j++;
            }
            nums[i]=aux;
            i++;
        }
        return nums;
    }
}
