using Microsoft.VisualBasic.CompilerServices;

namespace Calculator;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    


    private void button1_Click(object sender, EventArgs e)
    {

        try
        {
            int n1 = int.Parse(num1.Text);
            int n2 = int.Parse(num2.Text);
            string op = operate.Text;

            switch (op)
            {
                case "+":
                    MessageBox.Show($"{n1} + {n2} = {n1 + n2}");
                    break;
                case "-":
                    MessageBox.Show($"{n1} - {n2} = {n1 - n2}");
                    break;
                case "*":
                    MessageBox.Show($"{n1} * {n2} = {n1 * n2}");
                    break;
                case "/":
                    MessageBox.Show($"{n1} / {n2} = {n1 / n2}");
                    break;
                default:
                    MessageBox.Show("Invalid Operation!!");
                    break;

            }
        }
        catch (FormatException)
        {
            MessageBox.Show("Error parsing number !!");
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void label3_Click(object sender, EventArgs e) { }
    private void label2_Click(object sender, EventArgs e) { }
    private void num1_TextChanged(object sender, EventArgs e) { }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    private void num2_TextChanged(object sender, EventArgs e) { }
}
