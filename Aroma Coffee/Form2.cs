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
    public partial class Form2 : Form
    {
        private Model model;
        public Form2(Model mod)
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(64, 0, 0);
            label1.Text = "Name";
            label2.Text = "Password";
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            button1.Text = "Login";
            button2.Text = "Regist";
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button2.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            button2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            textBox2.PasswordChar = '*';
            model = mod;
            button2.Click += (s, e) =>
            {
                if (model.regist(textBox1.Text, textBox2.Text) == false)
                {
                    MessageBox.Show("Already exists");
                }
            };

            button1.Click += (s, e) =>
            {
                if (model.login(textBox1.Text, textBox2.Text))
                {
                    Form1 order = new Form1(model, textBox1.Text);
                    order.Show();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            };

        }
    }
}
