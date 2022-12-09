namespace crudCJ301116X
{
    partial class TelaMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pEDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOPEDIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOVOUSUÁRIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIZZAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pEDIDOSToolStripMenuItem,
            this.cADASTROToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pEDIDOSToolStripMenuItem
            // 
            this.pEDIDOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOPEDIDOToolStripMenuItem});
            this.pEDIDOSToolStripMenuItem.Name = "pEDIDOSToolStripMenuItem";
            this.pEDIDOSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.pEDIDOSToolStripMenuItem.Text = "PEDIDOS";
            // 
            // nOVOPEDIDOToolStripMenuItem
            // 
            this.nOVOPEDIDOToolStripMenuItem.Name = "nOVOPEDIDOToolStripMenuItem";
            this.nOVOPEDIDOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOVOPEDIDOToolStripMenuItem.Text = "NOVO PEDIDO";
            this.nOVOPEDIDOToolStripMenuItem.Click += new System.EventHandler(this.nOVOPEDIDOToolStripMenuItem_Click);
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOVOUSUÁRIOToolStripMenuItem,
            this.pIZZAToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            this.cADASTROToolStripMenuItem.Click += new System.EventHandler(this.cADASTROToolStripMenuItem_Click);
            // 
            // nOVOUSUÁRIOToolStripMenuItem
            // 
            this.nOVOUSUÁRIOToolStripMenuItem.Name = "nOVOUSUÁRIOToolStripMenuItem";
            this.nOVOUSUÁRIOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nOVOUSUÁRIOToolStripMenuItem.Text = "USUÁRIO";
            this.nOVOUSUÁRIOToolStripMenuItem.Click += new System.EventHandler(this.nOVOUSUÁRIOToolStripMenuItem_Click);
            // 
            // pIZZAToolStripMenuItem
            // 
            this.pIZZAToolStripMenuItem.Name = "pIZZAToolStripMenuItem";
            this.pIZZAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pIZZAToolStripMenuItem.Text = "PIZZA";
            this.pIZZAToolStripMenuItem.Click += new System.EventHandler(this.pIZZAToolStripMenuItem_Click);
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenu";
            this.Text = "TelaMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOPEDIDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nOVOUSUÁRIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIZZAToolStripMenuItem;
    }
}