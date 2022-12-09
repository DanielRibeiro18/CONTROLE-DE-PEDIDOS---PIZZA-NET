using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudCJ301116X
{
    public partial class Pedidos : Form
    {
        private int Id;

        private void AtualizarCardapio()
        {
            ltvPedidoPizza.Items.Clear();
            DAO Dao = new DAO();

            List<Pizza> cardapio = Dao.ListarTodasPizzas();
            if (cardapio.Count > 0)
            {
                foreach (var car in cardapio)
                {
                    ListViewItem lv = new ListViewItem(car.Id.ToString());
                    lv.SubItems.Add(car.Sabor);
                    lv.SubItems.Add(car.Tamanho);
                    lv.SubItems.Add(car.NumeroFatia);
                    lv.SubItems.Add(car.Preco);
                    ltvPedidoPizza.Items.Add(lv);
                }
            }
        }

        private void AtualizarListView()
        {
            ltvPedido.Items.Clear();
            DAO Dao = new DAO();

            List<Pedido> pedido = Dao.ListarTodosPedidos();
            if (pedido.Count > 0)
            {
                foreach (var ped in pedido)
                {
                    ListViewItem lv = new ListViewItem(ped.Id.ToString());
                    lv.SubItems.Add(ped.Valor);
                    lv.SubItems.Add(ped.Quantidade);
                    lv.SubItems.Add(ped.Date);
                    ltvPedido.Items.Add(lv);
                }
            }
        }

        private void LimparCampos()
        {
            txbID.Clear();
            mtbValorTotal.Clear();
            mtbQuant.Clear();
            txbIdPizza.Clear();
        }

        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnCardapio_Click(object sender, EventArgs e)
        {
            pnlCardapio.Visible = true;
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            pnlCardapio.Visible = false;
        }

        private void ltvPedidoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
                AtualizarCardapio();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "OCORREU UM ERRO AO CARREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ltvPedidoPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPedidoPizza.FocusedItem.Index;
                Id = int.Parse(ltvPedido.Items[index].SubItems[0].Text);
                txbIdPizza.Text = ltvPedido.Items[index].SubItems[0].Text;
                mtbValorTotal.Text = ltvPedidoPizza.Items[index].SubItems[4].Text;
                

            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void pnlCardapio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedidoLido;


                pedidoLido = new Pedido(mtbValorTotal.Text, mtbQuant.Text, int.Parse(txbIdPizza.Text), dtpPedido.Text);
                    DAO Dao = new DAO();
                    Dao.InserirNovoPedido(pedidoLido);
                

                MessageBox.Show("Pedido inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();
            AtualizarListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            
        }

        private void ltvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPedido.FocusedItem.Index;
                Id = int.Parse(ltvPedido.Items[index].SubItems[0].Text);
                txbID.Text = ltvPedido.Items[index].SubItems[0].Text;
                mtbValorTotal.Text = ltvPedido.Items[index].SubItems[1].Text;
                mtbQuant.Text = ltvPedido.Items[index].SubItems[2].Text;
                dtpPedido.Text = ltvPedido.Items[index].SubItems[3].Text;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja editar?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                try
                {
                    Pedido pedidoEditado;



                    pedidoEditado = new Pedido(Id, mtbValorTotal.Text, mtbQuant.Text, int.Parse(txbIdPizza.Text), dtpPedido.Text);
                    DAO Dao = new DAO();
                    Dao.EditarPedido(pedidoEditado);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO AO EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarListView();
            LimparCampos();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            DAO Dao = new DAO();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o pedido?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Pedido excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dao.ExcluirPedido(Id);
                }
                catch (Exception)
                {
                    throw new Exception("ERRO AO EXCLUIR");
                }
            }

            AtualizarListView();
            LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
