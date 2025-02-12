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
        ["En este tema se presenta un conjunto mínimo de elementos de un lenguaje de programación imperativo. Este mnjunto se particulariza para el lenguaje C±. Con los elementos presentados se podrán construir programas completos aunque con una estructura muy simple, ya que sólo pueden e:.tar formados por una secuencia de sentencias. Para que estos primeros programas produzcan result.ados, se introducen también varios mecanismos de escritura simple. ",
         "El objetivo que trata de alcanzar este tema es permitir el desarrollo de programas completos desde el principio. Estos programas se podrán realizar como práct icas con el computador de manera inmediata y directa utilizando un compilador de CjC++. ",
         "aaaaaaaaaaaaaaaa",
         "oooooooooooooooo"];

        TextBox textBox = new(strings,[20,10]);

        textBox.PrintText();

        

    }
}