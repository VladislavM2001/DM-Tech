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
        }
        private static string text;
        public static string TextP
        {
            get { return text; }
            set { text = value; }
        }
       
        
        private void Button1_Click(object sender, EventArgs e)
        {
            List<string> a = new List<string>();
            a.Add(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Input number!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                TextP = textBox1.Text;
                Calculator c = new Calculator();
                this.Hide();
                this.Close();
            }
            
           
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

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
