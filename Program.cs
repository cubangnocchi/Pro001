using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using PRO001;


internal class Program
{
    private static void Main(string[] args)
    {
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
        MapObject.Testing();
        Maze.Testing();
        Menue.Testing();
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

    public static void ExperimentalMenue()
    {
        Menue.OptionMethod[] methods = new Menue.OptionMethod[]
        {
            Experiment01,
            Experiment02,
            Caption.Experiment03,
            CloseAplication
        };
        string[] lalala = ["Exp01", "Exp02", "Exp03", "Exit"];
        Menue mainMenue = new Menue("Main Menu", ['1', '2', '3', 'x'], lalala, methods);
        while(true){
            mainMenue.Print();
            char input = Caption.GetKey_asChar();
            mainMenue.Option(input);
        }
    }
    public static void Experiment01() => Console.WriteLine("opcion 1 seleccionada");
    public static void Experiment02() => Console.WriteLine("opcion 2 seleccionada");
    public static void CloseAplication()
    {
        Environment.Exit(0);
    }
}
