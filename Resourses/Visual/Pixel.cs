using System;
using System.Drawing;
//using Spectre.Console;
//using Colorful;

using SyCl = System.Console;
namespace Resourses.Visual;

public class Pixel
{
    //[i]-Parameters
    char[] chars;
    Color[] backGroundColors;
    Color[] charsColors;

    //I should change this for style[] and thats it...

    //[i]-Constructors
    
    public Pixel()
    {
        this.backGroundColors = new Color[2];
        this.charsColors = new Color[2];
        this.chars = [' ',' '];        
    }
    public Pixel(char leftChar, char rightChar)
    {
        this.chars = [leftChar, rightChar];
    }
    public Pixel(char leftChar, char rightChar, Color leftbackGroundColor, Color rightbackGroundColor, Color lefCharColor, Color rightCharColor)
    {
        this.backGroundColors = [leftbackGroundColor,rightbackGroundColor];
        this.charsColors = [lefCharColor, rightCharColor];
        this.chars = [leftChar, rightChar];
    } 

    public void Print()
    {
        if (this.chars == null){
            Console.Write("  ");
        }
        else{
            SyCl.Write(chars);
        }   

        //add the colors and all that later like this:
        /*
        if( style and all that is not null )
                      |
                      V
        Spectre.Write(chars[0], --colores y cosas--);
        S..        ...     [1]          ...         ;
        */        
    }

    
}    
 