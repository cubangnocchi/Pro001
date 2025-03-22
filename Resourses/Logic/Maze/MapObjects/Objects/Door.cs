using System;
using System.Diagnostics;
using Resourses.Tools;
namespace Resourses.Logic;
public class Door
{
    TypeOfDoor typeOfDoor;
    MapObject[] doors;

    public enum TypeOfDoor
    {
        CanOpen, 
        CanOpenOneSide, //not implemented
        CantOpen,
        BrokenDoor, //not implemented
        PlankedUp, //not implemented

    }

        //int[][] doorPositoions = TwoDoorPosCalculation(StartRoomPos, dir, roomSize);
        
        //Actions[] actions = [new Action(),];

        // + + + + + + + + + + + + + ++ + + + + + + + + 
        // + + + + + + Esto debe hacerlo maze poeque hace falta info
        // + + + + + + de él...
        // + + + + + + + + + + + + + + + + + + + + + + + 
        // + + + + + + Si no hay que pasar mínimo dos Rooms ....
        //  + + + + + + + + + + + + + 
        // + + + + +  + aaaaaaahhhhhhh!!!!!!!!
        
        //doors = [new MapObject(doorPositoions[0]),
        //         new MapObject(doorPositoions[1])];

        //+ + + + + + + + + 
        //+ + Recuerda que perfectamente lo puedes hacer con
        //+ + una dirección y pos de la Room y pan ya
        //+ + + + + + + + +
        //+ + 
    public Door(TypeOfDoor theTypeOfDoor, int[] doorPos, Cell cell)
    {
        this.doors = new MapObject[1];
        Actions act = DoorActionCreator(theTypeOfDoor, cell.SwitchWalkability);
        
        
        doors[0] = new MapObject(doorPos, [act], MapObject.TypeOfObject.Door);
    }

    public Door(TypeOfDoor theTypeOfDoor, int[] startPos, int[] endPos, Cell[] cells)
    {
        this.doors = new MapObject[2];
        Actions actStart = DoorActionCreator(theTypeOfDoor, cells[0].SwitchWalkability);
        Actions actEnd = DoorActionCreator(theTypeOfDoor, cells[1].SwitchWalkability);
        
        doors[0] = new MapObject(startPos, [actStart], MapObject.TypeOfObject.Door);
        doors[1] = new MapObject(endPos, [actEnd], MapObject.TypeOfObject.Door);
    
    }

    private static Actions DoorActionCreator(TypeOfDoor theTypeOfDoor, Actions.ActionMethod action)
    {
        Actions act;

        if(theTypeOfDoor == TypeOfDoor.CanOpen)
        {
            act = new Actions(action, true);
        }
        else if(theTypeOfDoor == TypeOfDoor.CantOpen)
        {
            act = new Actions(action, false);
        }
        else
        {
            act = new Actions(action, true);
        }

        return act;

    } 

    //[i]-Get/Set methods
    

    // mira ver cómo chucha interactuar desde la Door global 

    


}
