namespace aed_lista_06_ordenacao_01
{
    internal class OrdenadorInsercaoNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorInsercaoNormalInt(int[] vetor) : base(vetor) { }

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

    internal class OrdenadorInsercaoDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorInsercaoDepuracaoInt(int[] vetor) : base(vetor) { }

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

    internal class OrdenadorInsercaoNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorInsercaoNormalDecimal(decimal[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 1; i < vLength; i++)
            {
                decimal tmp = _vetor[i];
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

    internal class OrdenadorInsercaoDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorInsercaoDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 1; i < vLength; i++)
            {
                decimal tmp = _vetor[i];
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
