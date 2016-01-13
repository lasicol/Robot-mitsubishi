using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        
        public string temp_string;
        public string temp_string2, temp_string3;
        public bool przechwytywanie = false;
        public bool przechwytywanie2 = false;
        public SerialPort ComPortSetting = new SerialPort();
        string InputData = String.Empty;
        string tempData = String.Empty;
        delegate void SetTextCallback(string text);
        static public string lol;
        int j=0;

 

        //int odczyt = 0;
        public Form1()
        {
            ComPortSetting.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);
            //timer1.Start();
            InitializeComponent();
        }

        private void serialConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 FormaDruga = new Form2(this);
            FormaDruga.Owner = this;
            FormaDruga.ShowDialog();
        }
        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = ComPortSetting.ReadExisting();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }
        private void SetText(string text)
        {
            this.richTextBox_Rec.Text += text;
            if (przechwytywanie == true)
            {
               
                temp_string += text;
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            
            try
            {
                ComPortSetting.Write(richTextBox_send.Text + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }



        int i=0;
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 3)
            {
                przechwytywanie = false;
                timer1.Stop();
                listBox1.Items.Add(temp_string2 + temp_string);// + "\r";
                richTextBox1.Text += temp_string2 + temp_string + "\r";
                i = 0;
                temp_string = "";
            }
            i++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 FormaCzwarta = new Form4(this);
            FormaCzwarta.Owner = this;
            FormaCzwarta.ShowDialog();
        }

        private void button_monitorIO_Click(object sender, EventArgs e)
        {
            Form5 FormaPiata = new Form5(this);
            FormaPiata.Owner = this;
            FormaPiata.ShowDialog();
        }

        private void button_prog_edit_Click(object sender, EventArgs e)
        {
            Form7 FormaSiodma = new Form7(this);
            FormaSiodma.Owner = this;
            FormaSiodma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FormaDruga = new Form2(this);
            FormaDruga.Owner = this;
            FormaDruga.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(temp_string);
            //MessageBox.Show(przechwytywanie.ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label4.Text == "SENT")
                {
                try
                {
                    ComPortSetting.Write("RN" + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            else
                MessageBox.Show("Program unsent");
        }
        void lollol()
        {
            for (int j = 0; j < 100; j++)
            {
                przechwytywanie = true;
                ComPortSetting.Write("PR " + j.ToString() + "\r");
                timer2.Enabled = true;
                timer2.Start();
                //MessageBox.Show(form1.temp_string);
                temp_string3 = j.ToString() + "  |  ";
                //progressBar1.Value = j;
                Thread.Sleep(300);

            }
        }

    private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //for (int j = 0; j < 100; j++)
                //{
                //    przechwytywanie = true;
                //    ComPortSetting.Write("PR " + j.ToString() + "\r");
                //    timer2.Enabled = true;
                //    timer2.Start();
                //    //MessageBox.Show(form1.temp_string);
                //    temp_string3 = j.ToString() + "  |  ";
                //    progressBar1.Value = j;
                //    Thread.Sleep(300);

                //}
                //przechwytywanie = true;
                //ComPortSetting.Write("PR " + j.ToString() +  "\r");
                //timer2.Start();
                ////MessageBox.Show(form1.temp_string);
                //temp_string3 = j.ToString() + "  |  ";
                //progressBar1.Value = j;
                //Thread.Sleep(300);
                Thread T_save = new Thread(new ThreadStart(lollol));
                   T_save.Start();
                
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }
        int k = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (k == 5)
            {
                MessageBox.Show(przechwytywanie.ToString()); 
                przechwytywanie = false;
                timer1.Stop();
                listBox2.Items.Add(temp_string3 + temp_string);// + "\r";
               // richTextBox1.Text += temp_string2 + temp_string + "\r";
                i = 0;
                temp_string = "";
            }
            k++;
        }
    }
}
