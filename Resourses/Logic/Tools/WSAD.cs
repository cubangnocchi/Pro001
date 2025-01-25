namespace Resourses.Tools;

//this is basically a copy of directions
//whem I learn how to use inheritance I will aply it... maybe
//lets see...

//ta mal XD ... problema con tema instancia y to eso... 
//static needed to work properly
public class WSAD
{
    MyEnum dirEnum = new MyEnum(['w','s','a','d']);

    string[] dirNames = ["w",
                         "s",
                         "a",
                         "d"];

    int[] directions = [ 1, 0,
                        -1, 0,
                         0,-1,
                         0, 1];

    int dimentions = 2;

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
        for(int i = 0; i < (directions.Length/dimentions); i++)
        {
            if(dir[0] == directions[i*dimentions] &&
               dir[1] == directions[(i*dimentions) + 1])
            {
                return i;
            }

        }

        return -1;

    }


    

}