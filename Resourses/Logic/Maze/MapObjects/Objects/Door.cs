using System;
using System.Diagnostics;
using Resourses.Tools;
namespace Resourses.Logic;
public class Door
{
    #region parameters
    TypeOfDoor typeOfDoor;
    MapObject[] doors;

    Actions[] mapObjecActions;

    public enum TypeOfDoor
    {
        CanOpen,
        CanOpenOneSide, //not implemented
        CantOpen,
        BrokenDoor, //not implemented
        PlankedUp, //not implemented

    }

    #endregion
    #region Constructor
 
    public Door(TypeOfDoor theTypeOfDoor, int[] doorPos, Cell cell)
    {
        this.doors = new MapObject[1];
        Actions act = DoorActionCreator(theTypeOfDoor, cell.SwitchWalkability);
        mapObjecActions = [act]; // just for no error with null value

        doors[0] = new MapObject(doorPos, [act], MapObject.TypeOfObject.Door);
    }

    public Door(TypeOfDoor theTypeOfDoor, int[] startPos, int[] endPos, Cell[] cells)
    {
        this.doors = new MapObject[2];
        Actions actStart = new(cells[0].SwitchWalkability, false);
        Actions actEnd = new(cells[1].SwitchWalkability, false);
        mapObjecActions = [actStart, actEnd];

        Actions doorAction = DoorActionCreator(theTypeOfDoor, ExecuteMapObjectActions);
        doors[0] = new MapObject(startPos, [doorAction], MapObject.TypeOfObject.Door);
        doors[1] = new MapObject(endPos, [doorAction], MapObject.TypeOfObject.Door);

    }

    private static Actions DoorActionCreator(TypeOfDoor theTypeOfDoor, Actions.ActionMethod action)
    {
        Actions act;

        if (theTypeOfDoor == TypeOfDoor.CanOpen)
        {
            act = new Actions(action, "open door");
        }
        else if (theTypeOfDoor == TypeOfDoor.CantOpen)
        {
            act = new Actions(action, false);
        }
        else
        {
            act = new Actions(action, "open door");
        }

        return act;

    }

    public void ExecuteMapObjectActions()
    {
        Actions.ExecuteArray(mapObjecActions);
    }
    
    #endregion
    #region Get/Set
    //[i]-Get/Set methods

    public MapObject[] GetDoors() => doors;
    
    #endregion

    // mira ver cómo chucha interactuar desde la Door global 




}

