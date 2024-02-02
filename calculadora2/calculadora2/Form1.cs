namespace calculadora2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 soma = valor1 + valor2;
            MessageBox.Show("Resultado da soma: " + soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 subtracao = valor1 - valor2;
            MessageBox.Show("Resultado da subtração: " + subtracao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 mult = valor1 * valor2;
            MessageBox.Show("Resultado da multiplicação: " + mult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            Int32 div = valor1 / valor2;
            MessageBox.Show("Resultado da divisão: " + div);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            double raiz = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Resultado da raiz: " + Math.Sqrt(raiz));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double pot = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Resultado da potência: " + Math.Pow(num1, pot));
        }

        private void Calculadora_Load(object sender, EventArgs e)
        

        
        {

        }
    }
}
