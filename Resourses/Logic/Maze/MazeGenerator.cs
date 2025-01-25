using System;
using System.Runtime.InteropServices;
using Colorful;
using Spectre.Console.Rendering;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    //[i] - WSAD... ah... this no look gut :'c
    Direction wsad = new();
    
    //[i] - Here I will put all the methods nessesary for
    //      for building the maze.

    public void Build()
    {

    }

    //[i] - First stage of the building process
    //      Here I create "logic" rooms, connections
    //      starting points and int[,] Lee for 
    //      placing MapObjects

    public void BuildMazeLogic()
    {

    }

    private void PathMaker(int[] startPos)
    {
        //this ALL most be OPTIMIZED... what a maze XDDDDD...
        Direction dir = new(); //and this... I should have the 
                               //wsad as a class? how can I
                               //have an instanse of this available
                               //everywhere...
                               //lets see... WSAD as a parameter!!!!

        int[] randNearStep = RandNearUnconnected_DirStep(startPos);
        int[] nextPos = [startPos[0] + randNearStep[0], startPos[1] + randNearStep[1]];

        if(nextPos == startPos)
        {
            nextPos = UnconnectedRoomDir();
            if(nextPos[0] != -1 && nextPos[1] != -1) PathMaker(nextPos);
        }
        else
        {
            Connecter(startPos, dir.GetInt(randNearStep));
            PathMaker(nextPos);
        }

    }

    private int[] UnconnectedRoomDir()
    {
        for(int i = 0; i < mazeRooms.GetLength(0); i++)
        {
            for(int j = 0; j < mazeRooms.GetLength(1); j++)
            {
                if(mazeRooms[i,j].IsConnected())
                {
                    return [i,j];
                }
            }
        }

        return [-1,-1];
        
    }

    private int[] RandNearUnconnected_DirStep(int[] dir)
    {
        //return wsad dir int[] 
        //of the next room
        

        return [0,0];

    }

    private void Connecter(int[] pos, int dirInt)
    {
        //Excpt.InRange(0,3,dir); //esto debe estar en Directions.cs not here
        
        //connect the current room with the next one 
        mazeRooms[pos[0], pos[1]].Connect(dirInt);

        Direction wsad = new Direction();

        //gets next room dir...
        //[!]-Maybe this most be the other parameter of the
        //    method... the Dir up and down and all that
        //    just in the path maker...
        pos = [pos[0] + wsad.GetDir(dirInt)[0], pos[1] + wsad.GetDir(dirInt)[1]];        
        
        //connect next room in the oposit direction...
        //chechk math in Directions.cs preset wsad values...
        if(dirInt%2 != 0)
        {
            mazeRooms[pos[0], pos[1]].Connect(dirInt+1);
        }
        else
        {
            mazeRooms[pos[0], pos[1]].Connect(dirInt-1);
        }

    }

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

    }

    
}