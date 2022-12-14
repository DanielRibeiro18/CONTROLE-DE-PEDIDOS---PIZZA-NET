using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crudCJ301116X
{
    internal class Pedido
    {
        private int _id;
        private decimal _valor;
        private int _quantidade;
        private int _idpizza;
        private DateTime _date;
        private string _sabor;



        public Pedido(decimal valor, int quantidade, int idpizza, DateTime date)
        {
            _valor = valor;
            _quantidade = quantidade;
            _idpizza = idpizza;
            _date = date;

        }

        public Pedido(int id, decimal valor, int quantidade, int idpizza, DateTime date) :
            this(valor, quantidade, idpizza, date)
        {
            _id = id;

        }

        public Pedido(decimal valor, int quantidade, string sabor, DateTime date)
        {
            _valor = valor;
            _quantidade = quantidade;
            Sabor = sabor;
            _date = date;

        }

        public Pedido(int id, decimal valor, int quantidade, string sabor, DateTime date) :
            this(valor, quantidade, sabor, date)
        {
            _id = id;

        }

        //Validação do Id

        public int Id
        {
            get { return _id; }
        }

        //Validação do Valor.
        public decimal Valor
        {
            get { return _valor; }

        }

        //Validação da quantidade.
        public int Quantidade
        {
            get { return _quantidade; }

        }

        public int Idpizza
        {
            get { return _idpizza; }
        }

        //Validação da Data.
        public DateTime Date
        {
            get { return _date; }
            
        }

        //Validação do Sabor.
        public string Sabor
        {
            get { return _sabor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O sabor informado não é um texto válido");
                _sabor = value;
            }
        }


    }
}
