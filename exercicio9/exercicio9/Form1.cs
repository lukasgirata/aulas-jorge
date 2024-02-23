namespace exercicio9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto p = new Produto();

            p.nome = textBox1.Text;
            p.preco = Convert.ToDouble(textBox2.Text);
            p.desconto = Convert.ToDouble(textBox3.Text);

            p.porcen = p.preco / 100;
            p.calcu = p.porcen * p.desconto;
            p.precof = p.preco - p.calcu;

            MessageBox.Show("Nome do produto: " + p.nome + " Preço do produto: " + p.preco + " Desconto aplicado: " + p.desconto +
            " Preço final: " + p.precof);
        }
    }
}
