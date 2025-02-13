using System;
using System.Runtime.InteropServices;
using Colorful;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    //[i] - WSAD... ah... this no look gut :'c
    Direction wsad = new();
    
    //[i] - Here I will put all the methods nessesary for
    //      for starting to build the maze.

    public void Create(Type type)
    {
        BuildMazeLogic();
        Builder(type);
    }

    //[i] - First stage of the building process
    //      Here I create "logic" rooms, connections
    //      starting points and int[,] Lee for 
    //      placing MapObjects

    public void BuildMazeLogic()
    {
        PathMaker([0,0]);
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

        if(TL.ArrEqual(startPos, nextPos))
        {
            // + + + rememer that next starting pos is con 
            //       near to uncon
            nextPos = ConNearUnconRoomPos();
            if(!TL.ArrEqual(nextPos, [-1,-1])) PathMaker(nextPos);
        }
        else
        {
            Connecter(startPos, dir.GetInt(randNearStep));
            PathMaker(nextPos);
        }

    }

    private int[] ConNearUnconRoomPos()
    {


        for(int i = 0; i < mazeRooms.GetLength(0); i++)
        {
            for(int j = 0; j < mazeRooms.GetLength(1); j++)
            {
                int[] unconArr = UnconRoom_DirStep([i,j]);
                
                if(mazeRooms[i,j].IsConnected() && !TL.ArrEqual( unconArr,[0,0,0,0,0,0,0,0])) //usa el m'etodo que vas a crear en tools
                {
                    return [i,j];
                }
            }
        }

        return [-1,-1];
        
    }

    public int[] UnconRoom_DirStep(int[] pos)
    {
        //System.Console.WriteLine("UnconRoom_DirStep debug");
        //System.Console.WriteLine(" ");

        Direction wsad = new();
        //method for geting the DirStep of near
        //unconected rooms
        int[] exit = wsad.GetDirsArr();

        //System.Console.WriteLine("pos = ["+ pos[0] + ", " + pos[1] +"] exit = ["+ exit[0] + ", " + pos[1] + "]");
        //System.Console.WriteLine(" ");

        //each i value is a wsad direction
        for(int i = 0; i < 4; i++)
        {
            //get the position of an step
            int[] newPos = TL.PosStep(pos, i);

            //System.Console.WriteLine("i = "+ i +" newPos = [" + newPos[0]  + ", " + newPos[1] +"]");           

            //checks if the position dont exits or is connected
            if(TL.PosStepInRange(pos, mazeRooms.GetLength(0), mazeRooms.GetLength(1), i))
            {
                //System.Console.WriteLine("position exist");
                

                if(mazeRooms[newPos[0], newPos[1]].IsConnected())
                {
                    //System.Console.WriteLine("is connected");

                    exit[i*2] = 0;
                    exit[(i*2)+1] = 0;

                }
                
                //the step in that direction will be 0,0
                
            }
            else
            {
                //System.Console.WriteLine("position dont exist");
                exit[i*2] = 0;
                exit[(i*2)+1] = 0;
            }
            //System.Console.WriteLine(" ");

        }
        
        return exit;
    }

    private int[] RandNearUnconnected_DirStep(int[] pos)
    {

        
        

        int[] optionsDir = UnconRoom_DirStep(pos);
        int optionsNum = 4 - TL.CountArrInArrFixed(optionsDir, [0,0]);

        //System.Console.WriteLine("debug RandNearUnconnected_DirStep");
        //System.Console.WriteLine("optionsNum = " + optionsNum);

        //System.Console.WriteLine("optionsDir = {[" + optionsDir[0] + ", " + optionsDir[1] + "]");
        //System.Console.WriteLine("              [" + optionsDir[2] + ", " + optionsDir[3] + "]");
        //System.Console.WriteLine("              [" + optionsDir[4] + ", " + optionsDir[5] + "]");
        //System.Console.WriteLine("              [" + optionsDir[6] + ", " + optionsDir[7] + "]}");
        //System.Console.WriteLine(" ");
        
                                 
        
        int dice = new Random().Next(0, optionsNum);
        //System.Console.WriteLine("dice = " + dice);
        // + + here there are a lot of unnecessary things...
        int unnecessaryCounter = 0;
        //System.Console.WriteLine(" ");
        //System.Console.WriteLine("random selection for()");
        for(int i = 0; i < 4; i++)
        {
            //System.Console.WriteLine("i =" + i);
            // + + 
            if(!(optionsDir[i*2] == 0 && optionsDir[(i*2)+1] == 0))
            {
                if(unnecessaryCounter == dice)
                {
                    return [optionsDir[i*2],optionsDir[(i*2)+1]];
                }
                unnecessaryCounter++;
            }
        }

        return [0,0];

    }

    private void Connecter(int[] pos, int dirInt)
    {
        //System.Console.WriteLine(" ");
        //System.Console.WriteLine("debug Connecter");
        //System.Console.WriteLine(" ");
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
        if(dirInt%2 == 0)
        {
            mazeRooms[pos[0], pos[1]].Connect(dirInt+1);
        }
        else
        {
            mazeRooms[pos[0], pos[1]].Connect(dirInt-1);
        }

    }
}


