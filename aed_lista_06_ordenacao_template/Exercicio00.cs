using System;
using System.Diagnostics;

namespace aed_lista_06_ordenacao_template
{
    public enum Disposicao
    {
        Crescente,
        Decrescente,
        Aleatorio
    }

    public enum Tamanho
    {
        Mil = 1000,
        QuinhentosMil = 500000
    }

    public enum Tipo
    {
        Inteiro,
        Decimal
    }

    public enum Execucao
    {
        Tempo,
        Depuracao
    }

    public enum Algoritmos
    {
        Selecao,
        Insercao,
        Bolha,
        Merge,
        Heap,
        Quick
    }

    internal class Program
    {
        const int QUANTIDADE_EXECUCOES = 1;

        public static void Etapa03InteiroTempo(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Tempo, Tipo.Inteiro, QUANTIDADE_EXECUCOES);
            int[] vetor;
            switch (disposicao)
            {
                case Disposicao.Aleatorio:
                    vetor = GerarVetor.GerarVetorIntAleatorio(tamanho);
                    break;
                case Disposicao.Crescente:
                    vetor = GerarVetor.GerarVetorIntCrescente(tamanho);
                    break;
                case Disposicao.Decrescente:
                    vetor = GerarVetor.GerarVetorIntDecrescente(tamanho);
                    break;
                default:
                    vetor = GerarVetor.GerarVetorIntAleatorio(tamanho);
                    break;
            }

            Stopwatch stopwatch = new Stopwatch();
            TimeSpan[] tempos = new TimeSpan[QUANTIDADE_EXECUCOES];

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Selecao, tempos[0].ToString());

            StatusLogger.Rodando(Algoritmos.Insercao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorInsercaoNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Insercao, tempos[0].ToString());

            StatusLogger.Rodando(Algoritmos.Bolha);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorBolhaNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Bolha, tempos[0].ToString());

            StatusLogger.Rodando(Algoritmos.Quick);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorQuickNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Quick, tempos[0].ToString());

            StatusLogger.Rodando(Algoritmos.Merge);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorMergeNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Merge, tempos[0].ToString());

            StatusLogger.Rodando(Algoritmos.Heap);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorHeapNormal(GerarVetor.CopiarVetor(vetor));
                stopwatch.Restart();
                ordenador.Ordernar();
                stopwatch.Stop();
                tempos[i] = stopwatch.Elapsed;
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Heap, tempos[0].ToString());

            Console.WriteLine();
        }

        public static void Etapa03InteiroDepuracao(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Depuracao, Tipo.Inteiro, QUANTIDADE_EXECUCOES);
            int[] vetor;
            switch (disposicao)
            {
                case Disposicao.Aleatorio:
                    vetor = GerarVetor.GerarVetorIntAleatorio(tamanho);
                    break;
                case Disposicao.Crescente:
                    vetor = GerarVetor.GerarVetorIntCrescente(tamanho);
                    break;
                case Disposicao.Decrescente:
                    vetor = GerarVetor.GerarVetorIntDecrescente(tamanho);
                    break;
                default:
                    vetor = GerarVetor.GerarVetorIntAleatorio(tamanho);
                    break;
            }

            Int64 comparacoes = 0;
            Int64 movimentacoes = 0;

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes  = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Selecao, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Insercao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorInsercaoDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Insercao, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Bolha);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorBolhaDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Bolha, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Quick);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorQuickDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Quick, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Merge);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorMergeDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Merge, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Heap);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorHeapDepuracao(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Heap, comparacoes, movimentacoes);

            Console.WriteLine();
        }

        public static void Etapa03DecimalTempo(Disposicao disposicao, int tamanho)
        {
            // Console.WriteLine("Rodando Etapa06DecimalTempo");
            // for(Algoritmos)
        }

        public static void Etapa03DecimalDepuracao(Disposicao disposicao, int tamanho)
        {
            // Console.WriteLine("Rodando Etapa06DecimalDepuracao");
            // for(Algoritmos)
        }

        public static void Etapa02(Disposicao disposicao, int tamanho)
        {
            // Etapa03InteiroTempo(disposicao, tamanho);
            Etapa03InteiroDepuracao(disposicao, tamanho);
            // Etapa03DecimalTempo(disposicao, tamanho);
            // Etapa03DecimalDepuracao(disposicao, tamanho);
        }

        public static void Etapa01()
        {
            foreach (var tamanho in Enum.GetValues(typeof(Tamanho)))
            {
                foreach (var disposicao in Enum.GetValues(typeof(Disposicao)))
                {
                    Etapa02((Disposicao)disposicao, (int) tamanho);
                }
            }
        }

        static void Main()
        {
            Etapa01();
        }
    }
}
