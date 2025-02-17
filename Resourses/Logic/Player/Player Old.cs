namespace Resourses.Logic;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using Tools;
/*
public class Player
{
    //[i]-Parameters
    string name;
    int energy;
    int cellRow;
    int cellCol;


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
        this.mazeRoomPos = [0, 0];
    }
    public Player(string theName, int theMapRow, int theMapCol)
    {
        this.name = theName;
        this.mazeRoomPos = [theMapRow, theMapCol];
    }

    //[i]-Get parameters
    public string GetName() => this.name;
    public int[] GetRoomCellPos() => [this.cellRow, this.cellCol];
    public int GetCellRow() => this.cellRow;
    public int GetCellCol() => this.cellCol;
    public int[] GetMazeRoomPos() => this.mazeRoomPos;
    public int[] GetPosition() => [mazeRoomPos[0], mazeRoomPos[1], cellRow, cellCol];


    //[i]-Set parameters

    public void SetName(string theName) => this.name = theName;
    public void SetCellPos(int theRow, int theCol)
    {
        SetCellRow(theRow); SetCellCol(theCol);
    }
    public void SetCellRow(int theRow) => this.cellRow = theRow;
    public void SetCellCol(int theCol) => this.cellCol = theCol;

    public void SetRoomPos(int theRow, int theCol) => this.mazeRoomPos = [theRow, theCol];

    public void SetPosition(int[] position)
    {
        SetRoomPos(position[0], position[1]);
        SetCellPos(position[2], position[3]);
        
    }
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

        Direction wsad = new();
        int[] dir = wsad.GetDir(theDir);
        int roomSize = maze.GetRoom(this.mazeRoomPos).GetSize();

        if (TL.PosStepInRange([cellRow, cellCol], roomSize, roomSize, theDir))
        {

            bool a = maze.GetRoom(mazeRoomPos).GetCell(TL.PosStep([cellRow, cellCol], theDir)).isWalkable();

            if (a)
            {

                this.cellRow += dir[0];
                this.cellCol += dir[1];
            }
        }
        else if (TL.PosStepInRange(mazeRoomPos, maze.GetSize()[0], maze.GetSize()[1], theDir))
        {

            int[] newRoomPos = TL.PosStep(mazeRoomPos, theDir);
            int[] newCellPos = TL.PosStepOutside(new int[] { cellRow, cellCol }, new int[] { roomSize, roomSize }, theDir);


            if (maze.GetRoom(TL.PosStep(mazeRoomPos, theDir)).GetCell
               (TL.PosStepOutside([cellRow, cellCol], [roomSize, roomSize], theDir)).isWalkable())
            {


                mazeRoomPos = TL.PosStep(mazeRoomPos, theDir);
                cellRow = TL.PosStepOutside([cellRow, cellCol], [roomSize, roomSize], theDir)[0];
                cellCol = TL.PosStepOutside([cellRow, cellCol], [roomSize, roomSize], theDir)[1];
            }
        }
    }


}
*/