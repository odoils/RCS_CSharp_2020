namespace Day16FileOpen
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
            this.BtnAddList = new System.Windows.Forms.Button();
            this.TestListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BtnAddList
            // 
            this.BtnAddList.Location = new System.Drawing.Point(68, 37);
            this.BtnAddList.Name = "BtnAddList";
            this.BtnAddList.Size = new System.Drawing.Size(148, 43);
            this.BtnAddList.TabIndex = 0;
            this.BtnAddList.Text = "izveidot sarakstu";
            this.BtnAddList.UseVisualStyleBackColor = true;
            // 
            // TestListView
            // 
            this.TestListView.HideSelection = false;
            this.TestListView.Location = new System.Drawing.Point(270, 25);
            this.TestListView.Name = "TestListView";
            this.TestListView.Size = new System.Drawing.Size(213, 299);
            this.TestListView.TabIndex = 1;
            this.TestListView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestListView);
            this.Controls.Add(this.BtnAddList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddList;
        private System.Windows.Forms.ListView TestListView;
    }
}

