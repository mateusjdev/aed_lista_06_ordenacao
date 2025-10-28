using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorInsercao
    {
        private int[] _vetor;

        public OrdenadorInsercao(int[] vetor)
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
            for (int i = 1; i < vLength; i++)
            {
                int tmp = _vetor[i];
                int j = i - 1;
                while (j >= 0 && tmp < _vetor[j])
                {
                    _vetor[j + 1] = _vetor[j];
                    j--;
                }
                _vetor[j + 1] = tmp;
            }
        }
    }
}
