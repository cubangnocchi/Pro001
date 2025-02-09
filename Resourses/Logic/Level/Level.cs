using System;
using System.Globalization;
using Resourses.Tools;
using Resourses.Visual;

namespace Resourses.Logic;

/// <summary>
/// This class manages the level's logic. 
/// Here are declared parameters, constructors and get/set methods. 
/// </summary>
partial class Level
{
    int levelNumber;
    Maze levelMaze;

    public Level(int theLevelNumber)
    {
        this.levelNumber = theLevelNumber;
        if(levelNumber == 0)
        {
            //make a tutorial level
        }
        else if(levelNumber == 1)
        {
            //find each other made by two mazes, a team work one conected to the find each other maze...
        }
        else if(levelNumber%5 == 0)
        {
            //something special... like a boss, nuclear reactor... something
        }
        else
        {
            //just a normal maze... with dificulty stablished by levelNumber? 
        }
    }
}