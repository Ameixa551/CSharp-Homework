using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
                try
            {
                num1 = Convert.ToInt32(input1.Text);
                num2 = Convert.ToInt32(input2.Text);
                switch (opr_choose.SelectedItem)
                {
                    case "+":
                        output.Text = Convert.ToString(num1 + num2);
                        break;
                    case "-":
                        output.Text = Convert.ToString(num1 - num2);
                        break;
                    case "*":
                        output.Text = Convert.ToString(num1 * num2);
                            break;
                    case "/":
                        output.Text = Convert.ToString(num1 / num2);
                        break;
                    default:
                        output.Text = "error";
                        break;
                }
            }catch (OverflowException)
            {
                output.Text = "number overflow.";
            }
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            input1.Text = String.Empty;
            input2 .Text= String.Empty;
            output.Text = String.Empty;
            opr_choose.SelectedIndex = 0;
        }
    }
}
