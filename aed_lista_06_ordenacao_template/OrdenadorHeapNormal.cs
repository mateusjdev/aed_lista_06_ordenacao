using System;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorHeapNormal : OrdenacaoNormal
    {
        public OrdenadorHeapNormal(int[] vetor) : base(vetor) { }

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
            int i = novo;
            int pai = Pai(i);
            while (i > 0 && vetor[i] > vetor[pai])
            {
                Trocar(vetor, i, pai);
                pai = Pai(i);
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
                } else
                {
                    i = tam - 1;
                }
            }
        }

        public override void RealizarOrdenacao()
        {
            int tam = _vetor.Length;
            for (int novo = 1; novo < tam; novo++)
            {
                Construir(_vetor, novo);
            }

            while (tam > 1)
            {
                Trocar(_vetor, 0, tam - 1);
                Reconstruir(_vetor, tam);
            }
        }
    }
}
