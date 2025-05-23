﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace DM_Tech
{
    public partial class Main : Form
    {
       
        Calculator c1 = new Calculator();
            public Main()
            {

             InitializeComponent();
            
                openToolStripButton.Text = Calculator.Open1.ToString(); 
                printToolStripButton.Text = Calculator.Print1.ToString();
                Remove.Text = Calculator.Remove1.ToString();
           
            
            this.printDocument1.PrintPage += new System.Drawing.Printing.
             PrintPageEventHandler(this.printDocument1_PrintPage);
            listBox1.Items.Add("Devices:");
            string[] info = Calculator.TextPr.Split('\n');
            for(int i=0; i<info.Length;i++)
            {
                listBox1.Items.Add(info[i]);
            }
            listBox1.Items.Add("Current:"+Calculator.Tokec);
            listBox1.Items.Add("Number of devices:" + Calculator.Broi);
            listBox1.Items.Add("Lenght:" + Calculator.Duljina);
            listBox1.Items.Add("Cross section:" + Calculator.Sech);
            
            }

        private StringReader myReader;
        protected void printDocument1_PrintPage(object sender,
       System.Drawing.Printing.PrintPageEventArgs ev)
        {
           

            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            
            string line = null;
            Font printFont = new Font("Arial", 13, FontStyle.Bold);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
            }
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
            myBrush.Dispose();
        }



       
     
        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            listBox1.Items.Clear();
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Word (*.doc)|*.doc|PDF(*.pdf)|*.pdf|Text(*.txt)|*.txt";
            if (f.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(f.OpenFile()))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);

                    }
                }
            }
            toolStripProgressBar1.Value = 100;

           
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 100;
            printDialog1.Document = printDocument1;
            string strText = "";
            foreach (object x in listBox1.Items)
            {

                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Minimum = 0;
                toolStripProgressBar1.Value = 0;
                
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            listBox1.Items.Clear();
            toolStripProgressBar1.Value = 100;
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
