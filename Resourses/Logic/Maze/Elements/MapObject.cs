using System;
namespace Resourses.Logic;
public class MapObject{
    //Q what parameters do I need....
    int[,] RoomPos;
    int[,] CellPos;

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


    

    //[i] constructors:
    public MapObject()
    {
        
    }     
        
    //[i] methods for extracting information:
    
    //map objects maybe should be somehow above cells in visual and change cells properties...
    //like the door changes the walkable of a wall and a desk "[P" the same of ...


    }
