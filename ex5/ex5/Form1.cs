namespace ex5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            public static void Main(string[] args)
            {
                TamanhoCamiseta tamanho = TamanhoCamiseta.Medio;
                ExibirMensagemTamanho(tamanho);
            }
        }
    }
