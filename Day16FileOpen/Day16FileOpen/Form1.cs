using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day16FileOpen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Stringu lists
        //Pievienot jaunu saraksta elementu
        //Cilveks teksta lauka
        //mes sadu elementu pievienojam listView

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            List<String> testList = new List<String>();

            for (int i = 0; i < 5; i++)
            {
                testList.Add((i + 1) + ". elements");
            }

            foreach (String str in testList)
            {
                var item = new ListViewItem();
                item.Text = str;
                TestListView.Items.Add(item);
            }
        }        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //bool duplicate = false;
            if (inputText.Text != "")
            {
                if (TestListView.FindItemWithText(inputText.Text) == null)
                {
                    TestListView.Items.Add(new ListViewItem(inputText.Text));
                }
            }
        }
    }
           
}
