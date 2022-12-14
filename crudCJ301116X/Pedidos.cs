using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    lv.SubItems.Add(car.Preco.ToString());
                    lv.SubItems.Add(car.Imagem);
                    ltvPedidoPizza.Items.Add(lv);
                }
            }
        }

        private void AtualizarListViewFinal()
        {
            ltvPedidoFinal.Items.Clear();
            DAO Dao = new DAO();

            List<PedidoFinal> pedidofinal = Dao.ListarTodosPedidosFinais();

            if (pedidofinal.Count > 0)
            {
                foreach (var pf in pedidofinal)
                {
                    ListViewItem lv = new ListViewItem(pf.Id.ToString());
                    lv.SubItems.Add(pf.Quantidade.ToString());
                    lv.SubItems.Add(pf.ValorFinal.ToString());
                    lv.SubItems.Add(pf.MetodoPag);
                    lv.SubItems.Add(pf.Troco.ToString());
                    lv.SubItems.Add(pf.Date.ToString());
                    ltvPedidoFinal.Items.Add(lv);
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
                    lv.SubItems.Add(ped.Valor.ToString());
                    lv.SubItems.Add(ped.Quantidade.ToString());
                    lv.SubItems.Add(ped.Sabor);
                    lv.SubItems.Add(ped.Date.ToString());

                    ltvPedido.Items.Add(lv);
                }
            }
        }

        private void LimparCampos()
        {
            txbID.Clear();
            txbValorUnit.Clear();
            txbQuant.Clear();
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
                AtualizarListViewFinal();
                AtualizarCardapio();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "OCORREU UM ERRO AO CARREGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                decimal valor = ValorUnit(decimal.Parse(txbValorUnit.Text));

                pedidoLido = new Pedido(valor, int.Parse(txbQuant.Text), int.Parse(txbIdPizza.Text), DateTime.Parse(dtpPedido.Text));
                DAO Dao = new DAO();
                Dao.InserirNovoPedido(pedidoLido);


                MessageBox.Show("Pedido inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarListView();
            LimparCampos();

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {


        }

        private decimal ValorUnit(decimal total = 0m)
        {

            int quant = int.Parse(txbQuant.Text);

            decimal preco = decimal.Parse(txbValorUnit.Text);

            total += ((quant - 1) * preco);


            return total;
        }

        private void ValorTotal()
        {
            decimal total = 0m;
            for (int i = 0; i < ltvPedido.Items.Count; i++)

            {
                total += decimal.Parse(ltvPedido.Items[i].SubItems[1].Text); ;
            }
            txbTotalaPagar.Text = total.ToString("N");

        }
        private void QuantItens()
        {
            decimal total = 0;
            for (int i = 0; i < ltvPedido.Items.Count; i++)

            {
                total += int.Parse(ltvPedido.Items[i].SubItems[2].Text); ;
            }
            txbQuantFinal.Text = total.ToString();

        }

        private void CriarTroco()
        {

            if (txbTotalPago.Text == string.Empty)
            {
                MessageBox.Show("Tente novamente! Não há entrada de caixa.");
                txbTroco.Clear();
                return;
            }

            else
            {
                decimal total = 0m;
                decimal pago = decimal.Parse(txbTotalaPagar.Text);

                decimal pagar = decimal.Parse(txbTotalPago.Text);

                total += (pagar - pago);

                txbTroco.Text = total.ToString("N");
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

                    decimal valor = ValorUnit(decimal.Parse(txbValorUnit.Text));

                    pedidoEditado = new Pedido(Id, valor, int.Parse(txbQuant.Text), int.Parse(txbIdPizza.Text), DateTime.Parse(dtpPedido.Text));
                    DAO Dao = new DAO();

                    MessageBox.Show("Pizza editado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

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


        private void btnRetornarPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ltvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPedido.FocusedItem.Index;
                Id = int.Parse(ltvPedido.Items[index].SubItems[0].Text);
                txbID.Text = ltvPedido.Items[index].SubItems[0].Text;
                txbIdPedido.Text = ltvPedido.Items[index].SubItems[0].Text;
                txbQuant.Text = ltvPedido.Items[index].SubItems[2].Text;

                ValorTotal();
                QuantItens();



            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void ltvPedidoPizza_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ltvPedidoPizza_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void ltvPedidoPizza_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPedidoPizza.FocusedItem.Index;
                Id = int.Parse(ltvPedidoPizza.Items[index].SubItems[0].Text);
                txbIdPizza.Text = ltvPedidoPizza.Items[index].SubItems[0].Text;
                txbValorUnit.Text = ltvPedidoPizza.Items[index].SubItems[4].Text;
                ptbPizza.ImageLocation = ltvPedidoPizza.Items[index].SubItems[5].Text;

            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
            pnlCardapio.Visible = false;
        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            pnlFinalizar.Visible = true;
        }

        private void btnRetornarFinal_Click(object sender, EventArgs e)
        {
            pnlFinalizar.Visible = false;
        }

        private void txbTotalPago_TextChanged(object sender, EventArgs e)
        {
            CriarTroco();
        }



        private void btnInserirFim_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoFinal pedidofinalLido;


                if (rdbPix.Checked)
                {
                    pedidofinalLido = new PedidoFinal(int.Parse(txbQuantFinal.Text), decimal.Parse(txbTotalaPagar.Text), "PIX", decimal.Parse(txbTroco.Text), int.Parse(txbIdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFinal(pedidofinalLido);
                }
                if (rdbCartao.Checked)
                {
                    pedidofinalLido = new PedidoFinal(int.Parse(txbQuantFinal.Text), decimal.Parse(txbTotalaPagar.Text), "CARTAO", decimal.Parse(txbTroco.Text), int.Parse(txbIdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFinal(pedidofinalLido);
                }
                if (rdbDinheiro.Checked)
                {
                    pedidofinalLido = new PedidoFinal(int.Parse(txbQuantFinal.Text), decimal.Parse(txbTotalaPagar.Text), "DINHEIRO", decimal.Parse(txbTroco.Text), int.Parse(txbIdPedido.Text));
                    DAO Dao = new DAO();
                    Dao.InserirFinal(pedidofinalLido);
                }

                MessageBox.Show("Pedido inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO AO INSERIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarListViewFinal();
            LimparCampos();
        }

        private void txbQuantTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbPizza_Click(object sender, EventArgs e)
        {

        }

        private void txbQuantFinal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnExcluirFim_Click(object sender, EventArgs e)
        {
            DAO Dao = new DAO();

            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir o pedido final?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Pedido final excluído com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dao.ExcluirFim(Id);
                }
                catch (Exception)
                {
                    throw new Exception("ERRO AO EXCLUIR");
                }
            }

            AtualizarListViewFinal();
            LimparCampos();
        }

        private void ltvPedidoFinal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvPedidoFinal.FocusedItem.Index;
                Id = int.Parse(ltvPedidoFinal.Items[index].SubItems[0].Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "Erro");
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string nomeArquivo = @"C:\Users\Dan\Desktop\PIZZA_NET_FINAL\crudCJ301116X\RelatórioPedidos\Pedidos.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\Dan\Desktop\PIZZA_NET_FINAL\crudCJ301116X\Imagensprojeto\LOGOS\LogoIfspCJO.png");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_RIGHT;

            iTextSharp.text.Image logo2 = iTextSharp.text.Image.GetInstance(@"C:\Users\Dan\Desktop\PIZZA_NET_FINAL\crudCJ301116X\Imagensprojeto\LOGOS\LogoPIZZA.png");
            logo2.ScaleToFit(140f, 120f);
            logo2.Alignment = Element.ALIGN_LEFT;


            string dados = "";

            Paragraph paragrafo = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("PIZZA NET - CJ301116X\n\n");

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));

            paragrafo2.Alignment = Element.ALIGN_CENTER;
            paragrafo2.Add("\nRELATÓRIO DE PEDIDOS PIZZA NET\n");

            PdfPTable tabela1 = new PdfPTable(6);
            tabela1.DefaultCell.FixedHeight = 20;

            PdfPCell celula1 = new PdfPCell(new Phrase("TABELA FINAL DE PEDIDOS"));
            celula1.Colspan = 6;

            tabela1.AddCell(celula1);

            celula1.FixedHeight = 40;
            celula1.HorizontalAlignment = Element.ALIGN_CENTER;
            celula1.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela1.AddCell(celula1);



            tabela1.AddCell("Id");
            tabela1.AddCell("Quantidade");
            tabela1.AddCell("Valor");
            tabela1.AddCell("Método de pag.");
            tabela1.AddCell("Troco");
            tabela1.AddCell("Data");


            for (int i = 0; i < ltvPedidoFinal.Items.Count; i++)
            {
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[0].Text);
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[1].Text);
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[2].Text);
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[3].Text);
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[4].Text);
                tabela1.AddCell(ltvPedidoFinal.Items[i].SubItems[5].Text);

            }

            PdfPCell celula2 = new PdfPCell(new Phrase("TABELA DE PEDIDOS"));
            celula2.Colspan = 5;


            PdfPTable tabela2 = new PdfPTable(5);
            tabela2.DefaultCell.FixedHeight = 20;

            tabela2.AddCell(celula2);

            celula2.FixedHeight = 40;
            celula2.HorizontalAlignment = Element.ALIGN_CENTER;
            celula2.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela2.AddCell(celula2);


            tabela2.AddCell("Id");
            tabela2.AddCell("Valor");
            tabela2.AddCell("Quantidade");
            tabela2.AddCell("Sabor");
            tabela2.AddCell("Date");

            for (int i = 0; i < ltvPedido.Items.Count; i++)
            {
                tabela2.AddCell(ltvPedido.Items[i].SubItems[0].Text);
                tabela2.AddCell(ltvPedido.Items[i].SubItems[1].Text);
                tabela2.AddCell(ltvPedido.Items[i].SubItems[2].Text);
                tabela2.AddCell(ltvPedido.Items[i].SubItems[3].Text);
                tabela2.AddCell(ltvPedido.Items[i].SubItems[4].Text);

            }

            PdfPCell celula3 = new PdfPCell(new Phrase("TABELA DE PIZZAS"));
            celula3.Colspan = 5;


            PdfPTable tabela3 = new PdfPTable(5);
            tabela3.DefaultCell.FixedHeight = 20;

            tabela3.AddCell(celula3);

            celula3.FixedHeight = 40;
            celula3.HorizontalAlignment = Element.ALIGN_CENTER;
            celula3.VerticalAlignment = Element.ALIGN_MIDDLE;
            tabela3.AddCell(celula3);


            tabela3.AddCell("Id");
            tabela3.AddCell("Sabor");
            tabela3.AddCell("Tamanho");
            tabela3.AddCell("Número fatias");
            tabela3.AddCell("Preço");

            for (int i = 0; i < ltvPedidoPizza.Items.Count; i++)
            {
                tabela3.AddCell(ltvPedidoPizza.Items[i].SubItems[0].Text);
                tabela3.AddCell(ltvPedidoPizza.Items[i].SubItems[1].Text);
                tabela3.AddCell(ltvPedidoPizza.Items[i].SubItems[2].Text);
                tabela3.AddCell(ltvPedidoPizza.Items[i].SubItems[3].Text);
                tabela3.AddCell(ltvPedidoPizza.Items[i].SubItems[4].Text);

            }



            doc.Open();
            doc.Add(logo);
            doc.Add(logo2);
            doc.Add(paragrafo);
            doc.Add(tabela1);
            doc.Add(tabela2);
            doc.Add(tabela3);
            doc.Add(paragrafo2);
            doc.Close();


            DialogResult resultado = MessageBox.Show("Deseja abrir o relatório de pedidos?", "Relatório", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
                System.Diagnostics.Process.Start(@"C:\Users\Dan\Desktop\PIZZA_NET_FINAL\crudCJ301116X\RelatórioPedidos\Pedidos.pdf");

        }
    }
}
