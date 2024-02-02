namespace calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botaosoma(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);  
            Int32 soma = valor1 + valor2;
            MessageBox.Show("Resultado da soma: " + soma.ToString());
        }

        private void botaomenos(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 menos = valor1 - valor2;
            MessageBox.Show("Resultado da subtração: " + menos.ToString());
        }

        private void botaomult(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 mult = valor1 * valor2;
            MessageBox.Show("Resultado da multiplicação: " + mult.ToString());
        }

        private void botaodiv(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 div = valor1 / valor2;
            MessageBox.Show("Resultado da divisão: " + div.ToString());
        }
    }
}
