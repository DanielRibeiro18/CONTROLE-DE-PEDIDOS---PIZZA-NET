using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudCJ301116X
{
    public partial class Login : Form
    {
        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public Login()
        {
            InitializeComponent();
            Con = new Conexao();
            Cmd = new SqlCommand();
        }

        public void LimparCampos()
        {
            txbUsuario.Clear();
            txbSenha.Clear();
        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string admin;
            try
            {
                Usuario usuarioLido;

                EncryptDecrypt crypt = new EncryptDecrypt();
                string hash = crypt.base64Encode(txbSenha.Text);

               
                usuarioLido = new Usuario(txbUsuario.Text, hash);

                DAO Dao = new DAO();
                admin = Dao.EntrarUser(usuarioLido);


                if (admin != null)
                {
                    
                    if (admin.Equals("NAO"))
                    {
                        this.Visible = false;
                        TelaMenu telafunc = new TelaMenu(admin);
                        telafunc.ShowDialog();
                        this.Visible = true;
                    }

                    if (admin.Equals("SIM"))
                    {
                        this.Visible = false;
                        TelaMenu telafunc = new TelaMenu(admin);
                        telafunc.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Dados não encontrados!\n" + "Tente novamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PROBLEMAS AO FAZER LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimparCampos();

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja finalizar?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("OBRIGADO POR UTILIZAR O SISTEMA!\nDANIEL - CJ301116X");
                    Application.Exit();
                }
                catch (Exception)
                {
                    throw new Exception("ERRO AO FINALIZAR");
                }
            }
        }
    }
}
