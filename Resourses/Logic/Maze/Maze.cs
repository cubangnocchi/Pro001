using System;
using System.Runtime.InteropServices;
using Colorful;
using Spectre.Console.Rendering;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    //Cell[,] mazeCells; //maybe this should be changed by a room[,]
                       //consider only using Rooms as a tooll
                       //or maybe rooms makes easier the work for visual

    Room[,] mazeRooms;
    List<MapObject> mapObjects = new List<MapObject>{};
    //string name; 
    //string seed;

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

    

    public Maze(int rows, int cols, int roomSize)
    {
        mazeRooms = new Room[rows,cols];

        for(int i = 0; i < rows; i++)
        {
           for (int j = 0; j < cols; j++)
           {
               mazeRooms[i,j] = new Room(roomSize);
           }
        }

        
    }
    public Maze( int size, int roomSize): this(size, size, roomSize)
    {
        //creates an scuare maze
    }
    
    /*public Maze(string theName, int width, int height, string theSeed){
        mazeCells = new Cell[width, height];
        name = theName;
        seed = theSeed;
        GeneratorFromSeed();
    }*/

    
    //[i] get parameters methods


    public Room GetRoom(int i, int j) => this.mazeRooms[i, j];
    public Room GetRoom(int[] dir) => this.mazeRooms[dir[0], dir[1]];

    public static void Testing() => System.Console.WriteLine("- Maze loaded correctly");
    
    public int[] GetSize()
    {
        return [mazeRooms.GetLength(0), mazeRooms.GetLength(1)];
    }

    public MapObject[] GetMapObjects() => mapObjects.ToArray();


    //[i] MapObjects methods
    





    //revisa bien lo de los nombres...




/*
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
    + + + + hazte un array de direccioneeeeeee!!!! + + +
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

    /*
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

    ºπ a key 


    miraver si encuentras como hacer que dos cosas ocurran en paralelo...
    */
}






    
