using System;
using System.Globalization;
namespace Resourses.Tools;

/*
[i]-TL Tools, a class for general use methods.

Features: 
- 


*/

public class TL
{
    //[i]-int array methods
    public static bool ArrEqual(int[] a, int[] b)
    {
        //returns true if bouth are equal
        if(a.Length == b.Length)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        return false;

    }

    public static int[] AddArr(int[] a, int[] b) 
    {
        if (a.Length != b.Length) throw new ArgumentException("TL.AddArr no valid parameters. Arrays with the same length expected.");
        
        int[] output = new int[a.Length];

        for(int i = 0; i < a.Length; i++)
        {
            output[i] = a[i] + b[i];
        } 

        return output;
    }

    public static int CountArrInArrFixed(int[] arr, int[] find)
    {
        if(arr.Length < find.Length || arr.Length%find.Length != 0) return -1;

        int exit = 0;
        int count;

        for(int i = 0; i < (arr.Length/find.Length); i++)
        {
            count = 0;
            for(int j = 0; j < find.Length; j++)
            {
                if(arr[(i*find.Length) + j] == find[j]) count++;
            }
            if(count == find.Length) exit++;
        }

        return exit;
    }

    //[i]-General array[,] methods
    public static bool PosInRange(int[] pos, int rows, int cols)
    {
        //check if a pos is in range
        if(pos[0] < 0 || pos[1] < 0 ||
           pos[0] >= rows || pos[1] >= cols)
        {
            return false;
        }
        return true;
    }

    public static bool PosStepInRange(int[] pos, int rows, int cols, int step)
    {
        return PosInRange(PosStep(pos, step), rows, cols);
    }

    public static bool PosStepInRange(int[] pos, int rows, int cols, int[] step)
    {
        return PosInRange(PosStep(pos, step), rows, cols);
    }

    public static int[] PosStep(int[] pos, int step)
    {
        Direction wsad = new();
        
        return 
        [
            //make the step, changing pos with the direction int
            pos[0] + wsad.GetDir(step)[0],
            pos[1] + wsad.GetDir(step)[1],
        ];
    }

    public static int[] PosStep(int[] pos, int[] step)
    {
        return 
        [
        //make the step by changing pos
        pos[0] + step[0],
        pos[1] + step[1],
        ];
    }

}