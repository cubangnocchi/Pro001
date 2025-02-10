using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace Resourses.Visual;

public class TextBox
{
    /*esto es para:
    - convertir un texto a una imagen de nxm
    - hacer un menue de opciones
    - mira a ver como hacer una barrita pa subir y bajar jsjsj     
    */

    //[i]-Parameters:
    List<List<string>> text; //to change the text if nessesary by having the same instance
    //Image[] pages; //for making scrolling posible

    List<Image> pages;


    public TextBox(string[] theText, int[] size)
    {
        Build(theText, size);
    }

    //[i] Get information mehtods:

    public int PagesNumber() => pages.Count;

    public Image GetPage(int pageNumber)
    {
        return pages[pageNumber]; 
    }

    public Image GetPage() => GetPage(0);

    public List<Image> GetPages() => pages;

    public int[] GetPageSize() => pages[0].GetSize();

    //[i] Set parameters methods:

    public void ChangeText(string[] newText)
    {
        Build(newText, pages[0].GetSize());
    }
    public void ChangeSize(int[] size)
    {
        Build(text, size); //
    }

    //[i] TextBox building methods

    private void Build(string[] theText, int[] size)
    {    
        Build(TextToWords(theText), size);
    }

    private void Build(List<List<string>> theText, int[] size)
    {
        this.text = theText;

        this.pages = TextWordsToPages(theText);
        //start geiting text into Image with justification...
        //if there is a word that have no space to be writen in 
        //the (last line -1), add a "(...)" in the las line and 
        //the keys to scroll... then create a new Image and repeat til 
        //the text ends and the work is done...

    }

    public List<List<string>> TextToWords (string[] theText)
    {
        //method for identifying words
        //to generate a new string[,] where each row is a separated text from []theText
        //and in each col there is a word

       List<List<string>> output = new List<List<string>>();


        string auxWord = "";

        for(int i = 0; i < theText.Length; i++)
        {
            List<string> auxList = new List<string>();

            for(int j = 0; j < theText[i].Length; j++)
            {
                if(theText[i][j] != ' ')
                {
                    auxWord += theText[i][j];
                }
                else
                {
                    auxList.Add(auxWord);
                    auxWord = "";
                }
            }

            output.Add(auxList);
        }

        return output;

    }

    public List<Image> TextWordsToPages(List<List<string>>theText, int[]size)
    {
        List<List<string>> auxText = theText; //this text can be changed for 

        List<Image> output = new List<Image>();

        Image auxIMage = new(size[0], size[1]);

        //forma A:

        int pixelRow = 0;
        int pixelCol = 0; 
        int pixelAux = new();

        foreach(List<string> paragraph in auxText)
        {
            foreach(string word in paragraph)
            {
                if(pixelRow == auxIMage.GetLength(0) - 1)
                {

                }
                if(word.Length/2 >= auxIMage.GetSize()[1] - pixelCol)
                {
                    if(word.Length/2 >= auxIMage.GetSize()[1])
                    {
                        //divide forzosamente la palabra
                    }
                    else
                    {
                        pixelRow++;
                    }
                }

                //si el pixel anterior termina con un espacio:
                if(pixelCol > 1 && (auxIMage.GetPixel(pixelRow, pixelCol-1).GetString()[1] == ' '))
                {
                    for(int i = 0; i < word.Length/2; i++)
                    {
                        Pixel pixel;
                        if(i*2 + 1 >= word.Length)
                        {
                            pixel = new(word[i*2], ' ');
                            
                            if(pixelCol < (auxIMage.GetLength(1) - 1))
                            {
                                pixelCol ++;
                            }
                            else
                            {
                                pixelCol = 0; pixelRow++;
                            }
 
                        }
                        else
                        {
                            pixel
                        }
   
                    
                        auxIMage.SetPixel(pixelRow, pixelCol, pixel);
                    }
                }
                else
                {
                //si el pixel anterior no tiene un espacio se agrega un espacio delante
                //se le agrega uno 
                    

                }
                
                
            }
        }

        //forma B:





    }

    

    





}