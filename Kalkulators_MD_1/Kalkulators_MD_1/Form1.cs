using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators_MD_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOne_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnNine.Text);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            ProcessNumPadInput(btnZero.Text);
        }

        private void ProcessNumPadInput(string value)
        {
            if (Darbiba.GetInput() != "0" || value == ",")
            {
                txtOutput.Text += value;
            }
            else
            {
                txtOutput.Text = value;
            }

            Darbiba.SetInput(txtOutput.Text);

            if (value != ",")
            {
                Darbiba.DoAritmetics();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            Darbiba.Reset();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            ProcessArithmeticsInput(btnSum.Text);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            ProcessArithmeticsInput(btnSubtract.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            ProcessArithmeticsInput(btnMultiply.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            ProcessArithmeticsInput(btnDivide.Text);
        }

        private void ProcessArithmeticsInput(string value)
        {
            Darbiba.SetOperator(value);
            Darbiba.SetInput("0");
            txtOutput.Text = Darbiba.GetResult();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            Darbiba.SetOperator("");
            Darbiba.SetInput("0");
            txtOutput.Text = Darbiba.GetResult();
        }
    }
}
