namespace ex006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compara c = new Compara();

            double co;

            co = c.Comp(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            MessageBox.Show("O maior número é: " + co);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compara c = new Compara();

            double co1;

            co1 = c.Compa(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            MessageBox.Show("O maior número é: " + co1);
        }
    }
}
