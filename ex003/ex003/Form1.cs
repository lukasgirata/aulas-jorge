namespace ex003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matematica ma = new Matematica();

            Int32 soma;

            soma = ma.Soma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show("A soma dos numeros inteiros é: " + soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matematica ma = new Matematica();

            double media;

            media = ma.Media(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            MessageBox.Show("A media dois numeros é: " + media);
        }
    }
}
