using System;
namespace Resourses.Logic{
public class Maze
{
    Cell[,] maze;
    string name; 
    int seed;

    public Maze(string theName, int width, int height){
        maze= new Cell[width, height];
        name = theName;
        Generator();
    }
    public Maze(string theName, int width, int height, int theSeed){
        maze= new Cell[width, height];
        name = theName;
        seed = theSeed;
        GeneratorFromSeed();
    }

    public static void Testing() => Console.WriteLine("- Maze loaded correctly");
    
    //[i] maze generation methods:

    private void Generator(){        

    }
    private void GeneratorFromSeed(){
        

    }
    //private void GenetateTutorial(){

    //}
}

}

    
