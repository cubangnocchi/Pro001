using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
namespace PRO001;

class MiniTest
{
    

    public static void Run()
    {
      
        GeneratedMaze001();
        
        
        
    }

    

    public static void GeneratedMaze001()
    {
        Maze maze = new(4, 7);
        maze.Create(Maze.Type.Standard);

        Camera.AllMapFixed(maze).Print();

    }
    
    public static void PaintingRooms()
    {
        int[,] metaRoom = new int[5,5];
        //metaRoom = 
        Room room = new();
    }
    

    public static void GeneratedMaze()
    {

    }

}