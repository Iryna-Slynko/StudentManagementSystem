using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    class Student
    {
        
        public string Name { get; set; }
        public string StudentID { get; private set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public bool Enrolled { set; get; }

        public Student(string name, string studentID, int age, string course, bool enrolled)
        {
            Name = name;
            StudentID = studentID;
            Age = age;
            Course = course;
            Enrolled = enrolled;
        }
    
}
}
