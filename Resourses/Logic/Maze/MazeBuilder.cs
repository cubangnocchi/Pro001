using System;
using System.Runtime.InteropServices;
using Colorful;
using Spectre.Console.Rendering;
using Resourses.Tools;

namespace Resourses.Logic;

public partial class Maze
{
    //[i] - Second stage of the building
    //      process. Here the room cels are 
    //      added and the MapObjects
    //-------------------------------------

    public enum Type
    {
        //this could be eliminated...
        //...read all the coments
        Tutorial,
        FindPlayer,
        TeamWork,
        Standard
    }

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
        //standard maze builder

        for(int i = 0; i < mazeRooms.GetLength(0); i++)
        {
            for(int j = 0; j < mazeRooms.GetLength(1); j++)
            {
                //build the rooms 
                System.Console.WriteLine(" ");
                System.Console.WriteLine($"Building room {i},{j}");
                mazeRooms[i,j].Build();
            }
        }
            
    }

    
}