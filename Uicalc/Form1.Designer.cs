namespace Uicalc;

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
        screen = new System.Windows.Forms.TextBox();
        one = new System.Windows.Forms.Button();
        two = new System.Windows.Forms.Button();
        three = new System.Windows.Forms.Button();
        four = new System.Windows.Forms.Button();
        seven = new System.Windows.Forms.Button();
        six = new System.Windows.Forms.Button();
        five = new System.Windows.Forms.Button();
        eight = new System.Windows.Forms.Button();
        nine = new System.Windows.Forms.Button();
        zero = new System.Windows.Forms.Button();
        dot = new System.Windows.Forms.Button();
        divide = new System.Windows.Forms.Button();
        add = new System.Windows.Forms.Button();
        power = new System.Windows.Forms.Button();
        multiply = new System.Windows.Forms.Button();
        enter = new System.Windows.Forms.Button();
        subtract = new System.Windows.Forms.Button();
        sqrt = new System.Windows.Forms.Button();
        left = new System.Windows.Forms.Button();
        right = new System.Windows.Forms.Button();
        convert = new System.Windows.Forms.Button();
        Clear = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // screen
        // 
        screen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        screen.Location = new System.Drawing.Point(157, 53);
        screen.Multiline = true;
        screen.Name = "screen";
        screen.ReadOnly = true;
        screen.Size = new System.Drawing.Size(453, 71);
        screen.TabIndex = 0;
        screen.TextChanged += screen_TextChanged;
        // 
        // one
        // 
        one.Location = new System.Drawing.Point(163, 214);
        one.Name = "one";
        one.Size = new System.Drawing.Size(61, 47);
        one.TabIndex = 1;
        one.Text = "1";
        one.UseVisualStyleBackColor = true;
        one.Click += button1_Click;
        // 
        // two
        // 
        two.Location = new System.Drawing.Point(267, 214);
        two.Name = "two";
        two.Size = new System.Drawing.Size(61, 47);
        two.TabIndex = 2;
        two.Text = "2";
        two.UseVisualStyleBackColor = true;
        two.Click += button2_Click;
        // 
        // three
        // 
        three.Location = new System.Drawing.Point(359, 214);
        three.Name = "three";
        three.Size = new System.Drawing.Size(61, 47);
        three.TabIndex = 3;
        three.Text = "3";
        three.UseVisualStyleBackColor = true;
        three.Click += button3_Click;
        // 
        // four
        // 
        four.Location = new System.Drawing.Point(163, 291);
        four.Name = "four";
        four.Size = new System.Drawing.Size(61, 47);
        four.TabIndex = 4;
        four.Text = "4";
        four.UseVisualStyleBackColor = true;
        four.Click += button4_Click;
        // 
        // seven
        // 
        seven.Location = new System.Drawing.Point(163, 364);
        seven.Name = "seven";
        seven.Size = new System.Drawing.Size(61, 47);
        seven.TabIndex = 5;
        seven.Text = "7";
        seven.UseVisualStyleBackColor = true;
        seven.Click += button5_Click;
        // 
        // six
        // 
        six.Location = new System.Drawing.Point(359, 291);
        six.Name = "six";
        six.Size = new System.Drawing.Size(61, 47);
        six.TabIndex = 6;
        six.Text = "6";
        six.UseVisualStyleBackColor = true;
        six.Click += button6_Click;
        // 
        // five
        // 
        five.Location = new System.Drawing.Point(267, 291);
        five.Name = "five";
        five.Size = new System.Drawing.Size(61, 47);
        five.TabIndex = 7;
        five.Text = "5";
        five.UseVisualStyleBackColor = true;
        five.Click += button7_Click;
        // 
        // eight
        // 
        eight.Location = new System.Drawing.Point(267, 364);
        eight.Name = "eight";
        eight.Size = new System.Drawing.Size(61, 47);
        eight.TabIndex = 8;
        eight.Text = "8";
        eight.UseVisualStyleBackColor = true;
        eight.Click += button8_Click;
        // 
        // nine
        // 
        nine.Location = new System.Drawing.Point(359, 364);
        nine.Name = "nine";
        nine.Size = new System.Drawing.Size(61, 47);
        nine.TabIndex = 9;
        nine.Text = "9";
        nine.UseVisualStyleBackColor = true;
        nine.Click += button9_Click;
        // 
        // zero
        // 
        zero.Location = new System.Drawing.Point(163, 434);
        zero.Name = "zero";
        zero.Size = new System.Drawing.Size(165, 47);
        zero.TabIndex = 10;
        zero.Text = "0";
        zero.UseVisualStyleBackColor = true;
        zero.Click += button10_Click;
        // 
        // dot
        // 
        dot.Location = new System.Drawing.Point(359, 434);
        dot.Name = "dot";
        dot.Size = new System.Drawing.Size(61, 47);
        dot.TabIndex = 11;
        dot.Text = ".";
        dot.UseVisualStyleBackColor = true;
        dot.Click += button11_Click;
        // 
        // divide
        // 
        divide.Location = new System.Drawing.Point(458, 214);
        divide.Name = "divide";
        divide.Size = new System.Drawing.Size(61, 47);
        divide.TabIndex = 12;
        divide.Text = "/";
        divide.UseVisualStyleBackColor = true;
        divide.Click += button12_Click;
        // 
        // add
        // 
        add.Location = new System.Drawing.Point(458, 291);
        add.Name = "add";
        add.Size = new System.Drawing.Size(61, 47);
        add.TabIndex = 13;
        add.Text = "+";
        add.UseVisualStyleBackColor = true;
        add.Click += button13_Click;
        // 
        // power
        // 
        power.Location = new System.Drawing.Point(458, 364);
        power.Name = "power";
        power.Size = new System.Drawing.Size(61, 47);
        power.TabIndex = 14;
        power.Text = "^2";
        power.UseVisualStyleBackColor = true;
        power.Click += button14_Click;
        // 
        // multiply
        // 
        multiply.Location = new System.Drawing.Point(549, 214);
        multiply.Name = "multiply";
        multiply.Size = new System.Drawing.Size(61, 47);
        multiply.TabIndex = 15;
        multiply.Text = "*";
        multiply.UseVisualStyleBackColor = true;
        multiply.Click += button15_Click;
        // 
        // enter
        // 
        enter.Location = new System.Drawing.Point(467, 434);
        enter.Name = "enter";
        enter.Size = new System.Drawing.Size(143, 47);
        enter.TabIndex = 16;
        enter.Text = "Enter";
        enter.UseVisualStyleBackColor = true;
        enter.Click += button16_Click;
        // 
        // subtract
        // 
        subtract.Location = new System.Drawing.Point(549, 291);
        subtract.Name = "subtract";
        subtract.Size = new System.Drawing.Size(61, 47);
        subtract.TabIndex = 17;
        subtract.Text = "-";
        subtract.UseVisualStyleBackColor = true;
        subtract.Click += button17_Click;
        // 
        // sqrt
        // 
        sqrt.Location = new System.Drawing.Point(549, 364);
        sqrt.Name = "sqrt";
        sqrt.Size = new System.Drawing.Size(61, 47);
        sqrt.TabIndex = 18;
        sqrt.Text = "√";
        sqrt.UseVisualStyleBackColor = true;
        sqrt.Click += button18_Click;
        // 
        // left
        // 
        left.Location = new System.Drawing.Point(273, 146);
        left.Name = "left";
        left.Size = new System.Drawing.Size(100, 47);
        left.TabIndex = 19;
        left.Text = "<-";
        left.UseVisualStyleBackColor = true;
        left.Click += button19_Click;
        // 
        // right
        // 
        right.Location = new System.Drawing.Point(379, 146);
        right.Name = "right";
        right.Size = new System.Drawing.Size(100, 47);
        right.TabIndex = 20;
        right.Text = "->";
        right.UseVisualStyleBackColor = true;
        right.Click += right_Click;
        // 
        // convert
        // 
        convert.Location = new System.Drawing.Point(548, 146);
        convert.Name = "convert";
        convert.Size = new System.Drawing.Size(61, 47);
        convert.TabIndex = 21;
        convert.Text = "+/-";
        convert.UseVisualStyleBackColor = true;
        convert.Click += convert_Click;
        // 
        // Clear
        // 
        Clear.Location = new System.Drawing.Point(162, 149);
        Clear.Name = "Clear";
        Clear.Size = new System.Drawing.Size(61, 43);
        Clear.TabIndex = 22;
        Clear.Text = "Clear";
        Clear.UseVisualStyleBackColor = true;
        Clear.Click += Clear_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 561);
        Controls.Add(Clear);
        Controls.Add(convert);
        Controls.Add(right);
        Controls.Add(left);
        Controls.Add(sqrt);
        Controls.Add(subtract);
        Controls.Add(enter);
        Controls.Add(multiply);
        Controls.Add(power);
        Controls.Add(add);
        Controls.Add(divide);
        Controls.Add(dot);
        Controls.Add(zero);
        Controls.Add(nine);
        Controls.Add(eight);
        Controls.Add(five);
        Controls.Add(six);
        Controls.Add(seven);
        Controls.Add(four);
        Controls.Add(three);
        Controls.Add(two);
        Controls.Add(one);
        Controls.Add(screen);
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button Clear;

    private System.Windows.Forms.Button convert;

    private System.Windows.Forms.Button right;

    private System.Windows.Forms.Button left;

    private System.Windows.Forms.TextBox screen;
    private System.Windows.Forms.Button one;
    private System.Windows.Forms.Button two;
    private System.Windows.Forms.Button three;
    private System.Windows.Forms.Button four;
    private System.Windows.Forms.Button seven;
    private System.Windows.Forms.Button six;
    private System.Windows.Forms.Button five;
    private System.Windows.Forms.Button eight;
    private System.Windows.Forms.Button nine;
    private System.Windows.Forms.Button zero;
    private System.Windows.Forms.Button dot;
    private System.Windows.Forms.Button divide;
    private System.Windows.Forms.Button add;
    private System.Windows.Forms.Button power;
    private System.Windows.Forms.Button multiply;
    private System.Windows.Forms.Button enter;
    private System.Windows.Forms.Button subtract;
    private System.Windows.Forms.Button sqrt;

    #endregion
}