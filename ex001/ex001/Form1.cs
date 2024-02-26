namespace ex001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculadora ca = new Calculadora();

            Int32 somar;

            somar = ca.Valores(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show("Soma dos valores inteiros: " + somar.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculadora ca = new Calculadora();

            double soma;

            soma = ca.Valores(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            MessageBox.Show("Soma dos valores decimais: " + soma.ToString());
        }
    }
}
