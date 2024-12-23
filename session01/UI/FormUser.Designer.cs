namespace session01.UI;

partial class FormUser
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
        label1 = new Label();
        textBoxID = new TextBox();
        textBoxFirstName = new TextBox();
        label2 = new Label();
        textBoxLastName = new TextBox();
        label3 = new Label();
        textBoxTel = new TextBox();
        label4 = new Label();
        textBoxEmail = new TextBox();
        label5 = new Label();
        buttonFirst = new Button();
        buttonPrev = new Button();
        buttonLast = new Button();
        buttonNext = new Button();
        buttonSave = new Button();
        buttonDelete = new Button();
        buttonNew = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(47, 24);
        label1.Name = "label1";
        label1.Size = new Size(17, 15);
        label1.TabIndex = 0;
        label1.Text = "Id";
        // 
        // textBoxID
        // 
        textBoxID.Location = new Point(124, 21);
        textBoxID.Name = "textBoxID";
        textBoxID.Size = new Size(243, 23);
        textBoxID.TabIndex = 1;
        // 
        // textBoxFirstName
        // 
        textBoxFirstName.Location = new Point(124, 50);
        textBoxFirstName.Name = "textBoxFirstName";
        textBoxFirstName.Size = new Size(243, 23);
        textBoxFirstName.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(47, 53);
        label2.Name = "label2";
        label2.Size = new Size(64, 15);
        label2.TabIndex = 2;
        label2.Text = "First Name";
        // 
        // textBoxLastName
        // 
        textBoxLastName.Location = new Point(124, 79);
        textBoxLastName.Name = "textBoxLastName";
        textBoxLastName.Size = new Size(243, 23);
        textBoxLastName.TabIndex = 5;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(47, 82);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 4;
        label3.Text = "Last Name";
        // 
        // textBoxTel
        // 
        textBoxTel.Location = new Point(124, 108);
        textBoxTel.Name = "textBoxTel";
        textBoxTel.Size = new Size(243, 23);
        textBoxTel.TabIndex = 7;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(47, 111);
        label4.Name = "label4";
        label4.Size = new Size(21, 15);
        label4.TabIndex = 6;
        label4.Text = "Tel";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(124, 137);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(243, 23);
        textBoxEmail.TabIndex = 9;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(47, 140);
        label5.Name = "label5";
        label5.Size = new Size(36, 15);
        label5.TabIndex = 8;
        label5.Text = "Email";
        // 
        // buttonFirst
        // 
        buttonFirst.Location = new Point(47, 181);
        buttonFirst.Name = "buttonFirst";
        buttonFirst.Size = new Size(36, 23);
        buttonFirst.TabIndex = 10;
        buttonFirst.Text = "<<";
        buttonFirst.UseVisualStyleBackColor = true;
        buttonFirst.Click += buttonFirst_Click;
        // 
        // buttonPrev
        // 
        buttonPrev.Location = new Point(89, 181);
        buttonPrev.Name = "buttonPrev";
        buttonPrev.Size = new Size(36, 23);
        buttonPrev.TabIndex = 11;
        buttonPrev.Text = "<";
        buttonPrev.UseVisualStyleBackColor = true;
        buttonPrev.Click += buttonPrev_Click;
        // 
        // buttonLast
        // 
        buttonLast.Location = new Point(331, 181);
        buttonLast.Name = "buttonLast";
        buttonLast.Size = new Size(36, 23);
        buttonLast.TabIndex = 13;
        buttonLast.Text = ">>";
        buttonLast.UseVisualStyleBackColor = true;
        buttonLast.Click += buttonLast_Click;
        // 
        // buttonNext
        // 
        buttonNext.Location = new Point(289, 181);
        buttonNext.Name = "buttonNext";
        buttonNext.Size = new Size(36, 23);
        buttonNext.TabIndex = 12;
        buttonNext.Text = ">";
        buttonNext.UseVisualStyleBackColor = true;
        buttonNext.Click += buttonNext_Click;
        // 
        // buttonSave
        // 
        buttonSave.Location = new Point(131, 181);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(44, 23);
        buttonSave.TabIndex = 14;
        buttonSave.Text = "Save";
        buttonSave.UseVisualStyleBackColor = true;
        buttonSave.Click += buttonSave_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(181, 181);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(48, 23);
        buttonDelete.TabIndex = 15;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonNew
        // 
        buttonNew.Location = new Point(235, 181);
        buttonNew.Name = "buttonNew";
        buttonNew.Size = new Size(48, 23);
        buttonNew.TabIndex = 16;
        buttonNew.Text = "New";
        buttonNew.UseVisualStyleBackColor = true;
        buttonNew.Click += buttonNew_Click;
        // 
        // FormUser
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(402, 230);
        Controls.Add(buttonNew);
        Controls.Add(buttonDelete);
        Controls.Add(buttonSave);
        Controls.Add(buttonLast);
        Controls.Add(buttonNext);
        Controls.Add(buttonPrev);
        Controls.Add(buttonFirst);
        Controls.Add(textBoxEmail);
        Controls.Add(label5);
        Controls.Add(textBoxTel);
        Controls.Add(label4);
        Controls.Add(textBoxLastName);
        Controls.Add(label3);
        Controls.Add(textBoxFirstName);
        Controls.Add(label2);
        Controls.Add(textBoxID);
        Controls.Add(label1);
        Name = "FormUser";
        Text = "FormUser";
        Load += FormUser_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxID;
    private TextBox textBoxFirstName;
    private Label label2;
    private TextBox textBoxLastName;
    private Label label3;
    private TextBox textBoxTel;
    private Label label4;
    private TextBox textBoxEmail;
    private Label label5;
    private Button buttonFirst;
    private Button buttonPrev;
    private Button buttonLast;
    private Button buttonNext;
    private Button buttonSave;
    private Button buttonDelete;
    private Button buttonNew;
}