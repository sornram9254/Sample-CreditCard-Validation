using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCard
{
    public partial class Form1 : Form
    {
        int number;
        int firstDigit;
        int lastDigit;
        int res;
        public Form1()
        {
            InitializeComponent();
            txtLastNumHidden.Visible = false;

            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox11.Text == "" || textBox12.Text == "" || textBox13.Text == "" || textBox14.Text == "" || textBox15.Text == "" || textBox16.Text == "")
            {
                MessageBox.Show("Please enter a valid credit card number");
            }
            else {
                number = int.Parse(textBox1.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox17.Text = res.ToString();
                label3.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox3.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox18.Text = res.ToString();
                label4.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox5.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox19.Text = res.ToString();
                label5.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox7.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox20.Text = res.ToString();
                label6.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox9.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox21.Text = res.ToString();
                label7.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox11.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox22.Text = res.ToString();
                label8.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox13.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox23.Text = res.ToString();
                label9.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                number = int.Parse(textBox15.Text)*2;
                firstDigit = 0;
                lastDigit = 0;
                res = 0;
                firstDigit = number / 10;
                lastDigit = number % 10;
                res = firstDigit + lastDigit;
                textBox24.Text = res.ToString();
                label10.Text = number + "\n(" + firstDigit + " + " + lastDigit + ")";
                //-----------------------------------------------------------------------
                textBox25.Text = textBox2.Text;
                textBox26.Text = textBox4.Text;
                textBox27.Text = textBox6.Text;
                textBox28.Text = textBox8.Text;
                textBox29.Text = textBox10.Text;
                textBox30.Text = textBox12.Text;
                textBox31.Text = textBox14.Text;
                //-----------------------------------------------------------------------
                int sum1 = int.Parse(textBox17.Text) + int.Parse(textBox18.Text) + int.Parse(textBox19.Text) + int.Parse(textBox20.Text) + int.Parse(textBox21.Text) + int.Parse(textBox22.Text) + int.Parse(textBox23.Text) + int.Parse(textBox24.Text);
                int sum2 = int.Parse(textBox25.Text) + int.Parse(textBox26.Text) + int.Parse(textBox27.Text) + int.Parse(textBox28.Text) + int.Parse(textBox29.Text) + int.Parse(textBox30.Text) + int.Parse(textBox31.Text);
                textBox32.Text = sum1.ToString();
                textBox33.Text = sum2.ToString();
                //-----------------------------------------------------------------------
                int total = sum1 + sum2;
                txtTotal.Text = total.ToString();
                //-----------------------------------------------------------------------
                String last_char = txtTotal.ToString();
                txtLastNumHidden.Text = (last_char[last_char.Length - 1]).ToString();
                int TenMinusLast = 10 - int.Parse(txtLastNumHidden.Text);
                txtLastNum.Text = TenMinusLast.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            CleatLabel();

            label11.Text = "<-----------------------+\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                      <-+";

            textBox1.Text  = "4";
            textBox2.Text  = "9";
            textBox3.Text  = "1";
            textBox4.Text  = "6";
            textBox5.Text  = "9";
            textBox6.Text  = "4";
            textBox7.Text  = "4";
            textBox8.Text  = "6";
            textBox9.Text  = "9";
            textBox10.Text = "8";
            textBox11.Text = "9";
            textBox12.Text = "7";
            textBox13.Text = "3";
            textBox14.Text = "8";
            textBox15.Text = "8";
            textBox16.Text = "4";
        }
        private void ClearTextboxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void CleatLabel()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is Label)
                        (control as Label).ResetText();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            ClearTextboxes();
            CleatLabel();
            label11.Text = "<-----------------------+\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                          |\n                      <-+";
        }
    }
}
