using System;
using System.Windows.Forms;

namespace winSin
{
    public partial class FormSin : Form
    {
        private double Start { get; set; }
        private double End { get; set; }

        public string LabelText
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public FormSin(double start, double end)
        {
            InitializeComponent();
            Start = start;
            End = end;
        }


        public void PrintPoints(double start, double end)
        {
            for (double x = start; x <= end; x = x+ 0.1)
            {
                double sinValue = Math.Round(Math.Sin(x), 2);
             
                richTextBox1.Text += $" Sin {x} = {sinValue} \n";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPoints(Start, End);
        }
    }


}
