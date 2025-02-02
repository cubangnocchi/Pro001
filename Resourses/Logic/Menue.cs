using System;
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using Resourses.Tools;
namespace Resourses.Logic;

public class Menue
{
    //Menue parameters
    public delegate void OptionMethod();
    private char[] optionsKeys;    
    private string menueName;
    private string[] optionsNames; 
    private OptionMethod[] OptionMethods;
    private int menueLength;



    public Menue(string theMenueName, char[] theOptionKeys,  string[] theOptionsNames,  OptionMethod[] theOptionMethods)
    {
        //capting general parameters
        this.menueName = theMenueName;
        this.optionsKeys = theOptionKeys;
        this.OptionMethods = theOptionMethods;
        this.menueLength =  theOptionKeys.Length;

        //saving properly the option names with the format:
        //[x]-"OptionName"
        string[] importedOptionNames = theOptionsNames;
        for (int i = 0; i < this.menueLength; i++)
        {
            importedOptionNames[i] =  "[" + optionsKeys[i] + "]-" + theOptionsNames[i];
        }
        this.optionsNames = importedOptionNames;
    }

    //just a nonsense testing mehtod I like to add...
    public static void Testing() => Console.WriteLine("- Menue loaded correctly");
    
    //methods to get private information from the class instanse...
    public string GetMenueName() => this.menueName;
    public string[] GetOptionNames() => this.optionsNames;

    //method for executing options
    public void Option(char theInput)
    {
        //checking if the input is a valid iption
        int optionPosition = OptionExist(theInput);
        if (optionPosition != -1)
        {
            //executes the selected method option
            this.OptionMethods[optionPosition]?.Invoke();            
        }        
    }

    /*
    them try some kind of methods for adding and deleting
    options... like a dinamic list... or directly make
    parameters as lis? mmmmm... nah...  I'll do it later
    */

    private int OptionExist(char theInput){
        //preset value for non valid option
        int optionPosition = -1;
        for(int i = 0; i < this.optionsKeys.Length; i++)
        {
            if (optionsKeys[i] == theInput)
            {
                //saves the valid option
                optionPosition = i;                
            }        
        }
        return optionPosition;

    }

    //method for simple console printing... temporal for testing
    public void Print()
    {
        Console.WriteLine("----" + this.menueName + "----");
        Console.WriteLine(" ");
        for (int i = 0; i < this.menueLength; i++){
            Console.WriteLine(this.optionsNames[i]);
        }
        Console.WriteLine(" ");
        Console.WriteLine("[i]-Pres a key for selecting an option"); 
        Console.WriteLine(" ");
    }

    
}