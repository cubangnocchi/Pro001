using System;
using System.Dynamic;
using Resourses.Tools;

namespace Resourses.Logic;

/// <summary>
/// Class for executing interactions between two objects.
/// </summary>
public class Actions
{

    /// <summary>
    /// delegate method 
    /// </summary>
    public delegate void ActionMethod();
    ActionMethod actionMethod;
    ActionMethod? antiActionMethod;
    bool playerCanInteract {get; set;}
    bool? activated;

    int? counter;
    string? name;


    

    //Item? intem; //an Item needed for dooing the action 


    //[i]-parameters Get/Set methods:

    public bool CanPLayerInteract() => playerCanInteract;
    public bool? IsActivated() => activated;
    public int? GetCounter() => counter;
    public bool GetPlayerCanInteract() => playerCanInteract; //+ important +
    public bool? GetActivated() => activated;

    

    //[i]-Constructors:

    /// <summary>
    /// Main constructor
    /// </summary>
    /// <param name="theAction">method to be executed</param>
    /// <param name="theAntiAction">method to be executed once the main method is activated, nullable</param>
    /// <param name="thePlayerCanInteract">bool value that defines if the player can interact or not with it</param>
    /// <param name="theActivated">bool value that represents the state of the main action, nullable</param>
    /// <param name="thecounter">int value to save, nullable</param>
    public Actions (ActionMethod theAction,
                    ActionMethod? theAntiAction, 
                    bool thePlayerCanInteract, 
                    bool? theActivated,
                    int? thecounter,
                    string? theName)
    {
        this.actionMethod = theAction;
        this.antiActionMethod = theAntiAction;
        this.playerCanInteract = thePlayerCanInteract;
        this.activated = theActivated;
        this.counter = thecounter;
        this.name = theName;
    }

    /// <summary>
    /// Constructor for an action without AntiAction and no counter.
    /// </summary>
    /// <param name="theAction">method to be executed</param>
    /// <param name="thePlayerCanInteract">bool value that defines if the player can interact or not with it</param>
    public Actions (ActionMethod theAction, bool thePlayerCanInteract) : this(theAction, null, thePlayerCanInteract, null, null, null)
    {}

    /// <summary>
    /// Constructor for an interactive action with name and without AntiAction and no counter.
    /// </summary>
    /// <param name="theAction">method to be executed</param>
    /// <param name="theName">bool value that defines if the player can interact or not with it</param>
    public Actions (ActionMethod theAction, string theName) : this(theAction, null, true, null, null, theName)
    {}

    /// <summary>
    /// Constructor for an action without AntiACtion.
    /// </summary>
    /// /// <param name="theAction">method to be executed</param>
    /// <param name="thePlayerCanInteract">bool value that defines if the player can interact or not with it</param>
    /// <param name="theCounter">int value to save, nullable</param>
    public Actions (ActionMethod theAction, bool thePlayerCanInteract, int? theCounter) : this(theAction, null, thePlayerCanInteract, null, theCounter, null)
    {}


    //[i] Main methods


    /// <summary>
    /// Can not be delegated 
    /// </summary>
    /// <param name="mainAction"> 
    /// if true, invoque main action
    /// if dalse, invoque anti action
    /// </param>
    public void Execute(bool mainAction) 
    {
        if(mainAction)
        {
            actionMethod.Invoke();
        }
        else if(antiActionMethod != null)
        {
            antiActionMethod.Invoke();
        }
    }
    
    //--[i] Main methods that can be delegated
    public void Execute() 
    {
        if(activated == null)
        {
            actionMethod.Invoke();
            if(counter != null)
            {
                counter++;
            }
        }
        else if(activated == false)
        {
            actionMethod.Invoke();
            activated = true;
        }
        else if(antiActionMethod != null)
        {
            antiActionMethod.Invoke();
            activated = false;
        }
    }

    public void ExecuteAnti() 
    {
        if(antiActionMethod != null)
        {
            antiActionMethod.Invoke();
        }
    }
    public void ExecuteMain() 
    {
        actionMethod.Invoke();
    }

    public void Activate() => activated = true; //can be delegated
    public void DeActivate() => activated = false; //can be delegated
    public void CounterPlusPlus() => counter++;

    #region Arr/List
    public static void ExecuteList(List<Actions> acts)
    {
        ExecuteArray(acts.ToArray());

    }
    public static void ExecuteArray(Actions[] acts)
    {
        foreach (var act in acts)
        {
            act.Execute();
        }
    }
    #endregion 





    

        

}