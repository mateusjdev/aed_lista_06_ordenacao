using System;

namespace aed_lista_06_ordenacao_template
{
    internal class Program
    {
        const int TAMANHO_VETOR = 100000;

        static void Main()
        {
            int[] vetor = new int[TAMANHO_VETOR];
            var random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next();
            }

            var selecao = new OrdernadorSelecao(vetor);
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}");
            selecao.Ordernar();
            Console.WriteLine($"Esta ordenado: {selecao.ConferirOrdenacao()}");

            Console.WriteLine("\nPresscione qualquer tecla para continuar");
            Console.ReadKey();
        }
    }
}
