using System;
using System.Runtime.InteropServices;
using Colorful;
using Spectre.Console.Rendering;
using Resourses.Tools;

namespace Resourses.Logic;
public class Maze
{
    //Cell[,] mazeCells; //maybe this should be changed by a room[,]
                       //consider only using Rooms as a tooll
                       //or maybe rooms makes easier the work for visual

    Room[,] mazeRooms;
    LogicRoom[,] logicRooms;
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

    /*               +
                     +
                     +
    + + + Room ahora es otra clase... + + +
                     +
                     +
                     +
    
    */

    public Maze(string theName, int rows, int cols, int roomSize){
        mazeRooms = new Room[rows,cols];
        logicRooms = new LogicRoom[rows,cols];
        name = theName;
        Generator(rows, cols, roomSize);
        
    }
    public Maze(string theName, int size, int roomSize): this(theName, size, size, roomSize)
    {
        //creates an scuare maze
    }
    
    /*public Maze(string theName, int width, int height, string theSeed){
        mazeCells = new Cell[width, height];
        name = theName;
        seed = theSeed;
        GeneratorFromSeed();
    }*/

    public Maze()
    {
        TestMazeGenerator();
    }

    //[i] get parameters methods

    public Room GetRoom(int i, int j) => this.mazeRooms[i, j];

    public static void Testing() => System.Console.WriteLine("- Maze loaded correctly");
    
    //[i] maze generation methods:

    private void Generator(int width, int height, int roomSize){

        //prepare the Rooms
        for(int i = 0; i<width; i++)
        {
            for(int j = 0; j< height; j++)
            {
                this.mazeRooms[i,j] = new Room(roomSize);
            }

        }
        /*for(int i=0; i<10 (mazeRooms.GetLength(1)*mazeRooms.GetLength(2)); i++)
        {
            //acá va el metodo de hacer recorridos conectando habitaciones y modificándolas
            
            //valora el sumarle obstáculos
        }
        */
        //prueba hacerlo recurcivo jeje... (iterarlo sale mejor jiji...?)
        int[,] connectedRoomsPosition = new int[width,height];
        PathMaker(0,0, (width*height));        
        
    }

    private void TestMazeGenerator()
    {
        Room walled = new Room(3);
        LogicRoom logicRoom = new LogicRoom();
        walled.Create(logicRoom);
        this.mazeRooms = new Room[5,5];

        for(int i = 0; i < 5; i++)
        {
            for (int j = 0; j<5; i++)
            {
                if(i == 0 || i == 5 || j == 0 || j == 5)
                {
                    this.mazeRooms[i,j] = walled;
                }
            }
        }

        
    }
    private void GeneratorFromSeed()
    {
        
    }
    

    //revisa bien lo de los nombres...
    private void PathMaker()
    {

    }

    private void PathMaker(int row, int col, int counter) //reviiiiisa los apuuuntes -_-# //path number
    {

        Direction direction = new Direction();

        if(counter != 0)
        {
            logicRooms[row,col].Connect();

            if(ExistUnconnectedCloseRoom(row, col))
            {
                bool[] closeRooms = UnconnectedCloseRooms(row, col);
                int howManyTrues = HowManyTrues(closeRooms);

                Random random = new Random();
                int option = random.Next(0, howManyTrues);


                int j = 0;
                for(int i = 0; i<4; i++)
                {
                    if(j==howManyTrues)
                    {
                        
                        int[] dir = NumberToDirection(i);

                        //make some modifications to the rooms
                        //for making posible the connection
                        //like taking down some walls, you know..
                        //remember the mapObject thing..

                        //temporal room change for litle rooms in
                        //testing prosses...
                        
                        //----change walls of bouth------
                        //logicRooms[row,col]
                        //mazeRooms[row,col].Create();

                        //recursive proces
                        PathMaker(row+dir[0],col+dir[1],counter-1);

                        //+++++ array de direccioneeee
                        //for(...i<4)
                        //  ... (qeu avance de dos en dos)


                    }
                    if(closeRooms[i]) j++;
                    
                }

            }
            else
            {

            }
        }
        


    }
    /*                   +
                         +
                         +
                         +
    + + + + hazte un array de rireccioneeeeeee!!!! + + +
                         +
    + + + + usa lee para saber donde colocar objetos jejejejej + + +
                         +
                         +
                         +
                         +
    asi te quitas asumirlas todo el tiempo ._.
    es muyyyyyyyyyyy tedioooooso
    ah!
    
    */
    private int[] NumberToDirection(int num)
    {
        if(num == 0)
        {
            return [-1,0];
        }
        if(num == 1)
        {
            return [0,-1];
        }
        if(num == 2)
        {
            return [+1,0];
        }
        if(num == 3)
        {
            return [0,+1];
        }
        return [0,0];
        
        
    }

    private int HowManyTrues(bool[] bools)
    {
        int counter = 0;
        for(int i = 0; i < bools.Length; i++)
        {
            if(bools[i])
            {
                counter++;
            }            
        }
        return counter;
        
    }

    private bool[] UnconnectedCloseRooms(int row, int col)
    {
        bool[] closeRooms = [false, false, false, false]; 
        
        if (row - 1 >= 0)
        {
            closeRooms[0] = !logicRooms[row -1, col].IsConnected();
        }
        if (col - 1 >= 0)
        {
            closeRooms[1] = !logicRooms[row, col -1].IsConnected();
        }
        if (row + 1 <= logicRooms.GetLength(0))
        {
            closeRooms[2] = !logicRooms[row + 1, col].IsConnected();

        }
        if (col + 1 <= logicRooms.GetLength(1))
        {
            closeRooms[3] = !logicRooms[row, col + 1].IsConnected();
        }
        
        return closeRooms;
    }
    private bool ExistUnconnectedCloseRoom(int i, int j)
    {
        bool[] closeRooms = UnconnectedCloseRooms(i,j);
        for(int k = 0; k < 4; k++)
        {
            if(closeRooms[k])
            {
                return true;
            }
        }
        return false;
        
    }


    private int[] ConnectedCloseToUnconnected()
    {
        for (int i = 0; i < logicRooms.GetLength(0); i++)
        {
            for (int j = 0; j < logicRooms.GetLength(0); j++)
            {
                if (logicRooms[i, j].IsConnected())
                {                    
                    if(ExistUnconnectedCloseRoom(i, j))
                    {
                        return [i,j];
                    }
                }

            }
        }
        return[0,0];
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




    
