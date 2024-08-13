namespace exemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double value))
            {
                value = value / 10;
                // Adiciona 500 ao valor se a primeira CheckBox estiver marcada
                if (checkBox2.Checked)
                {
                    double x = value;
                    value = value - (value * 0.20) ;
                    
                }

                // Adiciona 350 ao valor se a segunda CheckBox estiver marcada
                if (checkBox1.Checked)
                {
                    value = value * 0.10;
                }

                // Exibe o resultado no Label
                label1.Text = "Resultado: " + value.ToString();
            }
            else
            {
                // Exibe uma mensagem de erro se o valor não for um número válido
                MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}