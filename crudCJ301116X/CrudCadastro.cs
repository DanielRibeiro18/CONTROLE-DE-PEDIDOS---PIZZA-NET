using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudCJ301116X
{   
    public partial class CrudCadastro : Form
    {
        private int Id;

        public CrudCadastro()
        {

            InitializeComponent();
        }

        private void AtualizarListView()
        {
            ltvDados.Items.Clear();
            DAO Dao = new DAO();

            List<Usuario> usuarios = Dao.ListarTodosClientes();
            if (usuarios.Count > 0)
            {
                foreach (var user in usuarios)
                {
                    ListViewItem lv = new ListViewItem(user.Id.ToString());
                    lv.SubItems.Add(user.Nome);
                    lv.SubItems.Add(user.Sexo);
                    lv.SubItems.Add(user.Telefone);
                    lv.SubItems.Add(user.Celular);
                    lv.SubItems.Add(user.Endereco);
                    lv.SubItems.Add(user.Numero);
                    lv.SubItems.Add(user.Cpf);
                    lv.SubItems.Add(user.UsuarioCad);
                    lv.SubItems.Add(user.Senha);
                    lv.SubItems.Add(user.Admin);
                    ltvDados.Items.Add(lv);
                }
            }        
        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }
     
        private void LimparCampos()
        {
            txbID.Clear();
            txbNome.Clear();
            mtbTelefone.Clear();
            mtbCelular.Clear();
            mtbCpf.Clear();
            txbEndereco.Clear();
            txbNumero.Clear();
            txbUsuario.Clear();
            txbSenha.Clear();
            cmbTipo.SelectedItem = null;
            rdbMasculino.Checked = false;
            rdbFeminino.Checked = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {       
            try
            {
                Usuario usuarioLido;

                EncryptDecrypt md5 = new EncryptDecrypt();
                string hash = md5.base64Encode(txbSenha.Text);

                if (rdbMasculino.Checked)
                {
                    usuarioLido = new Usuario(txbNome.Text, rdbMasculino.Text, mtbTelefone.Text, mtbCelular.Text, txbEndereco.Text, txbNumero.Text, mtbCpf.Text, txbUsuario.Text, hash, cmbTipo.Text);
                    DAO Dao = new DAO();
                    Dao.Inserir(usuarioLido);
                }
                else if (rdbFeminino.Checked)
                {
                    usuarioLido = new Usuario(txbNome.Text, rdbFeminino.Text, mtbTelefone.Text, mtbCelular.Text, txbEndereco.Text, txbNumero.Text, mtbCpf.Text, txbUsuario.Text, hash, cmbTipo.Text);
                    DAO Dao = new DAO();
                    Dao.Inserir(usuarioLido);
                }

                

                MessageBox.Show("Usuario " + txbNome.Text + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();
            AtualizarListView();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DAO Dao = new DAO();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Usuario " + txbNome.Text + " excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dao.Excluir(Id);
                }
                catch (Exception)
                {
                    throw new Exception("ERRO AO EXCLUIR");
                }
            }

            AtualizarListView();
            LimparCampos();     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja editar?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                EncryptDecrypt md5 = new EncryptDecrypt();
                string hash = md5.base64Encode(txbSenha.Text);

                try
                {
                    Usuario usuarioEditado;
                    if (rdbMasculino.Checked)
                    {
                        usuarioEditado = new Usuario(Id, txbNome.Text, rdbMasculino.Text, mtbTelefone.Text, mtbCelular.Text, txbEndereco.Text, txbNumero.Text, mtbCpf.Text, txbUsuario.Text, hash, cmbTipo.Text);
                        DAO Dao = new DAO();

                        MessageBox.Show("Usuario " + txbNome.Text + " editado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dao.Editar(usuarioEditado);
                    }

                    if (rdbFeminino.Checked)
                    {
                        usuarioEditado = new Usuario(Id, txbNome.Text, rdbFeminino.Text, mtbTelefone.Text, mtbCelular.Text, txbEndereco.Text, txbNumero.Text, mtbCpf.Text, txbUsuario.Text, hash, cmbTipo.Text);
                        DAO Dao = new DAO();

                        MessageBox.Show("Usuario " + txbNome.Text + " editado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Dao.Editar(usuarioEditado);
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
        private void ltvDados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvDados.FocusedItem.Index;
                Id = int.Parse(ltvDados.Items[index].SubItems[0].Text);
                txbID.Text = ltvDados.Items[index].SubItems[0].Text;
                txbNome.Text = ltvDados.Items[index].SubItems[1].Text;
                if (ltvDados.Items[index].SubItems[2].Text == "Masculino")
                {
                    rdbMasculino.Checked = true;
                }
                else if (ltvDados.Items[index].SubItems[2].Text == "Feminino")
                {
                    rdbFeminino.Checked = true;
                }
                mtbTelefone.Text = ltvDados.Items[index].SubItems[3].Text;
                mtbCelular.Text = ltvDados.Items[index].SubItems[4].Text;
                txbEndereco.Text = ltvDados.Items[index].SubItems[5].Text;
                txbNumero.Text = ltvDados.Items[index].SubItems[6].Text;
                mtbCpf.Text = ltvDados.Items[index].SubItems[7].Text;
                txbUsuario.Text = ltvDados.Items[index].SubItems[8].Text;


                EncryptDecrypt md5 = new EncryptDecrypt();
                string hash = md5.base64Decode(ltvDados.Items[index].SubItems[9].Text);
                txbSenha.Text = hash;
                
                cmbTipo.Text = ltvDados.Items[index].SubItems[10].Text;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }
        private void CrudCliente_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizarListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "OCORREU UM ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }

        private void lblPizzanet_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
