namespace aed_lista_06_ordenacao_01
{
    internal class OrdenadorSelecaoNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorSelecaoNormalInt(int[] vetor) : base(vetor) { }

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

    internal class OrdenadorSelecaoDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorSelecaoDepuracaoInt(int[] vetor) : base(vetor) { }

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

    internal class OrdenadorSelecaoNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorSelecaoNormalDecimal(decimal[] vetor) : base(vetor) { }

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

    internal class OrdenadorSelecaoDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorSelecaoDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

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
