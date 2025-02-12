using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace Resourses.Visual;

public class TextBox01
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


    public TextBox01(string[] theText, int[] size)
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

        this.pages = TextWordsToPages(theText, size);
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

    public List<Image> TextWordsToPages(List<List<string>> theText, int[] size)
    {
        List<List<string>> auxText = theText; // This text can be changed 

        List<Image> output = new List<Image>();

        Image auxIMage = new(size[0], size[1]);

        int pixelRow = 0;
        int pixelCol = 0;

        foreach (List<string> paragraph in auxText)
        {
            foreach (string word in paragraph)
            {
                // Check if the current row has reached the end of the image
                if (pixelRow >= auxIMage.GetLength(0))
                {
                    // Save the current image and create a new one
                    output.Add(auxIMage);
                    auxIMage = new Image(size[0], size[1]);
                    pixelRow = 0;
                    pixelCol = 0;
                }

                // Check if the word fits in the remaining space of the current row
                if (word.Length / 2 >= auxIMage.GetSize()[1] - pixelCol)
                {
                    // If the word is too long to fit in a single row, split the word
                    if (word.Length / 2 >= auxIMage.GetSize()[1])
                    {
                        int remainingLength = word.Length;
                        int startIndex = 0;

                        while (remainingLength > 0)
                        {
                            int lengthToDraw = Math.Min(remainingLength, auxIMage.GetSize()[1] - pixelCol);
                            string part = word.Substring(startIndex, lengthToDraw);

                            // Draw the part of the word
                            DrawWord(auxIMage, part, pixelRow, pixelCol);

                            remainingLength -= lengthToDraw;
                            startIndex += lengthToDraw;
                            pixelRow++;
                            pixelCol = 0;

                            // Check if the current row has reached the end of the image
                            if (pixelRow >= auxIMage.GetLength(0))
                            {
                                // Save the current image and create a new one
                                output.Add(auxIMage);
                                auxIMage = new Image(size[0], size[1]);
                                pixelRow = 0;
                                pixelCol = 0;
                            }
                        }
                    }
                    else
                    {
                        // Move to the next row
                        pixelRow++;
                        pixelCol = 0;
                    }
                }

                // Draw the word
                DrawWord(auxIMage, word, pixelRow, pixelCol);
                pixelCol += word.Length / 2 + 1; // Add space between words
            }

            // Move to the next row after each paragraph
            pixelRow++;
            pixelCol = 0;
        }

        // Add the last image to the output
        output.Add(auxIMage);

        return output;
    }

    private void DrawWord(Image image, string word, int row, int col)
    {
        // Implement the logic to draw the word onto the image at the specified position
        // This is a placeholder implementation
        for (int i = 0; i < word.Length; i++)
        {
            image.SetPixel(col + i, row, Color.Black); // Example: drawing each character as a black pixel
        }
    }
}