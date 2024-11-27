using System;
namespace Resourses.Logic;
public class Maze
{
    Cell[,] maze;
    string name; 
    int seed;

    public Maze(string theName, int width, int height){
        maze= new Cell[width, height];
        name = theName;
        Generator();
    }
    public Maze(string theName, int width, int height, int theSeed){
        maze= new Cell[width, height];
        name = theName;
        seed = theSeed;
        GeneratorFromSeed();
    }

    public static void Testing() => Console.WriteLine("- Maze loaded correctly");
    
    //[i] maze generation methods:

    private void Generator(){        

    }
    private void GeneratorFromSeed(){
        

    }

    //private void GenetateTutorial(){

    //}

    /*
    []     []
    [][]=[][]   los = son puertas
    [][]=[][]
    []    "[]  " es un boton
    []

    se pueden hacer puertas que luego de x turnos se cierren (deben tener boton de ambos lados pa que funcione
    el team work) (tipo de trampa)

    el criterio para volver a empezar la construccion de conexiones es una habitacion que no este conectada y
    tenga al lado una conectada

    quizas pueda hacer que

    []     []    []     []
    [][]=[][]  o []     [] para que no siempre sea doble la puerta
    []     []    [][]=[][]
    []     []    []     []

    [P  desk
    [)  pantalla de terminal?

    buscando con Windows + .

    ⁅⁅⁆⁆¦¦‖⁑⁂⁗⁁⁜※⁋īīĳĹ↑↓↼⇀⇖■▣▦□▬▬▮○◔◑◕●◍◉◜◝◞◟◤◥◢◣◧◫◷◱◰◼◾◭◮ⅧⅮↇↂ
    
    []≔≕[] closed door
    []⁅  ⁆[] open door

     )  (
    (    )
    ※  ※

    quizas pueda hacer 
    los niveles en plan:
    
    -pared02              y asi puedo
    -pared01
    -piso
    [] o
    [] ‖
    []           
    []       o 
    [][][][]◟◞[][][][]??????


    miraver si encuentras como hacer que dos cosas ocurran en paralelo...
    */
}




    
