using System;
using System.Net;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorQuickNormal : OrdenacaoNormal
    {
        public OrdenadorQuickNormal(int[] vetor) : base(vetor) { }

        private void QuickSort(int[] vetor, int esq, int dir)
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
                QuickSort(vetor, esq, iDir);
            if (iEsq < dir)
                QuickSort(vetor, iEsq, dir);
        }

        public override void RealizarOrdenacao()
        {
            QuickSort(_vetor, 0, _vetor.Length - 1);
        }
    }
}
