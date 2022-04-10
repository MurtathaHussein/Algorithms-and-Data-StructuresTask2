using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Murtatha Hussein
// 21432516
namespace Week3TaskB.Classes
{

    internal class Employee
    {
        private int id;
        private String name;
        private bool avalibility;
        
        public Employee (int id,string name)
        {
            this.name = name;
            this.id = id;   
           
            

        }
        public Employee(int id, bool available)
        {
            this.id = id;
            this.Avalibility = available;



        }
        public Employee(int id, String name , bool avalibility)
        {
            this.id = id;
            this.name = name;
            this.avalibility = avalibility;
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool Avalibility
        {
            get { return avalibility; }
            set { avalibility = value; }

        }




    }
}
