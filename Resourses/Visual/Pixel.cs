using System;
using System.Drawing;
namespace Resourses.Visual;

public class Pixel
{
    char[] chars;
    Color[] colors;
    
    public Pixel()
    {
        this.colors = new Color[2];
        this.chars = new char[2];        
    }
}