using System;
namespace Resourses.Logic
{
public class Cell
{
    private bool walkable;
    private TypeOfCell typeOfCell;

    //[i] constructors:
    
    public Cell(){
        //[i] empty or preset cell
        bool walkable = true;
        typeOfCell = TypeOfCell.presetFloor;

    }
    public Cell(TypeOfCell theTypeOfCell)
    {
        //revisar como crear celldas de n tipos
        typeOfCell = theTypeOfCell;

        if (typeOfCell == TypeOfCell.presetFloor)
        {
            bool walkable = true;            
        }
        if (typeOfCell == TypeOfCell.presetWall)
        {
            bool walkable = false;
        }
    }

        //[i] methods for extracting information:
        public bool isWalkable() => walkable;
        public TypeOfCell getTypeOfCell() => typeOfCell;
    

    public static void Testing() => Console.WriteLine("- Cell loaded correctly");

    //[i] resourses for making the cells work properly

    public enum TypeOfCell
    {
        presetFloor,  //0
        presetWall,   //1
        presetDoor    //2
    }

    //Q do I need some kind of private class for making the cells work...
}
}    
