using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdernadorSelecao
    {
        private int[] _vetor;

        public OrdernadorSelecao(int[] vetor)
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
            bool estaOrdenado = ConferirOrdenacao();
            int vLenght = _vetor.Length;
            for (int i = 0; i < vLenght; i++)
            {
                int iMenor = i;
                for (int j = i + 1; j < vLenght; j++)
                {
                    if (_vetor[j] < _vetor[iMenor])
                    { 
                        iMenor = j;
                    }
                }
                Trocar(_vetor, i, iMenor);
            }
        }
    }
}
