namespace session01.UI;

partial class FormCalc
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
        textBoxA = new TextBox();
        textBoxB = new TextBox();
        label2 = new Label();
        buttonAdd = new Button();
        buttonSub = new Button();
        buttonMul = new Button();
        buttonDiv = new Button();
        textBoxResult = new TextBox();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(44, 35);
        label1.Name = "label1";
        label1.Size = new Size(15, 15);
        label1.TabIndex = 0;
        label1.Text = "A";
        // 
        // textBoxA
        // 
        textBoxA.Location = new Point(65, 32);
        textBoxA.Name = "textBoxA";
        textBoxA.Size = new Size(206, 23);
        textBoxA.TabIndex = 1;
        // 
        // textBoxB
        // 
        textBoxB.Location = new Point(65, 61);
        textBoxB.Name = "textBoxB";
        textBoxB.Size = new Size(206, 23);
        textBoxB.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(44, 64);
        label2.Name = "label2";
        label2.Size = new Size(14, 15);
        label2.TabIndex = 2;
        label2.Text = "B";
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(65, 103);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(47, 23);
        buttonAdd.TabIndex = 4;
        buttonAdd.Text = "➕";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // buttonSub
        // 
        buttonSub.Location = new Point(118, 103);
        buttonSub.Name = "buttonSub";
        buttonSub.Size = new Size(47, 23);
        buttonSub.TabIndex = 5;
        buttonSub.Text = "➖";
        buttonSub.UseVisualStyleBackColor = true;
        // 
        // buttonMul
        // 
        buttonMul.Location = new Point(171, 103);
        buttonMul.Name = "buttonMul";
        buttonMul.Size = new Size(47, 23);
        buttonMul.TabIndex = 6;
        buttonMul.Text = "*";
        buttonMul.UseVisualStyleBackColor = true;
        // 
        // buttonDiv
        // 
        buttonDiv.Location = new Point(224, 103);
        buttonDiv.Name = "buttonDiv";
        buttonDiv.Size = new Size(47, 23);
        buttonDiv.TabIndex = 7;
        buttonDiv.Text = "➗";
        buttonDiv.UseVisualStyleBackColor = true;
        // 
        // textBoxResult
        // 
        textBoxResult.Location = new Point(65, 141);
        textBoxResult.Name = "textBoxResult";
        textBoxResult.ReadOnly = true;
        textBoxResult.Size = new Size(206, 23);
        textBoxResult.TabIndex = 9;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(44, 144);
        label3.Name = "label3";
        label3.Size = new Size(15, 15);
        label3.TabIndex = 8;
        label3.Text = "=";
        // 
        // FormCalc
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(328, 261);
        Controls.Add(textBoxResult);
        Controls.Add(label3);
        Controls.Add(buttonDiv);
        Controls.Add(buttonMul);
        Controls.Add(buttonSub);
        Controls.Add(buttonAdd);
        Controls.Add(textBoxB);
        Controls.Add(label2);
        Controls.Add(textBoxA);
        Controls.Add(label1);
        Name = "FormCalc";
        Text = "FormCalc";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBoxA;
    private TextBox textBoxB;
    private Label label2;
    private Button buttonAdd;
    private Button buttonSub;
    private Button buttonMul;
    private Button buttonDiv;
    private TextBox textBoxResult;
    private Label label3;
}