using System;

namespace aed_lista_06_ordenacao_template
{
    public abstract class OrdenacaoNormal
    {
        protected int[] _vetor;

        public int[] Vetor
        {
            get { return _vetor; }
            set { _vetor = value; }
        }

        public abstract  void RealizarOrdenacao();

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

        protected void Trocar(int[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                int tmp = vetor[posA];
                vetor[posA] = vetor[posB];
                vetor[posB] = tmp;
            }
        }

        public void Ordernar()
        {
            if (_vetor == null || _vetor.Length == 0)
            {
                throw new Exception("Vetor não inicializado");
            }
            RealizarOrdenacao();
        }

        protected OrdenacaoNormal(int[] vetor)
        {
            _vetor = vetor;
        }
    }

    internal class Program
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

        const int QUANTIDADE_EXECUCOES = 10;

        public static void Etapa03InteiroTempo(Disposicao disposicao, int tamanho)
        {
            Console.WriteLine("Rodando Etapa06InteiroTempo");
            for (int i = 0; i < QUANTIDADE_EXECUCOES; i++)
            {
                
            }
            // for(Algoritmos)
        }

        public static void Etapa03InteiroDepuracao(Disposicao disposicao, int tamanho)
        {
            Console.WriteLine("Rodando Etapa06InteiroDepuracao");
            // for(Algoritmos)
        }

        public static void Etapa03DecimalTempo(Disposicao disposicao, int tamanho)
        {
            Console.WriteLine("Rodando Etapa06DecimalTempo");
            // for(Algoritmos)
        }

        public static void Etapa03DecimalDepuracao(Disposicao disposicao, int tamanho)
        {
            Console.WriteLine("Rodando Etapa06DecimalDepuracao");
            // for(Algoritmos)
        }

        public static void Etapa02(Disposicao disposicao, int tamanho)
        {
            Etapa03InteiroTempo(disposicao, tamanho);
            Etapa03InteiroDepuracao(disposicao, tamanho);
            Etapa03DecimalTempo(disposicao, tamanho);
            Etapa03DecimalDepuracao(disposicao, tamanho);
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
