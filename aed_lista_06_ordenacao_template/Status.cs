using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_lista_06_ordenacao_template
{
    public enum Status
    {
        Rodando,
        Ordenado
    }

    internal class StatusLogger
    {
        public static void Params(Disposicao disposicao, int tamanho, Execucao execucao, Tipo tipo, int quantExec)
        {
            Console.WriteLine($"# Gerando vetor.");
            Console.WriteLine($"# tamanho: {tamanho}, disposicao: {disposicao}, execução: {execucao}, tipo: {tipo}, quantExec: {quantExec}\n");
        }

        public static void Rodando(Algoritmos algoritmo)
        {
            // Console.WriteLine($"Rodando algoritmo {algoritmo}...");
        }

        public static void Finalizado(Algoritmos algoritmo)
        {

            // Console.WriteLine($"Finalizado algo. {algoritmo} (Ordenado)");
            Console.WriteLine($"{algoritmo} (Ordenado)");
        }

        public static void Finalizado(Algoritmos algoritmo, string tempo)
        {
            // Console.WriteLine($"Finalizado algo. {algoritmo} (Ordenado) em {tempo}");
            Console.WriteLine($"{algoritmo} (Ordenado) em {tempo}");
        }

        public static void Finalizado(Algoritmos algoritmo, Int64 comparacoes, Int64 movimentacoes)
        {
            // Console.WriteLine($"Finalizado algo. {algoritmo} (Ordenado) com {comparacoes} compracações e {movimentacoes} movimentações.");
            Console.WriteLine($"{algoritmo} (Ordenado) com {comparacoes} compracações e {movimentacoes} movimentações.");
        }
    }
}
