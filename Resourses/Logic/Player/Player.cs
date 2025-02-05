namespace Resourses.Logic;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Tools;

public class Player
{
    //[i]-Parameters
    string name;
    int row;
    int col;


    int[] mazeRoomPos;

    //Skill[] skils; ??
    //or should I make some kind of true/false array where 
    //each position is an skill :eyesEmote: :drop:
    //bool[] skills; ?...
    //some skills enum...
    //what skills could do maybe should be something for the
    //game manager...


    //[i]-Constructors

    public Player(string theName)
    {
        this.name = theName;
        this.mazeRoomPos = [0,0];
    }
    public Player(string theName, int theMapRow, int theMapCol)
    {
        this.name = theName;
        this.mazeRoomPos = [theMapRow,theMapCol];
    }

    //[i]-Get parameters
    public string GetName() =>  this.name;
    public int[] Position() => [this.row, this.col];
    public int  GetRow() => this.row;
    public  int GetCol() => this.col;
    public int[] GetMazeRoomPos() => this.mazeRoomPos;


    //[i]-Set parameters

    public void SetName(string  theName) => this.name = theName;
    public void SetPosition(int  theRow, int theCol)
    {
        SetRow(theRow); SetCol(theCol);
    }
    public void SetRow(int theRow) => this.row = theRow;
    public void SetCol(int theCol) => this.col = theCol;

    public void SetRoom(int theRow, int theCol) => this.mazeRoomPos = [theRow,theCol];

    //[i]-Movement methods

    // + + + + + + [this info should be managed by something else]
    // + + + + + + partial class GameManager?
    public void MoveUp(Maze maze)
    {
        Move(0, maze);
    }
    public void MoveDown(Maze maze)
    {
        Move(1, maze);
    }
    public void MoveLeft(Maze maze)
    {
        Move(2, maze);
    }
    public void MoveRight(Maze maze)
    {
        Move(3, maze);
    }

    /// <summary> Move the player in the direction given by the int </summary>
    /// <param name="theDir">The direction to move in</param>
    /// <param name="maze">The maze to move in</param>
    /// <!--aaaa-->
    public void Move(int theDir, Maze maze)
    {
        /*
        System.Console.WriteLine("--- debuging Move ---");
        System.Console.WriteLine("Input theDir = " + theDir);
        System.Console.WriteLine("this.row and this.col = " + this.row + ", " + this.col);
        Console.WriteLine($"this.mazeRoomPos = [{mazeRoomPos[0]}, {mazeRoomPos[1]}]");
        Console.WriteLine(" ");
        */

        Direction wsad = new();
        int[] dir = wsad.GetDir(theDir);
        int roomSize = maze.GetRoom(this.mazeRoomPos).GetSize();
        //int roomSize = 7;

        /*
        Console.WriteLine("--- parameters to evaluate ---");
        Console.WriteLine($"dir = [{dir[0]}, {dir[1]}]");
        Console.WriteLine($"roomSize = {roomSize}");
        Console.WriteLine(" ");
        Console.WriteLine("--- parameters evaluation, first if( q && p) ---");
        Console.WriteLine("q = TL.PosStepInRange([row, col], roomSize, roomSize, theDir) = " + TL.PosStepInRange([row, col], roomSize, roomSize, theDir));
        Console.WriteLine(" ");
        */
        //Console.WriteLine("-- parameters evaluation, else if(r) --");
        //Console.WriteLine("r = TL.PosStepInRange(mazeRoomPos, maze.GetSize()[0], maze.GetSize()[1], theDir) = " + TL.PosStepInRange(mazeRoomPos, maze.GetSize()[0], maze.GetSize()[1], theDir));
        //Console.WriteLine("-- parameters evaluation, nested if(s) --");
        //Console.WriteLine("s = maze.GetRoom(TL.PosStep(mazeRoomPos, theDir)).GetCell(TL.PosStepOutside([row, col], [roomSize, roomSize], theDir)).isWalkable() = " + maze.GetRoom(TL.PosStep(mazeRoomPos, theDir)).GetCell(TL.PosStepOutside([row, col], [roomSize, roomSize], theDir)).isWalkable());
        Console.WriteLine(" ");

        if (TL.PosStepInRange([row, col], roomSize, roomSize, theDir))
        {
            //Console.WriteLine("p = maze.GetRoom(mazeRoomPos).GetCell(TL.PosStep([row, col], theDir)).isWalkable() = " + maze.GetRoom(mazeRoomPos).GetCell(TL.PosStep([row, col], theDir)).isWalkable());
            
            bool a = maze.GetRoom(mazeRoomPos).GetCell(TL.PosStep([row, col], theDir)).isWalkable();
            //Console.WriteLine("a = " + a);
            if(a)
            {
                //System.Console.WriteLine("aaaaaaaaaaaa movement in range");

                this.row += dir[0]; 
                this.col += dir[1];
            }
        }
        else if(TL.PosStepInRange(mazeRoomPos, maze.GetSize()[0], maze.GetSize()[1], theDir)  ) 
        {
            
            //System.Console.WriteLine("other room exist");
            //Console.WriteLine("--- parameters evaluation, nested if(s) ---");
            int[] newRoomPos = TL.PosStep(mazeRoomPos, theDir);
            int[] newCellPos = TL.PosStepOutside(new int[] { row, col }, new int[] { roomSize, roomSize }, theDir);
            //Console.WriteLine($"newRoomPos = [{newRoomPos[0]}, {newRoomPos[1]}]");
            //Console.WriteLine($"newCellPos = [{newCellPos[0]}, {newCellPos[1]}]");
            //Console.WriteLine($"isWalkable = {maze.GetRoom(newRoomPos).GetCell(newCellPos).isWalkable()}");
            
            if(maze.GetRoom(TL.PosStep(mazeRoomPos, theDir)).GetCell
               (TL.PosStepOutside([row, col], [roomSize, roomSize], theDir)).isWalkable())
            {
                //System.Console.WriteLine("movement out of range to an other room");


                mazeRoomPos = TL.PosStep(mazeRoomPos, theDir);
                row = TL.PosStepOutside([row, col], [roomSize, roomSize], theDir)[0];
                col = TL.PosStepOutside([row, col], [roomSize, roomSize], theDir)[1];
            }
        }
    }


}
