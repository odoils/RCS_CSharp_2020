namespace Day_18_FailaLasisana
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
            this.listWords = new System.Windows.Forms.ListView();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listWords
            // 
            this.listWords.HideSelection = false;
            this.listWords.Location = new System.Drawing.Point(437, 75);
            this.listWords.Name = "listWords";
            this.listWords.Size = new System.Drawing.Size(271, 344);
            this.listWords.TabIndex = 0;
            this.listWords.UseCompatibleStateImageBehavior = false;
            this.listWords.View = System.Windows.Forms.View.List;
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(121, 101);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(107, 42);
            this.btnReadFromFile.TabIndex = 1;
            this.btnReadFromFile.Text = "NOLASIT";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(194, 206);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(154, 150);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.listWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        

        private System.Windows.Forms.ListView listWords;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.RichTextBox txtMessage;
    }
}

