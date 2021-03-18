using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertMoney();
        }

        private void ConvertMoney()
        {
            var value1 = double.Parse(this.Rupiah.Text);
            double value2;
            if (this.comboBox1.SelectedItem.ToString() == "To USD")
            {
                value2 = value1 / 14399;
                this.Result.Text = Math.Round(value2, 2) + "";
            }
            else if (this.comboBox1.SelectedItem.ToString() == "To Yen")
            {
                value2 = value1 / 133;
                this.Result.Text = Math.Round(value2, 2) + "";
            }
            
        }
    }
}
