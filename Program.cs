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
        Console.WriteLine("Visual");
        Screen.Testing();
        Camera.Testing();        
        Console.WriteLine("----------------------");
    }
    private static void StartingMenue(){
        bool menueOpen = true;
        string menueOption = "";
        while(menueOpen){
            Console.WriteLine(" ");
            Console.WriteLine("------[MENUE]-----");
            Console.WriteLine(" ");
            Console.WriteLine("[1] PLAY");
            Console.WriteLine("[2] TEST MODE");
            Console.WriteLine(" ");
            Console.WriteLine("Write the option number and press [Enter]");
            Console.WriteLine(" ");
            menueOption = Console.ReadLine();
            if(menueOption == "1"){
                Console.WriteLine("not available");
                menueOpen = false;
                
            }
            else if(menueOption == "2"){
                Console.WriteLine(" ");
                TestMenue();
                menueOpen = false;
            }
            else{
                Console.WriteLine("something goes wrong");
            } 

        }        
    }

    private static void TestMenue(){
        Console.WriteLine(" ");

    }
}
