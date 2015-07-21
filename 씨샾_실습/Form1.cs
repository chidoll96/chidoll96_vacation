using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        work Work = work.getinstance();
        machine Machine = machine.getinstance();
        systemcenter Center =systemcenter.getinstance();

     
        
        public Form1()
        {
            Center.m1num = 0;
            Center.m2num = 0;
            Center.waitnumber = 0;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            Center.waitnumber++;
            label1.Text = Center.waitnumber.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
         private void  button3_Click(object sender, EventArgs e)
        {
            if (Center.m2num < Center.waitnumber)
            {
                Center.m2num += Machine.sum(Work.number());
                Center.m1num += Machine.sum(Work.number());
                label8.Visible = false;
                label7.Visible = true;
            }
            if (Center.m2num == Center.waitnumber)
                button2.Visible = false;
            label5.Text = Center.m2num.ToString();
          
        }
         private void button2_Click(object sender, EventArgs e)
         {
             if (Center.m1num < Center.waitnumber)
             {
                 Center.m1num += Machine.sum(Work.number());
                 Center.m2num += Machine.sum(Work.number());
                 label8.Visible = true;
                 label7.Visible = false;
             }
             if (Center.m1num == Center.waitnumber)
                 button3.Visible = false;
               label6.Text = Center.m1num.ToString();
         }
    }
}
