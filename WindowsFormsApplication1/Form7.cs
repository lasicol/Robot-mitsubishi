using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        int line=2;
        Form1 form1;
        public Form7(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            richTextBox1.Text += "10 ";
            //richTextBox1.Text += " ";
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(" ");
            

        }

       

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Text += (line*10).ToString() + " ";
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.Focus();
                line++;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nowys;
            try
            {
                nowys = richTextBox1.Text.Replace("\n", "\r");
                form1.ComPortSetting.Write(nowys + "\r");
                form1.label4.Text = "SENT";
                form1.label4.ForeColor = Color.Blue;
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                form1.ComPortSetting.Write("RN " + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    textBox1.Text += (line * 10).ToString() + " ";
            //    textBox1.SelectionStart = textBox1.Text.Length;
            //    textBox1.Focus();
            //    line++;

            //}
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            
        }
    }
}
