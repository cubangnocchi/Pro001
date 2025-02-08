using System;
namespace Resourses.Visual;

public class Caption
{
    public static char GetKey_asChar()
    {
        //returns the pressed key as a character

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        return keyInfo.KeyChar;
        
    }

    public static void Experiment03() => Console.WriteLine("opcion 3 seleccionada");


}