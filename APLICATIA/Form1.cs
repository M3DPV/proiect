using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace namssssss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            firstCustomControl.BringToFront();
            indexpanel.Height = one.Height;
            indexpanel.Top = one.Top;
        }
        private void one_Click(object sender, EventArgs e)
        {
            firstCustomControl.BringToFront();
            indexpanel.Height = one.Height;
            indexpanel.Top = one.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            utilizari1.BringToFront();
            indexpanel.Height = two.Height;
            indexpanel.Top = two.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proiecte1.BringToFront();
            indexpanel.Height = three.Height;
            indexpanel.Top = three.Top;
        }
        private void four_Click(object sender, EventArgs e)
        {
            contacte1.BringToFront();
            indexpanel.Height = four.Height;
            indexpanel.Top = four.Top;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            contact1.BringToFront();
            indexpanel.Height = five.Height;
            indexpanel.Top = five.Top;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Utilizari1_Load(object sender, EventArgs e)
        {

        }
    }
}
