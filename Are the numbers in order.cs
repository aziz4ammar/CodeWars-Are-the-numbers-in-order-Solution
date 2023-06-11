using System;

public class Kata
{
    public static bool IsAscOrder(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }

        return true;
    }
}
