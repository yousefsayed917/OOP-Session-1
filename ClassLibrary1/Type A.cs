using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //Allowed access Modifier In Tne Namespace
    //1- Internal (Default)
    //2- Public
    public class Type_A
    {
        //private int x;
        //internal int y;
        //public int z;
        //public void print()
        //{
        //    Console.WriteLine(x);
        //}
        #region What We Can Write In The Class Or Struct
        //Attributes[Filed]
        //Properties[Full Property-Automatic Property-Index]
        //Functions[Constructor-Setter And Getter-Methods]
        // Event[Not now] 

        //Allowed Access Modifiers In Struct
        //Private (Default)
        //Internal
        //Public 

        //Allowed Access Modifiers In Class
        //Private 
        //Internal (Default)
        //Public
        //Prodected 
        //Provate Protected
        //Internal Protected
        #endregion
        #region Interface
        //Signature for Method
        //Signature for Property
        //DeFault Implemented Property(c#8)
        //DEfault Implemented Method

        //Allowed Access Modifiers In Interface
        //Private 
        //Internal
        //Public (Default)
        //Prodected 
        //Provate Protected
        //Internal Protected
        #endregion
    }
}
