using System;
namespace Resourses.Tools;

public class Excpt
{
    public static void Exp()
    {
        throw new ArgumentException ("--exception--");
    }
    public static void Exp(string str)
    {
        throw new ArgumentException (str);
    }
    public static void InRange(int min, int max, int var)
    {
        if(var < min || var > max) Exp("out of range");
    }
}