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
    public partial class TelaMenu : Form
    {
        public TelaMenu(string admin)
        {
            InitializeComponent();

            if (admin == "NAO")
                cADASTROToolStripMenuItem.Visible = false;
        }

        private void nOVOUSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CrudCadastro cadastro = new CrudCadastro();
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pIZZAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CrudPizza pizza = new CrudPizza();
            pizza.ShowDialog();
            this.Visible = true;
        }

        private void nOVOPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Pedidos ped = new Pedidos();
            ped.ShowDialog();
            this.Visible = true;
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja realizar logout?", "LOGOUT", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("REALIZANDO LOGOUT, OBRIGADO POR UTILIZAR O SISTEMA!");
                Close();
            }
        }
    }
}
