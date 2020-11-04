using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blocking_the_user_interface1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double computeAverages(long noOfValues)
        {
            double total = 0;
            Random rand = new Random();
            for (long values = 0; values < noOfValues; values++)
            {
                total = total + rand.NextDouble();
            }
            return total / noOfValues;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            long noOfValues = long.Parse(NumberOfValuesTextBox.Text);
            ResultTextBoxBlock.Text = computeAverages(noOfValues).ToString();
        }
    }
}
