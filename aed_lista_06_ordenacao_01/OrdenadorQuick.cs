namespace aed_lista_06_ordenacao_01
{
    internal class OrdenadorQuickNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorQuickNormalInt(int[] vetor) : base(vetor) { }

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

    internal class OrdenadorQuickDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorQuickDepuracaoInt(int[] vetor) : base(vetor) { }

        private void QuickSort(int[] vetor, int esq, int dir)
        {
            // Pivo escolhido é o do meio
            int pivo = vetor[(esq + dir) / 2];
            // Contar atribuição do pivo?
            _movimentacoes++;
            int iEsq = esq;
            int iDir = dir;
            while (iEsq <= iDir)
            {
                _comparacoes++;
                while (vetor[iEsq] < pivo)
                {
                    _comparacoes++;
                    iEsq++;
                }
                _comparacoes++;
                while (vetor[iDir] > pivo)
                {
                    _comparacoes++;
                    iDir--;
                }
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

    internal class OrdenadorQuickNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorQuickNormalDecimal(decimal[] vetor) : base(vetor) { }

        private void QuickSort(decimal[] vetor, int esq, int dir)
        {
            // Pivo escolhido é o do meio
            decimal pivo = vetor[(esq + dir) / 2];
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

    internal class OrdenadorQuickDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorQuickDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

        private void QuickSort(decimal[] vetor, int esq, int dir)
        {
            // Pivo escolhido é o do meio
            decimal pivo = vetor[(esq + dir) / 2];
            // Contar atribuição do pivo?
            _movimentacoes++;
            int iEsq = esq;
            int iDir = dir;
            while (iEsq <= iDir)
            {
                _comparacoes++;
                while (vetor[iEsq] < pivo)
                {
                    _comparacoes++;
                    iEsq++;
                }
                _comparacoes++;
                while (vetor[iDir] > pivo)
                {
                    _comparacoes++;
                    iDir--;
                }
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
