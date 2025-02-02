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
        }

        public static Pixel GetTxtr(Txtr txtr)
        {
            return txtr switch
            {
                Txtr.wall => new Pixel("[", "]", new Color(50,50,50), new Color(50,50,50), new Color(255,255,255), new Color(255,255,255)),
                Txtr.floor => new Pixel(" ", " ", new Color(170,170,170), new Color(170,170,170), new Color(0,0,0), new Color(0,0,0)),
                Txtr.player1 => new Pixel("(", ")", new Color(0, 0, 0), new Color(0, 0, 0), new Color(255, 255, 255), new Color(255, 255, 255)), // Added background color
                _ => new Pixel(),
            };
        }
    }
}
