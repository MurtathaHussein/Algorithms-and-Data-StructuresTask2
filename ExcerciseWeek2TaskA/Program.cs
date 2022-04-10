
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseWeek2TaskA
{
 //Murtatha Hussein
 // MMU ID: 21432516
    class Program
    {
        static void Main(string[] args)

        {
            //Student array object to hold student info
            Student[] student = new Student[10];
            student[0] = new Student("Jade", 19, 112233); //creating student instance with its name,age and id and saving to student array
            student[1] = new Student("Jack", 22, 223344);
            student[2] = new Student("Mason", 20, 334455);
            student[3] = new Student("Laila", 23, 556677);
            student[4] = new Student("Yousef", 19, 667788);
            student[5] = new Student("Mike", 19, 212131);
            student[6] = new Student("Halima", 18, 202040);
            student[7] = new Student("Mustafa", 26, 050695);
            student[8] = new Student("Khadija", 22, 090999);
            student[9] = new Student("Zahra", 22, 171098);

            //to display student info from student array using loop
            for (int i = 0; i < 10; i++)
                Console.WriteLine(student[i].GetInfo());  //GetInfo method returns student information

            Console.ReadKey();
        }
    }
}
