
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Resourses.Logic;

public class Player : MazeObject
{
    //[i]-Parameters
    string name;
    int energy;
    

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
        this.position = new int[] { 0, 0, 1, 1 };
        

    }
    public Player(string theName, int[] thePositon)
    {
        this.name = theName;
         
        this.position = thePositon;
        MazeObject mazeObject = new MazeObject(this.position);

        MazeObject mazeObject = new MazeObject(this.position);

    }

    
    

}
