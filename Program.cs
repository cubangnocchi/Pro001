using System;
using Resourses.Logic;
using Resourses.Visual;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-----Starting Game-----");
        ResoursesLoadingTest();
        StartingMenue();

    }

    private static void ResoursesLoadingTest(){
        Console.WriteLine("ResoursesLoadingTest:");
        Console.WriteLine("Logic");
        Maze.Testing();
        Cell.Testing();
        Item.Testing();
        MapObject.Testing();
        Console.WriteLine("Visual");
        Screen.Testing();
        Camera.Testing();        
        Console.WriteLine("----------------------");
    }
    private static void StartingMenue(){
        /**
           this is temporal... some day this gonna be seen through Screen.cs 
           and maybe I will need some kind of Menue.cs or something... maybe 
           a private class...................... think about it
        **/
        bool menue_Open = true;    
        while(menue_Open){
            Console.WriteLine(" ");
            Console.WriteLine("------[MENUE]-----");
            Console.WriteLine(" ");
            Console.WriteLine("[1] PLAY");
            Console.WriteLine("[2] TEST MODE");
            Console.WriteLine("[3] Exit");
            Console.WriteLine(" ");
            Console.WriteLine("Write the option number and press [Enter]");
            Console.WriteLine(" ");

            ConsoleKeyInfo auxKey = Console.ReadKey();
            char menueOption = auxKey.KeyChar;

            if(menueOption == '1')
            {
                Console.WriteLine("not available");
                menue_Open = false;             
            }
            else if(menueOption == '2')
            {
                Console.WriteLine(" ");
                TestMenue();
                menue_Open = false;
            }
            else if(menueOption == '3')
            {
                menue_Open = false;                
            }
            else
            {
                Console.WriteLine("something goes wrong");
            } 

        }        
    }

    private static void TestMenue(){
        Console.WriteLine(" ");

    }
}
