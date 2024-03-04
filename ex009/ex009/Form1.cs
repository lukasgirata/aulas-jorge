namespace ex009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> lista = new List<int> { 1, 2, 3, 4, 3, 5 };

            Int32 remover;
            remover = lista.RemoverElemento;

            Console.WriteLine("Lista original:");
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            RemoverElemento(lista, 3);

            Console.WriteLine("Lista após remover todas as ocorrências do número 3:");
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            RemoverElemento(lista, 1);

            Console.WriteLine("Lista após remover elemento no índice 1:");
            foreach (int num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
