using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LEDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.ForeColor = System.Drawing.Color.FromArgb(255, trackBar2.Value, trackBar1.Value, trackBar3.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button2a_Click(object sender, EventArgs e)
        {
            panel1.ForeColor = Color.FromArgb(0, trackBar2.Value, trackBar1.Value, trackBar3.Value);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = trackBar2.Value;
            int g = trackBar1.Value;
            int b = trackBar3.Value;
            string r1 = r.ToString();
            string g1 = g.ToString();
            string b1 = b.ToString();
            serialPort1.WriteLine(r1 + "," + g1 + "," + b1);
        }
    }
}
