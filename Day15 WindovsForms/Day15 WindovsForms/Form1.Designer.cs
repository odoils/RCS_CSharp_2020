namespace Day15_WindovsForms
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
            this.izvade = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.vardaIevade = new System.Windows.Forms.TextBox();
            this.vecums = new System.Windows.Forms.TextBox();
            this.teksts1 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // izvade
            // 
            this.izvade.AccessibleName = "btDemo";
            this.izvade.AutoSize = true;
            this.izvade.Location = new System.Drawing.Point(107, 254);
            this.izvade.Name = "izvade";
            this.izvade.Size = new System.Drawing.Size(99, 20);
            this.izvade.TabIndex = 0;
            this.izvade.Text = "Demo teksts";
            // 
            // button1
            // 
            this.button1.AccessibleName = "poga";
            this.button1.Location = new System.Drawing.Point(111, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "spied seit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vardaIevade
            // 
            this.vardaIevade.Location = new System.Drawing.Point(106, 31);
            this.vardaIevade.Name = "vardaIevade";
            this.vardaIevade.Size = new System.Drawing.Size(100, 26);
            this.vardaIevade.TabIndex = 2;
            // 
            // vecums
            // 
            this.vecums.Location = new System.Drawing.Point(106, 81);
            this.vecums.Name = "vecums";
            this.vecums.Size = new System.Drawing.Size(100, 26);
            this.vecums.TabIndex = 3;
            // 
            // teksts1
            // 
            this.teksts1.AccessibleName = "btDemo";
            this.teksts1.AutoSize = true;
            this.teksts1.Location = new System.Drawing.Point(25, 31);
            this.teksts1.Name = "teksts1";
            this.teksts1.Size = new System.Drawing.Size(51, 20);
            this.teksts1.TabIndex = 4;
            this.teksts1.Text = "Vards";
            // 
            // Age
            // 
            this.Age.AccessibleName = "btDemo";
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(25, 87);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(67, 20);
            this.Age.TabIndex = 5;
            this.Age.Text = "Vecums";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.teksts1);
            this.Controls.Add(this.vecums);
            this.Controls.Add(this.vardaIevade);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.izvade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label izvade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vardaIevade;
        private System.Windows.Forms.TextBox vecums;
        private System.Windows.Forms.Label teksts1;
        private System.Windows.Forms.Label Age;
    }
}

