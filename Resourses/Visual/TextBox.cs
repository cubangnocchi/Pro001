using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Collections.Concurrent;
using System.ComponentModel;
namespace Resourses.Visual;

public class TextBox
{
    List<Image> pagesImages;

    List<List<string>> pagesLines; 
    
    public TextBox(string[] theText, int[] size)
    {
        Build(theText, size);
    }

    //[i] Get information mehtods:

   

    //[i] Set parameters methods:

    

    //[i] TextBox building methods

    private void Build(string[] theText, int[] size)
    {
        this.pagesLines = Lines_to_PagesLines(StringParagraphs_To_ListOfLines(theText, size[0]), size[1]);


    }

    private List<List<string>> Lines_to_PagesLines(List<string> lines, int rows)
    {
        List<List<string>> output = new List<List<string>>();

        List<string> auxPage = new List<string>();

        foreach(string line in lines)
        {
            if(auxPage.Count() < rows)
            {
                auxPage.Add(line);
            }
            else
            {
                output.Add(auxPage);
                auxPage = [line];
            }
        }

        return output;

    }

    
    /// <summary>
    /// this method will make a list of paragraphs that are lists of strings with the same length
    /// </summary>
    /// <param name="strings"> each string is a paragraph</param>
    /// <param name="length"> the max length of a text line</param>
    /// <returns></returns>
    private List<string> StringParagraphs_To_ListOfLines(string[] strings, int length)
    {
        //the var that contains the value that will be return
        List<string> output = new List<string>();

        string auxLine = ""; //for saving the line before adding it

        foreach(string paragraph in strings)
        {
            List<string> words = StringToWordsList(paragraph);

            if(words[0] == "")
            {
                output.Add(" ");

            }
            else
            {
                for (int i = 0; i < words.Count; i++)
                {
                    string word = words[i];
                    if (auxLine.Length == 0)
                    {
                        auxLine += word;
                    }
                    else if((auxLine.Length + word.Length + 1) <= length)
                    {
                        auxLine += " " + word;
                    }
                    else if(word.Length <= length)
                    {
                        output.Add(auxLine);
                        auxLine = word;  
                    }
                    else if(word.Length > length)
                    {
                        List<string> list = WordDivider(word, length);
                        for (int j = 0; j < list.Count; j++)
                        {
                            string w = list[j];
                            words.Insert(i+j+1, w);
                        }
                    }
                    else 
                    {
                        output.Add(auxLine);
                        auxLine = "";
                    }
                    
                }
                if(auxLine != "")
                {
                    output.Add(auxLine);
                }
            }
            
        }
        
        return output;
    }

    private List<string> StringToWordsList(string paragraph)
    {
        List<string> output = new List<string>();

        string auxWord = "";

        foreach(char c in paragraph)
        {
            if(c != ' ')
            {
                auxWord += c;
            }
            else
            {
                output.Add(auxWord);
                auxWord = "";
            }

        }
        if(auxWord != "") output.Add(auxWord);

        return output;

    }

    private List<string> WordDivider(string word, int length)
    {
        List<string> output = new List<string>();

        string auxWord = "";

        foreach(char c in word)
        {
            if(auxWord.Length < (length - 2))
            {
                auxWord += c;
            }
            else
            {
                output.Add(auxWord + "-");
                auxWord = "";
            }

        }
        if(auxWord != "") output.Add(auxWord);

        return output;
        
    }

}


    

    