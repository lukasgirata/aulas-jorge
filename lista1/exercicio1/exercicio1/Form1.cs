namespace exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nome = textBox1.Text;

            double nota1 = Convert.ToDouble(textBox2.Text);
            double nota2 = Convert.ToDouble(textBox3.Text);
            double nota3 = Convert.ToDouble(textBox4.Text);
            double nota4 = Convert.ToDouble(textBox5.Text);

            var soma = nota1 + nota2 + nota3 + nota4;
            var div = soma / 4;

            if (div >= 7)
            {
                MessageBox.Show("A media do aluno foi de " + div + ", Aprovado!!");
            }
            else
            {
                MessageBox.Show("A media do aluno foi de " + div + ", Reprovado!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 pres = Convert.ToInt32(textBox6.Text);
            Int32 falt = Convert.ToInt32(textBox7.Text);

            Int32 div2 = pres / 100;
            Int32 min = div2 * 25;

            if (falt > min)
            {
                MessageBox.Show("O aluno possui um número de faltas muito alto, Reprovado!!");
            }
            else
            {
                MessageBox.Show("O aluno possui um número de faltas aceitável, Aprovado!!");
            }
        }
    }
}
