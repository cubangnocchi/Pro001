
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Resourses.Logic;

public class Player : MazePos
{
    //[i]-Parameters
    string name;
    byte energy;
    

    //Skill[] skils; ??
    //or should I make some kind of true/false array where 
    //each position is an skill :eyesEmote: :drop:
    //bool[] skills; ?...
    //some skills enum...
    //what skills could do maybe should be something for the
    //game manager...


    //[i]-Constructors

    public Player(string theName):base([0, 0, 1, 1])
    {

        this.name = theName;
        
    }
    public Player(string theName, int[] thePositon):base(thePositon)
    {

        this.name = theName;

    }

    public byte Energy { get => energy; set => energy = value; }
}
