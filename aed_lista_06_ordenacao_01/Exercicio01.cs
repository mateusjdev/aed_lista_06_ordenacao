using System;
using System.Diagnostics;

namespace aed_lista_06_ordenacao_01
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

        public static void BenchmarkInteiroTempo(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Tempo, Tipo.Inteiro, QUANTIDADE_EXECUCOES);
            var vetor = GerarVetor.GerarVetorIntComDisposicao(disposicao, tamanho);

            Stopwatch stopwatch = new Stopwatch();
            TimeSpan[] tempos = new TimeSpan[QUANTIDADE_EXECUCOES];

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoNormalInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorInsercaoNormalInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorBolhaNormalInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorQuickNormalInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorMergeNormalInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorHeapNormalInt(GerarVetor.CopiarVetor(vetor));
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

        public static void BenchmarkInteiroDepuracao(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Depuracao, Tipo.Inteiro, QUANTIDADE_EXECUCOES);
            var vetor = GerarVetor.GerarVetorIntComDisposicao(disposicao, tamanho);

            Int64 comparacoes = 0;
            Int64 movimentacoes = 0;

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoDepuracaoInt(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Selecao, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Insercao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorInsercaoDepuracaoInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorBolhaDepuracaoInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorQuickDepuracaoInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorMergeDepuracaoInt(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorHeapDepuracaoInt(GerarVetor.CopiarVetor(vetor));
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

        public static void BenchmarkDecimalTempo(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Tempo, Tipo.Decimal, QUANTIDADE_EXECUCOES);
            var vetor = GerarVetor.GerarVetorDecimalComDisposicao(disposicao, tamanho);

            Stopwatch stopwatch = new Stopwatch();
            TimeSpan[] tempos = new TimeSpan[QUANTIDADE_EXECUCOES];

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoNormalDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorInsercaoNormalDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorBolhaNormalDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorQuickNormalDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorMergeNormalDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorHeapNormalDecimal(GerarVetor.CopiarVetor(vetor));
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

        public static void BenchmarkDecimalDepuracao(Disposicao disposicao, int tamanho)
        {
            StatusLogger.Params(disposicao, tamanho, Execucao.Depuracao, Tipo.Decimal, QUANTIDADE_EXECUCOES);
            var vetor = GerarVetor.GerarVetorDecimalComDisposicao(disposicao, tamanho);

            Int64 comparacoes = 0;
            Int64 movimentacoes = 0;

            StatusLogger.Rodando(Algoritmos.Selecao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorSelecaoDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
                ordenador.Ordernar();
                if (!ordenador.ConferirOrdenacao())
                {
                    throw new Exception("Ordenação não foi realizada!");
                }
                comparacoes = ordenador.Comparacoes;
                movimentacoes = ordenador.Movimentacoes;
            }
            // TODO: Calcular média das execuções
            StatusLogger.Finalizado(Algoritmos.Selecao, comparacoes, movimentacoes);

            StatusLogger.Rodando(Algoritmos.Insercao);
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                var ordenador = new OrdenadorInsercaoDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorBolhaDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorQuickDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorMergeDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
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
                var ordenador = new OrdenadorHeapDepuracaoDecimal(GerarVetor.CopiarVetor(vetor));
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

        static void Main()
        {
            foreach (var tamanho in Enum.GetValues(typeof(Tamanho)))
            {
                foreach (var disposicao in Enum.GetValues(typeof(Disposicao)))
                {
                    Disposicao _disposicao = (Disposicao)disposicao;
                    int _tamanho = (int)tamanho;
                    BenchmarkInteiroTempo(_disposicao, _tamanho);
                    BenchmarkInteiroDepuracao(_disposicao, _tamanho);
                    BenchmarkDecimalTempo(_disposicao, _tamanho);
                    BenchmarkDecimalDepuracao(_disposicao, _tamanho);
                }
            }
        }
    }
}
