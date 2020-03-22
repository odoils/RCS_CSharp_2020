namespace StudentsGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listStudents = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddDemoData = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.inpName = new System.Windows.Forms.TextBox();
            this.inpSurname = new System.Windows.Forms.TextBox();
            this.inpCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listStudents
            // 
            this.listStudents.HideSelection = false;
            this.listStudents.Location = new System.Drawing.Point(343, 35);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(212, 97);
            this.listStudents.TabIndex = 0;
            this.listStudents.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Pievienot";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(19, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Dzest";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddDemoData
            // 
            this.btnAddDemoData.Location = new System.Drawing.Point(19, 102);
            this.btnAddDemoData.Name = "btnAddDemoData";
            this.btnAddDemoData.Size = new System.Drawing.Size(91, 36);
            this.btnAddDemoData.TabIndex = 3;
            this.btnAddDemoData.Text = "AddDemo";
            this.btnAddDemoData.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(19, 158);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(91, 30);
            this.btnLoadFromFile.TabIndex = 4;
            this.btnLoadFromFile.Text = "Ielade";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(19, 25);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(91, 32);
            this.btnSaveToFile.TabIndex = 5;
            this.btnSaveToFile.Text = "Saglabat";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            // 
            // inpName
            // 
            this.inpName.Location = new System.Drawing.Point(152, 50);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(100, 26);
            this.inpName.TabIndex = 6;
            // 
            // inpSurname
            // 
            this.inpSurname.Location = new System.Drawing.Point(152, 128);
            this.inpSurname.Name = "inpSurname";
            this.inpSurname.Size = new System.Drawing.Size(100, 26);
            this.inpSurname.TabIndex = 7;
            // 
            // inpCourse
            // 
            this.inpCourse.Location = new System.Drawing.Point(152, 209);
            this.inpCourse.Name = "inpCourse";
            this.inpCourse.Size = new System.Drawing.Size(100, 26);
            this.inpCourse.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uzvards";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kurss";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveToFile);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnLoadFromFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAddDemoData);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inpName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inpCourse);
            this.groupBox1.Controls.Add(this.inpSurname);
            this.groupBox1.Location = new System.Drawing.Point(40, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 406);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(343, 209);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(212, 182);
            this.txtMessage.TabIndex = 13;
            this.txtMessage.Text = "";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStudents;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddDemoData;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.TextBox inpSurname;
        private System.Windows.Forms.TextBox inpCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtMessage;
    }
}

