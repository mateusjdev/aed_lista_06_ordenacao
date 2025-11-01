using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorSelecaoNormal : OrdenacaoNormal
    {
        public OrdenadorSelecaoNormal(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
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

    internal class OrdenadorSelecaoDepuracao: OrdenacaoDepuracao
    {
        public OrdenadorSelecaoDepuracao(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
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
                    _comparacoes++;
                }
                Trocar(_vetor, i, iMenor);
            }
        }
    }
}
