using System;
using Spectre.Console;

namespace Resourses.Visual
{
    public class Pixel
    {
        private Color[] backGroundColors;
        private Color[] charsColors;
        private string[] chars;

        public Pixel()
        {
            this.backGroundColors = new Color[2] { Color.Black, Color.Black };
            this.charsColors = new Color[2] { Color.White, Color.White };
            this.chars = new string[2] { " ", " " };
        }

        public Pixel(string leftChar, string rightChar)
        {
            this.backGroundColors = new Color[2] { Color.Black, Color.Black };
            this.charsColors = new Color[2] { Color.White, Color.White };
            this.chars = new string[2] { leftChar, rightChar };
        }

        public Pixel(string leftChar, string rightChar, Color leftbackGroundColor, Color rightbackGroundColor, Color lefCharColor, Color rightCharColor)
        {
            this.backGroundColors = new Color[2] { leftbackGroundColor, rightbackGroundColor };
            this.charsColors = new Color[2] { lefCharColor, rightCharColor };
            this.chars = new string[2] { leftChar, rightChar };
        }

        public void Print()
        {
            if (this.chars == null)
            {
                Console.Write("  ");
            }
            else
            {
                // Ensure colors are initialized
                if (this.charsColors == null)
                {
                    this.charsColors = new Color[2] { Color.White, Color.White };
                }
                if (this.backGroundColors == null)
                {
                    this.backGroundColors = new Color[2] { Color.Black, Color.Black };
                }

                AnsiConsole.Write($"[rgb({backGroundColors[0].R},{backGroundColors[0].G},{backGroundColors[0].B})][on rgb({charsColors[0].R},{charsColors[0].G},{charsColors[0].B})]{Markup.Escape(chars[0])}[/][/]"); 
                AnsiConsole.Write($"[rgb({backGroundColors[1].R},{backGroundColors[1].G},{backGroundColors[1].B})][on rgb({charsColors[1].R},{charsColors[1].G},{charsColors[1].B})]{Markup.Escape(chars[1])}[/][/]"); 
            }
        }
    }
}
