using System.Security.Permissions;

namespace ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool valida()
        {
            bool val = false;

            if(string.IsNullOrEmpty(textBox1.Text) )
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
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O campo da nota 4 está vazio");
                textBox5.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("O campo de aulas dadas está vazio");
                textBox6.Focus();
                val = true;
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("O campo de faltas está vazio");
                textBox7.Focus();
                val = true;
            }

            return val;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (valida() == false)
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valida() == false)
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
}
