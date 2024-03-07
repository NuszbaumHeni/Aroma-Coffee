using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aroma_Coffee
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label1.Text = "Sample Winforms App";
            label2.Text = "Version 1. 0. 0. 0.";
            label3.Text = "Copyright";
            label4.Text = "Microsoft Samples";
            listBox1.Items.Add("Nuszbaum Henriett");
            listBox1.Items.Add("Szoldatics Levente");
            listBox1.Enabled = false;
        }
    }
}
