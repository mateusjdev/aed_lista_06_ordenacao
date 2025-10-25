using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdernadorBolha
    {
        private int[] _vetor;

        public OrdernadorBolha(int[] vetor)
        {
            _vetor = vetor;
        }

        public bool ConferirOrdenacao()
        {
            bool estaOrdenado = true;
            for (int i = 1; i < _vetor.Length; i++)
            {
                if (_vetor[i - 1] > _vetor[i])
                {
                    estaOrdenado = false;
                    i = _vetor.Length;
                }
            }
            return estaOrdenado;
        }

        public void Trocar(int[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                int tmp = vetor[posA];
                vetor[posA] = vetor[posB];
                vetor[posB] = tmp;
            }
        }

        public void Ordernar()
        {
            int vLength = _vetor.Length;
            for (int i = 0; i < vLength - 1; i++)
            {
                for (int j = vLength - 1; j > i; j--)
                {
                    if (_vetor[j] < _vetor[j - 1])
                    {
                        Trocar(_vetor, j, j - 1);
                    }
                }
            }
        }
    }
}
