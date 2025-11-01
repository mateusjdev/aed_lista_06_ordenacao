namespace aed_lista_06_ordenacao_01
{
    internal class OrdenadorMergeNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorMergeNormalInt(int[] vetor) : base(vetor) { }

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

        private static void MergeSort(int[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                MergeSort(vetor, esq, meio);
                MergeSort(vetor, meio + 1, dir);
                Intercalar(vetor, esq, meio, dir);
            }
        }

        public override void RealizarOrdenacao()
        {
            MergeSort(_vetor, 0, _vetor.Length - 1);
        }
    }

    internal class OrdenadorMergeDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorMergeDepuracaoInt(int[] vetor) : base(vetor) { }

        private void Intercalar(int[] vetor, int esq, int meio, int dir)
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
                _comparacoes++;
                _movimentacoes++;
            }
            // Atribui o restante do vetor da esquerda
            while (iEsq <= meio)
            {
                vTmp[j++] = vetor[iEsq++];
                _movimentacoes++;
            }
            // Atribui o restante do vetor da direita
            while (iDir <= dir)
            {
                vTmp[j++] = vetor[iDir++];
                _movimentacoes++;
            }
            // Substitui os elementos do vetor pelos elementos intercalados
            for (int k = 0; k < tamanho; k++)
            {
                vetor[esq + k] = vTmp[k];
                _movimentacoes++;
            }
        }

        private void MergeSort(int[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                MergeSort(vetor, esq, meio);
                MergeSort(vetor, meio + 1, dir);
                Intercalar(vetor, esq, meio, dir);
            }
        }

        public override void RealizarOrdenacao()
        {
            MergeSort(_vetor, 0, _vetor.Length - 1);
        }
    }

    internal class OrdenadorMergeNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorMergeNormalDecimal(decimal[] vetor) : base(vetor) { }

        private static void Intercalar(decimal[] vetor, int esq, int meio, int dir)
        {
            // Cria um vetor temporário para guardar os elementos intercalados
            int tamanho = dir - esq + 1;
            decimal[] vTmp = new decimal[tamanho];
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

        private static void MergeSort(decimal[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                MergeSort(vetor, esq, meio);
                MergeSort(vetor, meio + 1, dir);
                Intercalar(vetor, esq, meio, dir);
            }
        }

        public override void RealizarOrdenacao()
        {
            MergeSort(_vetor, 0, _vetor.Length - 1);
        }
    }

    internal class OrdenadorMergeDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorMergeDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

        private void Intercalar(decimal[] vetor, int esq, int meio, int dir)
        {
            // Cria um vetor temporário para guardar os elementos intercalados
            int tamanho = dir - esq + 1;
            decimal[] vTmp = new decimal[tamanho];
            int iEsq = esq;
            int iDir = meio + 1;
            int j = 0;
            // Intercala os elementos dos vetores para o vetor temporário
            while (iEsq <= meio && iDir <= dir)
            {
                vTmp[j++] = vetor[iEsq] <= vetor[iDir] ? vetor[iEsq++] : vetor[iDir++];
                _comparacoes++;
                _movimentacoes++;
            }
            // Atribui o restante do vetor da esquerda
            while (iEsq <= meio)
            {
                vTmp[j++] = vetor[iEsq++];
                _movimentacoes++;
            }
            // Atribui o restante do vetor da direita
            while (iDir <= dir)
            {
                vTmp[j++] = vetor[iDir++];
                _movimentacoes++;
            }
            // Substitui os elementos do vetor pelos elementos intercalados
            for (int k = 0; k < tamanho; k++)
            {
                vetor[esq + k] = vTmp[k];
                _movimentacoes++;
            }
        }

        private void MergeSort(decimal[] vetor, int esq, int dir)
        {
            if (esq < dir)
            {
                int meio = (esq + dir) / 2;
                MergeSort(vetor, esq, meio);
                MergeSort(vetor, meio + 1, dir);
                Intercalar(vetor, esq, meio, dir);
            }
        }

        public override void RealizarOrdenacao()
        {
            MergeSort(_vetor, 0, _vetor.Length - 1);
        }
    }
}
