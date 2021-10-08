using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2_CSharp
{
    public partial class Form1 : Form
    {
        private Random random;
        private Timer timer;
        public double mean { get; set; }
        public int n { get; set; }
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            timer = new Timer();

            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 400;
        }

        private void button1_Click(object sender, EventArgs e) { timer.Start(); }

        private void button2_Click(object sender, EventArgs e) { timer.Stop(); }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int generatedValue = random.Next(18, 31);
            updateMean(generatedValue);
            this.textBox1.AppendText("Generated Number: " + generatedValue);
            this.textBox1.AppendText(Environment.NewLine);
            this.textBox1.AppendText("New mean = " + mean.ToString());
            this.textBox1.AppendText(Environment.NewLine);
        }

        private void updateMean(int nextNumber)
        {
            n += 1;
            mean = mean + ((1.0d/n) * (nextNumber - mean));
        }
    }
}
