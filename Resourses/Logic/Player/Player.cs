namespace Resourses.Logic;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using Tools;

public class Player
{
    //[i]-Parameters
    string name;
    int energy;
    int[] position;

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
        this.position = [0, 0, 1, 1];
    }
    public Player(string theName, int[] thePositon)
    {
        this.name = theName;
        this.position = thePositon;
    }

    //[i]-Get parameters
    public int[] GetPosition() => position; 
    public int[] GetRoomPos() => [position[0], position[1]];
    public int[] GetCellPos() => [position[2], position[3]];
    

    //[i]-Set parameters
    public void SetPosition(int[] thePos) => position = thePos;
    public void SetRoomPos(int[] theRoomPos)
    {
        position[0] = theRoomPos[0];
        position[1] = theRoomPos[1];
    }
    public void SetCellPos(int[] theCellPos)
    {
        position[2] = theCellPos[0];
        position[3] = theCellPos[1];
    }
    

}
