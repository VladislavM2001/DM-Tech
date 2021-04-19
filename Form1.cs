using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DM_Tech
{
    public partial class Calculator : Form
    {
        Form2 f;
        Main m;
        double tok;
        private static string open1;
        public static string Open1
        {
            get { return open1; }
            set { open1 = value; }
        }
        private static string print1;
        public static string Print1
        {
            get { return print1; }
            set { print1 = value; }
        }
        private static string remove1;
        public static string Remove1
        {
            get { return remove1; }
            set { remove1 = value; }
        }


        public Calculator()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button3, "Devices number between 0-250!");
            
            toolTip1.SetToolTip(button5, "Devices number between 0-250!");
            
            toolTip1.SetToolTip(button7, "Devices number between 0-250!");
            
            toolTip1.SetToolTip(button9, "Devices number between 0-250!");
            
            toolTip1.SetToolTip(button11, "Devices number between 0-250!");
            toolTip1.SetToolTip(button12, "Devices number between 0-250!");
            toolTip1.SetToolTip(button13, "Devices number between 0-250!");
            toolTip1.SetToolTip(button14, "Devices number between 0-250!");
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox15.Enabled = false;
            textBox17.Enabled = false;
            timer2.Start();
            button2.Text = "Devices:";
            button1.Text = "Calculate";

            label1.Text = "Number of devices";
            label2.Text = "Current mA";
            button16.Text = "Calculate Length";
            button17.Text = "Calculate cross section";
            label3.Text = "Input Length";
            label4.Text = "Cross Section";
            label5.Text = "Lenght";
            L1 = "Number";
            newToolStripButton.Text = "New";
            saveToolStripButton.Text = "Save";
            printToolStripButton.Text = "Print";
            toolStripDropDownButton1.Text = "Language";
            toolStripButton2.Text = "About";
            
            Open1 = "Open";
            Print1 = "Print";
            Remove1 = "Remove";
            button16.Enabled = false;
            button17.Enabled = false;
            textBox16.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
           
          
        }



    
        private static string sech;
        public static string Sech
        {
            get { return sech; }
            set { sech = value; }
        }
        private static string text1;
        public static string TextPr
        {
            get { return text1; }
            set { text1 = value; }
        }
        private static string tokec;
        public static string Tokec
        {
            get { return tokec; }
            set { tokec = value; }
        }
        private static string broi;
        public static string Broi
        {
            get { return broi; }
            set { broi = value; }
        }
        private static string duljina;
        public static string Duljina
        {
            get { return duljina; }
            set { duljina = value; }
        }

        public void GetValue(string text)
        {
            listBox1.Items.Add(text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (panel1.Height != 30)
            {
                panel1.Height = 30;
                timer1.Enabled = false;
            }

        }



        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000A T A1R(490μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox3.Text = "0";         
            f = new Form2();  
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox3.Text = "0";
            }
            else
            {
                listBox1.Items.Add("D9000A T A1R(490μA):" + Form2.TextP);
                textBox3.AppendText(Form2.TextP);
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panel1.Height = 284;
            timer1.Stop();
        }

        /*private void Button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000AI A1R(510μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox4.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox4.Text = "0";
            }
            else
            {
                listBox1.Items.Add("D9000AI A1R(510μA):" + Form2.TextP);
                textBox4.AppendText(Form2.TextP);
            }
           

        }
*/
        private void Button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000A T A1S(490μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox5.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox5.Text = "0";
            }
            else
            {
                listBox1.Items.Add("D9000A T A1S(490μA):" + Form2.TextP);
                textBox5.AppendText(Form2.TextP);
            }
            
            
        }

      /*  private void Button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000AI A1S(490μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox6.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox6.Text = "0";
            }
            else
            {
             listBox1.Items.Add("D9000AI A1S(510μA):" + Form2.TextP);
            textBox6.AppendText(Form2.TextP);
            }
            
            
        }*/

        private void Button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000A SR(500μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox7.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox7.Text = "0";
            }
            else
            {
            listBox1.Items.Add("D9000A SR(500μA):" + Form2.TextP);
            textBox7.AppendText(Form2.TextP);
            }
            
            
        }

        /*private void Button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000AI SR(520μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox8.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox8.Text = "0";
            }
            else
            {
listBox1.Items.Add("D9000AI SR(520μA):" + Form2.TextP);
            textBox8.AppendText(Form2.TextP);
            }
            
            
            

        }*/

        private void Button9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000A MSR(510μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox9.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox9.Text = "0";
            }
            else
            {
listBox1.Items.Add("D9000A MSR(510μA):" + Form2.TextP);
            textBox9.AppendText(Form2.TextP);
            }
            
          
           

        }

       /* private void Button10_Click(object sender, EventArgs e)
        {


            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000AI MSR(530μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox10.Text = "0";

            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox10.Text = "0";
            }
            else
            {
listBox1.Items.Add("D9000AI MSR(530μA):" + Form2.TextP);
            textBox10.AppendText(Form2.TextP);
           
            }
            
          

        }*/

        private void Button11_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "D9000A MCP(450μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox11.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox11.Text = "0";
            }
            else
            {
 listBox1.Items.Add("D9000A MCP(450μA):" + Form2.TextP);
            textBox11.AppendText(Form2.TextP);
            }
           
            
            


        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "M9000A ACZ(30mA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox12.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox12.Text = "0";
            }
            else
            {
 listBox1.Items.Add("M9000A ACZ(30mA):" + Form2.TextP);
            textBox12.AppendText(Form2.TextP);
            }
           
           
            


        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "M9000A IN/OUT(500μA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox13.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox13.Text = "0";
            }
            else
            {
listBox1.Items.Add("M9000A IN/OUT(500μA):" + Form2.TextP);
            textBox13.AppendText(Form2.TextP);
            }
            
           
           

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (listBox1.Items != null)
            {
                for (int n = listBox1.Items.Count - 1; n >= 0; --n)
                {
                    string removelistitem = "S9000A(10mA):";
                    if (listBox1.Items[n].ToString().Contains(removelistitem))
                    {
                        listBox1.Items.RemoveAt(n);
                    }
                }
            }
            textBox14.Text = "0";
            f = new Form2();
            f.ShowDialog();
            if (Form2.TextP == "0")
            {
                textBox14.Text = "0";
            }
            else
            {
listBox1.Items.Add("S9000A(10mA):" + Form2.TextP);
            textBox14.AppendText(Form2.TextP);
            }
            
            
           
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                button16.Enabled = false;
                button17.Enabled = false;
                textBox16.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
            }
            else
            {
                button16.Enabled = true;
                button17.Enabled = true;
                textBox16.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                radioButton4.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;

                double num1 = double.Parse(textBox3.Text);
                double num2 = double.Parse(textBox4.Text);
                double num3 = double.Parse(textBox5.Text);
                double num4 = double.Parse(textBox6.Text);
                double num5 = double.Parse(textBox7.Text);
                double num6 = double.Parse(textBox8.Text);
                double num7 = double.Parse(textBox9.Text);
                double num8 = double.Parse(textBox10.Text);
                double num9 = double.Parse(textBox11.Text);
                double num10 = double.Parse(textBox12.Text);
                double num11 = double.Parse(textBox13.Text);
                double num12 = double.Parse(textBox14.Text);
                double sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12;
                if (sum > 250)
                {
                    MessageBox.Show("Devices must be less than 250!");
                }
                else
                {
                    textBox1.Text = sum.ToString();
                }


                tok = num1 * 0.49 + num2 * 0.51 + num3 * 0.49 + num4 * 0.51 + num5 * 0.50 + num6 * 0.52 + num7 * 0.51 + num8 * 0.53 + num9 * 0.45 + num10 * 30 + num11 * 0.50 + num12 * 10;
                if (tok > 500)
                {
                    MessageBox.Show("Current must be less 500mA!");

                }
                else
                {

                    textBox2.Text = tok.ToString() + "mA";
                }
            }
           

        }

        private void Button16_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox3.Text);
            double num2 = double.Parse(textBox4.Text);
            double num3 = double.Parse(textBox5.Text);
            double num4 = double.Parse(textBox6.Text);
            double num5 = double.Parse(textBox7.Text);
            double num6 = double.Parse(textBox8.Text);
            double num7 = double.Parse(textBox9.Text);
            double num8 = double.Parse(textBox10.Text);
            double num9 = double.Parse(textBox11.Text);
            double num10 = double.Parse(textBox12.Text);
            double num11 = double.Parse(textBox13.Text);
            double num12 = double.Parse(textBox14.Text);
            tok = num1 * 0.49 + num2 * 0.51 + num3 * 0.49 + num4 * 0.51 + num5 * 0.50 + num6 * 0.52 + num7 * 0.51 + num8 * 0.53 + num9 * 0.45 + num10 * 30 + num11 * 0.50 + num12 * 10;
            if (radioButton1.Checked == true)
            {

                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 0.5);
                lenght /= 0.0268;
                   
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));
                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";

            }
            if (radioButton2.Checked == true)
            {
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 0.75) / 0.0268;
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));
                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";

            }
            if (radioButton3.Checked == true)
            {
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 1) / 0.0268;
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));
                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";

            }
            if (radioButton4.Checked == true)
            {
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 1.5) / 0.0268;
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));
                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";

            }
            if (radioButton5.Checked == true)
            {
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 2) / 0.0268;
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));
                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";

            }
            if (radioButton6.Checked == true)
            {
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double lenght = (R1 * 2.5) / 0.0268;
                if (Math.Abs(lenght) > 4000) lenght = 4000;
                else
                    Math.Floor(Math.Abs(lenght));

                textBox15.Text = Math.Abs(lenght / 2).ToString("#.") + "m";
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            
            if (textBox16.Text == "")
            {
                MessageBox.Show("Input lenght(0-2000m)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double num1 = double.Parse(textBox3.Text);
                double num2 = double.Parse(textBox4.Text);
                double num3 = double.Parse(textBox5.Text);
                double num4 = double.Parse(textBox6.Text);
                double num5 = double.Parse(textBox7.Text);
                double num6 = double.Parse(textBox8.Text);
                double num7 = double.Parse(textBox9.Text);
                double num8 = double.Parse(textBox10.Text);
                double num9 = double.Parse(textBox11.Text);
                double num10 = double.Parse(textBox12.Text);
                double num11 = double.Parse(textBox13.Text);
                double num12 = double.Parse(textBox14.Text);
                double lenght = double.Parse(textBox16.Text);
                double tok1 = tok / 1000;
                double R = 13 / tok1;
                double R1 = R - ((num2 + num4 + num6 + num8 + num9 + num10 + num11 + num12) * 0.2);
                double sechenie = (0.0268 * lenght * 2) / R1;

                if (Math.Abs(sechenie) <= 0.5)
                {
                    sechenie = 0.5;
                    textBox17.Text = sechenie.ToString() + "mm2";
                }
                else if (Math.Abs(sechenie) <= 0.75)
                {
                    sechenie = 0.75;
                    textBox17.Text = Math.Abs(sechenie).ToString() + "mm2";
                }
                else if (Math.Abs(sechenie) <= 1)
                {
                    sechenie = 1;
                    textBox17.Text = Math.Abs(sechenie).ToString() + "mm2";
                }
                else if (Math.Abs(sechenie) <= 1.5)
                {
                    sechenie = 1.5;
                    textBox17.Text = Math.Abs(sechenie).ToString() + "mm2";
                }
                else if (Math.Abs(sechenie) <= 2)
                {
                    sechenie = 2;
                    textBox17.Text = Math.Abs(sechenie).ToString() + "mm2";
                }
                else if (Math.Abs(sechenie) <= 2.5)
                {
                    sechenie = 2.5;
                    textBox17.Text = Math.Abs(sechenie).ToString() + "mm2";
                }
                else
                {
                    MessageBox.Show("Invalid lenght!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }







        private void PrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            m = new Main();
            m.ShowDialog();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            Open1 = "Отвори файл";
            Print1 = "Принтирай";
            Remove1 = "Премахни";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "Text(*.txt)|*.txt";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)

            {
                using (var sw = new StreamWriter(saveFile.FileName, true))
                {
                    sw.WriteLine("Devices:");
                    foreach (var item in listBox1.Items)
                    {
                        sw.Write(item.ToString() + Environment.NewLine);
                    }
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine();
                    sw.WriteLine("Number:" + textBox1.Text);
                    sw.WriteLine("Current(mA):" + textBox2.Text);
                    sw.WriteLine("Lenght:" + textBox15.Text);
                    sw.WriteLine("Cross section:" + textBox17.Text);
                }
                MessageBox.Show("File is saved!");
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
           
            
            if (listBox1.Items.Count==0)
                
            {
                MessageBox.Show("Empty List!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                foreach (var item in listBox1.Items)
                {

                    TextPr += item.ToString();
                    TextPr += "\n";
                }
                Tokec = textBox2.Text;
                Broi = textBox1.Text;
                Duljina = textBox15.Text;
                Sech = textBox17.Text;
                m = new Main();
                m.ShowDialog();
            }
            
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = "";
            listBox1.Items.Clear();
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            button3.Enabled = true;
            //button4.Enabled = true;
            button5.Enabled = true;
            //button6.Enabled = true;
            button7.Enabled = true;
            //button8.Enabled = true;
            button9.Enabled = true;
            //button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            textBox1.Text = " ";
            textBox16.Clear();
            textBox15.Clear();
            textBox17.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            button17.Enabled = false;
            textBox16.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            button16.Enabled = false;


        }
        private static string l1;
        public static string L1
        {
            get { return l1; }
            set { l1 = value; }
        }
        
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button2.Text = "Devices:";
            button1.Text = "Calculate";
          
           label1.Text = "Number of devices";
            label2.Text = "Current mA";
            button16.Text = "Calculate Length";
            button17.Text = "Calculate cross section";
            label3.Text = "Input Length";
            L1 = "Number";
            newToolStripButton.Text = "New";
            saveToolStripButton.Text = "Save";
            printToolStripButton.Text = "Print";
            toolStripDropDownButton1.Text = "Language";
            toolStripButton2.Text = "About";
            
            Open1 = "Open";
            Print1 = "Print";
            Remove1 = "Remove";


        }

        private void българскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Text = "Устройство:";
            button1.Text = "Изчисли";
            label1.Text = "Брой устройства";
            label2.Text = "Ток mA";
            button16.Text = "Изчисляване на дължината";
            button17.Text = "Изчисляване на сечението";
            label3.Text = "Въведете дължина";
            newToolStripButton.Text = "Нов файл";
            saveToolStripButton.Text = "Запази";
            printToolStripButton.Text = "Принтирай";
            toolStripDropDownButton1.Text = "Език";
            toolStripButton2.Text = "Относно";
            
            L1 ="Брой";
            Open1 = "Отвори файл";
            Print1 = "Принтирай";
            Remove1 = "Премахни";
            label4.Text = "Сечение на проводника";
            label5.Text = "Дължина на проводника";

        }

        /*private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                Application.Exit();
            }
            else if (listBox1.Items.Count != 0)
            {
                DialogResult dial = MessageBox.Show("Do you want to save?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dial == DialogResult.Yes)
                {
                    var saveFile = new SaveFileDialog();
                    saveFile.Filter = "Word(*.doc)|*.doc|Text(*.txt)|*.txt";
                    if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                    {
                        using (var sw = new StreamWriter(saveFile.FileName, true))
                        {
                            sw.WriteLine("Devices:");
                            foreach (var item in listBox1.Items)
                            {
                                sw.Write(item.ToString() + Environment.NewLine);
                            }
                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine("Number:" + textBox1.Text);
                            sw.WriteLine("Current(mA):" + textBox2.Text);
                            sw.WriteLine("Lenght:" + textBox15.Text);
                            sw.WriteLine("Cross section:" + textBox17.Text);
                        }
                        MessageBox.Show("File is saved!");

                    }
                    this.Close();
                }
                else if (dial == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }*/

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dataa = DateTime.Now;
            this.toolStripLabel1.Text = dataa.ToString(" dd/MM/yyyy HH:mm:ss");
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                Application.Exit();
            }
            else if (listBox1.Items.Count != 0)
            {
                DialogResult dial = MessageBox.Show("Do you want to save?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dial == DialogResult.Yes)
                {
                    var saveFile = new SaveFileDialog();
                    saveFile.Filter = "Word(*.doc)|*.doc|Text(*.txt)|*.txt";
                    if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                    {
                        using (var sw = new StreamWriter(saveFile.FileName, true))
                        {
                            sw.WriteLine("Devices:");
                            foreach (var item in listBox1.Items)
                            {
                                sw.Write(item.ToString() + Environment.NewLine);
                            }
                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine();
                            sw.WriteLine("Number:" + textBox1.Text);
                            sw.WriteLine("Current(mA):" + textBox2.Text);
                            sw.WriteLine("Lenght:" + textBox15.Text);
                            sw.WriteLine("Cross section:" + textBox17.Text);
                        }
                        MessageBox.Show("File is saved!");

                    }
                    this.Close();
                }
                else if(dial == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

            private void toolStripButton2_Click(object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start("http://dm-teh.com/about-us/");
            }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox3.Text);
            double num2 = double.Parse(textBox4.Text);
            double num3 = double.Parse(textBox5.Text);
            double num4 = double.Parse(textBox6.Text);
            double num5 = double.Parse(textBox7.Text);
            double num6 = double.Parse(textBox8.Text);
            double num7 = double.Parse(textBox9.Text);
            double num8 = double.Parse(textBox10.Text);
            double num9 = double.Parse(textBox11.Text);
            double num10 = double.Parse(textBox12.Text);
            double num11 = double.Parse(textBox13.Text);
            double num12 = double.Parse(textBox14.Text);
            double sum = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 + num10 + num11 + num12;
            if (sum > 250)
            {
                MessageBox.Show("Devices must be less than 250!");
            }
            else
            {
                textBox1.Text = sum.ToString();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            textBox16.MaxLength = 4;
            int maxval = int.Parse(textBox16.Text);
            if (maxval > 2000)
            {
                textBox16.Text = "2000";
            }
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox15.Text = null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }

}
