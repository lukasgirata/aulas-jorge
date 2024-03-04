using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Exibir
    {
        public static void ExibirMensagemTamanho(TamanhoCamiseta tamanho)
        {
            TamanhoCamiseta  t = new TamanhoCamiseta();

            switch (tamanho)
            {
                case TamanhoCamiseta.Pequeno:
                    MessageBox.Show("Tamanho da camiseta: Pequeno");
                    break;
                case TamanhoCamiseta.Medio:
                    MessageBox.Show("Tamanho da camiseta: Médio");
                    break;
                case TamanhoCamiseta.Grande:
                    MessageBox.Show("Tamanho da camiseta: Grande");
                    break;
                default:
                    MessageBox.Show("Tamanho da camiseta desconhecido");
                    break;
            }
        }
    }
}
