using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirst : MonoBehaviour
{
    public static int decrement(int x)
    {
        x = x - 1;
        return x;
    }

    public static int[] decrements(int[] xs)
    {
        int[] result = new int[xs.Length];
        for(int i = 0; i < xs.Length; i++)
        {
            if(xs[i] < xs[0])
            {
                result[i] = decrement(xs[i]);
            }
            else
            {
                result[i] = xs[i];
            }
        }
        return result;
    }
}
