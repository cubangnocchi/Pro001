using Resourses.Visual;
namespace Resourses.Visual;

public class Textures{

    public enum Txtr
    {
        wall,
        floor,

        player1,

    }

    public static Pixel GetTxtr(Txtr txtr)
    {
        switch (txtr)
        {
            case Txtr.wall    : return new Pixel ('[',']');
            
            case Txtr.floor   : return new Pixel (' ',' ');

            case Txtr.player1 : return new Pixel ('(',')');

            

            
        }

        return new Pixel();



    }

    
}