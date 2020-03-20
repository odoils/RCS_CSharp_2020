using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day15_WindovsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!FieldsEmpty(vardaIevade.Text, vecums.Text))
            {
                izvade.Text = "Sveiks, " + vardaIevade.Text + ", Tev ir " + vecums.Text + " gadi";
            }
        }

        private bool FieldsEmpty(String field1, String field2)
        {
            if (field1 == "")
            {
                izvade.Text = "Pietrukst vards";
                return true;
            }

            if (field2 == "")
            {
                izvade.Text = "Pietrukst vecums";
                return true;
            }
            return false;
        }
    }
}
