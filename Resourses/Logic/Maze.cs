using System;
namespace Resourses.Logic;
public class Maze
{
    Cell[,] mazeCells; //maybe this should be changed by a room[,]
                       //consider only using Rooms as a tooll
                       //or maybe rooms makes easier the work for visual

    Room[,] mazeRooms;
    string name; 
    string seed;

    /*public Maze(string theName, int width, int height){
        maze= new Cell[width, height];
        name = theName;
        Generator();
    }
    public Maze(string theName, int width, int height, int roomScuareSize){
        maze= new Cell[(width*roomScuareSize), (height*roomScuareSize)];
        name = theName;
        Generator();
    }*/

    public Maze(string theName, int width, int height, int roomScuareSize){
        mazeRooms = new Room[width,height];
        name = theName;
        Generator();
    }
    
    /*public Maze(string theName, int width, int height, string theSeed){
        mazeCells = new Cell[width, height];
        name = theName;
        seed = theSeed;
        GeneratorFromSeed();
    }*/

    public static void Testing() => Console.WriteLine("- Maze loaded correctly");
    
    //[i] maze generation methods:

    private void Generator(){
        //prueba hacerlo recurcivo jeje...
        for(int i=0; i<10/*(mazeRooms.Length(1)*mazeRooms.Length(2))*/; i++)
        {
            //acá va el metodo de hacer recorridos conectando habitaciones y modificándolas
            Connector();
            //valora el sumarle obstáculos
        }        
        
    }
    private void GeneratorFromSeed(){
        
    }

    private void Connector(/*position for starting the path, path number, number for counting*/)
    {
        

    }

    //private void GenetateTutorial(){

    //}

    /*
    []     []
    [][]=[][]   los = son puertas
    [][]=[][]
    []    "[]  " es un boton
    []

    se pueden hacer puertas que luego de x turnos se cierren (deben tener boton de ambos lados pa que funcione
    el team work) (tipo de trampa)

    el criterio para volver a empezar la construccion de conexiones es una habitacion que no este conectada y
    tenga al lado una conectada

    quizas pueda hacer que

    []     []    []     []
    [][]=[][]  o []     [] para que no siempre sea doble la puerta
    []     []    [][]=[][]
    []     []    []     []

    [P  desk
    [)  pantalla de terminal?

    buscando con Windows + .

    ⁅⁅⁆⁆¦¦‖⁑⁂⁗⁁⁜※⁋īīĳĹ↑↓↼⇀⇖■▣▦□▬▬▮○◔◑◕●◍◉◜◝◞◟◤◥◢◣◧◫◷◱◰◼◾◭◮ⅧⅮↇↂ
    
    []≔≕[] closed door
    []⁅  ⁆[] open door

     )  (
    (    )
    ※  ※

    quizas pueda hacer 
    los niveles en plan:
    
    -pared02              y asi puedo
    -pared01
    -piso
    [] o
    [] ‖
    []           
    []       o 
    [][][][]◟◞[][][][]??????


    miraver si encuentras como hacer que dos cosas ocurran en paralelo...
    */
}




    
