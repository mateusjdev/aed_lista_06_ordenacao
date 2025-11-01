using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorInsercaoNormal : OrdenacaoNormal
    {
        public OrdenadorInsercaoNormal(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
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
