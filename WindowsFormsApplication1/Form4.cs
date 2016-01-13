using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{

    public partial class Form4 : Form
    {
        
        
 
        Form1 form1;
        static bool lol=false;
        int sValue;
        int speedValue;
        public Form4(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        
    private void radiobuttony()
        {




        }

        private void button_move_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(suwak.Value.ToString());
            sValue = suwak.Value ;

            if (rB_cz1.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 1," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
                
            }
            else if (rB_cz2.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 2," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            else if (rB_cz3.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 3," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            else if (rB_cz4.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 4," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            else if (rB_cz5.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 5," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            else if (rB_cz6.Checked)
            {
                try
                {
                    form1.ComPortSetting.Write("DJ 6," + sValue.ToString() + "\r");
                }
                catch
                {
                    MessageBox.Show("Connection error");
                }
            }
            //MessageBox.Show(sValue.ToString());
        }

        private void button_GO_Click(object sender, EventArgs e)
        {
            try
            {
                form1.ComPortSetting.Write("GO\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void button_GC_Click(object sender, EventArgs e)
        {
            try
            {
                form1.ComPortSetting.Write("GC\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }

        private void button_speed_Click(object sender, EventArgs e)
        {
            
            speedValue = suwak_speed.Value / 5;
            label_speed.Text = speedValue.ToString();
            try
            {
                form1.ComPortSetting.Write("SP " + speedValue.ToString() + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }

        private void suwak_ValueChanged(object sender, EventArgs e)
        {
            sValue = suwak.Value;
            label_degree.Text = sValue.ToString();
            

        }

        private void suwak_speed_ValueChanged(object sender, EventArgs e)
        {
            speedValue = suwak_speed.Value / 5;
            label_speed.Text = speedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                form1.ComPortSetting.Write("WH\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button_moveXYZ_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = (int) numericUpDown_x.Value;
            y = (int)numericUpDown_y.Value;
            z = (int)numericUpDown_z.Value;
            try
            {
                form1.ComPortSetting.Write("DW " + x.ToString() + "," + y.ToString() + "," + z.ToString() + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
           
        }

        private void button_moveSTR_Click(object sender, EventArgs e)
        {
            int x2, y2, z2;
            x2 = (int)numericUpDown_sx.Value;
            y2 = (int)numericUpDown_sy.Value;
            z2 = (int)numericUpDown_sz.Value;
           
            try
            {
                form1.ComPortSetting.Write("DS " + x2.ToString() + "," + y2.ToString() + "," + z2.ToString() + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                form1.ComPortSetting.Write("HE " + numericPosition1.Value.ToString() + "\r");

                form1.ComPortSetting.Write("WH \r");

                form1.przechwytywanie = true;
                form1.timer1.Start();
                //MessageBox.Show(form1.temp_string);
                form1.temp_string2 = numericPosition1.Value.ToString() + "  |  ";
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void button_moveto_Click(object sender, EventArgs e)
        {
            
            try
            {
                form1.ComPortSetting.Write("MO " + numericPosition2.Value.ToString() + "\r");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }
        }
    }
}
