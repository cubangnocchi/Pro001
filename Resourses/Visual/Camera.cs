using System;
namespace Resourses.Visual;
public class Camera{

    /**  
       The idea of this class is to have all the methods nessesary for generating
    an image for the player to see what his sharacter can see.  I will start with
    a 2D senital vew of the maze but at the end if I have enough time I will make
    a 3d one.
    **/ 
    public static void Testing() => Console.WriteLine("- Camera loaded correctly"); //boberia xD

    //--------------------[i]-Here the methods for Map based vew-----------------------------------------------------------------

    public static Image AllMapFixed()
    {
        return new Image(1,1);//pa que no de error xd????
    }
    // public static Image RayTracedVewInMap(){}

    public static Image AllMap(int x, int y)
    {
        //for vewing all the map but changin map position instead of the player
        return new Image(1,1);
    }
    

    //---------------------[i]-Here the methods for Room based vew-----------------------------------------------------------------

    //[!]-remember also thinking in beag rooms formed of some rooms... 
    public static Image RoomAll()
    {
        return new Image(1,1);
    }

    /*public static Image AllMap(int x, int y)
    {
        //for vewing all the map but changin map position instead of the player
    }
    */

    // public static Image RayTracedVewInMap(){}
    // public static Image RayTracedVewInRoom(){}
}
    
