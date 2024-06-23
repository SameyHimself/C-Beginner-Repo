using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console Customization:
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Hello World");
            Console.WriteLine("--------------------------------");

            // Simple Name Program:
            Console.Write("What is your name?:  ");
            string name = "Homelander";
            Console.WriteLine($"Hello {name} !");
            Console.WriteLine("--------------------------------");

            //Data Types:
            //Boolean:
            bool canIVote = true;
            //Integer:
            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);
            //Long:
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);
            //Decimal:
            decimal DeciPiVal = 3.14159265358979323846264338327950288419M;
            decimal DeciBigNum = 3.0290922729304105875015782190535021950M;
            Console.WriteLine("Pi * Big Num = {0}", DeciPiVal* DeciBigNum);
            Console.WriteLine("Biggest Decimal: {0}", decimal.MaxValue);
            Console.WriteLine("Smallest Decimal: {0}", decimal.MinValue);
            //Double:
            Console.WriteLine("Biggest Double: {0}", double.MaxValue);
            Console.WriteLine("Smallest Double: {0}", double.MinValue);
            double DblPiVal = 6.14159265358979323846264338327950288419;
            double DblBigNum = 3.14159265358979323846264338327950288419;
            Console.WriteLine("DBL : Double Pi Value + Double Big Number = {0}", DblBigNum +  DblBigNum);
            //Float:
            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            Console.WriteLine("Smallest Float: {0}", float.MinValue);
            float FltPiVal = 6.14159265358979323846264338327950288419F;
            float FltBigNum = 3.14159265358979323846264338327950288419F;
            Console.WriteLine("FLT : Float Pi Value + Float Big Number = {0}", FltBigNum + FltBigNum);
            Console.WriteLine("-----------------------------------");

            //Other Data Types:
              //byte : 8-bit unsigned int 0 to 255
               //char : 16 bit unicode character 
               //sbyte : 8-bit signed int 128 to 127
               //short : 16-bit signed int -32,768,to 32,767
               //uint : 32-bit unsigned int 0 to 4,284,967,295
               //ulong : 64 bit unsigned int 0 to 118,446,774,073,709,551,615
               //ushort : 16-bit unsigned int 0 to 65,535 
            

            //Casting (Converting Data types):
            //Converting from string to other datatypes:
            bool boolFromStr = bool.Parse("true");
            Console.WriteLine("DataType: {0}", boolFromStr.GetType());
            int intFromStr = int.Parse("100");
            Console.WriteLine("DataType: {0}", intFromStr.GetType());
            double dblfromStr = double.Parse("12.23");
            Console.WriteLine("DataType: {0}", dblfromStr.GetType());

            //Converting from other datatypes to string:
            string strval = dblfromStr.ToString();
            Console.WriteLine("DataType: {0}", strval.GetType());

            //Implicit conversions:
            //No special syntax is required because the conversion always succeeds and no data is lost.
            //Examples include conversions from smaller to larger integral types, and conversions from derived classes to base classes.

            //Explicit conversions(casts):
            //Explicit conversions require a cast expression.
            //Casting is required when information might be lost in the conversion, or when the conversion might not succeed for other reasons.

            // Converting from Double to Integer (Explicit Conversion):
            double dblNum = 12.453;
            Console.WriteLine("Integer : {0}", (int)dblNum);

            // Implicit Conversion(int in long):
            int intnum = 10;
            long longnum = intnum;
            Console.WriteLine("Datatype: {0}", longnum.GetType());
            Console.WriteLine("-----------------------------");

            // Recieving Input & Formatting Output:
            Console.WriteLine("Give a big number: ");
            string strvalue = "2123214";
            double dblfromString = double.Parse(strvalue);
            int INTFromStr = (int)dblfromString;

            Console.WriteLine("Currency : {0:c}", dblfromString);
            Console.WriteLine("Pad with 0s : {0:d4}", INTFromStr);
            Console.WriteLine("3 decimal space : {0:f3}", dblfromString);
            Console.WriteLine("Commas : {0:n4}", INTFromStr);
            Console.WriteLine("----------------------------");

            //String Functions:
            string randstring = "This is a string";
            Console.WriteLine("Length of a string: {0}", randstring.Length);
            Console.WriteLine("String contains 'is': {0}", randstring.Contains("is"));
            Console.WriteLine("Index of 'string': {0}", randstring.IndexOf("string"));
            Console.WriteLine("Remove from string: {0}", randstring.Remove(10, 6));
            Console.WriteLine("Insert in string: {0}", randstring.Insert(5, "JHOL"));
            Console.WriteLine("Replace in string: {0}", randstring.Replace("a", "the"));
            Console.WriteLine("Compare A to B: {0}", String.Compare("A","B",StringComparison.OrdinalIgnoreCase));
            //Compare string and ignore case:
            //(1): < 0 : str1 preceeds str 2
            //(2): = : zero
            //(3): > 0 : str2 preceeds str 1
            Console.WriteLine("---------------------------");
            Console.WriteLine("A equal a: {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad left: {0}", randstring.PadLeft(20,'.'));
            Console.WriteLine("Pad right: {0}", randstring.PadRight(20, '.'));
            Console.WriteLine("Trim: {0}", randstring.Trim());
            Console.WriteLine("Uppercase: {0}", randstring.ToUpper());
            Console.WriteLine("Lowercase: {0}", randstring.ToLower());
            string newstring = string.Format("{0} likes to {1} with {2} {3} {4}", "Carmen", "travel", "his", "favourite", "toys");
            Console.Write(newstring + "\n");
            // Escape Characters:
            // (1):\’ – Output a Single quote
            // (2):\” – Output a double quote
            // (3):\ – Output a Backslash
            // (4):\n – Insert a newline
            // (5):\r – Insert a carriage -return
            // (6):\t – Insert a tab
            // (7):\0 – Insert a null character
            // (8):\b – Insert a backspace













        }
    }
}
