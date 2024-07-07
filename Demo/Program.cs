using ClassLibrary1;
using Demo.Encapsulation;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            //Type_A obj = new Type_A();
            //obj.x = 10; Invalid x Is Private
            //obj.y = 20; Invalid y Is Internal (Same Solution not Same Project)
            //obj.z = 29; Valid z Is Public
            #endregion
            #region What is OOP
            /*OOP Is A Style Of Programming Based On
            Object Concept, It Doesn’t Refer To A
            Specific Language But It Is A Way To
            Build A Program By Making Simulation Of Reality*/
            #endregion
            #region Encapsulation
            //Employee employee = new Employee(1,"yousef",10000);
            //employee.Id = 20;//Set Id Directly Through Attribute
            //Console.WriteLine(employee.ToString());
            //employee.SetName("mohamed"); //Set the name using setter method
            //Console.WriteLine(employee.GetName()); //Get the name using getter method
            //employee.Salary = 9000; //set with Property
            //Console.WriteLine(employee.Salary); //get with Property

            #endregion
            #region Class
            //Car C1;
            //Declare For Reference From Type Car
            //C1 Can Refer To Object From Type Car
            //CLR Will Allocate 4 Bytes For Reference In Stack ,Zero Bytes In Heap

            //Car C2 = new Car();
            //Allocate Required Bytes At Heap
            //Intialize Allocated Bytes At Heap With Default Value 
            //Call User Defined Constructor If Exists
            //Assign Reference C2 To Allocated Object At Heap
            #endregion
        }
    }
}
