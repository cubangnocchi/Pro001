using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Collections.Concurrent;
using System.ComponentModel;
namespace Resourses.Visual;

public partial class TextBox
{
    //[i]-Parameters
    List<Image> pagesImages;
    List<List<string>> pagesLines;

    //[i]-Constructors
    public TextBox(string[] theText, int[] size)
    {
        Build(theText, size);
    }

    //[i] Get information mehtods:

    public string GetLine(int page, int line)
    {
        return pagesLines[page][line];
    }

    public int GetPagesCount() => pagesLines.Count();

    public int GetPageLength(int page) => pagesLines[page].Count();   

    //[i] Set parameters methods:

    //[i] Console printing methods:

    public void PrintText()
    {
        for(int i = 0; i < pagesLines.Count(); i++)
        {
            PrintText(i);
            Console.WriteLine(" ");
        }

    }
    
    public void PrintText(int page)
    {
        foreach(string line in pagesLines[page])
        {
            Console.WriteLine(line);
        }

    }

    public void PrintText(int page, int line)
    {
        Console.WriteLine(pagesLines[page][line]);

    }

    

}