namespace estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSrc = new System.Windows.Forms.Label();
            this.btnSrc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCamisetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueCamisetasDataSet = new estoque.estoqueCamisetasDataSet();
            this.tblCamisetaTableAdapter = new estoque.estoqueCamisetasDataSetTableAdapters.tblCamisetaTableAdapter();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.btnFoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblData = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamisetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueCamisetasDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(6, 18);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(86, 13);
            this.lblSrc.TabIndex = 6;
            this.lblSrc.Text = "Consultar por ID";
            // 
            // btnSrc
            // 
            this.btnSrc.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSrc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSrc.FlatAppearance.BorderSize = 0;
            this.btnSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrc.ForeColor = System.Drawing.Color.White;
            this.btnSrc.Image = ((System.Drawing.Image)(resources.GetObject("btnSrc.Image")));
            this.btnSrc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSrc.Location = new System.Drawing.Point(204, 14);
            this.btnSrc.Name = "btnSrc";
            this.btnSrc.Size = new System.Drawing.Size(75, 21);
            this.btnSrc.TabIndex = 7;
            this.btnSrc.Text = "Buscar";
            this.btnSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSrc.UseVisualStyleBackColor = false;
            this.btnSrc.Click += new System.EventHandler(this.btnSrc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSrc);
            this.groupBox2.Controls.Add(this.lblSrc);
            this.groupBox2.Controls.Add(this.btnSrc);
            this.groupBox2.Location = new System.Drawing.Point(7, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 41);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(108, 14);
            this.txtSrc.MaxLength = 4;
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(80, 21);
            this.txtSrc.TabIndex = 15;
            this.txtSrc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSrc_KeyPress_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnAlt);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Location = new System.Drawing.Point(7, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(5, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 0;
            this.button2.Text = "Adicionar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.Chocolate;
            this.btnAlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlt.ForeColor = System.Drawing.Color.White;
            this.btnAlt.Image = ((System.Drawing.Image)(resources.GetObject("btnAlt.Image")));
            this.btnAlt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlt.Location = new System.Drawing.Point(86, 10);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(75, 50);
            this.btnAlt.TabIndex = 0;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkRed;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDel.Location = new System.Drawing.Point(167, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 50);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Excluir";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.imgDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.tblCamisetaBindingSource;
            this.dgvData.Location = new System.Drawing.Point(7, 110);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(781, 269);
            this.dgvData.TabIndex = 10;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            this.corDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.corDataGridViewTextBoxColumn.Width = 75;
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tamanhoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tamanhoDataGridViewTextBoxColumn.Width = 60;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriaDataGridViewTextBoxColumn.Width = 65;
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.generoDataGridViewTextBoxColumn.Width = 75;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preço";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precoDataGridViewTextBoxColumn.Width = 45;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantidadeDataGridViewTextBoxColumn.Width = 70;
            // 
            // imgDataGridViewTextBoxColumn
            // 
            this.imgDataGridViewTextBoxColumn.DataPropertyName = "img";
            this.imgDataGridViewTextBoxColumn.HeaderText = "Imagem";
            this.imgDataGridViewTextBoxColumn.Name = "imgDataGridViewTextBoxColumn";
            this.imgDataGridViewTextBoxColumn.ReadOnly = true;
            this.imgDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblCamisetaBindingSource
            // 
            this.tblCamisetaBindingSource.DataMember = "tblCamiseta";
            this.tblCamisetaBindingSource.DataSource = this.estoqueCamisetasDataSet;
            // 
            // estoqueCamisetasDataSet
            // 
            this.estoqueCamisetasDataSet.DataSetName = "estoqueCamisetasDataSet";
            this.estoqueCamisetasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCamisetaTableAdapter
            // 
            this.tblCamisetaTableAdapter.ClearBeforeFill = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(735, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(53, 25);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRecarregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecarregar.FlatAppearance.BorderSize = 0;
            this.btnRecarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecarregar.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnRecarregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecarregar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecarregar.Image")));
            this.btnRecarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecarregar.Location = new System.Drawing.Point(696, 80);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(92, 21);
            this.btnRecarregar.TabIndex = 11;
            this.btnRecarregar.Text = "Recarregar";
            this.btnRecarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecarregar.UseVisualStyleBackColor = false;
            this.btnRecarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFoto
            // 
            this.btnFoto.BackColor = System.Drawing.Color.Purple;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnFoto.Image")));
            this.btnFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoto.Location = new System.Drawing.Point(608, 80);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(78, 21);
            this.btnFoto.TabIndex = 12;
            this.btnFoto.Text = "Ver Foto";
            this.btnFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaida);
            this.groupBox1.Controls.Add(this.btnEntrada);
            this.groupBox1.Location = new System.Drawing.Point(255, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnSaida
            // 
            this.btnSaida.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnSaida.Image")));
            this.btnSaida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaida.Location = new System.Drawing.Point(85, 10);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(75, 50);
            this.btnSaida.TabIndex = 0;
            this.btnSaida.Text = "Saída";
            this.btnSaida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSaida.UseVisualStyleBackColor = false;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Image")));
            this.btnEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEntrada.Location = new System.Drawing.Point(4, 10);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(75, 50);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(693, 382);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(29, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.ControlBox = false;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFoto);
            this.Controls.Add(this.btnRecarregar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCamisetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueCamisetasDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Button btnSrc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvData;
        private estoqueCamisetasDataSet estoqueCamisetasDataSet;
        private System.Windows.Forms.BindingSource tblCamisetaBindingSource;
        private estoqueCamisetasDataSetTableAdapters.tblCamisetaTableAdapter tblCamisetaTableAdapter;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imgDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtSrc;
    }
}

