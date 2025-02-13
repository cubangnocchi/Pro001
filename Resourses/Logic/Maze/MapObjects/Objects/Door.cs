using System;
using System.Diagnostics;
namespace Resourses.Logic;
public class Door : MapObject
{
    TypeOfDoor typeOfDoor;

    public enum TypeOfDoor
    {
        CanOpenAll,
        CanOpenInside,
        CantOpen,
        BrokenDoor,
        PlankedUp,

    }

    public Door(TypeOfDoor theTypeOfDoor, int[] theConnectedRoomsPos)
    {
        
    }
}
