using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex009
{
    internal class ManipuladorLista
    {
        public static void RemoverElemento(List<int> lista, int numero)
        {
            lista.RemoveAll(x => x == numero);
        }

        public static void RemoverElemento(List<int> lista, int indice)
        {
            if (indice >= 0 && indice < lista.Count)
            {
                lista.RemoveAt(indice);
            }
            else
            {
                MessageBox.Show("O índice fornecido está fora dos limites da lista.");
            }
        }
    }
}
