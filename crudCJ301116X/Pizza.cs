using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudCJ301116X
{
    internal class Pizza
    {
        //SABOR, TAMANHO, NUMERO DE FATIAS, PREÇO, IMAGEM

        private int _id;
        private string _sabor;
        private string _tamanho;
        private string _numerofatia;
        private string _preco;
        private string _disponibilidade;
        

        public Pizza(string sabor, string tamanho, string numerofatia, string preco, string disponibilidade)
        {
            Sabor = sabor;
            Tamanho = tamanho;
            NumeroFatia = numerofatia;
            Preco = preco;
            Disponibilidade = disponibilidade;


        }
        public Pizza(int id, string sabor, string tamanho, string numerofatia, string preco, string disponibilidade) :
            this(sabor, tamanho, numerofatia, preco, disponibilidade)
        {
            _id = id;
        }

        //Validação do Id

        public int Id
        {
            get { return _id; }
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

        //Validação do Tamanho.
        public string Tamanho
        {
            get { return _tamanho; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O tamanho informado não é um texto válido");
                _tamanho = value;
            }
        }

        //Validação do Número de fatias
        public string NumeroFatia
        {
            get { return _numerofatia; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O número de fatias informado não é um texto válido");
                _numerofatia = value;
            }
        }

        //Validação do Preço
        public string Preco
        {
            get { return _preco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O preço informado não é um texto válido");
                _preco = value;
            }
        }



        public string Disponibilidade
        {
            get { return _disponibilidade; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A disponibilidade informada não é válida");
                _disponibilidade = value;
            }
        }

    }
}
