using System;
using System.Diagnostics;

namespace aed_lista_06_ordenacao_template
{
    internal class Program
    {
        const int TAMANHO_VETOR = 10000;

        public static int[] GerarCopiaVetor(int[] origem)
        {
            int vLength = origem.Length;
            int[] destino = new int[vLength];
            for (int i = 0; i < vLength; i++)
            {
                destino[i] = origem[i];
            }
            return destino;
        }

        public static int[] GerarVetor(int tamanho)
        {
            int[] vetor = new int[TAMANHO_VETOR];
            var random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next();
            }
            return vetor;
        }

        static void Main()
        {
            int[] vetor = GerarVetor(TAMANHO_VETOR);

            // SELEÇÂO
            Console.WriteLine("# Ordenação via Seleção\n");

            int[] vetorSelecao = GerarCopiaVetor(vetor);
            var selecao = new OrdenadorSelecao(vetorSelecao);
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}");
            selecao.Ordernar();
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}\n");

            // INSERÇÂO
            Console.WriteLine("# Ordenação via Inserção\n");

            int[] vetorInsercao = GerarCopiaVetor(vetor);
            var insercao = new OrdenadorInsercao(vetorInsercao);
            Console.WriteLine($"Esta ordenado: {insercao.ConferirOrdenacao()}");
            insercao.Ordernar();
            Console.WriteLine($"Esta ordenado: {insercao.ConferirOrdenacao()}\n");

            // BOLHA
            Console.WriteLine("# Ordenação via Bolha\n");

            int[] vetorBolha = GerarCopiaVetor(vetor);
            var bolha = new OrdenadorBolha(vetorBolha);
            Console.WriteLine($"Esta ordenado: {bolha.ConferirOrdenacao()}");
            bolha.Ordernar();
            Console.WriteLine($"Esta ordenado: {bolha.ConferirOrdenacao()}\n");

            // MERGE
            Console.WriteLine("# Ordenação via Merge\n");

            int[] vetorMerge = GerarCopiaVetor(vetor);
            var merge = new OrdenadorMerge(vetorMerge);
            Console.WriteLine($"Esta ordenado: {merge.ConferirOrdenacao()}");
            merge.Ordernar();
            Console.WriteLine($"Esta ordenado: {merge.ConferirOrdenacao()}\n");

            // QUICK
            Console.WriteLine("# Ordenação via Quick\n");

            int[] vetorQuick = GerarCopiaVetor(vetor);
            var quick = new OrdenadorQuick(vetorQuick);
            Console.WriteLine($"Esta ordenado: {quick.ConferirOrdenacao()}");
            quick.Ordernar();
            Console.WriteLine($"Esta ordenado: {quick.ConferirOrdenacao()}\n");

            // HEAP
            Console.WriteLine("# Ordenação via Heap\n");

            int[] vetorHeap = GerarCopiaVetor(vetor);
            var heap = new OrdenadorQuick(vetorHeap);
            Console.WriteLine($"Esta ordenado: {heap.ConferirOrdenacao()}");
            heap.Ordernar();
            Console.WriteLine($"Esta ordenado: {heap.ConferirOrdenacao()}\n");

            Console.WriteLine("Presscione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
