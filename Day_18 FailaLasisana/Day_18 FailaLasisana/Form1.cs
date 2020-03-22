using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_18_FailaLasisana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "";
            List<string> Test = FileIO.LoadFromFile();

            if (Test != null)
            {
                foreach (string vards in Test)
                {
                    listWords.Items.Add(vards);
                }
            }
            else
            {
                txtMessage.Text += "Neizdevās ielādēt vārdus no faila!";
                txtMessage.Text += FileIO.GetErrorMessage();
            }
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
