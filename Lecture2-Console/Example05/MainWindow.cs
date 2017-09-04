using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public partial class MainWindow : Form
    {
        //宣告在這邊~~ 這樣每個function都可以用
        private bool hasDotDigit = false;

        private bool operatinput = false;

        private float result, numbernow;
        private int operation = 0;  //0 = first  1 = add  2 = minus  3 = mult  4 = devide

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0" )
            { ResultTextBox.Text = ResultTextBox.Text + "1"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "1"; }

            if (operatinput)
            {
                ResultTextBox.Text = "1";
                operatinput = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "2"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "2"; }
            if (operatinput)
            {
                ResultTextBox.Text = "2";
                operatinput = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "3"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "3"; }
            if (operatinput)
            {
                ResultTextBox.Text = "3";
                operatinput = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "4"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "4"; }
            if (operatinput)
            {
                ResultTextBox.Text = "4";
                operatinput = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "5"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "5"; }
            if (operatinput)
            {
                ResultTextBox.Text = "5";
                operatinput = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "6"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "6"; }
            if (operatinput)
            {
                ResultTextBox.Text = "6";
                operatinput = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "7"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "7"; }
            if (operatinput)
            {
                ResultTextBox.Text = "7";
                operatinput = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "8"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "8"; }
            if (operatinput)
            {
                ResultTextBox.Text = "8";
                operatinput = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "9"; }
            if (ResultTextBox.Text == "0")
            { ResultTextBox.Text = "9"; }
            if (operatinput)
            {
                ResultTextBox.Text = "9";
                operatinput = false;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ResultTextBox.Text != "0")
            { ResultTextBox.Text = ResultTextBox.Text + "0"; }
            if (operatinput)
            {
                ResultTextBox.Text = "0";
                operatinput = false;
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!hasDotDigit)
            {
                if (ResultTextBox.Text != "")
                {
                    ResultTextBox.Text = ResultTextBox.Text + '.';
                    hasDotDigit = true;
                }
                if (ResultTextBox.Text == "")
                {
                    ResultTextBox.Text = "0" + ".";
                    hasDotDigit = true;
                }
            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (operation == 1)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result + numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 2)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result - numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 3)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result * numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 4)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result / numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            operation = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = numbernow;
                operatinput = true;
            }
            else if (operation == 1)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result + numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 2)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result - numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 3)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result * numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 4)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result / numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            operation = 1;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = numbernow;
                operatinput = true;
            }
            else if (operation == 1)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result + numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 2)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result - numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 3)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result * numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 4)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result / numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            operation = 2;
        }

        private void allclearButton_Click(object sender, EventArgs e)
        {
            result = 0;
            ResultTextBox.Text = "0";
            hasDotDigit = false;
            operatinput = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            hasDotDigit = false;
            operatinput = true;
        }

        private void multButton_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = numbernow;
                operatinput = true;
            }
            else if (operation == 1)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result + numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 2)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result - numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 3)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result * numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 4)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result / numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            operation = 3;
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = numbernow;
                operatinput = true;
            }
            else if (operation == 1)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result + numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 2)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result - numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 3)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result * numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            else if (operation == 4)
            {
                numbernow = float.Parse(ResultTextBox.Text);
                result = result / numbernow;
                ResultTextBox.Text = (result).ToString();
                hasDotDigit = false;
                operatinput = true;
            }
            operation = 4;
        }
    }
}