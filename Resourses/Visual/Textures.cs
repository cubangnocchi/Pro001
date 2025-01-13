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
        return txtr switch
        {
            Txtr.wall => new Pixel('[', ']'),
            Txtr.floor => new Pixel(' ', ' '),
            Txtr.player1 => new Pixel('(', ')'),
            _ => new Pixel(),
        };
    }

    
}