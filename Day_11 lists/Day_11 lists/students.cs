using System;
using System.Collections.Generic;
using System.Text;

namespace Day_11_lists
{
    public class students
    {
        private String name;
        private String surname;
        private int course;

        public students (String name, String surname, int course) 
        {
            this.name = name;
            this.surname = surname;
            this.course = course;       
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void setSurname(String surname)
        {
            this.surname = surname;
        }
        public void setCourse(int course)
        {
            this.course = course;
        }




        public String GetName()
        {
            return name;
        }
        public String GetSurname()
        {
            return surname;
        }
        public int GetCourse()
        {
            return course;
        }
        public void print() // izvadisanas viens no veidiem, bet jaizsauc Main
        {
            Console.WriteLine(name + " " + surname + " " + course);
        }
    }
}
