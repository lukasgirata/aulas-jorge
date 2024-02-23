using System.Reflection;
using System.Text.RegularExpressions;

namespace exercicio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();

            car.modelo = textBox1.Text;
            car.marca = textBox2.Text;

            car.descricao = car.modelo + " - " + car.marca;

            MessageBox.Show("Descrição do carro: " + car.descricao);
        }
    }
}
