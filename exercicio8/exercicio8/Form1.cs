namespace exercicio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo tri = new Triangulo();

            tri.ladoa = Convert.ToDouble(textBox1.Text);
            tri.ladob = Convert.ToDouble(textBox2.Text);
            tri.ladoc = Convert.ToDouble(textBox3.Text);    


            tri.perimetro = tri.ladoa + tri.ladob + tri.ladoc;

            MessageBox.Show("O perímetro do triângulo é de: " + tri.perimetro);

        }
    }
}
