namespace ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            bool val = false;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O campo de nome está vazio");
                textBox1.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("O campo da nota 1 está vazio");
                textBox2.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("O campo da nota 2 está vazio");
                textBox3.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("O campo da nota 3 está vazio");
                textBox4.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("O campo da nota 4 está vazio");
                textBox5.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("O campo da nota de Aulas Dadas está vazio");
                textBox6.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("O campo de faltas está vazio");
            }

            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                string nome = textBox1.Text;

                double nota1 = Convert.ToDouble(textBox2.Text);
                double nota2 = Convert.ToDouble(textBox3.Text);
                double nota3 = Convert.ToDouble(textBox4.Text);
                double nota4 = Convert.ToDouble(textBox5.Text);

                double soma = nota1 + nota2 + nota3 + nota4;
                double div = soma / 4;


                //double

                if (div >= 6)
                {

                    MessageBox.Show("A media anual do(a) aluno(a) " + nome + " foi de " + div + ", Aprovado(a)!!");
                }

                else
                {
                    MessageBox.Show("A media anual do(a) aluno(a) " + nome + " foi de " + div + ", Reprovado(a)!!");
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 dadas = Convert.ToInt32(textBox6.Text);
            Int32 faltas = Convert.ToInt32(textBox7.Text);

            double porcentagem = dadas / 100;
            double minimo = porcentagem * 25;

            if(faltas <= minimo){
                MessageBox.Show("O aluno foi aprovado com a quantidade aceitavel de faltas!! Ele faltou " + faltas + " dias");
            }

            else{
                MessageBox.Show("O aluno foi reprovado com " + faltas + " faltas!!");
            }
        }
    }
}
