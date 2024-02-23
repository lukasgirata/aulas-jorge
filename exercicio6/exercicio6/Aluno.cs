using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    internal class Aluno
    {
        public string nome;
        public double[] nota = new double[4] { 7, 7, 7, 7 };
        public double soma;
        public double media;

        public string medias()
        {
            for(int i = 0; i < nota.Length; i++)
            {
                soma += nota[i];
            }

            media = soma / 4;
            return Convert.ToString(media);
        }
    }
}
