using System;
namespace Resourses.Logic;
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
        ChangeType(theTypeOfCell);
        
        //revisar como crear celldas de n tipos
        
    }

    //[i] methods for changing cell properties
    public void ChangeType(TypeOfCell theTypeOfCell)
    {
        typeOfCell = theTypeOfCell;

        if (typeOfCell == TypeOfCell.presetFloor)
        {
            walkable = true;            
        }
        if (typeOfCell == TypeOfCell.presetWall)
        {
            walkable = false;
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
        //presetDoor    //2 maybe this can be a Map object that interacts with its cell
        //maybe the door should be a map opject added to the wall cell that modifies it's properties
    }

    //Q do I need some kind of private class for making the cells work...
}

