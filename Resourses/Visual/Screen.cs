using System;
namespace Resourses.Visual;
public class Screen
{
        /**                        +
                                   +
                                   +
                                   +
                                   +
                                   +
                                   +
                                   +
        ++++++ IMPORTANTE: dos caracteres hacen un cuadrado ++++++
                                   +
                                   +
                                   +
                                   +
                                   +
                                   +
                                   +
                                   +

        public void Screen(int width, int height){

        }
        try them to make a flexible version


        **/
    public static void Testing() => Console.WriteLine("- Screen loaded correctly");
    public static void ResolutionTest(int width, int height)
    {
        Console.WriteLine("");
        for (int i = 0; i < height; i++)
        {            
            for (int j = 0; j < width; j++)
            {
                Console.Write("[]");
            }
            Console.WriteLine("");            
        }
    }

    public static void ScreenRefresh()
    {

    }
        

        
}
