using System.Drawing;
using System.Xml.Linq;

namespace ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conversor co = new Conversor();

            double conta;

            co.real = Convert.ToInt32(textBox1.Text);

            conta = co.real * co.taxa;

            MessageBox.Show("O valor digitado convertido para doláres é de: " + conta);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conversor co = new Conversor();

            double conta1;

            co.dolar = Convert.ToDouble(textBox1.Text);

            conta1 = co.dolar / co.taxa;

            MessageBox.Show("O valor digitado convertido para reais é de: " + conta1);
        }
    }
}
