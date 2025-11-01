using System;

namespace aed_lista_06_ordenacao_01
{
    internal class GerarVetor
    {
        public static int[] CopiarVetor(int[] origem)
        {
            int vLength = origem.Length;
            int[] destino = new int[vLength];
            for (int i = 0; i < vLength; i++)
            {
                destino[i] = origem[i];
            }
            return destino;
        }

        public static decimal[] CopiarVetor(decimal[] origem)
        {
            int vLength = origem.Length;
            decimal[] destino = new decimal[vLength];
            for (int i = 0; i < vLength; i++)
            {
                destino[i] = origem[i];
            }
            return destino;
        }

        public static int[] GerarVetorIntComDisposicao(Disposicao disposicao, int tamanho)
        {
            int[] vetor;
            switch (disposicao)
            {
                case Disposicao.Aleatorio:
                    vetor = GerarVetorIntAleatorio(tamanho);
                    break;
                case Disposicao.Crescente:
                    vetor = GerarVetorIntCrescente(tamanho);
                    break;
                case Disposicao.Decrescente:
                    vetor = GerarVetorIntDecrescente(tamanho);
                    break;
                default:
                    vetor = GerarVetorIntAleatorio(tamanho);
                    break;
            }
            return vetor;
        }

        public static decimal[] GerarVetorDecimalComDisposicao(Disposicao disposicao, int tamanho)
        {
            decimal[] vetor;
            switch (disposicao)
            {
                case Disposicao.Aleatorio:
                    vetor = GerarVetorDecimalAleatorio(tamanho);
                    break;
                case Disposicao.Crescente:
                    vetor = GerarVetorDecimalCrescente(tamanho);
                    break;
                case Disposicao.Decrescente:
                    vetor = GerarVetorDecimalDecrescente(tamanho);
                    break;
                default:
                    vetor = GerarVetorDecimalAleatorio(tamanho);
                    break;
            }
            return vetor;
        }

        public static int[] GerarVetorIntCrescente(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            int[] vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = i;
            }
            return vetor;
        }

        public static int[] GerarVetorIntDecrescente(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            int[] vetor = new int[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = tamanho - i;
            }
            return vetor;
        }

        public static int[] GerarVetorIntAleatorio(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            int[] vetor = new int[tamanho];
            var random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next();
            }
            return vetor;
        }

        public static decimal[] GerarVetorDecimalCrescente(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            decimal[] vetor = new decimal[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = i;
            }
            return vetor;
        }

        public static decimal[] GerarVetorDecimalDecrescente(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            decimal[] vetor = new decimal[tamanho];
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = tamanho - i;
            }
            return vetor;
        }

        public static decimal[] GerarVetorDecimalAleatorio(int tamanho)
        {
            if (tamanho < 0)
            {
                throw new Exception();
            }
            decimal[] vetor = new decimal[tamanho];
            var random = new Random();
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (decimal)random.NextDouble();
            }
            return vetor;
        }
    }
}
