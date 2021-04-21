using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM_Tech
{
    public partial class Form2 : Form
    {
        
        public Form2()
            
        {
            InitializeComponent();
            label1.Text = Calculator.L1;
            textBox1.Text = "";
        }
        private static string text;
        public static string TextP
        {
            get { return text; }
            set { text = value; }
        }
       
        
        private void Button1_Click(object sender, EventArgs e)
        {       
                TextP = textBox1.Text;
                Calculator c = new Calculator();
                this.Hide();
                this.Close();   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                if (value > 250)
                    textBox1.Text = "250";
                else if (value < 0)
                    textBox1.Text = "0";
            }
            textBox1.MaxLength = 3;
           /* int max_Value = int.Parse(textBox1.Text);
            if (max_Value > 250)
            {
                textBox1.Text = "250";
            }*/

            if (textBox1.Text == null)
            {
                textBox1.Text =string.Empty;
            }

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                TextP = textBox1.Text;
                Calculator c = new Calculator();
                this.Hide();
                this.Close();
            }
            else
            {
                TextP = textBox1.Text;
            }
        }

       
    }
}
