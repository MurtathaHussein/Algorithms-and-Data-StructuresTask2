using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseWeek2TaskA
{
    class Student
    {
        // Class Variables / Members
        private int age;
        private String name;
        private int Id;
        
        // Constructor - uisng only name as input 
        public Student(String Aname, int Aage, int AId)
        {
            this.name = Aname;
            this.age = Aage;
            this.Id = AId;
        }

        //getter & setter for name 
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        //getter & setter for id 
        public int ID
        {
            get { return Id; }
            set { this.Id = value; }
        }

        //getter & setter for age 
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
        
        //method to return student information in string format
        public string GetInfo()
        {
            return Id + ":"+ name + ":" + age;
        }
    }
}
