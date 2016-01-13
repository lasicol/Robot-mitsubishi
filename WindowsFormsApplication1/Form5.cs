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
    public partial class Form5 : Form
    {
        Form1 form1;

        int numb_in=19;
        int numb_out = 15;
        int[] tab_in = new int[19];
        int[] tab_out = new int[15];



        public Form5(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();

            formGraphics.FillEllipse(myBrush, new Rectangle(30, 30, 20, 20));

            formGraphics.FillEllipse(myBrush, new Rectangle(30, 60, 20, 20));

            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            for (int i=0; i<=numb_in;i++)
            {
                form1.ComPortSetting.Write("ID "  + i.ToString() + "\r");


            }
        }
    }
}
