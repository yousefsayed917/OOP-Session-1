using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {//Encapsulation : Sperates Attributes From Its Use By [Setter and Getter - Property]   
        //Attributes
        public int Id { get; set; }//Automatic Property
        //Compiler Will Generate Backing Field (Hidden Private Attribute)
        private string Name;
        public Decimal salary;
        //Constructor
        public Employee(int Id, string Name,decimal salary)
        {
            this.Id = Id; 
            this.Name = Name;
            this.salary = salary;
        }
        //Getter
        public string GetName()
        {
            return Name;
        }
        //setter
        public void SetName(string Name)
        {
           // this.Name = Name.Length>5?Name.Substring(0,5):Name; Contorl validation
            this.Name = Name;
        }
        //Full Property
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public override string ToString()
        {
            return $"Id :{Id}\nName Is : {Name}\nSalary ={salary}";
        }
    }

}
