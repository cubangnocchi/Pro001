using System;
namespace Resourses.Logic;
public class Cell
{
    private bool walkable;
    private TypeOf typeOfCell;

    //[i] constructors:
    
    public Cell(){
        //[i] empty or preset cell
        bool walkable = true;
        typeOfCell = TypeOf.presetFloor;

    }
    public Cell(TypeOf theTypeOfCell)
    {
        //revisar como crear celldas de n tipos
        typeOfCell = theTypeOfCell;

        if (typeOfCell == TypeOf.presetFloor)
        {
            bool walkable = true;            
        }
        if (typeOfCell == TypeOf.presetWall)
        {
            bool walkable = false;
        }
    }

        //[i] methods for extracting information:
        public bool isWalkable() => walkable;
        public TypeOf getTypeOfCell() => typeOfCell;
    

    public static void Testing() => Console.WriteLine("- Cell loaded correctly");

    //[i] resourses for making the cells work properly

    public enum TypeOf
    {
        presetFloor,  //0
        presetWall,   //1
        //presetDoor    //2 maybe this can be a Map object that interacts with its cell
    }

    //Q do I need some kind of private class for making the cells work...
}

