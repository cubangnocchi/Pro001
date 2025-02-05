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
                //cells
                Txtr.wall => new Pixel("[", "]", new Color(50,50,50), new Color(50,50,50), new Color(100,100,100), new Color(100,100,100)),
                Txtr.floor => new Pixel("_", "|", new Color(170,170,170), new Color(170,170,170), new Color(150,150,150), new Color(150,150,150)),
               
                //players
                Txtr.player1 => new Pixel("m", "e", new Color(0, 0, 255), new Color(0, 0, 255), new Color(255, 255, 255), new Color(255, 255, 255)),

                //MapObjects
                //Enemies
                //Items


                _ => new Pixel(),
            };
        }
    }
}

