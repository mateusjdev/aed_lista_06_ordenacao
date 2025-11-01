using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorBolhaNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorBolhaNormalInt(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 0; i < vLength - 1; i++)
            {
                for (int j = vLength - 1; j > i; j--)
                {
                    if (_vetor[j] < _vetor[j - 1])
                    {
                        Trocar(_vetor, j, j - 1);
                    }
                }
            }
        }
    }

    internal class OrdenadorBolhaDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorBolhaDepuracaoInt(int[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 0; i < vLength - 1; i++)
            {
                for (int j = vLength - 1; j > i; j--)
                {
                    if (_vetor[j] < _vetor[j - 1])
                    {
                        Trocar(_vetor, j, j - 1);
                    }
                    _comparacoes++;
                }
            }
        }
    }

    internal class OrdenadorBolhaNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorBolhaNormalDecimal(decimal[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 0; i < vLength - 1; i++)
            {
                for (int j = vLength - 1; j > i; j--)
                {
                    if (_vetor[j] < _vetor[j - 1])
                    {
                        Trocar(_vetor, j, j - 1);
                    }
                }
            }
        }
    }

    internal class OrdenadorBolhaDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorBolhaDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

        public override void RealizarOrdenacao()
        {
            int vLength = _vetor.Length;
            for (int i = 0; i < vLength - 1; i++)
            {
                for (int j = vLength - 1; j > i; j--)
                {
                    if (_vetor[j] < _vetor[j - 1])
                    {
                        Trocar(_vetor, j, j - 1);
                    }
                    _comparacoes++;
                }
            }
        }
    }
}
