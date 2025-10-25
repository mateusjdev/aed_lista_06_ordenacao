using System;

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
            var selecao = new OrdernadorSelecao(vetorSelecao);
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}");
            selecao.Ordernar();
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}\n");

            // INSERÇÂO
            Console.WriteLine("# Ordenação via Inserção\n");

            int[] vetorInsercao = GerarCopiaVetor(vetor);
            var insercao = new OrdernadorInsercao(vetorInsercao);
            Console.WriteLine($"Esta ordenado: {insercao.ConferirOrdenacao()}");
            insercao.Ordernar();
            Console.WriteLine($"Esta ordenado: {insercao.ConferirOrdenacao()}\n");

            // BOLHA
            Console.WriteLine("# Ordenação via Bolha\n");

            int[] vetorBolha = GerarCopiaVetor(vetor);
            var bolha = new OrdernadorBolha(vetorBolha);
            Console.WriteLine($"Esta ordenado: {bolha.ConferirOrdenacao()}");
            bolha.Ordernar();
            Console.WriteLine($"Esta ordenado: {bolha.ConferirOrdenacao()}\n");

            // MERGE
            Console.WriteLine("# Ordenação via Merge\n");

            int[] vetorMerge = GerarCopiaVetor(vetor);
            var merge = new OrdernadorMerge(vetorMerge);
            Console.WriteLine($"Esta ordenado: {merge.ConferirOrdenacao()}");
            merge.Ordernar();
            Console.WriteLine($"Esta ordenado: {merge.ConferirOrdenacao()}\n");

            Console.WriteLine("Presscione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
