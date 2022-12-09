using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudCJ301116X
{
    internal class Usuario
    {
        private int _id;
        private string _nome;
        private string _sexo;
        private string _telefone;
        private string _celular;
        private string _endereco;
        private string _numero;
        private string _cpf;
        private string _usuario;
        private string _senha;
        private string _admin;
        

        public Usuario(string nome, string sexo, string telefone, string celular, string endereco, string numero, string cpf, string usuario, string senha, string admin)
        {
            Nome = nome;
            Sexo = sexo;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
            Numero = numero;
            Cpf = cpf;
            UsuarioCad = usuario;
            Senha = senha;           
            Admin = admin;
        }

        public Usuario(string usuario, string senha)
        {
            Senha = senha;
            UsuarioCad = usuario;
        }

        public Usuario(int id, string nome, string sexo, string telefone, string celular, string endereco, string numero, string cpf, string usuario, string senha, string admin) :
            this(nome, sexo, telefone, celular, endereco, numero, cpf, usuario, senha, admin)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
        }

        //Validação do Nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }

        //Validação do Sexo.
        public string Sexo
        {
            get { return _sexo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O sexo informado não é um texto válido");
                _sexo = value;
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
            }
        }

        //Validação do Celular
        public string Celular
        {
            get { return _celular; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O celular informado não é um texto válido");
                _celular = value;
            }
        }

        //Validação do endereço.
        public string Endereco
        {
            get { return _endereco; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O endereço informado não é um texto válido");
                _endereco = value;
            }
        }

        //Validação do Número.
        public string Numero
        {
            get { return _numero; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O número informado não é um texto válido");
                _numero = value;
            }
        }

        //Validação do Cpf.
        public string Cpf
        {   
            get { return _cpf; }
            set
            {
                ValidaCpf valida = new ValidaCpf();

                if (string.IsNullOrEmpty(value))
                    throw new Exception("O cpf informado não é um texto válido");
                if (value.Length < 11)
                    throw new Exception("Tamanho do cpf é inválido!");
                if (valida.ValidarCpf(value) == false)
                    throw new Exception("O cpf informado é inválido!");
                _cpf = value;
            }
        }

        //Validação do Usuario
        public string UsuarioCad
        {
            get { return _usuario; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O usuário informado não é um texto válido");
                _usuario = value;
            }
        }
        //Validação do Senha
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informada não é um texto válido");
                _senha = value;
            }
        }

        //Validação do Administrador

        public string Admin
        {
            get { return _admin; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O tipo de usuário não foi informado");
                _admin = value;
            }
        }

    }
}
