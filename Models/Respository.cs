using System.Collections.Generic;

namespace First2App.Models
{
    public class Respository
    {
        private static List<Student> _student=new List<Student>();
        public static List<Student> Student{
            get{
                return _student;
            }
            
        }
        public static void AddStudent(Student student){
            _student.Add(student);
        }
    }
}