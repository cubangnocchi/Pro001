using System;
using System.Runtime.InteropServices;
using Colorful;
using Spectre.Console.Rendering;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    public enum Type
    {
        Tutorial,
        FindPlayer,
        TeamWork,
        Standard
    }
    //[i] - Here I will put all the methods nessesary for
    //      for building the maze.

    //[i] - First stage of the building process
    //      Here I create "logic" rooms, connections
    //      starting points and int[,] Lee for 
    //      placing MapObjects

    //[i] - Second stage of the building
    //      process. Here the room cels are 
    //      added and the MapObjects
    //-------------------------------------

    private void Builder (Type type)
    {
        switch(type)
        {
            Type.Tutorial : BuildTutorial()
            Type.FindPlayer : BuildFindPlayer()
            Type.TeamWork : BuildTeamWork()
            Type.Standart : Build()

        }

    }

    private void BuildTutorial()
    {
        
    }
    private void BuildFindPlayer()
    {

    }
    private void BuildTeamWork()
    {

    }
    private void Builder()
    {

    }

    
}