namespace Uicalc;

public partial class Form1 : Form
{
    
    string currentInput = "";
    private double num1 = 0;
    private double num2 = 0;
    char? currentOperation = null;
    bool isOperationClicked = false;
    private string expression = "";
    
    public Form1()
    {
        InitializeComponent();
    }

    private void HandleNumberInput(string digit)
    {
        if (isOperationClicked)
        {
            currentInput = "";
            isOperationClicked = false;
        }

        // Prevent multiple decimal points
        if (digit == "." && currentInput.Contains("."))
        {
            return;
        }

        // Start with "0." if decimal is pressed first and input is empty
        if (digit == "." && string.IsNullOrEmpty(currentInput))
        {
            currentInput = "0";
        }


        currentInput += digit;
        expression += digit;
        screen.Text = currentInput;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        HandleNumberInput("1");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        HandleNumberInput("2");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        HandleNumberInput("3");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        HandleNumberInput("4");
    }

    private void button7_Click(object sender, EventArgs e)
    {
        HandleNumberInput("5");
    }

    private void button6_Click(object sender, EventArgs e)
    {
        HandleNumberInput("6");
    }

    private void button5_Click(object sender, EventArgs e)
    {
        HandleNumberInput("7");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        HandleNumberInput("8");
    }

    private void button9_Click(object sender, EventArgs e)
    {
        HandleNumberInput("9");
    }

    private void button10_Click(object sender, EventArgs e)
    {
        HandleNumberInput("0");
    }
    
    
   // Operator 
   private void HandleOperator(char operation)
   {
       if (!string.IsNullOrEmpty(currentInput))
       {
           if (currentOperation == null) // First operation
           {
               num1 = double.Parse(currentInput);
           }
           else // Chaining operations (e.g., 5 + 3 - 2)
           {
               num2 = double.Parse(currentInput);
               CalculateResult(); // Calculate the previous operation
               num1 = double.Parse(screen.Text); // Result becomes the new operand1
           }
           currentInput = ""; // Clear for next input or show operand1
           currentOperation = operation;
           isOperationClicked = true;
           expression += " " + operation + " ";
           screen.Text = expression;
           // Optionally, update the display to show operand1 and the operator
           // displayTextBox.Text = operand1.ToString() + " " + operation;
       }
       else if (currentOperation != null) // User changed their mind about the operator
       {
           if (expression.Length > 2)
           {
               expression = expression.Substring(0, expression.Length - 3); // remove " + "
               expression += " " + operation + " ";
               currentOperation = operation;
               screen.Text = expression;
           }
       }
   }
   

    private void button12_Click(object sender, EventArgs e)
    {
        // /
        HandleOperator('/');
        
    }

    private void button15_Click(object sender, EventArgs e)
    {
        // *
        HandleOperator('*');
    }

    private void button13_Click(object sender, EventArgs e)
    {
        // +
        HandleOperator('+');
    }

    private void button17_Click(object sender, EventArgs e)
    {
         // -
         HandleOperator('-');
    }

    private void convert_Click(object sender, EventArgs e)
    {
        //+/-
        if (!string.IsNullOrEmpty(currentInput) && currentInput != "0")
        {
            if (currentInput.StartsWith("-"))
            {
                currentInput = currentInput.Substring(1);
            }
            else
            {
                currentInput = "-" + currentInput;
            }
            screen.Text = currentInput;
        }
    }
    private void button14_Click(object sender, EventArgs e)
    {
        //power
        if (!string.IsNullOrEmpty(currentInput))
        {
            double number = double.Parse(currentInput);
            double result = Math.Pow(number, 2);
            screen.Text = result.ToString();
            currentInput = result.ToString();
            // Consider resetting operation state or allowing chaining
        }
    }


    private void button18_Click(object sender, EventArgs e)
    {
        //root
        if (!string.IsNullOrEmpty(currentInput))
        {
            double number = double.Parse(currentInput);
            if (number >= 0)
            {
                double result = Math.Sqrt(number);
                screen.Text = result.ToString();
                currentInput = result.ToString();
            }
            else
            {
                screen.Text = "Error: Invalid input for √"; // Or handle error appropriately
                currentInput = "";
            }
        }
    }



    private void button11_Click(object sender, EventArgs e)
    {
        //dot
        HandleNumberInput(".");
    }

    
    private void button19_Click(object sender, EventArgs e)
    {
        //left arrow
    }

    private void right_Click(object sender, EventArgs e)
    {
        //right arrow
    }
   
    
    
    
    private void button16_Click(object sender, EventArgs e)
    {
        // enter
        
        if (currentOperation != null && !string.IsNullOrEmpty(currentInput))
        {
            num2 = double.Parse(currentInput);
            expression += " = ";
            CalculateResult();
            expression += screen.Text;
            currentOperation = null; // Reset operation after calculation
            isOperationClicked = false; // Ready for new number input
            currentInput =  screen.Text; // The result is now the current input for further operations
        }
    }
    
    
    // result calculation
    private void CalculateResult()
    {
        double result = 0;
        try
        {
            switch (currentOperation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        screen.Text = "Error: Cannot divide by zero";
                        ResetCalculatorState();
                        return;
                    }
                    result = num1 / num2;
                    break;
                // Add cases for any other binary operators you might have
            }
            screen.Text = result.ToString();
            currentInput = result.ToString(); // Store result for potential chaining
            num1 = result; // The result becomes the new operand1 for chained operations
            // operand2 = 0; // Not strictly necessary to reset here, but can be good practice
            // currentOperation = null; // Moved to Enter_Click to allow chaining before hitting enter
        }
        catch (Exception ex)
        {
            screen.Text = "Error";
            System.Diagnostics.Debug.WriteLine($"Calculation Error: {ex.Message}");
            ResetCalculatorState();
        }
    }
    
    
    
    private void screen_TextChanged(object sender, EventArgs e)
    { 
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void Clear_Click(object sender, EventArgs e)
    {
        // clear 
        ResetCalculatorState(); 
            screen.Text = "0"; 
    }
    
    private void ResetCalculatorState()
    {
        currentInput = "";
        expression = "";
        num1 = 0;
        num2 = 0;
        currentOperation = null;
        isOperationClicked = false;
    }
}