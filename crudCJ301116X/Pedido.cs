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
        private string _valor;
        private string _quantidade;
        private int _idpizza;
        private string _date;


        public Pedido(string valor, string quantidade, int idpizza, string date)
        {
            Valor = valor;
            Quantidade = quantidade;
            _idpizza = idpizza;
            Date = date;
            

        }

        public Pedido(int id, string valor, string quantidade, int idpizza, string date) :
            this(valor, quantidade, idpizza, date)
        {
            _id = id;

        }

        //Validação do Id

        public int Id
        {
            get { return _id; }
        }

        //Validação do Valor.
        public string Valor
        {
            get { return _valor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O valor informado não é um texto válido");
                _valor = value;
            }
        }

        //Validação da quantidade.
        public string Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O valor informado não é um texto válido");
                _quantidade = value;
            }
        }

        public int Idpizza
        {
            get { return _idpizza; }
        }

        //Validação da Data.
        public string Date
        {
            get { return _date; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O valor informado não é um texto válido");
                _date = value;
            }
        }


    }
}
