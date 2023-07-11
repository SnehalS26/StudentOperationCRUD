using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOperationCRUD
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentCRUD studCRUD = new StudentCRUD();
            int option = 0;
            do
            {
                Console.WriteLine("1. Add Student Details");
                Console.WriteLine("2. Update Student Details");
                Console.WriteLine("3. Delete Student Details");
                Console.WriteLine("4. Display All Student Details");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Student stud = new Student();
                        Console.WriteLine("Enter Roll Number:");
                        stud.Roll_no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name:");
                        stud.Name = Console.ReadLine();
                        Console.WriteLine("Enter Email Id:");
                        stud.Email_id = Console.ReadLine();
                        studCRUD.AddStudent(stud);
                        break;
                    case 2:
                        Student stud1 = new Student();
                        Console.WriteLine("Enter Modify Roll Numb :");
                        stud1.Roll_no = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Student Name:");
                        stud1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Email Id:");
                        stud1.Email_id = Console.ReadLine();
                        studCRUD.UpdateStudent(stud1);
                        break;
                    case 3:
                        Console.WriteLine("Enter Roll Numb Delete:");
                        int roll_no = Convert.ToInt32(Console.ReadLine());
                        studCRUD.DeleteStudent(roll_no);
                        break;
                    case 4:
                        List<Student> list = studCRUD.GetStudents();
                        foreach (Student student in list)
                        {
                            Console.WriteLine($"{student.Roll_no} ---> {student.Name} ---> {student.Email_id}");
                        }
                        break;
                }
                Console.WriteLine("Enter 1 Option");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option == 1);
        }
    }
}
