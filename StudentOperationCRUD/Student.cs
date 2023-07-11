using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOperationCRUD
{
    public class Student
    {
        public int Roll_no { get; set; }
        public string Name { get; set; }
        public string Email_id { get; set; }

    }

    public class StudentCRUD
    {
        private List<Student> students;
        public StudentCRUD()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student stud)
        {
            students.Add(stud);
        }
        public void UpdateStudent(Student student)
        {
            foreach(Student student1 in students)
            {
                if(student1.Roll_no == student.Roll_no)
                {
                    student1.Name = student.Name;
                    student1.Email_id = student.Email_id;
                    break;
                }
            }
        }
        public void DeleteStudent(int roll_no)
        {
            foreach (Student student1 in students)
            {
                if(student1.Roll_no == roll_no)
                {
                    students.Remove(student1);
                    break;
                }
            }
        }
        public List<Student> GetStudents()
        {
            return students;
        }
        
    }
}
