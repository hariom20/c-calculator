using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result_value = 0;
        String Operation_perform = "";
        bool isoperationPerformed = false;
        String message = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text =="0" || isoperationPerformed)
            {
                textBox_result.Clear();
            }
            Button button = (Button)sender;
            isoperationPerformed = false;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains(".")) {
                    textBox_result.Text = textBox_result.Text + button.Text;
                }

            }
            else
            {
                textBox_result.Text = textBox_result.Text + button.Text;
                
            }

        }

        private void MathOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result_value!=0)
            {
                button7.PerformClick();
                Operation_perform = button.Text;
                labelcurrentoperation.Text = result_value + " " + Operation_perform;
                isoperationPerformed = true;
            }
            else
            {
                Operation_perform = button.Text;
                result_value = Double.Parse(textBox_result.Text);
                labelcurrentoperation.Text = result_value + " " + Operation_perform;
                isoperationPerformed = true;
            }
        }

        private void Clear_entry(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result_value = 0;
            message = "";
        }

        private void final_result(object sender, EventArgs e)
        {
            switch (Operation_perform)
            {
                case "+":
                    textBox_result.Text = (result_value + Double.Parse(textBox_result.Text)).ToString();
                    message = "The result is " + textBox_result.Text;
                    break;
                case "-":
                    textBox_result.Text = (result_value - Double.Parse(textBox_result.Text)).ToString();
                    message = "The result is " + textBox_result.Text;
                    break;
                case "*":
                    textBox_result.Text = (result_value * Double.Parse(textBox_result.Text)).ToString();
                    message = "The result is " + textBox_result.Text;
                    break;
                case "/":
                    textBox_result.Text = (result_value / Double.Parse(textBox_result.Text)).ToString();
                    message = "The result is " + textBox_result.Text;
                    break;
                default:
                    break;
            }
            result_value = Double.Parse(textBox_result.Text);
            labelcurrentoperation.Text = "";
            groupBox.Text = message;
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {
            button7.PerformClick();
            groupBox.Text = message;
        }
    }
}
