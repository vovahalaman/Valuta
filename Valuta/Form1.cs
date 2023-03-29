namespace Valuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "=>";
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox4.Clear();
            textBox3.Clear();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label2.Text = "<=";
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox4.Clear();
            textBox3.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs1, kurs2, suma, sum, sum_out;
            kurs1 = double.Parse(textBox1.Text);
            kurs2 = double.Parse(textBox2.Text);
            if (radioButton1.Checked == true && !string.IsNullOrEmpty(textBox3.Text))
            {
                textBox4.Enabled = true;
                suma = double.Parse(textBox3.Text);
                sum_out = suma * kurs1;
                textBox4.Text = sum_out.ToString();
            }
            if (radioButton2.Checked == true && !string.IsNullOrEmpty(textBox4.Text))
            {
                textBox4.Enabled = true;
                suma = double.Parse(textBox4.Text);
                sum_out = suma / kurs2;
                textBox3.Text = sum_out.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
        }
    }
}