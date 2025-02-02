using System;
using System.Runtime.InteropServices;
using Resourses.Logic;
using Resourses.Tools;
using Resourses.Visual;
using Tx = Resourses.Visual.Textures;

namespace Resourses.Visual;






public class Camera{

    /*
    ++++++ textures are managed by textures ...
    */
    

    


    /**  
       The idea of this class is to have all the methods nessesary for generating
    an image for the player to see what his sharacter can see.  I will start with
    a 2D senital vew of the maze but at the end if I have enough time I will make
    a 3d one.

       Also create a constructor for making the kind of camera you need.. 
       you may need more kind of cameras...

       for now the Camera dont need instanses
    **/
    public static void Testing() => Console.WriteLine("- Camera loaded correctly"); //boberia xD

    //--------------------[i]-Here the methods for Map based vew-----------------------------------------------------------------
    
    // + + Tip: for full maze vew use room vew hehe...
    public static Image CameraTest(Maze maze)
    {
        Image exit = new Image(15,15);
        


        for (int i = 0; i<5; i++)
        {
            for(int j = 0; j<5; j++)
            {               
                exit = Image.AddLayer(exit, Camera.RoomAll(maze.GetRoom(i,j)), i*3, j*3);
                
                //this way I can add the Image of a room by
                //multiplying its position in the maze by 
                //the room size...
                //                    +
                //                    +
                // + + [!]-Task, generalize the solution + +
                //                    +
                //                    +
            }
        }

        return exit;


    }
    public static Image AllMapFixed(Maze maze)
    {
        int roomSize = maze.GetRoom(0,0).GetSize();
        Image output = new(maze.GetSize()[0]*roomSize,
                           maze.GetSize()[1]*roomSize);
        
        for(int i = 0; i < maze.GetSize()[0]; i++)
        {
            for(int j = 0; j < maze.GetSize()[1]; j++)
            {
                output = Image.AddLayer(output, Camera.RoomAll(maze.GetRoom(i,j)), i*roomSize, j*roomSize);
                output.Print();
            }
        }
        
        
        return output;
    }
    // public static Image RayTracedVewInMap(){}

    public static Image AllMap(int x, int y)
    {
        //for vewing all the map but changin map position instead of the player
        return new Image(1,1);
    }
    

    //---------------------[i]-Here the methods for Room based vew-----------------------------------------------------------------

    //[!]-remember also thinking in beag rooms formed of some rooms... 
    public static Image RoomAll(Room room)
    {        
        Image output = new(room.GetSize());
        
        Func<Tx.Txtr, Pixel> Txtr = Tx.GetTxtr;    

        for (int i = 0; i < room.GetSize(); i++)
        {
            for(int j = 0; j<room.GetSize(); j++)
            {
                if (room.GetCell(i, j).getTypeOfCell() == Cell.TypeOfCell.Wall) 
                {
                    output.SetPixel(i, j, Txtr(Tx.Txtr.wall));
                }
                else if (room.GetCell(i, j).getTypeOfCell() == Cell.TypeOfCell.Floor) 
                {
                    output.SetPixel(i, j, Txtr(Tx.Txtr.floor));
                }                

            }
        }
        
        return output;
    }

    // public static Image RayTracedVewInMap(){}
    // public static Image RayTracedVewInRoom(){}
}
    
