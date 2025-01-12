using System;
using Spectre.Console;
using Colorful;
using SyCl = System.Console;

namespace Resourses.Visual;
public class Screen
{
    Image screenImage;
    //quizas todo esto pase a ser una serie de methods de Image
    

    public Screen(){

    }
    public enum ScreenType
    {
        MainMenue,
        SetingsMenue,
        TestingMenue,
        CharacterSelection,
        InGameScreen,
        PlayerStats,
        ChangeTurn,


    }
    
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
    public static void Testing() => System.Console.WriteLine("- Screen loaded correctly");
    public static void ResolutionTest(int width, int height)
    {
        System.Console.WriteLine("");
        for (int i = 0; i < height; i++)
        {            
            for (int j = 0; j < width; j++)
            {
                System.Console.Write("[]");
            }
            System.Console.WriteLine("");            
        }
    }

    public void ScreenRefresh()
    {
        SyCl.Clear();
        screenImage.Print();
    }

    


        

        
}
