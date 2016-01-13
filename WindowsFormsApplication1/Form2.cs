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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 form1;
        //SerialPort ComPort = new SerialPort();
        byte[] array;
        internal delegate void SerialDataReceivedEventHandlerDelegate(
                object sender, SerialDataReceivedEventArgs e);

        internal delegate void SerialPinChangedEventHandlerDelegate(
                 object sender, SerialPinChangedEventArgs e);
        private SerialPinChangedEventHandler SerialPinChangedEventHandler1;
        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        public string lol { get; private set; }

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            
            InitializeComponent();
            //SerialPinChangedEventHandler1 = new SerialPinChangedEventHandler(PinChanged);
            //form1.ComPortSetting.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(port_DataReceived_1);

        }

        private void comboBox_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button_form2_refresh_Click(object sender, EventArgs e)
        {
            comboBox_Port.Items.Clear();
            string[] ArrayComPortsNames = new string[20];
            int index = 0;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();

            try
            {
                do
                {

                    comboBox_Port.Items.Add(ArrayComPortsNames[index]);
                    index += 1;
                }
                while (!((ArrayComPortsNames[index] == ComPortName) ||
                                    (index == ArrayComPortsNames.GetUpperBound(0))));
            }
            catch
            {
                //MessageBox.Show("Nie wykryto podłączonego urządzenia szeregowego");
            }
        }

        private void button_form2_OK_Click(object sender, EventArgs e)
        {
            //  btnPortState.Text = "Open";
            try
            {
                form1.ComPortSetting.PortName = Convert.ToString(comboBox_Port.Text);
                form1.ComPortSetting.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
                form1.ComPortSetting.DataBits = Convert.ToInt16(comboBox_DataBits.Text);
                form1.ComPortSetting.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_StopBits.Text);
                form1.ComPortSetting.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parity.Text);
                form1.ComPortSetting.DtrEnable = checkBox_DTR.Enabled;
                form1.ComPortSetting.RtsEnable = checkBox_RTS.Enabled;
                form1.ComPortSetting.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_hand.Text);
            }
            catch
            { }
            this.Close();
            //ComPort.Open();
        }

        private void button_form2_open_Click(object sender, EventArgs e)
        {
            form1.ComPortSetting.PortName = Convert.ToString(comboBox_Port.Text);
            form1.ComPortSetting.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
            form1.ComPortSetting.DataBits = Convert.ToInt16(comboBox_DataBits.Text);
            form1.ComPortSetting.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_StopBits.Text);
            form1.ComPortSetting.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_Parity.Text);
            form1.ComPortSetting.DtrEnable = checkBox_DTR.Enabled;
            form1.ComPortSetting.RtsEnable = checkBox_RTS.Enabled;
            form1.ComPortSetting.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBox_hand.Text);
            
            form1.ComPortSetting.Open();
            form1.label2.Text = "CONNECTED";
            form1.label2.ForeColor = Color.Green;
            
        }
        //

        //private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        //{
        //    InputData = form1.ComPortSetting.ReadExisting();
        //    if (InputData != String.Empty)
        //    {
        //        this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
        //    }
        //}

        //private void SetText(string text)
        //{
        //    this.richTextBox2_form2.Text += text;
        //}
        private void button_form2_send_Click(object sender, EventArgs e)
        {
            
        }

        private void button_form2_close_Click(object sender, EventArgs e)
        {
            try
            {
                form1.ComPortSetting.Close();
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }

        //private void button_form2_receive_Click(object sender, EventArgs e)
        //{
        //    String RecievedData;
        //    RecievedData = form1.ComPortSetting.ReadExisting();
        //    if (!(RecievedData == ""))
        //    {
        //        richTextBox2_form2.Text += RecievedData;
        //    }
        //}

        private void button_form2_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //form1.richTextBox1.Text = richTextBox2_form2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_Port.Items.Clear();
            string[] ArrayComPortsNames = new string[20];
            int index = 0;
            string ComPortName = null;

            ArrayComPortsNames = SerialPort.GetPortNames();

            try
            {
                do
                {

                    comboBox_Port.Items.Add(ArrayComPortsNames[index]);
                    index += 1;
                }
                while (!((ArrayComPortsNames[index] == ComPortName) ||
                                    (index == ArrayComPortsNames.GetUpperBound(0))));
            }
            catch
            {
                //MessageBox.Show("Nie wykryto podłączonego urządzenia szeregowego");
            }
        }

        private void button_form2_close_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         
            try
            {
                form1.ComPortSetting.Close();
                form1.label2.Text = "UNCONNECTED";
                form1.label2.ForeColor = Color.Red;
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }
    }
}
