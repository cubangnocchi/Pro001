using System;
namespace Resourses.Tools;

public class Direction
{
    //[i]-Parameters
    string[] dirNames;
    MyEnum dirEnum;
    //mira a ver como usar esto como Enum..
    //busca como funciona un diccionario, je..
    int[] directions; 
    int dimentions;

    public Direction(string[] dirNames, int[] dir, int dimentions)
    {
        this.dirNames = dirNames;
        this.directions = dir;
        this.dimentions = dimentions;
        
    }

    public Direction(string[] dirNames, int dimentions)
    {
        //generar direcciones de cambios de a 1 a partir de
        //las dimenciones...
        //es como hacer un sistema generador!
        if (dirNames.Length % dimentions != 0)
        {
            throw new ArgumentException("No valid parameters");
        }

        int[] dir = new int[dirNames.Length];

        for (int i = 0; i < dir.Length; i++)
        {
            //aaaaaaaaaaaaaaaa
            //*c enreda
            


        }
        //quizá para un sistema sencillo de desplazamiento 1
        //al que el escalar se le mete por fuera....
        //con tener el número de dimenciones ya se tiene to...
        //para sistemas de direcciones más complejos ya usaré
        //el otro constructor...
    }

    //private 
    public Direction()
    {
        dirEnum = new MyEnum(['w','s','a','d']);

        dirNames = ["w",
                    "s",
                    "a",
                    "d"];

        directions = [ 1, 0,
                      -1, 0,
                       0,-1,
                       0, 1];

        dimentions = 2;

        /* creates pre set directions for clasic:

               [W]         
            [A][S][D]        
        
           as a 2D game maybe this will be the only one I will us hehe
        */        
    }

    //[i]-Get Parameters Methods
    public int[] GetDir(string dirName) 
    {
        //recive an string and them search its number  
        return GetDir(dirEnum.GetInt(dirName));
    }
    public int[] GetDir(char theChar)
    {
        //recive a char and them search its number  
        return GetDir(dirEnum.GetInt(theChar));

    }
    public int[] GetDir(int n)
    {
        int[] exit = new int[dimentions];

        for(int i = 0; i < dimentions; i++)
        {
            exit[i] = directions[n*dimentions + i];
        }
        
        
        return exit;
    }

    public int GetInt(int[] dir)
    {
        //Console.WriteLine(" ");
        //Console.WriteLine("GetInt debug");
        //Console.WriteLine("dir = [" + dir[0] + ", " + dir[1] + "]");
        for(int i = 0; i < (directions.Length/dimentions); i++)
        {
            if(dir[0] == directions[i*dimentions] &&
               dir[1] == directions[(i*dimentions) + 1])
            {
                Console.WriteLine("return " + i);
                return i;
            }

        }
        //Console.WriteLine("return " + -1);
        return -1;

    }

    public int[] GetDirsArr()
    {
        return directions;
    }


    //[i]-Set Parameters Methods

    //[i]-private methods

    

}