using System;
namespace Resourses.Visual;

public class Image
{
    //[i]-Parameters
    private Pixel[,] pixels;

    //[i]-Constructors
    public Image(int width, int height)
    {
        pixels = new Pixel[width,height];
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
        return (Dimention != 0|| Dimention !=1) ? -1 : pixels.GetLength(Dimention);

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
                if(b.GetPixel(i,j) != null || a.InRange(i+row, j+col))
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

