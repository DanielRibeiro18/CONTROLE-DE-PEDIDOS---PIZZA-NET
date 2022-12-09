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
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();
        }

        private void pgb_Entrada_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.pgb_Entrada.Value >= 50)
            {
                this.timer1.Enabled = false;
            }

            if (this.pgb_Entrada.Value == 50)
            {
                this.Visible = false;
                Login login = new Login();
                login.ShowDialog();
                
            }
            else
            this.pgb_Entrada.Value += 2;
            

                     
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            this.pgb_Entrada.Maximum = 50;

        }
    }
}
