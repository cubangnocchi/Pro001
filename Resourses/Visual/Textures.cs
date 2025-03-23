using Resourses.Visual;
using Spectre.Console;

namespace Resourses.Visual
{
    public class Textures
    {
        public enum Txtr
        {
            wall,
            floor,
            player1,
            player2,
            doorOpen,
            doorClose,
            unknown
        }

        public static Pixel GetTxtr(Txtr txtr)
        {
            return txtr switch
            {
                //cells
                Txtr.wall => new Pixel("[", "]", new Color(50,50,50), new Color(50,50,50), new Color(100,100,100), new Color(100,100,100)),
                Txtr.floor => new Pixel("_", "|", new Color(170,170,170), new Color(170,170,170), new Color(150,150,150), new Color(150,150,150)),
               
                //players
                Txtr.player1 => new Pixel("m", "e", new Color(0, 0, 255), new Color(0, 0, 255), new Color(255, 255, 255), new Color(255, 255, 255)),
                Txtr.player2 => new Pixel("(", ":", new Color(0, 255, 0), new Color(0, 255, 0), new Color(0, 0, 0), new Color(0, 0, 0)),
                
                //MapObjects
                //--Close = cell unwalkable + door // Open = wlk + dr
                Txtr.doorClose => new Pixel("]", "[", new Color(100,100,125), new Color(100,100,125), new Color(50,50,50), new Color(50,50,50)),
                Txtr.doorOpen => new Pixel("]", "[", new Color(150,150,170), new Color(150,150,170), new Color(100,100,100), new Color(100,100,100)),
               
                //Enemies
                //Items

                //unknown
                Txtr.unknown => new Pixel("?", "?", new Color(0,0,0), new Color(0,0,0), new Color(0,255,0), new Color(0,255,0)),
               


                _ => new Pixel()
            };
        }
    }
}

