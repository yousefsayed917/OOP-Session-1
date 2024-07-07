using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class TypeB
    {
       public TypeB()
        {
            Type_A obj = new Type_A();
            //obj.x=20; Invalid
            //obj.y = 20; Valid y Is Internal (In the Same Project)
            //obj.z = 29; Valid z Is Public
        }


    }
}
