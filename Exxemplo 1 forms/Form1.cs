namespace Exxemplo_1_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int soma = numero1 + numero2;
            label1.Text = "Soma:" + soma.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int r = numero1 - numero2;
            label1.Text = "Subtração:" + r.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int r = numero1 * numero2;
            label1.Text = "Multiplicação:" + r.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(textBox1.Text);
            int numero2 = int.Parse(textBox2.Text);
            int r = numero1 / numero2;
            label1.Text = "Divisão:" + r.ToString();
        }
    }
}