using System;
using System.Diagnostics;
namespace Resourses.Logic;
public partial class MapObject : MazePos
{
    #region Parameters
    
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

    #endregion
    #region Constructors

    //[i] constructors: 
    public MapObject(int [] thePosition, Actions[] theActions, TypeOfObject theTypeOfObject) : base(thePosition)
    {
        this.actions = theActions;
        this.typeOfObject = theTypeOfObject;

        //metadata
        
        for(int i = 0; i < actions.Length; i++)
        {

        }
    }
        
    #endregion
    #region get/set
    //[i] methods for extracting information:
    
    //map objects maybe should be somehow above cells in visual and change cells properties...
    //like the door changes the walkable of a wall and a desk "[P" the same of ...
    public Actions[] GetActions()
    {
        return actions;
    }

    public Actions GetAction(int index)
    {
        return actions[index];
    }

    public TypeOfObject GetTheType() => typeOfObject;

    public int[] IndexOfInteractiveActions()
    {
        List<int> indexList = new List<int>{};
        
        for (int i = 0; i < actions.Length; i++)
        {
            if(actions[i].CanPLayerInteract())
            {
                indexList.Add(i);
            }
        }

        return indexList.ToArray();
    }
    public bool IsInteractive()
    {
        foreach (Actions act in actions)
        {
            if(act.CanPLayerInteract()) return true;
        }        
        return false;
    }
    #endregion

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

