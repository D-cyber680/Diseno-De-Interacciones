using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Ejercicio : MonoBehaviour
{
    
    void Start()
    {
        int[] in_arr = new int[] { 8, 1, 2, 2, 3 };
        int[] out_arr = new int[in_arr.Length];
        Ejercicio1(in_arr, out_arr);

        foreach (var item in out_arr)
        {
            Debug.Log(item + ",");

        }
    }
    static void Ejercicio1(int[] nums, int[] out_arr)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    count += 1;
                }
            }
            out_arr[i] = count;
            count = 0;
        }
    }

}
