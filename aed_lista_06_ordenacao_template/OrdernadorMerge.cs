using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdernadorMerge
    {
        private int[] _vetor;

        public OrdernadorMerge(int[] vetor)
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

        private static void Intercalar(int[] vetor, int esq, int meio, int dir)
        {
            // Cria um vetor temporário para guardar os elementos intercalados
            int tamanho = dir - esq + 1;
            int[] vTmp = new int[tamanho];
            int iEsq = esq;
            int iDir = meio + 1;
            int j = 0;
            // Intercala os elementos dos vetores para o vetor temporário
            while (iEsq <= meio && iDir <= dir)
            {
                vTmp[j++] = vetor[iEsq] <= vetor[iDir] ? vetor[iEsq++] : vetor[iDir++];
            }
            // Atribui o restante do vetor da esquerda
            while (iEsq <= meio)
            {
                vTmp[j++] = vetor[iEsq++];
            }
            // Atribui o restante do vetor da direita
            while (iDir <= dir)
            {
                vTmp[j++] = vetor[iDir++];
            }
            // Substitui os elementos do vetor pelos elementos intercalados
            for (int k = 0; k < tamanho; k++)
            {
                vetor[esq + k] = vTmp[k];
            }
        }

        private static void Dividir(int[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                Dividir(vetor, esq, meio);
                Dividir(vetor, meio + 1, dir);
                Intercalar(vetor, esq, meio, dir);
            }
        }

        public void Ordernar()
        {
            Dividir(_vetor, 0, _vetor.Length - 1);
        }
    }
}
