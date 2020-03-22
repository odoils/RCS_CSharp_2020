using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsGUI
{
    public partial class Form1 : Form
    {
        List<Students> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Students>();
        }
        private void btnAddDemoData_Click(object sender, EventArgs e)
        {
            List<Students> demoStudents = new List<Students>()
            {
                new Students("Gatis", "Ozols", 1),
                new Students("Maris", "Priede", 2),
                new Students("Arnis", "Zariņš", 3)
            };

            foreach (Students student in demoStudents)
            {
                if (!StudentExist(student))
                {
                    students.Add(student);
                }
            }
            UpdateStudentsList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateStudentData(
                inpName.Text,
                inpSurname.Text,
                inpCourse.Text
            );

            if (errorMessage == "")
            {
                Students newStudent = new Students(
                    inpName.Text,
                    inpSurname.Text,
                    Convert.ToInt32(inpCourse.Text)
                );

                if (!StudentExist(newStudent))
                {
                    students.Add(newStudent);
                    UpdateStudentsList();
                }
                else
                {
                    errorMessage += "Šāds students jau eksistē!";
                }
            }
            txtMessage.Text = errorMessage;
        }
        private string ValidateName(string input)
        {
            if (input.Trim() == "")
            {
                return "Nav ievadits vārds!";
            }
            return "";
        }
        private string ValidateSurname(string input)
        {
            if (input.Trim() == "")
            {
                return "Nav ievadits uzvārds!";
            }
            return "";
        }
        private string ValidateCourse(string input)
        {
            if (input.Trim() == "")
            {
                return "Nav ievadits kurss!";
            }

            int numInput = -1;

            try
            {
                numInput = Convert.ToInt32(input);
            }
            catch
            {
                return "Ievadita kursa vertiba nav skaitlis!";
            }
            if (numInput < 1 || numInput > 3)
            {
                return "Kursam jābūt robežās no 1 līdz 3!";
            }
            return "";
        }

        private string ValidateStudentData(string name, string surname, string course)
        {
            string errorMessage = "";
            errorMessage += ValidateName(name);
            errorMessage += ValidateSurname(surname);
            errorMessage += ValidateCourse(course);
            return errorMessage;
        }
        private string ValidateStudentData(Students student)
        {
            return ValidateStudentData(
                student.GetName(),
                student.GetSurname(),
                student.GetCourse().ToString()
            );
        }
        private bool StudentExist(Students student)
        {
            return students.Any(x =>
                    x.GetName().ToLower() == student.GetName().ToLower() &&
                    x.GetSurname().ToLower() == student.GetSurname().ToLower() &&
                    x.GetCourse() == student.GetCourse()
            );
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listStudents.SelectedItems)
            {
                string[] studentPrms = item.Text.Split(' ');

                if (studentPrms.Length != 3)
                    continue;

                Students delStudent = students.SingleOrDefault(x =>
                        x.GetName() == studentPrms[0] &&
                        x.GetSurname() == studentPrms[1] &&
                        x.GetCourse().ToString() == studentPrms[2]
                );

                if (delStudent != null)
                {
                    students.Remove(delStudent);
                }
            }
            UpdateStudentsList();
        }
        private void UpdateStudentsList()
        {
            listStudents.Items.Clear();
            foreach (Students student in students)
            {
                string strStudent = string.Format(
                    "{0} {1} {2}",
                    student.GetName(),
                    student.GetSurname(),
                    student.GetCourse()
                );
                listStudents.Items.Add(strStudent);
            }
        }
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            List<Students> studentsFromFile;
            string errorMessage = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileIO.SetPath(openFileDialog1.FileName);
                    studentsFromFile = FileIO.LoadFromFile();

                    if (studentsFromFile != null)
                    {
                        foreach (Students student in studentsFromFile)
                        {
                            if (ValidateStudentData(student) != "")
                            {
                                errorMessage += "Nepareizi studenta dati! (" + student.ToText() + ")";
                                continue;
                            }
                            if (StudentExist(student))
                            {
                                errorMessage += "Šāds students jau eksistē! (" + student.ToText() + ")";
                                continue;
                            }
                            students.Add(student);
                        }
                    }
                    else
                    {
                        errorMessage += "Neizdevās ielādēt studentu sarakstu no faila!";
                        errorMessage += FileIO.GetErrorMessage();
                    }
                }
                catch (SecurityException ex)
                {
                    errorMessage += $"Security error. Error message: {ex.Message}" +
                    $"Details:{ex.StackTrace}";
                }
            }
            txtMessage.Text = errorMessage;

            UpdateStudentsList();
        }
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileIO.SetPath(saveFileDialog1.FileName);
                    if (!FileIO.WriteToFile(students))
                    {
                        errorMessage += "Neizdevās saglabāt!";
                        errorMessage += FileIO.GetErrorMessage();
                    }
                }
                catch (SecurityException ex)
                {
                    errorMessage += $"Security error. Error message: {ex.Message}" +
                    $"Details: {ex.StackTrace}";
                }
            }

            txtMessage.Text = errorMessage;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }


        //Izveidot demo sarakstu
        //Iezimeto elementu dzesana
        //Uztaisit cilveks var pievienot sarakstam studentu
        //ar try..catch un ifiem nodrosinat kludu apstradi
        //kurss- 1-3
        //Ja ir kluda, tad izvadam
        //String.Split()
    }
}
