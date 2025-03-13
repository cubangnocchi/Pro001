using System;
using System.Diagnostics;
namespace Resourses.Logic;
public partial class MapObject : MazePos
{
    
    Actions[] actions;
    TypeOfObject typeOfObject;
 
    public enum TypeOfObject
    {
        Door,
        Box,
        Button,
        Fence,
        Stairs, 
    };

    //[i] constructors: 
    public MapObject(int [] thePosition, Actions[] theActions, TypeOfObject theTypeOfObject) : base(thePosition)
    {
        this.actions = theActions;
        this.typeOfObject = theTypeOfObject;
    }
        
    //[i] methods for extracting information:
    
    //map objects maybe should be somehow above cells in visual and change cells properties...
    //like the door changes the walkable of a wall and a desk "[P" the same of ...


}

//Actions[] actions;

    //positon sytsem example:

    //{[0,0], 
    // [1,0]}

    //{[5,7], in room 0,0
    // [5,0]} in room 1,0

    //Maze must have an organized array of MapObjects
    //for making easier the search...

    //and rooms must have a bool haveMapObject to ask it self if 
    //a map object needs to be searched

    //interactions most be added as an Interactios[]? 
    //in that way I must organize interactions that are available or not 
    //to the player by relating the interactions to a 
    //bool[] "theName for saying that the player can interact ah"

    //interactions most have names for contextual text...
    //make at once the text box

    //need of an enum TypeOf
