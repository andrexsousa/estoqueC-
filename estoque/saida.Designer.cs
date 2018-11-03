namespace estoque
{
    partial class saida
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
            this.txtCodS = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblQuant = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.pctSaida = new System.Windows.Forms.PictureBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTamnho = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblEntradaSaida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaida)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodS
            // 
            this.txtCodS.Location = new System.Drawing.Point(153, 60);
            this.txtCodS.MaxLength = 4;
            this.txtCodS.Name = "txtCodS";
            this.txtCodS.Size = new System.Drawing.Size(100, 20);
            this.txtCodS.TabIndex = 0;
            this.txtCodS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodS_KeyPress);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(93, 63);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(54, 13);
            this.lblCod.TabIndex = 1;
            this.lblCod.Text = "Código ID";
            // 
            // numUpDown
            // 
            this.numUpDown.Enabled = false;
            this.numUpDown.Location = new System.Drawing.Point(290, 285);
            this.numUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(100, 20);
            this.numUpDown.TabIndex = 2;
            this.numUpDown.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(287, 269);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(109, 13);
            this.lblQuant.TabIndex = 1;
            this.lblQuant.Text = "Quantidade de Saída";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Green;
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(160, 323);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(84, 28);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(269, 58);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(31, 285);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(100, 20);
            this.txtEstoque.TabIndex = 4;
            this.txtEstoque.TextChanged += new System.EventHandler(this.txtEstoque_TextChanged);
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(28, 269);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(73, 13);
            this.lblEstoque.TabIndex = 1;
            this.lblEstoque.Text = "Estoque Atual";
            // 
            // pctSaida
            // 
            this.pctSaida.Location = new System.Drawing.Point(12, 103);
            this.pctSaida.Name = "pctSaida";
            this.pctSaida.Size = new System.Drawing.Size(114, 141);
            this.pctSaida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSaida.TabIndex = 5;
            this.pctSaida.TabStop = false;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(141, 103);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(55, 13);
            this.lblDescr.TabIndex = 7;
            this.lblDescr.Text = "Descrição";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Location = new System.Drawing.Point(144, 119);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(234, 20);
            this.txtDesc.TabIndex = 8;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(141, 154);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 7;
            this.lblCor.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.Enabled = false;
            this.txtCor.Location = new System.Drawing.Point(144, 170);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 8;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(141, 208);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(144, 224);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 8;
            // 
            // lblTamnho
            // 
            this.lblTamnho.AutoSize = true;
            this.lblTamnho.Location = new System.Drawing.Point(275, 154);
            this.lblTamnho.Name = "lblTamnho";
            this.lblTamnho.Size = new System.Drawing.Size(52, 13);
            this.lblTamnho.TabIndex = 7;
            this.lblTamnho.Text = "Tamanho";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Enabled = false;
            this.txtTamanho.Location = new System.Drawing.Point(278, 170);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 8;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(275, 208);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Location = new System.Drawing.Point(278, 224);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 8;
            // 
            // lblEntradaSaida
            // 
            this.lblEntradaSaida.AutoSize = true;
            this.lblEntradaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradaSaida.Location = new System.Drawing.Point(164, 18);
            this.lblEntradaSaida.Name = "lblEntradaSaida";
            this.lblEntradaSaida.Size = new System.Drawing.Size(72, 25);
            this.lblEntradaSaida.TabIndex = 9;
            this.lblEntradaSaida.Text = "Saída";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque Futuro";
            // 
            // txtQuantF
            // 
            this.txtQuantF.Enabled = false;
            this.txtQuantF.Location = new System.Drawing.Point(160, 285);
            this.txtQuantF.Name = "txtQuantF";
            this.txtQuantF.Size = new System.Drawing.Size(100, 20);
            this.txtQuantF.TabIndex = 4;
            // 
            // saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 363);
            this.Controls.Add(this.lblEntradaSaida);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblTamnho);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.pctSaida);
            this.Controls.Add(this.txtQuantF);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtCodS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Estoque";
            this.Load += new System.EventHandler(this.saida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSaida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodS;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.PictureBox pctSaida;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTamnho;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantF;
        public System.Windows.Forms.Label lblQuant;
        public System.Windows.Forms.Label lblEntradaSaida;
    }
}