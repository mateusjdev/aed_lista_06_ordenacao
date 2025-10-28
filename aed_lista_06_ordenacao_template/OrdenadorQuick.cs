using System;
using System.Net;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorQuick
    {
        private int[] _vetor;

        public OrdenadorQuick(int[] vetor)
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

        public static void Trocar(int[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                int tmp = vetor[posA];
                vetor[posA] = vetor[posB];
                vetor[posB] = tmp;
            }
        }

        private static void Dividir(int[] vetor, int esq, int dir)
        {
            // Pivo escolhido é o do meio
            int pivo = vetor[(esq + dir) / 2];
            int iEsq = esq;
            int iDir = dir;
            while (iEsq <= iDir)
            {
                while (vetor[iEsq] < pivo)
                    iEsq++;
                while (vetor[iDir] > pivo)
                    iDir--;
                if (iEsq <= iDir)
                {
                    Trocar(vetor, iEsq++, iDir--);
                }
            }

            if (esq < iDir)
                Dividir(vetor, esq, iDir);
            if (iEsq < dir)
                Dividir(vetor, iEsq, dir);
        }

        public void Ordernar()
        {
            Dividir(_vetor, 0, _vetor.Length - 1);
        }
    }
}
