using System;

namespace aed_lista_06_ordenacao_01
{
    internal class StatusLogger
    {
        public static void Params(Disposicao disposicao, int tamanho, Execucao execucao, Tipo tipo, int quantExec)
        {
            Console.WriteLine($"# Gerando vetor.");
            Console.WriteLine($"# tamanho: {tamanho}, disposicao: {disposicao}, execução: {execucao}, tipo: {tipo}, quantExec: {quantExec}\n");
        }

        public static void Rodando(Algoritmos algoritmo)
        {
            Console.WriteLine($"Rodando algoritmo {algoritmo}...");
        }

        public static void Finalizado(Algoritmos algoritmo, string tempo)
        {
            Console.WriteLine($"{algoritmo} ordenado em {tempo}");
        }

        public static void Finalizado(Algoritmos algoritmo, Int64 comparacoes, Int64 movimentacoes)
        {
            Console.WriteLine($"{algoritmo} ordenado com {comparacoes} compracações e {movimentacoes} movimentações.");
        }
    }
}
