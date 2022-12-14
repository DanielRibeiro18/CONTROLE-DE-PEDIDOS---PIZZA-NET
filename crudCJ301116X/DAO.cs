using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudCJ301116X
{
    internal class DAO
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public DAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public List<Usuario> ListarTodosClientes()
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Usuarios";



            List<Usuario> listaDeClientes = new List<Usuario>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Usuario user = new Usuario((int)rd["Id"], (string)rd["Nome"], (string)rd["Sexo"], (string)rd["Telefone"], (string)rd["Celular"],
                       (string)rd["Endereco"], (string)rd["Numero"], (string)rd["Cpf"], (string)rd["Usuario"], (string)rd["Senha"], (string)rd["Admin"]);
                    listaDeClientes.Add(user);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDeClientes;
        }
        public void Inserir(Usuario user)
        {
           
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "INSERT INTO Usuarios VALUES (@Nome, @Sexo, @Telefone, @Celular, @Endereco, @Numero, @Cpf, @Usuario, @Senha, @Admin)";


            Cmd.Parameters.AddWithValue("@Nome", user.Nome);
            Cmd.Parameters.AddWithValue("@Sexo", user.Sexo);
            Cmd.Parameters.AddWithValue("@Telefone", user.Telefone);
            Cmd.Parameters.AddWithValue("@Celular", user.Celular);
            Cmd.Parameters.AddWithValue("@Endereco", user.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", user.Numero);
            Cmd.Parameters.AddWithValue("@Cpf", user.Cpf);
            Cmd.Parameters.AddWithValue("@Usuario", user.UsuarioCad);
            Cmd.Parameters.AddWithValue("@Senha", user.Senha);
            Cmd.Parameters.AddWithValue("@Admin", user.Admin);

            try
            {

                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void Editar(Usuario usuarioEditado)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Usuarios SET Nome = @Nome, Sexo = @Sexo,Telefone = @Telefone, Celular = @Celular, 
            Endereco = @Endereco, Numero = @Numero, Cpf = @Cpf, Usuario = @Usuario, Senha = @Senha, Admin = @Admin WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", usuarioEditado.Id);
            Cmd.Parameters.AddWithValue("@Nome", usuarioEditado.Nome);
            Cmd.Parameters.AddWithValue("@Sexo", usuarioEditado.Sexo);
            Cmd.Parameters.AddWithValue("@Telefone", usuarioEditado.Telefone);
            Cmd.Parameters.AddWithValue("@Celular", usuarioEditado.Celular);
            Cmd.Parameters.AddWithValue("@Endereco", usuarioEditado.Endereco);
            Cmd.Parameters.AddWithValue("@Numero", usuarioEditado.Numero);
            Cmd.Parameters.AddWithValue("@Cpf", usuarioEditado.Cpf);
            Cmd.Parameters.AddWithValue("@Usuario", usuarioEditado.UsuarioCad);
            Cmd.Parameters.AddWithValue("@Senha", usuarioEditado.Senha);
            Cmd.Parameters.AddWithValue("@Admin", usuarioEditado.Admin);

            try
            {
                Cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        public void Excluir(int idUser)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "DELETE FROM Usuarios WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", idUser);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public string EntrarUser(Usuario loginuser)
        {
            string admin = null;

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"SELECT Admin FROM Usuarios WHERE Usuario = @Usuario AND Senha = @Senha";

            Cmd.Parameters.AddWithValue("@Usuario", loginuser.UsuarioCad);


            Cmd.Parameters.AddWithValue("@Senha", loginuser.Senha);


            try
            {

                SqlDataReader rd = Cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    admin = (string)rd["Admin"];
                }
                rd.Close();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Usuario não encontrado!");
            }
            finally
            {
                Con.CloseConnection();
            }

            return admin;
        }

        public List<Pizza> ListarTodasPizzas()
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "SELECT * FROM Pizza";



            List<Pizza> listaDePizza = new List<Pizza>();
            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Pizza pizza = new Pizza((int)rd["Id"], (string)rd["Sabor"], (string)rd["Tamanho"], (string)rd["NumeroFatia"], (decimal)rd["Preco"],
                       (string)rd["Disponibilidade"], (string)rd["Imagem"]);
                    listaDePizza.Add(pizza);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de pizzas no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDePizza;
        }

        public void InserirPizza(Pizza pizza)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "INSERT INTO Pizza VALUES (@Sabor, @Tamanho, @NumeroFatia, @Preco, @Disponibilidade, @Imagem)";


            Cmd.Parameters.AddWithValue("@Sabor", pizza.Sabor);
            Cmd.Parameters.AddWithValue("@Tamanho", pizza.Tamanho);
            Cmd.Parameters.AddWithValue("@NumeroFatia", pizza.NumeroFatia);
            Cmd.Parameters.AddWithValue("@Preco", pizza.Preco);
            Cmd.Parameters.AddWithValue("@Disponibilidade", pizza.Disponibilidade);
            Cmd.Parameters.AddWithValue("@Imagem", pizza.Imagem);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir pizza no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void EditarPizza(Pizza pizzaEditada)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Pizza SET Sabor = @Sabor, Tamanho = @Tamanho, NumeroFatia = @NumeroFatia, Preco = @Preco, 
            Disponibilidade = @Disponibilidade, Imagem = @Imagem WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", pizzaEditada.Id);
            Cmd.Parameters.AddWithValue("@Sabor", pizzaEditada.Sabor);
            Cmd.Parameters.AddWithValue("@Tamanho", pizzaEditada.Tamanho);
            Cmd.Parameters.AddWithValue("@NumeroFatia", pizzaEditada.NumeroFatia);
            Cmd.Parameters.AddWithValue("@Preco", pizzaEditada.Preco);
            Cmd.Parameters.AddWithValue("@Disponibilidade", pizzaEditada.Disponibilidade);
            Cmd.Parameters.AddWithValue("@Imagem", pizzaEditada.Imagem);

            try
            {
                Cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void ExcluirPizza(int idPizza)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "DELETE FROM Pizza WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", idPizza);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<Pedido> ListarTodosPedidos()
        {

            Cmd.Connection = Con.ReturnConnection();


            Cmd.CommandText = "SELECT Pedidos.Id, Pedidos.Valor, Pedidos.Quantidade, Pizza.Sabor, Pedidos.DataPedido FROM Pedidos" +
                " INNER JOIN Pizza ON Pedidos.Id_Pizza = Pizza.Id";



            List<Pedido> listaDePedido = new List<Pedido>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    Pedido pedido = new Pedido((int)rd["Id"], (decimal)rd["Valor"], (int)rd["Quantidade"], (string)rd["Sabor"],
                    (DateTime)rd["DataPedido"]);
                    
                    
                    listaDePedido.Add(pedido);
                }

                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura dos pedidos no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDePedido;
        }

        public void InserirNovoPedido(Pedido pedido)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "INSERT INTO Pedidos VALUES (@Valor, @Quantidade, @Id_Pizza, @DataPedido)";


            Cmd.Parameters.AddWithValue("@Valor", pedido.Valor);
            Cmd.Parameters.AddWithValue("@Quantidade", pedido.Quantidade);
            Cmd.Parameters.AddWithValue("@Id_Pizza", pedido.Idpizza);
            Cmd.Parameters.AddWithValue("@DataPedido", pedido.Date);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir pedido no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void EditarPedido(Pedido pedidoEditado)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"UPDATE Pedidos SET Valor = @Valor, Quantidade = @Quantidade, Id_Pizza = @Id_Pizza, DataPedido = @DataPedido WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", pedidoEditado.Id);
            Cmd.Parameters.AddWithValue("@Valor", pedidoEditado.Valor);
            Cmd.Parameters.AddWithValue("@Quantidade", pedidoEditado.Quantidade);
            Cmd.Parameters.AddWithValue("@Id_Pizza", pedidoEditado.Idpizza);
            Cmd.Parameters.AddWithValue("@DataPedido", pedidoEditado.Date);


            try
            {
                Cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao atualizar");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void ExcluirPedido(int idPedido)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "DELETE FROM Pedidos WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", idPedido);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public List<PedidoFinal> ListarTodosPedidosFinais()
        {

            Cmd.Connection = Con.ReturnConnection();


            Cmd.CommandText = @"SELECT FimPedido.Id, FimPedido.QuantItens, FimPedido.ValorTotal, FimPedido.MetodoPag, FimPedido.Troco, Pedidos.DataPedido
            FROM FimPedido INNER JOIN Pedidos ON FimPedido.Id_Pedido = Pedidos.Id ORDER BY Pedidos.DataPedido";



            List<PedidoFinal> listaDePedidojoin = new List<PedidoFinal>();

            try
            {
                SqlDataReader rd = Cmd.ExecuteReader();

                while (rd.Read())
                {
                    PedidoFinal pedidofinal = new PedidoFinal((int)rd["Id"], (int)rd["QuantItens"], (decimal)rd["ValorTotal"],
                    (string)rd["MetodoPag"], (decimal)rd["Troco"], (DateTime)rd["DataPedido"]);


                    listaDePedidojoin.Add(pedidofinal);
                }

                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura dos pedidos finais no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

            return listaDePedidojoin;
        }

        public void InserirFinal(PedidoFinal pedidofinal)
        {

            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "INSERT INTO FimPedido VALUES (@Quantidade, @ValorTotal, @MetodoPag, @Troco, @Id_Pedido)";


            Cmd.Parameters.AddWithValue("@Quantidade", pedidofinal.Quantidade);
            Cmd.Parameters.AddWithValue("@ValorTotal", pedidofinal.ValorFinal);          
            Cmd.Parameters.AddWithValue("@MetodoPag", pedidofinal.MetodoPag);
            Cmd.Parameters.AddWithValue("@Troco", pedidofinal.Troco);
            Cmd.Parameters.AddWithValue("@Id_Pedido", pedidofinal.IdPedido);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir fim do pedido no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public void ExcluirFim(int idFim)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = "DELETE FROM FimPedido WHERE Id = @Id";


            Cmd.Parameters.AddWithValue("@Id", idFim);

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Erro: Problemas ao excluir");
            }
            finally
            {
                Con.CloseConnection();
            }
        }

    }
}
