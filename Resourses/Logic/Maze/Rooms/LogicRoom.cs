using System;
using Resourses.Tools;

namespace Resourses.Logic;

/*
busca como chucha se creó el "public partial class"
*/

    
public partial class Room
{
    //Cell[,] roomCells; //maybe this should be a task of the Maze to transalate rooms to cells? 
                         //maybe the trabslation proceso most be in hands of this class?
                         //              from Room to cell's....
                         //what if I dont need cels ._. uh... 
    //TypeOfRoom typeOfRoom; 
    bool[] walls = new bool[4];
    bool[] connected = new bool[4];


    //[i]-remember this ones are for building the maze... 
    //maybe this should be saved by the maze? 
    //int route;
    //int path;  //this should be changed becouse of lee...

    //[i]-Constructors

    // -- for now logic constructors are not used 
    

    
    //[i]-Get parameters

    public bool IsConnected()
    {
        for(int i = 0; i < 4; i++)
        {
            if (connected[i])
            {
                return true;
            }
        }
        return false;
    }

    public bool IsConnected(int n)
    {
        return connected[n];
    }

    public int[] ConnectedDirections()
    {
        
        int[] output = [-1];
        for (int i = 0; i < connected.Length; i++)
        {
            if(connected[i])
            {
                
                if(TL.ArrEqual(output, [-1]))
                {
                    output = [i];
                }
                else
                {
                    output = TL.ConcatenateArrays(output, [i]);
                }

            }
        }
        return output.ToArray();

    }

    
    
    //[i]-Change parameters
    public void Connect(int dir)
    {
        connected[dir] = true;     
    }
    public void Disconect(int dir)
    {       
        connected[dir] = false;
    }

    public void SetStartingLogicWalls(bool[] theWalls)
    {
        walls = theWalls;
        connected[0] = !theWalls[0];
        connected[1] = !theWalls[1];  
        connected[2] = !theWalls[2];  
        connected[3] = !theWalls[3];          
    }

    public void SetWall(int wallPos, bool wallBool)
    {
        if(wallBool == false) connected[wallPos] = true;
        walls[wallPos] = wallBool;
    }



    

    /*
    /*
    maybe I should add some kind of linked refference or something
    */
 

    //------Important!!!!! make separate the simple logical and the complex room like methods and all that----------------------------------------------------------------------------------------------
    //------this just if you decide to do bouth, the "boolean walls room" and the "Cell[,] room"
        
    //public LogicRoom(/*int theHeight, int theWidth,*/ bool theLeftWall, bool theRightWall, bool theUpWall, bool theDownWall)
    /*{
        //roomCells = new Cell[theHeight,theWidth];
        leftWall = theLeftWall;
        rightWall = theRightWall;
        upWall = theUpWall;
        downWall = theDownWall;
        //Build();        
    }*/
    
    //public LogicRoom(int size) : this(/*size, size,*/ true, true, true, true) 
    //{
        //This creates an scuare basic room//
    //}
    //public LogicRoom() : this(9)
    //{
        //This creates a preset room with 9x9 size
    //}
    
/*
    ***GetLength(dimencion)

    public enum TypeOfRoom
    {
        //            number    where it have wals
        Preset4Walls, //0           all walls
        Preset0Walls, //1           no walls
        Walls_L_R_U,  //2           left, right, up
        Walls_L_R_D,  //3           left, right, down
        Walls_R_U_D,  //4           right, up, down
        Walls_L_U_D,  //5           left, up, down
        Walls_R_L,
        Walls_U_D,
        Walls_
        
        
        is this necesary? maybe just with 4 bools will work
        

         

    }
*/



    /*
    private void Build() //use an enum later
    {
        
        //here I fill the center of the room...
        //I should make this more dynamic for different tamannos xD
        //creo que mejor que 5x5, 10x10... o Zudoku 9x9
        /*
        [][][][][][][][][][]
        []                []
        []                []
        []                []
        []                []
        []                []
        [] o              []
        []                []
        []                []
        [][][][][][][][][][]

        9x9

        [][][][][][][][][]
        []              []
        []              []
        []              []
        []              []
        []              []
        []              []
        []              []
        [][][][][][][][][]

        5x5

        [][]==[][]
        []      []
        ##      ||
        []      []
        [][]##[][]

        7*7

        [][][]==[][][]
        []          []
        [][)        []
        []      ()  ||
        []          []
        []          []
        [][][]##[][][]

        ## for fences?

        what about this for the floor...
        |_|_|_|_|_
        |_|_|_|_|_
        |_|_|_|_|_
        |-|-|-|-|-

        [][][][][][][]∷∷[][]
        [][P—¦[P—¦—¦—¦—¦—¦[]
        []—¦—¦—¦—¦—¦—¦—¦—¦[]
        []—¦—¦—¦—¦—¦—¦—¦—¦⁞⁞ <= fense
        []—¦—¦—¦—¦—¦—¦—¦—¦[]
        [][][][][][][][][][]

        ⩶⩵⫴⫶⫼⫽⫷⫴⫬≔≕≣⊞⊟⊡⊠⋮⋯⋰⋱ ▥▤◯Ŀʭ‖¯‾_—–

        ⁞⁞ ∷∷ ?
        
        */

        /*

        for(int i=0; i<roomCells.GetLength(0); i++)
        {
            for (int j=0; j<roomCells.GetLength(1);j++)
            {
                this.roomCells[i,j] = new Cell(Cell.TypeOfCell.presetFloor);
            }
        }
        if (leftWall)
        {
            SetWall(0, true);
        }
        if (rightWall)
        {

        }
        if (upWall)
        {

        }
        if(downWall)
        {

        }




    }

    private void SetWall(int position, bool isHorizontal)
    {
        if (isHorizontal)
        {
            for (int i=0;  i<roomCells.GetLength(1); i++)
            {
                //this.roomCells[position, i]  
                //crea un metodo para cambiar el tipo de celda
            }
        }
        else
        {
            for (int i=0; i<roomCells.GetLength(0); i++)
            {

            }
        }

    }
    

    */
    
}






    
