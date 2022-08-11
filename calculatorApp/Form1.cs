namespace calculatorApp
{
    public partial class Form1 : Form
    {
        
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "1";
            calculatorDisplay.Text += userInput; 
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";

            calculatorDisplay.Text += "0";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == '0') 
                {
                    calculatorDisplay.Text = "Division by zero restricted.";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }
            }
            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }
        }

            private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
        }
    }
}