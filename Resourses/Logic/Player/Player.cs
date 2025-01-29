namespace Resourses.Logic;
using System;
using System.Collections.Generic;
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

    public void MoveUp(Maze maze)
    {
        //maybe this all should be in thre game manager...
        
        if(row == 0 && mazeRoomPos[0] != 0)
        {
            mazeRoomPos[0] --;
            row = maze.GetRoom(mazeRoomPos[0],mazeRoomPos[1]).GetSize() - 1;
        }
        else if(row != 0)
        {
            this.row -= 1; 
        }
    }
    public void MoveDown(Maze maze)
    {
        if(row == maze.GetRoom(mazeRoomPos[0],mazeRoomPos[1]).GetSize() - 1)
        {


        }
        {
            this.row += 1;
        }
        
    }
    public void MoveLeft(Maze maze)
    {
        this.col -= 1;
    }
    public void MoveRight(Maze maze)
    {
        this.col += 1;
    }


}
