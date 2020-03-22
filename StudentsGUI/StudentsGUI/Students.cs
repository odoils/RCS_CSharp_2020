﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGUI
{
    class Students
    {
        private String name;
        private String surname;
        private int course;

        public Students(String name, String surname, int course)
        {
            this.name = name;
            this.surname = surname;
            this.course = course;
        }
        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public String GetSurname()
        {
            return surname;
        }
        public void SetSurname(String surname)
        {
            this.surname = surname;
        }
        public int GetCourse()
        {
            return course;
        }
        public void SetCourse(int course)
        {
            this.course = course;
        }
        public string ToText()
        {
            return string.Format(
                "{0} {1} {2}",
                name, surname, course
            );
        }
    }
}
