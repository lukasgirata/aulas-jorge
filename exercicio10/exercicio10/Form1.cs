namespace exercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();

            f.nome = textBox1.Text;
            f.salario = Convert.ToDouble(textBox2.Text);

            f.anual = f.salario * 12;

            MessageBox.Show("O sálario anual do funcionário " + f.nome + " é de R$" + f.anual);
        }
    }
}
