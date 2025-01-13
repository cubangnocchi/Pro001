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
        //this could be eliminated...
        //...read all the coments
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
        switch (type)
        {
            case Type.Tutorial : 
                BuildTutorial();
                break;
            case Type.FindPlayer : 
                BuildFindPlayer();
                break;
            case Type.TeamWork : 
                BuildTeamWork();
                break;
            case Type.Standard : 
                Builder();    
                break;
        }
    }

    private void BuildTutorial()
    {
        //[i]-A litle maze with a how to play
        //    info and instrucions
    }
    private void BuildFindPlayer()
    {
        //[i]-A maze where due to the players position
        //    obstacules will be availabe to overcome 
        //    from bouth sides
        //
        // +-[Important]-----------------------------------[x]-+
        // | [!]-Notice that maybe this could be generaliced   |
        // |     without the need of specific builders, by     |
        // |     knowing if they start near or separated.      |   
        // |     And also by finding where the lee numbers are |
        // |     ecual, so from that coincidences team work    |
        // |     obstacules may be placed.                     |
        // +---------------------------------------------------+
        //...
        //if player 1 -> [room] <- p 2
        //--... 

        //remembeeeeeeeerrrrrr




        //the exit have a hard team work puzle
    }
    private void BuildTeamWork()
    {

    }
    private void Builder()
    {

    }

    
}