using System;
namespace Resourses.Visual;

public class Image
{
    //[i]-Parameters
    private Pixel[,] pixels;

    //[i]-Constructors
    public Image(int height, int width)
    {
        pixels = new Pixel[height, width];

        for (int y =  0; y  < height; y++)
        {
            for (int x = 0; x  < width; x++)
            {
                pixels[y, x] = new Pixel();

            }
        }
    }

    public Image(int size) : this(size, size)
    {
        //[i]-Creates an scuare image
    }
    
    //[i]-Acces to parameters
    public void SetPixel(int i, int j, Pixel thePixel)
    {
        this.pixels[i,j] = thePixel; 
    }
    public Pixel GetPixel(int i, int j){
        return pixels[i,j];
    }
    public int GetLength(int Dimention)
    {

        return (Dimention != 0 && Dimention !=1) ? -1 : pixels.GetLength(Dimention);

    }

    //[i]-Operations


    public void Print()
    {
        for(int i = 0; i < pixels.GetLength(0); i++)
        {
            Console.WriteLine("");
            for (int j = 0; j < pixels.GetLength(1); j++)
            {
                pixels[i,j].Print();
            }           

        }

    }
    public void Copy(Image a)
    {
        this.pixels = new Pixel[a.GetLength(0), a.GetLength(1)];

        for (int i = 0; i<a.GetLength(0); i++)
        {
            for(int j = 0; j<a.GetLength(1); j++)
            {
                this.pixels[i,j] = a.GetPixel(i, j);                                
            }
        }

    }
    public static Image CreateCopy(Image a)
    {
        Image b = new (a.GetLength(0), a.GetLength(1));
        /*
        Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
        at Resourses.Visual.Image..ctor(Int32 width, Int32 height) in F:\+++Programación+++\Pro001\Resourses\Visual\Image.cs:line 12
        at Resourses.Visual.Image.CreateCopy(Image a) in F:\+++Programación+++\Pro001\Resourses\Visual\Image.cs:line 65
        at Resourses.Visual.Image.AddLayer(Image a, Image b, Int32 col, Int32 row) in F:\+++Programación+++\Pro001\Resourses\Visual\Image.cs:line 82
        at Resourses.Visual.Camera.CameraTest(Maze maze) in F:\+++Programación+++\Pro001\Resourses\Visual\Camera.cs:line 51
        at PRO001.MiniTest.PreMadeMaze() in F:\+++Programación+++\Pro001\MiniTest.cs:line 53
        at PRO001.MiniTest.Run() in F:\+++Programación+++\Pro001\MiniTest.cs:line 36
        at Program.Main(String[] args) in F:\+++Programación+++\Pro001\Program.cs:line 12
        */

        for (int i = 0; i<a.GetLength(0); i++)
        {
            for(int j = 0; j<a.GetLength(1); j++)
            {
                b.SetPixel(i,j, a.GetPixel(i, j));                                
            }
        }

        return b;

    }    
    //[i]-Operations with Images

    public static Image AddLayer(Image a, Image b, int col, int row)
    {
        Image c = Image.CreateCopy(a);

        if (a.GetLength(0) < b.GetLength(0) || a.GetLength(1) < b.GetLength(1))
        {
            return a;
        }           
        
        for (int i = 0; i<b.GetLength(0); i++)
        {
            for(int j = 0; j<b.GetLength(1); j++)
            {
                if(b.GetPixel(i,j) != null && a.InRange(i+row, j+col))
                {
                    c.SetPixel(i+row, j+col, b.GetPixel(i,j));
                }                
            }
        }

        return c; 
    }
    public static Image AddLayer(Image a, Image b)
    {
        return AddLayer(a, b, 0, 0);               
    }

    private bool InRange(int i, int j)
    {
        return i < pixels.GetLength(0) && 
               j < pixels.GetLength(1) &&
               i >= 0 && j >= 0;
    }

    

    /*
    here I should add some methods for operations between images like adding them in some way
    */
}

