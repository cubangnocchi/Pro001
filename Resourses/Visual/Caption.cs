using System;
namespace Resourses.Logic;

public class Caption
{
    public static char GetKey_asChar()
    {
        //returns the pressed key as a character
        ConsoleKeyInfo key = Console.ReadKey(true);
        return key.KeyChar;
    }

    public static void Experiment03() => Console.WriteLine("opcion 3 seleccionada");


}