namespace aula5
{

    public partial class Form1 : Form
    {
        public double acumulador;
        public double acumuladorqtd;

        public Form1()
        {
            InitializeComponent();
            acumulador = 0;
            acumuladorqtd = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemNome = textBox2.Text;
            int.TryParse(textBox1.Text, out int qtd);
            double.TryParse(textBox3.Text, out double valor);
            
            if (qtd > 0 )
            {
                valor *= qtd;
                listBox1.Items.Add($"{itemNome} - Quantidade: {qtd} - Valor Total: {valor:F2}");

                acumuladorqtd += qtd;
                acumulador += valor;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear(); 
            }
            else
            {
                MessageBox.Show("Por favor, insira uma quantidade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (acumuladorqtd <= 30)
            {
                MessageBox.Show($"Valor Total {acumulador}");
            }
            else
            {
                MessageBox.Show("Limite acima do permitido");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
