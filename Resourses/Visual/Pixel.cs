using System;
using System.Drawing;
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
        this.chars = new char[2];        
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

    
}    
 