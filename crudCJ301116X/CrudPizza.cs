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
    public partial class CrudPizza : Form
    {
        private int Id;

        public CrudPizza()
        {
            InitializeComponent();
        }
        private void CrudPizza_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "OCORREU AO CARREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txbID.Clear();
            txbSabor.Clear();
            cmbTamanho.SelectedItem = null;
            cmbNFatia.SelectedItem = null;
            mtbPreco.Clear();
            chbDisponibilidade.Checked = false;
        }

        private void AtualizarListView()
        {
            ltvPizza.Items.Clear();
            DAO Dao = new DAO();

            List<Pizza> pizza = Dao.ListarTodasPizzas();
            if (pizza.Count > 0)
            {
                foreach (var pi in pizza)
                {
                    ListViewItem lv = new ListViewItem(pi.Id.ToString());
                    lv.SubItems.Add(pi.Sabor);
                    lv.SubItems.Add(pi.Tamanho);
                    lv.SubItems.Add(pi.NumeroFatia);
                    lv.SubItems.Add(pi.Preco);
                    lv.SubItems.Add(pi.Disponibilidade);
                    ltvPizza.Items.Add(lv);
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Pizza pizzaLida;

                if (chbDisponibilidade.Checked)
                {
                    pizzaLida = new Pizza(txbSabor.Text, cmbTamanho.Text, cmbNFatia.Text, mtbPreco.Text, "SIM");
                    DAO Dao = new DAO();
                    Dao.InserirPizza(pizzaLida);
                }
                else if (chbDisponibilidade.Checked == false)
                {
                    pizzaLida = new Pizza(txbSabor.Text, cmbTamanho.Text, cmbNFatia.Text, mtbPreco.Text, "NAO");
                    DAO Dao = new DAO();
                    Dao.InserirPizza(pizzaLida);
                }

                MessageBox.Show("Pizza de " + txbSabor.Text + " inserida com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja editar?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {

                try
                {
                    Pizza pizzaEditada;
                    if (chbDisponibilidade.Checked)
                    {
                        pizzaEditada = new Pizza(Id, txbSabor.Text, cmbTamanho.Text, cmbNFatia.Text, mtbPreco.Text, "SIM");
                        DAO Dao = new DAO();

                        MessageBox.Show("Pizza de " + txbSabor.Text + " editada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dao.EditarPizza(pizzaEditada);
                    }

                    if (chbDisponibilidade.Checked == false)
                    {
                        pizzaEditada = new Pizza(Id, txbSabor.Text, cmbTamanho.Text, cmbNFatia.Text, mtbPreco.Text, "NAO");
                        DAO Dao = new DAO();

                        MessageBox.Show("Pizza de " + txbSabor.Text + " editada com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dao.EditarPizza(pizzaEditada);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO AO EDITAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AtualizarListView();
            LimparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DAO Dao = new DAO();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir a pizza?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Pizza de " + txbSabor.Text + " excluída com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dao.ExcluirPizza(Id);
                }
                catch (Exception)
                {
                    throw new Exception("ERRO AO EXCLUIR");
                }
            }

            AtualizarListView();
            LimparCampos();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ltvPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPizza.FocusedItem.Index;
                Id = int.Parse(ltvPizza.Items[index].SubItems[0].Text);
                txbID.Text = ltvPizza.Items[index].SubItems[0].Text;
                txbSabor.Text = ltvPizza.Items[index].SubItems[1].Text;
                cmbTamanho.Text = ltvPizza.Items[index].SubItems[2].Text;
                cmbNFatia.Text = ltvPizza.Items[index].SubItems[3].Text;
                mtbPreco.Text = ltvPizza.Items[index].SubItems[4].Text;
                if (ltvPizza.Items[index].SubItems[5].Text == "SIM")
                {
                    chbDisponibilidade.Checked = true;
                }
                else if (ltvPizza.Items[index].SubItems[5].Text == "NAO")
                {
                    chbDisponibilidade.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void ltvPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
