using System;
using System.Diagnostics;
namespace Resourses.Logic;
public class Door
{
    TypeOfDoor typeOfDoor;
    MapObject[] doors;

    public enum TypeOfDoor
    {
        CanOpenAll,
        CanOpenInside,
        CantOpen,
        BrokenDoor,
        PlankedUp,

    }

    public Door(TypeOfDoor theTypeOfDoor, int[] StartRoomPos, int Dir)
    {
        int[] doorPos = DoorPosFromRoomPos(theConnectedRoomsPos);
        //+ + + + + + + + + 
        //+ + Recuerda que perfectamente lo puedes hacer con
        //+ + una dirección y pos de la Room y pan ya
        //+ + + + + + + + +
        //+ + 
    }

    public int[] DoorPosFromRoomPos(int[] RoomPos)
    { 
        int dy = RoomPos[1] - RoomPos[3];
        int dx = RoomPos[0] - RoomPos[2];
        if(dy < 0)
        {

        }
        if(dy > 0)
        {

        }
        if(dx )
        return [1];
    }


}
