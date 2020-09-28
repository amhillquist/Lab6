using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        private double tipPercent;
        public TipCalculator()
        {
            InitializeComponent();
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            AreBoxesValid();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double tip = 0;
            double value = double.Parse(inputBox.Text);
            if (tipPercent != 0)
            {
                tip = value * tipPercent;
                outputBox.Text = (tip).ToString();
            }
            else
                outputBox.Text = (tip).ToString();
            totalBillBox.Text = (value + tip).ToString();
        }

        private void tipBox_TextChanged(object sender, EventArgs e)
        {
            if (AreBoxesValid())
            {
                calcButton.Visible = true;
                tipPercent = double.Parse(tipBox.Text) / 100;
            }
        }
        private bool AreBoxesValid()
        {
            if (double.TryParse(inputBox.Text, out double input) && double.TryParse(tipBox.Text, out double tip))
                return calcButton.Enabled = true;
            return calcButton.Enabled = false;
        }
    }
}
