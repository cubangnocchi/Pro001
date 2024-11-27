namespace Resourses.Logic;

/*
busca como chucha se creó el "public partial class"
*/

    
public class Room
{
    Cell[,] roomCells;
        
    public Room(int roomType)
    {
        SetTypeOfRoom(roomType);
    }

    private void SetTypeOfRoom(int roomType) //use an enum later
    {
        roomCells= new Cell[5,5];
        //here I fill
        for(int i=1; i<5; i++)
        {
            for (int j=1; j<5;j++)
            {
                this.roomCells[i,j] = new Cell(Cell.TypeOf.presetFloor);
            }
        }
        
        if (roomType == 0)
        {
            //run with a for 
            
        }


    }

    private void SetWall(int wallType)
    {

    }

    enum TypeOfRoom
    {

    } 
}





    
