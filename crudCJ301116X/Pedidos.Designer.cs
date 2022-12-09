namespace crudCJ301116X
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCardapio = new System.Windows.Forms.Button();
            this.pnlCardapio = new System.Windows.Forms.Panel();
            this.ltvPedidoPizza = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.clhIdPizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNFatia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRetornar = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPizzanet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbQuant = new System.Windows.Forms.MaskedTextBox();
            this.mtbValorTotal = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.ltvPedido = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQuant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbIdPizza = new System.Windows.Forms.TextBox();
            this.pnlCardapio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpPedido
            // 
            this.dtpPedido.AllowDrop = true;
            this.dtpPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPedido.Location = new System.Drawing.Point(153, 185);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(312, 26);
            this.dtpPedido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data do pedido:";
            // 
            // btnCardapio
            // 
            this.btnCardapio.Location = new System.Drawing.Point(729, 56);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.Size = new System.Drawing.Size(135, 60);
            this.btnCardapio.TabIndex = 5;
            this.btnCardapio.Text = "EXIBIR CARDÁPIO ";
            this.btnCardapio.UseVisualStyleBackColor = true;
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click);
            // 
            // pnlCardapio
            // 
            this.pnlCardapio.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCardapio.Controls.Add(this.ltvPedidoPizza);
            this.pnlCardapio.Controls.Add(this.btnRetornar);
            this.pnlCardapio.Controls.Add(this.label2);
            this.pnlCardapio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCardapio.Location = new System.Drawing.Point(0, 0);
            this.pnlCardapio.Name = "pnlCardapio";
            this.pnlCardapio.Size = new System.Drawing.Size(876, 487);
            this.pnlCardapio.TabIndex = 6;
            this.pnlCardapio.Visible = false;
            this.pnlCardapio.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCardapio_Paint);
            // 
            // ltvPedidoPizza
            // 
            this.ltvPedidoPizza.BackColor = System.Drawing.Color.Gray;
            this.ltvPedidoPizza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhIdPizza,
            this.clhSabor,
            this.clhTamanho,
            this.clhNFatia,
            this.clhPreco});
            this.ltvPedidoPizza.FullRowSelect = true;
            this.ltvPedidoPizza.HideSelection = false;
            this.ltvPedidoPizza.Location = new System.Drawing.Point(12, 194);
            this.ltvPedidoPizza.Name = "ltvPedidoPizza";
            this.ltvPedidoPizza.Size = new System.Drawing.Size(852, 281);
            this.ltvPedidoPizza.TabIndex = 0;
            this.ltvPedidoPizza.UseCompatibleStateImageBehavior = false;
            this.ltvPedidoPizza.View = System.Windows.Forms.View.Details;
            this.ltvPedidoPizza.SelectedIndexChanged += new System.EventHandler(this.ltvPedidoPizza_SelectedIndexChanged);
            this.ltvPedidoPizza.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvPedidoPizza_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONSULTE O CARDÁPIO";
            // 
            // clhIdPizza
            // 
            this.clhIdPizza.Text = "Id da Pizza";
            this.clhIdPizza.Width = 100;
            // 
            // clhSabor
            // 
            this.clhSabor.Text = "Sabor";
            this.clhSabor.Width = 117;
            // 
            // clhTamanho
            // 
            this.clhTamanho.Text = "Tamanho";
            this.clhTamanho.Width = 142;
            // 
            // clhNFatia
            // 
            this.clhNFatia.Text = "Número de fatias";
            this.clhNFatia.Width = 157;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço";
            this.clhPreco.Width = 279;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackgroundImage = global::crudCJ301116X.Properties.Resources.Retornar2;
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetornar.Location = new System.Drawing.Point(774, 43);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(90, 105);
            this.btnRetornar.TabIndex = 61;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(153, 73);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(44, 24);
            this.txbID.TabIndex = 65;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(28, 75);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 20);
            this.lblID.TabIndex = 64;
            this.lblID.Text = "ID selecionado:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(302, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 25);
            this.lblTitulo.TabIndex = 67;
            this.lblTitulo.Text = "REGISTRE O PEDIDO!";
            // 
            // lblPizzanet
            // 
            this.lblPizzanet.AutoSize = true;
            this.lblPizzanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzanet.Location = new System.Drawing.Point(360, 9);
            this.lblPizzanet.Name = "lblPizzanet";
            this.lblPizzanet.Size = new System.Drawing.Size(119, 25);
            this.lblPizzanet.TabIndex = 66;
            this.lblPizzanet.Text = "PIZZA NET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Quantidade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Valor total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(501, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Código da pizza: ";
            // 
            // mtbQuant
            // 
            this.mtbQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbQuant.Location = new System.Drawing.Point(637, 131);
            this.mtbQuant.Mask = "00";
            this.mtbQuant.Name = "mtbQuant";
            this.mtbQuant.Size = new System.Drawing.Size(24, 26);
            this.mtbQuant.TabIndex = 71;
            // 
            // mtbValorTotal
            // 
            this.mtbValorTotal.BackColor = System.Drawing.Color.White;
            this.mtbValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbValorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtbValorTotal.Location = new System.Drawing.Point(153, 134);
            this.mtbValorTotal.Mask = "$ 00.00";
            this.mtbValorTotal.Name = "mtbValorTotal";
            this.mtbValorTotal.Size = new System.Drawing.Size(75, 19);
            this.mtbValorTotal.TabIndex = 72;
            this.mtbValorTotal.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::crudCJ301116X.Properties.Resources.Retornar2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(747, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 109);
            this.button1.TabIndex = 78;
            this.button1.Text = "Retornar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::crudCJ301116X.Properties.Resources.limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(409, 221);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 109);
            this.btnLimpar.TabIndex = 76;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::crudCJ301116X.Properties.Resources.excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(505, 221);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 109);
            this.btnExcluir.TabIndex = 77;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::crudCJ301116X.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(313, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 109);
            this.btnEditar.TabIndex = 75;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::crudCJ301116X.Properties.Resources.inserir;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(217, 221);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 109);
            this.btnInserir.TabIndex = 74;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ltvPedido
            // 
            this.ltvPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhValor,
            this.clhQuant,
            this.clhData});
            this.ltvPedido.FullRowSelect = true;
            this.ltvPedido.HideSelection = false;
            this.ltvPedido.Location = new System.Drawing.Point(200, 340);
            this.ltvPedido.Name = "ltvPedido";
            this.ltvPedido.Size = new System.Drawing.Size(434, 135);
            this.ltvPedido.TabIndex = 79;
            this.ltvPedido.UseCompatibleStateImageBehavior = false;
            this.ltvPedido.View = System.Windows.Forms.View.Details;
            this.ltvPedido.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvPedido_MouseDoubleClick);
            // 
            // clhId
            // 
            this.clhId.Text = "Id";
            this.clhId.Width = 41;
            // 
            // clhValor
            // 
            this.clhValor.Text = "Valor";
            this.clhValor.Width = 75;
            // 
            // clhQuant
            // 
            this.clhQuant.Text = "Quantidade";
            this.clhQuant.Width = 103;
            // 
            // clhData
            // 
            this.clhData.Text = "Data do pedido";
            this.clhData.Width = 180;
            // 
            // txbIdPizza
            // 
            this.txbIdPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdPizza.Location = new System.Drawing.Point(637, 185);
            this.txbIdPizza.Name = "txbIdPizza";
            this.txbIdPizza.Size = new System.Drawing.Size(24, 26);
            this.txbIdPizza.TabIndex = 80;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 487);
            this.Controls.Add(this.pnlCardapio);
            this.Controls.Add(this.txbIdPizza);
            this.Controls.Add(this.ltvPedido);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.mtbValorTotal);
            this.Controls.Add(this.mtbQuant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPizzanet);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCardapio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPedido);
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.pnlCardapio.ResumeLayout(false);
            this.pnlCardapio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCardapio;
        private System.Windows.Forms.Panel pnlCardapio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ltvPedidoPizza;
        private System.Windows.Forms.ColumnHeader clhIdPizza;
        private System.Windows.Forms.ColumnHeader clhSabor;
        private System.Windows.Forms.ColumnHeader clhTamanho;
        private System.Windows.Forms.ColumnHeader clhNFatia;
        private System.Windows.Forms.ColumnHeader clhPreco;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPizzanet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbQuant;
        private System.Windows.Forms.MaskedTextBox mtbValorTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListView ltvPedido;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhValor;
        private System.Windows.Forms.ColumnHeader clhQuant;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.TextBox txbIdPizza;
    }
}