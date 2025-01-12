namespace Resourses.Logic;

/*
busca como chucha se creó el "public partial class"
*/

    
public class LogicRoom
{
    //Cell[,] roomCells; //maybe this should be a task of the Maze to transalate rooms to cells? 
                         //maybe the trabslation proceso most be in hands of this class?
                         //              from Room to cell's....
                         //what if I dont need cels ._. uh... 
    //TypeOfRoom typeOfRoom; 
    bool leftWall;
    bool rightWall;
    bool upWall;
    bool downWall;

    bool connected;


    //[i]-remember this ones are for building the maze... 
    //maybe this should be saved by the maze? 
    int route;
    int path;

    //[i]-Constructors
    public LogicRoom(bool leftWall, bool rightWall, bool upWall, bool downWall)
    {
        this.leftWall = leftWall;
        this.rightWall = rightWall;
        this.upWall = upWall;
        this.downWall = downWall;
        this.connected = false;
    }
    public LogicRoom():this(true, true, true, true)
    {
        //create a closed room
    }
    
    //[i]-Get parameters
    public bool IsConnected() => connected;
    public bool IsLeftWall() => leftWall;
    public bool IsRightWall() => rightWall;
    public bool IsUpWall() => upWall;
    public bool IsDownWall() => downWall;
    //[i]-Change parameters
    public void Connect()
    {
        connected = true;
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






    
