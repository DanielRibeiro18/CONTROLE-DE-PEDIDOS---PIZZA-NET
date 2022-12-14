namespace crudCJ301116X
{
    partial class CrudPizza
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPizzanet = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txbSabor = new System.Windows.Forms.TextBox();
            this.lblNFatia = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblSabor = new System.Windows.Forms.Label();
            this.ltvPizza = new System.Windows.Forms.ListView();
            this.clhId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhSabor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTamanho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNFatia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDisponibilidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhImagem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chbDisponibilidade = new System.Windows.Forms.CheckBox();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.cmbNFatia = new System.Windows.Forms.ComboBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.ptbPizza = new System.Windows.Forms.PictureBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txbCaminhoImagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPrecoUnit = new crudCJ301116X.txbValor();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(18, 9);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(165, 13);
            this.lblMatricula.TabIndex = 66;
            this.lblMatricula.Text = "Daniel Ribeiro Abdo - CJ301116X";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(400, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 25);
            this.lblTitulo.TabIndex = 65;
            this.lblTitulo.Text = "CADASTRE SUA PIZZA!";
            // 
            // lblPizzanet
            // 
            this.lblPizzanet.AutoSize = true;
            this.lblPizzanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzanet.Location = new System.Drawing.Point(458, 9);
            this.lblPizzanet.Name = "lblPizzanet";
            this.lblPizzanet.Size = new System.Drawing.Size(119, 25);
            this.lblPizzanet.TabIndex = 64;
            this.lblPizzanet.Text = "PIZZA NET";
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(998, 65);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(44, 24);
            this.txbID.TabIndex = 63;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(873, 67);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 20);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "ID selecionado:";
            // 
            // txbSabor
            // 
            this.txbSabor.BackColor = System.Drawing.SystemColors.Window;
            this.txbSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSabor.Location = new System.Drawing.Point(183, 96);
            this.txbSabor.Name = "txbSabor";
            this.txbSabor.Size = new System.Drawing.Size(345, 24);
            this.txbSabor.TabIndex = 39;
            // 
            // lblNFatia
            // 
            this.lblNFatia.AutoSize = true;
            this.lblNFatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFatia.Location = new System.Drawing.Point(592, 99);
            this.lblNFatia.Name = "lblNFatia";
            this.lblNFatia.Size = new System.Drawing.Size(134, 20);
            this.lblNFatia.TabIndex = 47;
            this.lblNFatia.Text = "Número de fatias:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(592, 131);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(89, 20);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço (R$):";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(66, 126);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(80, 20);
            this.lblTamanho.TabIndex = 44;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(66, 95);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(56, 20);
            this.lblSabor.TabIndex = 40;
            this.lblSabor.Text = "Sabor:";
            // 
            // ltvPizza
            // 
            this.ltvPizza.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhId,
            this.clhSabor,
            this.clhTamanho,
            this.clhNFatia,
            this.clhPreco,
            this.clhDisponibilidade,
            this.clhImagem});
            this.ltvPizza.FullRowSelect = true;
            this.ltvPizza.HideSelection = false;
            this.ltvPizza.Location = new System.Drawing.Point(187, 398);
            this.ltvPizza.Name = "ltvPizza";
            this.ltvPizza.Size = new System.Drawing.Size(701, 161);
            this.ltvPizza.TabIndex = 67;
            this.ltvPizza.UseCompatibleStateImageBehavior = false;
            this.ltvPizza.View = System.Windows.Forms.View.Details;
            this.ltvPizza.SelectedIndexChanged += new System.EventHandler(this.ltvPizza_SelectedIndexChanged);
            this.ltvPizza.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvPizza_MouseDoubleClick);
            // 
            // clhId
            // 
            this.clhId.Text = "Id";
            this.clhId.Width = 49;
            // 
            // clhSabor
            // 
            this.clhSabor.Text = "Sabor";
            this.clhSabor.Width = 82;
            // 
            // clhTamanho
            // 
            this.clhTamanho.Text = "Tamanho";
            this.clhTamanho.Width = 119;
            // 
            // clhNFatia
            // 
            this.clhNFatia.Text = "Número Fatias";
            this.clhNFatia.Width = 120;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço";
            this.clhPreco.Width = 119;
            // 
            // clhDisponibilidade
            // 
            this.clhDisponibilidade.Text = "Disponibilidade";
            this.clhDisponibilidade.Width = 122;
            // 
            // clhImagem
            // 
            this.clhImagem.Text = "Imagem";
            this.clhImagem.Width = 85;
            // 
            // chbDisponibilidade
            // 
            this.chbDisponibilidade.AutoSize = true;
            this.chbDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDisponibilidade.Location = new System.Drawing.Point(70, 170);
            this.chbDisponibilidade.Name = "chbDisponibilidade";
            this.chbDisponibilidade.Size = new System.Drawing.Size(143, 24);
            this.chbDisponibilidade.TabIndex = 68;
            this.chbDisponibilidade.Text = "Está disponível?";
            this.chbDisponibilidade.UseVisualStyleBackColor = true;
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Items.AddRange(new object[] {
            "BROTINHO",
            "MÉDIA",
            "GRANDE"});
            this.cmbTamanho.Location = new System.Drawing.Point(183, 123);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(156, 28);
            this.cmbTamanho.TabIndex = 73;
            // 
            // cmbNFatia
            // 
            this.cmbNFatia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNFatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNFatia.FormattingEnabled = true;
            this.cmbNFatia.Items.AddRange(new object[] {
            "6",
            "8",
            "10"});
            this.cmbNFatia.Location = new System.Drawing.Point(767, 92);
            this.cmbNFatia.Name = "cmbNFatia";
            this.cmbNFatia.Size = new System.Drawing.Size(100, 28);
            this.cmbNFatia.TabIndex = 74;
            // 
            // btnRetornar
            // 
            this.btnRetornar.BackgroundImage = global::crudCJ301116X.Properties.Resources.Retornar2;
            this.btnRetornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRetornar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetornar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetornar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRetornar.Location = new System.Drawing.Point(998, 270);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(90, 109);
            this.btnRetornar.TabIndex = 60;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::crudCJ301116X.Properties.Resources.limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Location = new System.Drawing.Point(460, 270);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 109);
            this.btnLimpar.TabIndex = 58;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::crudCJ301116X.Properties.Resources.excluir;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(556, 270);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 109);
            this.btnExcluir.TabIndex = 59;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::crudCJ301116X.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(364, 270);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 109);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackgroundImage = global::crudCJ301116X.Properties.Resources.inserir;
            this.btnInserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInserir.Location = new System.Drawing.Point(268, 270);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 109);
            this.btnInserir.TabIndex = 55;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // ptbPizza
            // 
            this.ptbPizza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbPizza.Location = new System.Drawing.Point(767, 170);
            this.ptbPizza.Name = "ptbPizza";
            this.ptbPizza.Size = new System.Drawing.Size(100, 94);
            this.ptbPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPizza.TabIndex = 76;
            this.ptbPizza.TabStop = false;
            this.ptbPizza.Click += new System.EventHandler(this.ptbPizza_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackgroundImage = global::crudCJ301116X.Properties.Resources.procurar3;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcurar.Location = new System.Drawing.Point(652, 270);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(95, 109);
            this.btnProcurar.TabIndex = 77;
            this.btnProcurar.Text = "Procurar imagem";
            this.btnProcurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txbCaminhoImagem
            // 
            this.txbCaminhoImagem.BackColor = System.Drawing.SystemColors.Window;
            this.txbCaminhoImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCaminhoImagem.Location = new System.Drawing.Point(596, 193);
            this.txbCaminhoImagem.Multiline = true;
            this.txbCaminhoImagem.Name = "txbCaminhoImagem";
            this.txbCaminhoImagem.ReadOnly = true;
            this.txbCaminhoImagem.Size = new System.Drawing.Size(151, 71);
            this.txbCaminhoImagem.TabIndex = 78;
            this.txbCaminhoImagem.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(592, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "Imagem:";
            // 
            // txbPrecoUnit
            // 
            this.txbPrecoUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoUnit.Location = new System.Drawing.Point(767, 131);
            this.txbPrecoUnit.Name = "txbPrecoUnit";
            this.txbPrecoUnit.Size = new System.Drawing.Size(100, 26);
            this.txbPrecoUnit.TabIndex = 79;
            this.txbPrecoUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CrudPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrecoUnit);
            this.Controls.Add(this.txbCaminhoImagem);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.ptbPizza);
            this.Controls.Add(this.cmbNFatia);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.chbDisponibilidade);
            this.Controls.Add(this.ltvPizza);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPizzanet);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txbSabor);
            this.Controls.Add(this.lblNFatia);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblSabor);
            this.Name = "CrudPizza";
            this.Text = "CrudPizza";
            this.Load += new System.EventHandler(this.CrudPizza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPizzanet;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txbSabor;
        private System.Windows.Forms.Label lblNFatia;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.ListView ltvPizza;
        private System.Windows.Forms.ColumnHeader clhId;
        private System.Windows.Forms.ColumnHeader clhSabor;
        private System.Windows.Forms.ColumnHeader clhTamanho;
        private System.Windows.Forms.ColumnHeader clhNFatia;
        private System.Windows.Forms.ColumnHeader clhPreco;
        private System.Windows.Forms.ColumnHeader clhDisponibilidade;
        private System.Windows.Forms.CheckBox chbDisponibilidade;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.ComboBox cmbNFatia;
        private System.Windows.Forms.PictureBox ptbPizza;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txbCaminhoImagem;
        private System.Windows.Forms.ColumnHeader clhImagem;
        private txbValor txbPrecoUnit;
        private System.Windows.Forms.Label label1;
    }
}