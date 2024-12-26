using System;
using Spectre.Console;
using Colorful;

namespace Resourses.Visual;
public class Screen
{
    Image screenImage;
    //quizas todo esto pase a ser una serie de methods de Image
    private class ScreenElement
    {
        int[] stating;
        int[] ending;
        int width;
        int height;
        Image elementImage;
        public ScreenElement(int[] theStartingPosition,int[] theEndingPosition)
        {
            this.stating = theStartingPosition;
            this.ending = theEndingPosition;
            this.width = ending[0] - stating[0];
            this.height = ending[1] - stating[1];
            elementImage = new Image(width, height);
            /*            +
                          +
                          +
            +++++hay info de mas jaja... 
            solo necesito el desplazamiento dela imagen
                          +
                          +
                          +
                          +
                          
            */
        }
        public Image GetImage(Image reference)
        {
            Image exit = new Image(reference.GetLength(0), reference.GetLength(1));
            for (int i = 0; i<width; i++){
                for(int j = 0; j<height; j++)
                {

                }
            }
            return exit;
        }
    }
    private ScreenElement[] screenElements;

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

    public static void ScreenRefresh()
    {
        //change resolution to its 

    }
        

        
}
