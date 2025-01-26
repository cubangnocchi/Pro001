using System;
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