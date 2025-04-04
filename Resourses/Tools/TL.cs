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
        //returns true if both are equal
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

    public static int[] VectorScalarMultiplication(int[] vector, int esc)
    {
        int[] output = new int[vector.Length];

        for(int i = 0; i < vector.Length; i++)
        {
            output[i] = vector[i]*esc;
        }

        return output;
    }

    public static int[] ConcatenateArrays(int[] first, int[] second)
    {
        int[] output = new int[first.Length + second.Length];
        
        int i = 0;
        foreach (int v in first)
        {
            output[i] = v;
            i++;
        }
        foreach (int v in second)
        {
            output[i] = v;
            i++;
        }

        return output;
    }


    public static int CountArrInArrFixed(int[] arr, int[] find)
    {
        if(arr.Length < find.Length || arr.Length%find.Length != 0) return -1;

        int exit = 0;
        int count = 0;

        for (int i = 0; i <= arr.Length - find.Length; i += find.Length)
        {
            bool match = true;
            for (int j = 0; j < find.Length; j++)
            {
                if (arr[i + j] != find[j])
                {
                    match = false;
                    break;
                }
            }
            if (match) count++;
    }

    return count;
    }

    //[i]-position methods
    public static bool PosInRange(int[] pos, int rows, int cols)
    {
        //check if a pos is in range
        if(pos.Length != 2) throw new ArgumentException("Position array must contain exactly two elements.");
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
        
        return new int[] {
            //make the step, changing pos with the direction int
            pos[0] + wsad.GetDir(step)[0],
            pos[1] + wsad.GetDir(step)[1],
        };
    }

    public static int[] PosStep(int[] pos, int[] step)
    {
        return new int[] {
            //make the step by changing pos
            pos[0] + step[0],
            pos[1] + step[1],
        };
    }

    /// <summary> Make a step outside an space, if the step is outside the space, return the position in other space </summary>
    /// <param name="pos">The position to step from</param>
    /// <param name="space">The space to step in or out</param>
    /// <param name="step">The step to make</param>
    public static int[] PosStepOutside(int[] pos, int[] space, int step)
    {
        Direction wsad = new();
        int[] stepArr = wsad.GetDir(step);

        int[] output = new int[2];

        // Calculate new position
        int newRow = pos[0] + stepArr[0];
        int newCol = pos[1] + stepArr[1];

        /*
        output[0] = pos[0] + (PosStepInRange(pos, space[0], space[1], step) ? 0 : 
                              ((stepArr[0] < 0)? space[0] - 1 : -(space[0] - 1 )));
        
        output[1] = pos[1] + (PosStepInRange(pos, space[0], space[1], step) ? 0 : 
                              ((stepArr[1] < 0)? space[1] - 1 : -(space[0] - 1 )));
        */
        
        /*
        if (output[0] < 0)
        {
            output[0] = space[0] - 1;
        }
        else if (output[0] >= space[0])
        {
            output[0] = 0;
        }

        if (output[1] < 0)
        {
            output[1] = space[1] - 1;
        }
        else if (output[1] >= space[1])
        {
           output[1] = 0;
        }
        */

        // Check if the new position is outside the current space
        if (newRow < 0)
        {
            output[0] = space[0] - 1;
        }
        else if (newRow >= space[0])
        {
            output[0] = 0;
        }
        else
        {
            output[0] = newRow;
        }

        if (newCol < 0)
        {
            output[1] = space[1] - 1;
        }
        else if (newCol >= space[1])
        {
            output[1] = 0;
        }
        else
        {
            output[1] = newCol;
        }

            return output;
        }

    public static bool IsCloseTo(int[] posA, int[] posB)
    {
        for (int i = 0; i < 4; i++)
        {
            if(ArrEqual(PosStep(posA, i), posB))
            {
                return true;
            }
        }
        return false;
    }
    public static int? IsCloseDir(int[] posA, int[] posB)
    {
        for (int i = 0; i < 4; i++)
        {
            if(ArrEqual(PosStep(posA, i), posB))
            {
                return i;
            }
        }
        return null;
    }

}
