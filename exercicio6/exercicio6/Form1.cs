namespace exercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aluno a = new Aluno();

            a.nome = (textBox1.Text);

            MessageBox.Show("Olá " +  a.nome + " a sua média anual foi de: " + a.media);  

        }
    }
}
