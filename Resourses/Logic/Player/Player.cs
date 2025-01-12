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
    }
    public Player(string theName, int theRow, int theCol)
    {
        this.name = theName;
        this.row = theRow;
        this.col = theCol;
    }

    //[i]-Get parameters
    public string GetName() =>  this.name;
    public int[] Position() => [this.row, this.col];
    public int  GetRow() => this.row;
    public  int GetCol() => this.col;


    //[i]-Set parameters

    public void SetName(string  theName) => this.name = theName;
    public void SetPosition(int  theRow, int theCol)
    {
        SetRow(theRow); SetCol(theCol);
    }
    public void SetRow(int theRow) => this.row = theRow;
    public void SetCol(int theCol)  => this.col = theCol;

    //[i]-Movement methods

    public void MoveUp()
    {
        this.row -= 1; 
    }
    public void MoveDown()
    {
        this.row += 1;
    }
    public void MoveLeft()
    {
        this.col -= 1;
    }
    public void MoveRight()
    {
        this.col += 1;
    }


}
