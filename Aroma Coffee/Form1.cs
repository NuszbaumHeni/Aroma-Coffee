using Microsoft.VisualBasic.Devices;

namespace Aroma_Coffee
{
    public partial class Form1 : Form
    {
        Model model;
        string user;
        MenuStrip MainMenu = new MenuStrip();
        ToolStripMenuItem FileMenu = new ToolStripMenuItem("File");
        public Form1(Model mod, string name)
        {
            model = mod;
            user = name;
            InitializeComponent();
            SetUp();
            MyMnuItems();
            MyMenu();
            button1.Click += (s, e) =>
            {
                if (radioButton1.Checked)
                {
                    int water, cofe, choco, milk, sugar;
                    (water, cofe, choco)= model.ChangeMaterial("Szimpla");
                    if (water < 1 || cofe < 1 || choco < 0 || Convert.ToInt32(textBox2.Text) < numericUpDown1.Value || Convert.ToInt32(textBox4.Text) < numericUpDown2.Value)
                    {
                        MessageBox.Show("Not enough ingredients");
                    }
                    else
                    {
                        order(water, cofe, choco);
                        model.coffeorder(user, "Szimpla", water, cofe, choco, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text));
                        listBox1.Items.Add("Szimpla");
                    }
                }

                if (radioButton2.Checked)
                {
                    int water, cofe, choco;
                    (water, cofe, choco) = model.ChangeMaterial("Hosszú");
                    if (water < 2 || cofe < 2 || choco < 0 || Convert.ToInt32(textBox2.Text) < numericUpDown1.Value || Convert.ToInt32(textBox4.Text) < numericUpDown2.Value)
                    {
                        MessageBox.Show("Not enough ingredients");
                    }
                    else
                    {
                        order(water, cofe, choco);
                        model.coffeorder(user, "Hosszú", water, cofe, choco, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text));
                        listBox1.Items.Add("Hosszú");
                    }
                }
                if (radioButton3.Checked)
                {
                    int water, cofe, choco;
                    (water, cofe, choco) = model.ChangeMaterial("Cappucino");
                    if (water < 1 || cofe < 1 || choco < 2 || Convert.ToInt32(textBox2.Text) < numericUpDown1.Value || Convert.ToInt32(textBox4.Text) < numericUpDown2.Value)
                    {
                        MessageBox.Show("Not enough ingredients");
                    }
                    else
                    {
                        order(water, cofe, choco);
                        model.coffeorder(user, "Cappucino", water, cofe, choco, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text));
                        listBox1.Items.Add("Cappucino");
                    }

                }
                if (radioButton4.Checked)
                {
                    int water, cofe, choco;
                    (water, cofe, choco) = model.ChangeMaterial("Frappé");
                    if(water < 1 || cofe < 2 || choco < 2 || Convert.ToInt32(textBox2.Text) < numericUpDown1.Value || Convert.ToInt32(textBox4.Text) < numericUpDown2.Value) 
                    {
                        MessageBox.Show("Not enough ingredients");
                    }
                    else
                    {
                        order(water, cofe, choco);
                        model.coffeorder(user, "Frappé", water, cofe, choco, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox4.Text));
                        listBox1.Items.Add("Frappé");
                    }
                }
            };
            button2.Click += (s, e) =>
            {
                textBox1.Text = "20";
                textBox3.Text = "20";
                textBox5.Text = "10";
                textBox2.Text = "20";
                textBox4.Text = "20";
            };
            

        }

        private void SetUp()
        {
            this.BackgroundImage = Image.FromFile("kave.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = "Víz:";
            label2.Text = "Kávé:";
            label3.Text = "Csoki:";
            label4.Text = "Cukor:";
            label5.Text = "Tej:";
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label3.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label4.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            label5.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox1.Text = "20";
            textBox2.Text = "20";
            textBox3.Text = "20";
            textBox4.Text = "20";
            textBox5.Text = "10";
            groupBox1.Text = "Státusz";
            groupBox2.Text = "Kérem válasszon";
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            radioButton1.Text = "Szimpla";
            radioButton2.Text = "Hosszú";
            radioButton3.Text = "Capuccino";
            radioButton4.Text = "Frappé";
            radioButton1.ForeColor = Color.Black;
            radioButton2.ForeColor = Color.Black;
            radioButton3.ForeColor = Color.White;
            radioButton4.ForeColor = Color.White;
            label6.Text = "Cukor";
            label7.Text = "Tej";
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            button1.Text = "Kávézik";
            button2.Text = "Gépet feltölt";
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button2.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            button2.Font = new Font(Label.DefaultFont, FontStyle.Bold);
        }
        public void order(int a, int b, int c) 
        {
            textBox1.Text = (Convert.ToInt32(textBox1.Text) - a).ToString();
            textBox3.Text = (Convert.ToInt32(textBox3.Text) - b).ToString();
            textBox5.Text = (Convert.ToInt32(textBox5.Text) - c).ToString();
            textBox2.Text = (Convert.ToInt32(textBox2.Text) - numericUpDown1.Value).ToString();
            textBox4.Text = (Convert.ToInt32(textBox4.Text) - numericUpDown2.Value).ToString();  
        }
        private void MyMenu()
        {
            MainMenu.BackColor = Color.FromArgb(64, 0, 0); ;
            MainMenu.ForeColor = Color.White;
            MainMenu.Text = "File Menu";
            MainMenu.Name = "MainMenu";
            MainMenu.Dock = DockStyle.Top;

            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);

        }
        private void MyMnuItems()
        {

            string[] row = new string[] { "Névjegyzék", "Kilépés" };


            FileMenu = new ToolStripMenuItem(row[0], null, new EventHandler(jegyzek_Clicked));
            MainMenu.Items.Add(FileMenu);

            FileMenu = new ToolStripMenuItem(row[1], null, new EventHandler(exit_Clicked));
            MainMenu.Items.Add(FileMenu);
        }

        private void exit_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jegyzek_Clicked(object sender, EventArgs e)
        {
            Form3 jegyzek = new Form3();
            jegyzek.Show();
        }

    }
}
