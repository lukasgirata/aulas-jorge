namespace exercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo ci = new Circulo();

            ci.raio = Convert.ToDouble(textBox1.Text);
            ci.diam = ci.raio * 2;

            MessageBox.Show("O diametro do círculo informado é: " + ci.diam);
        }
    }
}
