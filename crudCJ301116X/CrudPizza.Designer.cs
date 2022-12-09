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
            this.chbDisponibilidade = new System.Windows.Forms.CheckBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.cmbNFatia = new System.Windows.Forms.ComboBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
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
            this.txbID.Location = new System.Drawing.Point(998, 75);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(44, 24);
            this.txbID.TabIndex = 63;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(873, 77);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 20);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "ID selecionado:";
            // 
            // txbSabor
            // 
            this.txbSabor.BackColor = System.Drawing.SystemColors.Window;
            this.txbSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSabor.Location = new System.Drawing.Point(218, 113);
            this.txbSabor.Name = "txbSabor";
            this.txbSabor.Size = new System.Drawing.Size(345, 24);
            this.txbSabor.TabIndex = 39;
            // 
            // lblNFatia
            // 
            this.lblNFatia.AutoSize = true;
            this.lblNFatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFatia.Location = new System.Drawing.Point(586, 115);
            this.lblNFatia.Name = "lblNFatia";
            this.lblNFatia.Size = new System.Drawing.Size(134, 20);
            this.lblNFatia.TabIndex = 47;
            this.lblNFatia.Text = "Numero de fatias:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(644, 162);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(54, 20);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço:";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanho.Location = new System.Drawing.Point(130, 157);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(80, 20);
            this.lblTamanho.TabIndex = 44;
            this.lblTamanho.Text = "Tamanho:";
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabor.Location = new System.Drawing.Point(157, 115);
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
            this.clhDisponibilidade});
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
            this.clhId.Width = 101;
            // 
            // clhSabor
            // 
            this.clhSabor.Text = "Sabor";
            this.clhSabor.Width = 111;
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
            // chbDisponibilidade
            // 
            this.chbDisponibilidade.AutoSize = true;
            this.chbDisponibilidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDisponibilidade.Location = new System.Drawing.Point(134, 202);
            this.chbDisponibilidade.Name = "chbDisponibilidade";
            this.chbDisponibilidade.Size = new System.Drawing.Size(143, 24);
            this.chbDisponibilidade.TabIndex = 68;
            this.chbDisponibilidade.Text = "Está disponível?";
            this.chbDisponibilidade.UseVisualStyleBackColor = true;
            // 
            // mtbPreco
            // 
            this.mtbPreco.BackColor = System.Drawing.Color.Silver;
            this.mtbPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPreco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mtbPreco.Location = new System.Drawing.Point(704, 163);
            this.mtbPreco.Mask = "$ 00.00";
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(100, 19);
            this.mtbPreco.TabIndex = 70;
            this.mtbPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Items.AddRange(new object[] {
            "MEDIA",
            "GRANDE",
            "FAMILIA"});
            this.cmbTamanho.Location = new System.Drawing.Point(218, 154);
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
            this.cmbNFatia.Location = new System.Drawing.Point(726, 107);
            this.cmbNFatia.Name = "cmbNFatia";
            this.cmbNFatia.Size = new System.Drawing.Size(78, 28);
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
            this.btnLimpar.Location = new System.Drawing.Point(521, 270);
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
            this.btnExcluir.Location = new System.Drawing.Point(617, 270);
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
            this.btnEditar.Location = new System.Drawing.Point(425, 270);
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
            this.btnInserir.Location = new System.Drawing.Point(329, 270);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(90, 109);
            this.btnInserir.TabIndex = 55;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // CrudPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 571);
            this.Controls.Add(this.cmbNFatia);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.mtbPreco);
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
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.ComboBox cmbNFatia;
    }
}