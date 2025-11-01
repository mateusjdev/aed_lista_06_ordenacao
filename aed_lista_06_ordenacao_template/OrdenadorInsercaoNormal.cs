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

    internal class OrdenadorInsercaoDepuracao: OrdenacaoDepuracao
    {
        public OrdenadorInsercaoDepuracao(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 1; i < vLength; i++)
            {
                int tmp = _vetor[i];
                _movimentacoes++;
                int j = i - 1;
                _comparacoes++;
                while (j >= 0 && tmp < _vetor[j])
                {
                    _comparacoes++;
                    _vetor[j + 1] = _vetor[j];
                    _movimentacoes++;
                    j--;
                }
                _vetor[j + 1] = tmp;
                _movimentacoes++;
            }
        }
    }
}
