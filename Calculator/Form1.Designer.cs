namespace Calculator;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        num1 = new System.Windows.Forms.TextBox();
        num2 = new System.Windows.Forms.TextBox();
        operate = new System.Windows.Forms.ComboBox();
        button1 = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // num1
        // 
        num1.Location = new System.Drawing.Point(315, 119);
        num1.Name = "num1";
        num1.Size = new System.Drawing.Size(181, 23);
        num1.TabIndex = 0;
        num1.TextChanged += num1_TextChanged;
        // 
        // num2
        // 
        num2.Location = new System.Drawing.Point(315, 245);
        num2.Name = "num2";
        num2.Size = new System.Drawing.Size(181, 23);
        num2.TabIndex = 2;
        num2.TextChanged += num2_TextChanged;
        // 
        // operate
        // 
        operate.FormattingEnabled = true;
        operate.Items.AddRange(new object[] { "-", "*", "/", "+" });
        operate.Location = new System.Drawing.Point(315, 181);
        operate.Name = "operate";
        operate.Size = new System.Drawing.Size(181, 23);
        operate.Sorted = true;
        operate.TabIndex = 3;
        operate.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(356, 308);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(105, 39);
        button1.TabIndex = 4;
        button1.Text = "Calculate";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(210, 126);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(71, 16);
        label1.TabIndex = 5;
        label1.Text = "1st Number";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(210, 252);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(85, 16);
        label2.TabIndex = 6;
        label2.Text = "2nd Number";
        label2.Click += label2_Click;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(210, 188);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(71, 16);
        label3.TabIndex = 7;
        label3.Text = "Operation";
        label3.Click += label3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(operate);
        Controls.Add(num2);
        Controls.Add(num1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox operate;

    private System.Windows.Forms.TextBox num1;
    private System.Windows.Forms.TextBox num2;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Button button1;

    #endregion
}