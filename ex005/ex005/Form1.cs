namespace ex005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area a = new Area();

            double area;

            area = a.Retangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            MessageBox.Show("A �rea do ret�ngulo � de: " + area + "m�");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Area a = new Area();

            double raio;

            raio = a.Circulo(Convert.ToDouble(textBox1.Text));

            MessageBox.Show("A �rea da circunfer�ncia (Raio) � de: " + raio);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Area a = new Area();

            double area1;

            area1 = a.Triangulo(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            MessageBox.Show("A �rea do tri�ngulo � de: " + area1 + " m�");
        }
    }
}
