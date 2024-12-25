using System;
namespace Resourses.Visual;

public class Image
{
    private Pixel[,] pixels;
    public Image(int width, int height)
    {
        pixels = new Pixel[width,height];
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
    public static Image AddLayer(Image a, Image b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
        {
            return a;
        }

        Image c = Image.CreateCopy(a);           
        
        for (int i = 0; i<a.GetLength(0); i++)
        {
            for(int j = 0; j<a.GetLength(1); j++)
            {
                if(b.GetPixel(i,j) != null)
                {
                    c.SetPixel(i,j,b.GetPixel(i,j));
                }
                
            }
        }

        return c;        
    }

    /*
    here I should add some methods for operations between images like adding them in some way
    */
}

