using System;
using System.Reflection.Emit;

namespace Resourses.Tools;

//[i]-Dynamic enum for relating n numbers with n strings
public class MyEnum
{
    //[i]-parameters
    string[] elements;
    char[] chars;
    int[] numbers;

    //busca forma alternativa...
    //AssamblyBuilder...  

    //[i]-constructors
    public MyEnum(string[] theElements, int[] theNumbers)
    {
        //[i]-Exeption management
        if (theElements == null ||
            theNumbers == null  ||
            theNumbers.Length != theElements.Length)
        {
            throw new ArgumentException
            ("DyEnum.DyEnum no valid parameters");
        }

        //[i]-parameter asignation
        elements = theElements;
        numbers = theNumbers;
    }
    public MyEnum(char[] theChars, int[] theNumbers)
    {
        if ( theChars == null ||
           theNumbers == null ||
           theNumbers.Length != theChars.Length)
        {
            throw new ArgumentException
            ("DyEnum.DyEnum no valid parameters");
        }

        chars = theChars;
        numbers = theNumbers;
    }
    public MyEnum(string[] theElements)
    {
        //[i]-Exeption management
        if(theElements == null)
        {
            throw new ArgumentException
            ("DyEnum.DyEnum no valid parameters");
        }

        elements = theElements;
        numbers = new int[theElements.Length];
        
        for(int i = 0; i < theElements.Length; i++)
        {
            numbers[i] = i;            
        }
    }

    public MyEnum(char[] theChars)
    {
        //[i]-Exeption management
        if(theChars == null)
        {
            throw new ArgumentException
            ("DyEnum.DyEnum no valid parameters");
        }

        chars = theChars;
        numbers = new int[theChars.Length];
        
        for(int i = 0; i < theChars.Length; i++)
        {
            numbers[i] = i;            
        }
    }



    //[i]-Get parameter methods

    public int GetInt(string str)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if(str == elements[i])
            {
                return numbers[i];
            }
        }
        return -1;

    }

    public int GetInt(char theChar)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if(theChar == chars[i])
            {
                return numbers[i];
            }
        }
        return -1;

    }

    public string GetString(int n)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            if(n == numbers[i])
            {
                return elements[i];
            }
        }
        return "";
    }




}



