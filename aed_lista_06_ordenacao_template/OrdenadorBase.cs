using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aed_lista_06_ordenacao_template
{
    public abstract class OrdenacaoNormalInt
    {
        protected int[] _vetor;

        public int[] Vetor
        {
            get { return _vetor; }
            set { _vetor = value; }
        }

        public abstract void RealizarOrdenacao();

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

        protected static void Trocar(int[] vetor, int posA, int posB)
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

        protected OrdenacaoNormalInt(int[] vetor)
        {
            _vetor = vetor;
        }
    }

    public abstract class OrdenacaoDepuracaoInt
    {
        protected int[] _vetor;
        protected Int64 _comparacoes = 0;
        protected Int64 _movimentacoes = 0;

        public int[] Vetor
        {
            get { return _vetor; }
            set { _vetor = value; }
        }

        public Int64 Comparacoes
        {
            get { return _comparacoes; }
            set { _comparacoes = value; }
        }

        public Int64 Movimentacoes
        {
            get { return _movimentacoes; }
            set { _movimentacoes = value; }
        }

        public abstract void RealizarOrdenacao();

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
                _movimentacoes += 3;
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

        protected OrdenacaoDepuracaoInt(int[] vetor)
        {
            _vetor = vetor;
        }
    }

    public abstract class OrdenacaoNormalDecimal
    {
        protected decimal[] _vetor;

        public decimal[] Vetor
        {
            get { return _vetor; }
            set { _vetor = value; }
        }

        public abstract void RealizarOrdenacao();

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

        protected static void Trocar(decimal[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                decimal tmp = vetor[posA];
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

        protected OrdenacaoNormalDecimal(decimal[] vetor)
        {
            _vetor = vetor;
        }
    }

    public abstract class OrdenacaoDepuracaoDecimal
    {
        protected decimal[] _vetor;
        protected Int64 _comparacoes = 0;
        protected Int64 _movimentacoes = 0;

        public decimal[] Vetor
        {
            get { return _vetor; }
            set { _vetor = value; }
        }

        public Int64 Comparacoes
        {
            get { return _comparacoes; }
            set { _comparacoes = value; }
        }

        public Int64 Movimentacoes
        {
            get { return _movimentacoes; }
            set { _movimentacoes = value; }
        }

        public abstract void RealizarOrdenacao();

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

        protected void Trocar(decimal[] vetor, int posA, int posB)
        {
            if (posA != posB)
            {
                decimal tmp = vetor[posA];
                vetor[posA] = vetor[posB];
                vetor[posB] = tmp;
                _movimentacoes += 3;
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

        protected OrdenacaoDepuracaoDecimal(decimal[] vetor)
        {
            _vetor = vetor;
        }
    }
}
