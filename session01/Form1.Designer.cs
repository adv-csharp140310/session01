namespace session01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCalc = new Button();
            buttonUsers = new Button();
            SuspendLayout();
            // 
            // buttonCalc
            // 
            buttonCalc.Location = new Point(12, 12);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(75, 23);
            buttonCalc.TabIndex = 0;
            buttonCalc.Text = "Calc";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Location = new Point(12, 41);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(75, 23);
            buttonUsers.TabIndex = 1;
            buttonUsers.Text = "Users";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 286);
            Controls.Add(buttonUsers);
            Controls.Add(buttonCalc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCalc;
        private Button buttonUsers;
    }
}
