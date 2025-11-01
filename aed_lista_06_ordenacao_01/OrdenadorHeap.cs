namespace aed_lista_06_ordenacao_01
{
    internal class OrdenadorHeapNormalInt : OrdenacaoNormalInt
    {
        public OrdenadorHeapNormalInt(int[] vetor) : base(vetor) { }

        private static int Pai(int i)
        {
            return (i - 1) / 2;
        }

        private static int MaiorFilho(int[] vetor, int i, int tam)
        {
            int filho = (2 * i) + 1;
            bool ehUltimo = filho == (tam - 1);
            if (!(ehUltimo || vetor[filho] > vetor[filho + 1]))
            {
                filho++;
            }
            return filho;
        }

        private static bool TemFilho(int pos, int tam)
        {
            return pos < (tam / 2);
        }

        void Construir(int[] vetor, int novo)
        {
            for (int i = novo; i > 0 && vetor[i] > vetor[Pai(i)]; i = Pai(i))
            {
                Trocar(vetor, i, Pai(i));
            }
        }

        void Reconstruir(int[] vetor, int tam)
        {
            int i = 0;
            while (TemFilho(i, tam))
            {
                int filho = MaiorFilho(vetor, i, tam);
                if (vetor[i] < vetor[filho])
                {
                    Trocar(vetor, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam - 1;
                }
            }
        }

        void HeapSort(int[] vetor, int tam)
        {
            for (int novo = 1; novo < tam; novo++)
            {
                Construir(vetor, novo);
            }

            while (tam > 1)
            {
                Trocar(vetor, 0, tam - 1);
                Reconstruir(vetor, --tam);
            }
        }

        public override void RealizarOrdenacao()
        {
            HeapSort(_vetor, _vetor.Length);
        }
    }

    internal class OrdenadorHeapDepuracaoInt : OrdenacaoDepuracaoInt
    {
        public OrdenadorHeapDepuracaoInt(int[] vetor) : base(vetor) { }

        private static int Pai(int i)
        {
            return (i - 1) / 2;
        }

        private int MaiorFilho(int[] vetor, int i, int tam)
        {
            int filho = (2 * i) + 1;
            bool ehUltimo = filho == (tam - 1);
            if (!ehUltimo)
            {
                if (vetor[filho] < vetor[filho + 1])
                {
                    filho++;
                }
                _comparacoes++;
            }
            return filho;
        }

        private static bool TemFilho(int pos, int tam)
        {
            return pos < (tam / 2);
        }

        void Construir(int[] vetor, int novo)
        {
            int i = novo;
            while (i > 0)
            {
                if (vetor[i] > vetor[Pai(i)])
                {
                    Trocar(vetor, i, Pai(i));
                }
                _comparacoes++;
                i = Pai(i);
            }
        }

        void Reconstruir(int[] vetor, int tam)
        {
            int i = 0;
            while (TemFilho(i, tam))
            {
                int filho = MaiorFilho(vetor, i, tam);
                if (vetor[i] < vetor[filho])
                {
                    Trocar(vetor, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam - 1;
                }
                _comparacoes++;
            }
        }

        void HeapSort(int[] vetor, int tam)
        {
            for (int novo = 1; novo < tam; novo++)
            {
                Construir(vetor, novo);
            }

            while (tam > 1)
            {
                Trocar(vetor, 0, tam - 1);
                Reconstruir(vetor, --tam);
            }
        }

        public override void RealizarOrdenacao()
        {
            HeapSort(_vetor, _vetor.Length);
        }
    }

    internal class OrdenadorHeapNormalDecimal : OrdenacaoNormalDecimal
    {
        public OrdenadorHeapNormalDecimal(decimal[] vetor) : base(vetor) { }

        private static int Pai(int i)
        {
            return (i - 1) / 2;
        }

        private static int MaiorFilho(decimal[] vetor, int i, int tam)
        {
            int filho = (2 * i) + 1;
            bool ehUltimo = filho == (tam - 1);
            if (!(ehUltimo || vetor[filho] > vetor[filho + 1]))
            {
                filho++;
            }
            return filho;
        }

        private static bool TemFilho(int pos, int tam)
        {
            return pos < (tam / 2);
        }

        void Construir(decimal[] vetor, int novo)
        {
            for (int i = novo; i > 0 && vetor[i] > vetor[Pai(i)]; i = Pai(i))
            {
                Trocar(vetor, i, Pai(i));
            }
        }

        void Reconstruir(decimal[] vetor, int tam)
        {
            int i = 0;
            while (TemFilho(i, tam))
            {
                int filho = MaiorFilho(vetor, i, tam);
                if (vetor[i] < vetor[filho])
                {
                    Trocar(vetor, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam - 1;
                }
            }
        }

        void HeapSort(decimal[] vetor, int tam)
        {
            for (int novo = 1; novo < tam; novo++)
            {
                Construir(vetor, novo);
            }

            while (tam > 1)
            {
                Trocar(vetor, 0, tam - 1);
                Reconstruir(vetor, --tam);
            }
        }

        public override void RealizarOrdenacao()
        {
            HeapSort(_vetor, _vetor.Length);
        }
    }

    internal class OrdenadorHeapDepuracaoDecimal : OrdenacaoDepuracaoDecimal
    {
        public OrdenadorHeapDepuracaoDecimal(decimal[] vetor) : base(vetor) { }

        private static int Pai(int i)
        {
            return (i - 1) / 2;
        }

        private int MaiorFilho(decimal[] vetor, int i, int tam)
        {
            int filho = (2 * i) + 1;
            bool ehUltimo = filho == (tam - 1);
            if (!ehUltimo)
            {
                if (vetor[filho] < vetor[filho + 1])
                {
                    filho++;
                }
                _comparacoes++;
            }
            return filho;
        }

        private static bool TemFilho(int pos, int tam)
        {
            return pos < (tam / 2);
        }

        void Construir(decimal[] vetor, int novo)
        {
            int i = novo;
            while (i > 0)
            {
                if (vetor[i] > vetor[Pai(i)])
                {
                    Trocar(vetor, i, Pai(i));
                }
                _comparacoes++;
                i = Pai(i);
            }
        }

        void Reconstruir(decimal[] vetor, int tam)
        {
            int i = 0;
            while (TemFilho(i, tam))
            {
                int filho = MaiorFilho(vetor, i, tam);
                if (vetor[i] < vetor[filho])
                {
                    Trocar(vetor, i, filho);
                    i = filho;
                }
                else
                {
                    i = tam - 1;
                }
                _comparacoes++;
            }
        }

        void HeapSort(decimal[] vetor, int tam)
        {
            for (int novo = 1; novo < tam; novo++)
            {
                Construir(vetor, novo);
            }

            while (tam > 1)
            {
                Trocar(vetor, 0, tam - 1);
                Reconstruir(vetor, --tam);
            }
        }

        public override void RealizarOrdenacao()
        {
            HeapSort(_vetor, _vetor.Length);
        }
    }
}
