using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudCJ301116X
{
    internal class PedidoFinal
    {
        private int _id;
        private int _quantidade;
        private decimal _valorfinal;
        private string _metodopag;
        private decimal _troco;
        private DateTime _date;
        private int _idpedido;

        public PedidoFinal(int quantidade, decimal valorfinal, string metodopag, decimal troco, int idpedido)
        {
            _quantidade = quantidade;
            _valorfinal = valorfinal;
            _metodopag = metodopag;
            _troco = troco;
            _idpedido = idpedido;
        }

        public PedidoFinal(int id, int quantidade, decimal valorfinal, string metodopag, decimal troco, int idpedido) :
            this(quantidade, valorfinal, metodopag, troco, idpedido)
        {
            _id = id;

        }

        public PedidoFinal(int quantidade, decimal valorfinal, string metodopag, decimal troco, DateTime date)
        {
            _quantidade = quantidade;
            _valorfinal = valorfinal;
            _metodopag = metodopag;
            _troco = troco;
            _date = date;

        }

        public PedidoFinal(int id, int quantidade, decimal valorfinal, string metodopag, decimal troco, DateTime date) :
            this(quantidade, valorfinal, metodopag, troco, date)
        {
            _id = id;

        }

        //Validação do Id

        public int Id
        {
            get { return _id; }
        }

        //Validação do Quantidade.
        public decimal Quantidade
        {
            get { return _quantidade; }

        }

        //Validação do Valor final.
        public decimal ValorFinal
        {
            get { return _valorfinal; }

        }

        //Validação do Usuario
        public string MetodoPag
        {
            get { return _metodopag; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O método de pagamento informado não é um texto válido");
                _metodopag = value;
            }
        }

        public decimal Troco
        {
            get { return _troco; }

        }

        //Validação da Data.
        public DateTime Date
        {
            get { return _date; }

        }

        //Validação da Id Pedido.
        public int IdPedido
        {
            get { return _idpedido; }
        }
    }
}
