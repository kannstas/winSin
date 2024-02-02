using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winSin
{
    public partial class Form1 : Form
    {
        private double StartPoint
        {
            get { return Double.Parse(textBox1.Text); }
            set { StartPoint = value; }

        }

        private double EndPoint
        {

            get { return Double.Parse(textBox2.Text); }
            set { EndPoint = value; }

        }



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            FormSin formSin = new FormSin(StartPoint, EndPoint);

            
            string interval = $"Левая граница: {StartPoint}, правая граница: {EndPoint} ";
            formSin.LabelText = interval;

            formSin.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
