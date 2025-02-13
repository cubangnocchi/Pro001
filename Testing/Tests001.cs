using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using Resourses.Tools;
namespace Pro001;

public partial class MiniTest
{
    public static void TextBoxTest()
    {
        string[] strings = 
        ["a e i o u",
         "eo",
         "aaaaaaaaaaaaaaa",
         "bbbbbbbbbbbbbbb",
         "1 2 3 4 5"];

        TextBox textBox = new(strings,[10,10]);

        textBox.PrintText();
        Console.WriteLine(" ");
        Console.ReadKey(true);
      

    }
}