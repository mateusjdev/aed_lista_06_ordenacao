using System;
using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace aed_lista_06_ordenacao_template
{
    internal class OrdenadorHeap
    {
        private int[] _vetor;

        public OrdenadorHeap(int[] vetor)
        {
            _vetor = vetor;
        }

        public bool ConferirOrdenacao()
        {
            bool estaOrdenado = true;
            for (int i = 1; i < _vetor.Length; i++)
            {
                if (_vetor[i - 1] > _vetor[i])
                {
                    estaOrdenado = false;
                    i = _vetor.Length;
                }
            }
            return estaOrdenado;
        }

        public static void Trocar(int[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                int tmp = vetor[posA];
                vetor[posA] = vetor[posB];
                vetor[posB] = tmp;
            }
        }

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

        static void Construir(int[] vetor, int novo)
        {
            int i = novo;
            int pai = Pai(i);
            while (i > 0 && vetor[i] > vetor[pai])
            {
                Trocar(vetor, i, pai);
                pai = Pai(i);
            }
        }

        static void Reconstruir(int[] vetor, int tam)
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

        public void Ordernar()
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
