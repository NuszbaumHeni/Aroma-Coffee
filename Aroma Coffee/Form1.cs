namespace Aroma_Coffee
{
    public partial class Form1 : Form
    {
        Model model;
        string user;
        public Form1(Model mod, string name)
        {
            InitializeComponent();
            SetUp();
            menuStrip2.ItemClicked += (s, e) =>
            {
                Form3 nevjegyzek = new Form3();
                nevjegyzek.Show();
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
            groupBox1.Text = "Státusz";
            groupBox2.Text = "Kérem válasszon";
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox1.ForeColor = Color.FromArgb(64, 0, 0);
            groupBox2.ForeColor = Color.FromArgb(64, 0, 0);
            radioButton1.Text = "Szimpla";
            radioButton2.Text = "Hosszú";
            radioButton3.Text = "Capuccino";
            radioButton4.Text = "Frappe";
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
            menuStrip2.BackColor = Color.FromArgb(64, 0, 0);
            menuStrip2.ForeColor = Color.White;
        }
    }
}
