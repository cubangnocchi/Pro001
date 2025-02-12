using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using Resourses.Tools;
using Resourses.GameManager;
namespace Pro001;


internal class Program
{
    private static void Main(string[] args)
    {
        //GameManager.MainMenue();
        MiniTest.Run();



        //Console.WriteLine("-----Starting Game-----");
        //ResoursesLoadingTest();

        //Screen.CambiarTamanoTexto(80, 25);
       // Console.WriteLine("⁅⁅⁆⁆¦¦‖⁑⁂⁗⁁⁜※⁋īīĳĹ↑↓↼⇀⇖■▣▦□▬▬▮○◔◑◕●◍◉◜◝◞◟◤◥◢◣◧◫◷◱◰◼◾◭◮ⅧⅮↇↂ");
        

        //ExperimentalMenue();

        /*
        Console.WriteLine("A");
        var colorFondo = new Color(255, 255, 255);
        var colorTexto = new Color(0, 0, 200);
        var style = new Style(colorTexto, colorFondo);
        AnsiConsole.Markup($"[bold {style}]B[/]");
        Console.Write("C");



        Screen.ResolutionTest(60,30);

        Console.WindowWidth = 121;
        Console.WindowHeight = 31;
        

        ConsoleKeyInfo a = Console.ReadKey(true);
        Console.WriteLine("width: "+ Console.WindowWidth +" height: " + Console.WindowHeight);
        a = Console.ReadKey(true);

        //120, 9000
        */

    }

    /*
    haz el pinche menú principal con la clase implementada
    ah
    */

    private static void ResoursesLoadingTest(){
        //[i]-
        Console.WriteLine("ResoursesLoadingTest:");
        Console.WriteLine("Logic");
        Cell.Testing();
        Item.Testing();
        //MapObject.Testing();
        Maze.Testing();
        Menue.Testing();
        Console.WriteLine("Visual");
        Screen.Testing();
        Camera.Testing();        
        Console.WriteLine("----------------------");
        

        
        
    }
    
    public static void ClearConsole()
    {
        Console.Clear();
        AnsiConsole.Clear();
        
    }
    public static void CloseAplication()
    {
        Environment.Exit(0);
    }

    public static void Sorry()
    {
        Program.ClearConsole();
        var sorry = new Canvas(10,10);
        //0 = black
        //1 = darkGreen
        //2 = Green
        //3 = Green1

        int[,] colors = 
        {{0,0,0,0,0,0,0,0,0,0},
         {0,0,0,0,0,0,0,0,0,0},
         {0,0,3,0,0,0,0,3,0,0},
         {0,0,0,0,0,0,0,0,0,0},
         {0,0,0,3,3,3,3,0,0,0},
         {0,0,3,0,0,0,0,3,0,0},
         {0,0,0,0,0,0,0,0,0,0},
         {0,0,0,0,0,0,0,0,0,0},
         {0,0,0,0,0,0,0,0,0,0},
         {0,0,0,0,0,0,0,0,0,0},
        };

        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < 10; j++)
            {
                if(colors[i,j] == 0)
                {
                    sorry.SetPixel(j,i, Color.Black);
                }
                else if(colors[i,j] == 1)
                {
                    sorry.SetPixel(j,i, Color.DarkGreen);
                }
                else if(colors[i,j] == 2)
                {
                    sorry.SetPixel(j,i, Color.Green);
                }
                else if(colors[i,j] == 3)
                {
                    sorry.SetPixel(j,i, Color.Green1);
                }
            }
        }

        AnsiConsole.Write(sorry);
        AnsiConsole.Markup($"[Green]Sorry, this function is not implemented jet.[/]");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        AnsiConsole.Markup($"[Green]Press any key to continue...[/]");

        ConsoleKeyInfo a = Console.ReadKey(true);

        
    }
}
