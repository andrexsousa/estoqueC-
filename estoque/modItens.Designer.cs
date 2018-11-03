namespace estoque
{
    partial class modItens
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modItens));
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblQua = new System.Windows.Forms.Label();
            this.numQuant = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.grpTamanho = new System.Windows.Forms.GroupBox();
            this.rbP = new System.Windows.Forms.RadioButton();
            this.rbGG = new System.Windows.Forms.RadioButton();
            this.rbG = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbUni = new System.Windows.Forms.RadioButton();
            this.rbBaby = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGames = new System.Windows.Forms.RadioButton();
            this.rbHumor = new System.Windows.Forms.RadioButton();
            this.rbRock = new System.Windows.Forms.RadioButton();
            this.rbFilmes = new System.Windows.Forms.RadioButton();
            this.rbHerois = new System.Windows.Forms.RadioButton();
            this.rbAnime = new System.Windows.Forms.RadioButton();
            this.grpCor = new System.Windows.Forms.GroupBox();
            this.rbPreta = new System.Windows.Forms.RadioButton();
            this.rbCinza = new System.Windows.Forms.RadioButton();
            this.rbBranca = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFotoAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).BeginInit();
            this.grpTamanho.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviar.Location = new System.Drawing.Point(428, 259);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(70, 45);
            this.btnEnviar.TabIndex = 23;
            this.btnEnviar.Text = "Salvar";
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // pctFoto
            // 
            this.pctFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctFoto.Location = new System.Drawing.Point(91, 14);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(133, 160);
            this.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFoto.TabIndex = 89;
            this.pctFoto.TabStop = false;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.txtCod);
            this.grpItem.Controls.Add(this.txtPreco);
            this.grpItem.Controls.Add(this.txtEstoque);
            this.grpItem.Controls.Add(this.lblQua);
            this.grpItem.Controls.Add(this.numQuant);
            this.grpItem.Controls.Add(this.label6);
            this.grpItem.Controls.Add(this.label5);
            this.grpItem.Controls.Add(this.label4);
            this.grpItem.Controls.Add(this.lblPre);
            this.grpItem.Controls.Add(this.grpTamanho);
            this.grpItem.Controls.Add(this.grpTipo);
            this.grpItem.Controls.Add(this.groupBox1);
            this.grpItem.Controls.Add(this.grpCor);
            this.grpItem.Controls.Add(this.txtNome);
            this.grpItem.Controls.Add(this.label1);
            this.grpItem.Controls.Add(this.lblNome);
            this.grpItem.Controls.Add(this.lblCod);
            this.grpItem.Controls.Add(this.label8);
            this.grpItem.Controls.Add(this.lblPreco);
            this.grpItem.Location = new System.Drawing.Point(2, 28);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(416, 297);
            this.grpItem.TabIndex = 500;
            this.grpItem.TabStop = false;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(15, 33);
            this.txtCod.MaxLength = 4;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 21);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            this.txtCod.Leave += new System.EventHandler(this.txtCod_Leave_1);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(232, 214);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(54, 21);
            this.txtPreco.TabIndex = 18;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Enabled = false;
            this.txtEstoque.Location = new System.Drawing.Point(318, 243);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(50, 21);
            this.txtEstoque.TabIndex = 20;
            this.txtEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.ForeColor = System.Drawing.Color.Red;
            this.lblQua.Location = new System.Drawing.Point(209, 283);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(0, 13);
            this.lblQua.TabIndex = 111;
            // 
            // numQuant
            // 
            this.numQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numQuant.Location = new System.Drawing.Point(209, 259);
            this.numQuant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuant.Name = "numQuant";
            this.numQuant.Size = new System.Drawing.Size(63, 21);
            this.numQuant.TabIndex = 19;
            this.numQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuant.ValueChanged += new System.EventHandler(this.numQuant_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 109;
            this.label6.Text = "R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(213, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(52, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 105;
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.ForeColor = System.Drawing.Color.Red;
            this.lblPre.Location = new System.Drawing.Point(246, 197);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(0, 13);
            this.lblPre.TabIndex = 104;
            // 
            // grpTamanho
            // 
            this.grpTamanho.Controls.Add(this.rbP);
            this.grpTamanho.Controls.Add(this.rbGG);
            this.grpTamanho.Controls.Add(this.rbG);
            this.grpTamanho.Controls.Add(this.rbM);
            this.grpTamanho.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpTamanho.Location = new System.Drawing.Point(285, 67);
            this.grpTamanho.Name = "grpTamanho";
            this.grpTamanho.Size = new System.Drawing.Size(122, 124);
            this.grpTamanho.TabIndex = 300;
            this.grpTamanho.TabStop = false;
            this.grpTamanho.Text = "Selecione o Tamanho";
            // 
            // rbP
            // 
            this.rbP.AutoSize = true;
            this.rbP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbP.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbP.Location = new System.Drawing.Point(15, 16);
            this.rbP.Name = "rbP";
            this.rbP.Size = new System.Drawing.Size(31, 17);
            this.rbP.TabIndex = 8;
            this.rbP.TabStop = true;
            this.rbP.Text = "P";
            this.rbP.UseVisualStyleBackColor = true;
            // 
            // rbGG
            // 
            this.rbGG.AutoSize = true;
            this.rbGG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbGG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbGG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbGG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbGG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbGG.Location = new System.Drawing.Point(15, 82);
            this.rbGG.Name = "rbGG";
            this.rbGG.Size = new System.Drawing.Size(39, 17);
            this.rbGG.TabIndex = 11;
            this.rbGG.TabStop = true;
            this.rbGG.Text = "GG";
            this.rbGG.UseVisualStyleBackColor = true;
            // 
            // rbG
            // 
            this.rbG.AutoSize = true;
            this.rbG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbG.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbG.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbG.Location = new System.Drawing.Point(15, 60);
            this.rbG.Name = "rbG";
            this.rbG.Size = new System.Drawing.Size(32, 17);
            this.rbG.TabIndex = 10;
            this.rbG.TabStop = true;
            this.rbG.Text = "G";
            this.rbG.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbM.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbM.Location = new System.Drawing.Point(15, 38);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(33, 17);
            this.rbM.TabIndex = 9;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbUni);
            this.grpTipo.Controls.Add(this.rbBaby);
            this.grpTipo.Location = new System.Drawing.Point(150, 67);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(122, 124);
            this.grpTipo.TabIndex = 200;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Selecione o Tipo";
            // 
            // rbUni
            // 
            this.rbUni.AutoSize = true;
            this.rbUni.Checked = true;
            this.rbUni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbUni.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbUni.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbUni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbUni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbUni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbUni.Location = new System.Drawing.Point(14, 16);
            this.rbUni.Name = "rbUni";
            this.rbUni.Size = new System.Drawing.Size(62, 17);
            this.rbUni.TabIndex = 6;
            this.rbUni.TabStop = true;
            this.rbUni.Text = "Unissex";
            this.rbUni.UseVisualStyleBackColor = true;
            // 
            // rbBaby
            // 
            this.rbBaby.AutoSize = true;
            this.rbBaby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBaby.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbBaby.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbBaby.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbBaby.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbBaby.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBaby.Location = new System.Drawing.Point(14, 39);
            this.rbBaby.Name = "rbBaby";
            this.rbBaby.Size = new System.Drawing.Size(74, 17);
            this.rbBaby.TabIndex = 7;
            this.rbBaby.TabStop = true;
            this.rbBaby.Text = "Baby Look";
            this.rbBaby.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGames);
            this.groupBox1.Controls.Add(this.rbHumor);
            this.groupBox1.Controls.Add(this.rbRock);
            this.groupBox1.Controls.Add(this.rbFilmes);
            this.groupBox1.Controls.Add(this.rbHerois);
            this.groupBox1.Controls.Add(this.rbAnime);
            this.groupBox1.Location = new System.Drawing.Point(15, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 90);
            this.groupBox1.TabIndex = 400;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a Categoria";
            // 
            // rbGames
            // 
            this.rbGames.AutoSize = true;
            this.rbGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGames.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbGames.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbGames.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbGames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbGames.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbGames.Location = new System.Drawing.Point(79, 16);
            this.rbGames.Name = "rbGames";
            this.rbGames.Size = new System.Drawing.Size(57, 17);
            this.rbGames.TabIndex = 15;
            this.rbGames.TabStop = true;
            this.rbGames.Text = "Games";
            this.rbGames.UseVisualStyleBackColor = true;
            // 
            // rbHumor
            // 
            this.rbHumor.AutoSize = true;
            this.rbHumor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHumor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbHumor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbHumor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbHumor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbHumor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbHumor.Location = new System.Drawing.Point(79, 62);
            this.rbHumor.Name = "rbHumor";
            this.rbHumor.Size = new System.Drawing.Size(56, 17);
            this.rbHumor.TabIndex = 17;
            this.rbHumor.TabStop = true;
            this.rbHumor.Text = "Humor";
            this.rbHumor.UseVisualStyleBackColor = true;
            // 
            // rbRock
            // 
            this.rbRock.AutoSize = true;
            this.rbRock.Checked = true;
            this.rbRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbRock.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbRock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbRock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbRock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbRock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbRock.Location = new System.Drawing.Point(14, 16);
            this.rbRock.Name = "rbRock";
            this.rbRock.Size = new System.Drawing.Size(48, 17);
            this.rbRock.TabIndex = 12;
            this.rbRock.TabStop = true;
            this.rbRock.Text = "Rock";
            this.rbRock.UseVisualStyleBackColor = true;
            // 
            // rbFilmes
            // 
            this.rbFilmes.AutoSize = true;
            this.rbFilmes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbFilmes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbFilmes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbFilmes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbFilmes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbFilmes.Location = new System.Drawing.Point(79, 39);
            this.rbFilmes.Name = "rbFilmes";
            this.rbFilmes.Size = new System.Drawing.Size(87, 17);
            this.rbFilmes.TabIndex = 16;
            this.rbFilmes.TabStop = true;
            this.rbFilmes.Text = "Filmes/Series";
            this.rbFilmes.UseVisualStyleBackColor = true;
            // 
            // rbHerois
            // 
            this.rbHerois.AutoSize = true;
            this.rbHerois.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbHerois.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbHerois.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbHerois.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbHerois.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbHerois.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbHerois.Location = new System.Drawing.Point(14, 62);
            this.rbHerois.Name = "rbHerois";
            this.rbHerois.Size = new System.Drawing.Size(55, 17);
            this.rbHerois.TabIndex = 14;
            this.rbHerois.TabStop = true;
            this.rbHerois.Text = "Heróis";
            this.rbHerois.UseVisualStyleBackColor = true;
            // 
            // rbAnime
            // 
            this.rbAnime.AutoSize = true;
            this.rbAnime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAnime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbAnime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbAnime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbAnime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbAnime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbAnime.Location = new System.Drawing.Point(14, 39);
            this.rbAnime.Name = "rbAnime";
            this.rbAnime.Size = new System.Drawing.Size(54, 17);
            this.rbAnime.TabIndex = 13;
            this.rbAnime.TabStop = true;
            this.rbAnime.Text = "Anime";
            this.rbAnime.UseVisualStyleBackColor = true;
            // 
            // grpCor
            // 
            this.grpCor.Controls.Add(this.rbPreta);
            this.grpCor.Controls.Add(this.rbCinza);
            this.grpCor.Controls.Add(this.rbBranca);
            this.grpCor.Location = new System.Drawing.Point(15, 67);
            this.grpCor.Name = "grpCor";
            this.grpCor.Size = new System.Drawing.Size(122, 124);
            this.grpCor.TabIndex = 100;
            this.grpCor.TabStop = false;
            this.grpCor.Text = "Selecione a Cor";
            // 
            // rbPreta
            // 
            this.rbPreta.AutoSize = true;
            this.rbPreta.Checked = true;
            this.rbPreta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPreta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbPreta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbPreta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbPreta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbPreta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPreta.Location = new System.Drawing.Point(14, 16);
            this.rbPreta.Name = "rbPreta";
            this.rbPreta.Size = new System.Drawing.Size(51, 17);
            this.rbPreta.TabIndex = 3;
            this.rbPreta.TabStop = true;
            this.rbPreta.Text = "Preta";
            this.rbPreta.UseVisualStyleBackColor = true;
            // 
            // rbCinza
            // 
            this.rbCinza.AutoSize = true;
            this.rbCinza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbCinza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbCinza.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbCinza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbCinza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbCinza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbCinza.Location = new System.Drawing.Point(14, 62);
            this.rbCinza.Name = "rbCinza";
            this.rbCinza.Size = new System.Drawing.Size(51, 17);
            this.rbCinza.TabIndex = 5;
            this.rbCinza.Text = "Cinza";
            this.rbCinza.UseVisualStyleBackColor = true;
            // 
            // rbBranca
            // 
            this.rbBranca.AutoSize = true;
            this.rbBranca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbBranca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbBranca.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.rbBranca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.rbBranca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.rbBranca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbBranca.Location = new System.Drawing.Point(14, 39);
            this.rbBranca.Name = "rbBranca";
            this.rbBranca.Size = new System.Drawing.Size(58, 17);
            this.rbBranca.TabIndex = 4;
            this.rbBranca.Text = "Branca";
            this.rbBranca.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 33);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(249, 21);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 700;
            this.label1.Text = "Quantidade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(154, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 13);
            this.lblNome.TabIndex = 93;
            this.lblNome.Text = "Descrição";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 14);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 87;
            this.lblCod.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 600;
            this.label8.Text = "Em estoque";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(206, 197);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(34, 13);
            this.lblPreco.TabIndex = 601;
            this.lblPreco.Text = "Preço";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Rock",
            "Anime",
            "Heróis",
            "Games",
            "Filmes",
            "Humor"});
            this.cmbCategoria.Location = new System.Drawing.Point(17, 65);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 99;
            this.cmbCategoria.Text = "Escolha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Categoria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImg);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pctFoto);
            this.groupBox2.Controls.Add(this.btnFotoAdd);
            this.groupBox2.Location = new System.Drawing.Point(424, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 210);
            this.groupBox2.TabIndex = 450;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagem";
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblImg.Location = new System.Drawing.Point(6, 188);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(0, 13);
            this.lblImg.TabIndex = 105;
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Remover";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFotoAdd
            // 
            this.btnFotoAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFotoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFotoAdd.FlatAppearance.BorderSize = 0;
            this.btnFotoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoAdd.ForeColor = System.Drawing.Color.White;
            this.btnFotoAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnFotoAdd.Image")));
            this.btnFotoAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFotoAdd.Location = new System.Drawing.Point(3, 119);
            this.btnFotoAdd.Name = "btnFotoAdd";
            this.btnFotoAdd.Size = new System.Drawing.Size(85, 23);
            this.btnFotoAdd.TabIndex = 21;
            this.btnFotoAdd.Text = "Adicionar";
            this.btnFotoAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFotoAdd.UseVisualStyleBackColor = false;
            this.btnFotoAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 105;
            this.label2.Text = "Novo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpar.Location = new System.Drawing.Point(504, 259);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 45);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Green;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Enabled = false;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNovo.Location = new System.Drawing.Point(580, 259);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 45);
            this.btnNovo.TabIndex = 25;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.button3_Click);
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // modItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 326);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "modItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itens";
            this.Load += new System.EventHandler(this.modItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuant)).EndInit();
            this.grpTamanho.ResumeLayout(false);
            this.grpTamanho.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCor.ResumeLayout(false);
            this.grpCor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFotoAdd;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbCinza;
        private System.Windows.Forms.RadioButton rbBranca;
        private System.Windows.Forms.RadioButton rbPreta;
        private System.Windows.Forms.GroupBox grpTamanho;
        private System.Windows.Forms.RadioButton rbP;
        private System.Windows.Forms.RadioButton rbG;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.GroupBox grpCor;
        private System.Windows.Forms.RadioButton rbGG;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbUni;
        private System.Windows.Forms.RadioButton rbBaby;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGames;
        private System.Windows.Forms.RadioButton rbHumor;
        private System.Windows.Forms.RadioButton rbRock;
        private System.Windows.Forms.RadioButton rbFilmes;
        private System.Windows.Forms.RadioButton rbHerois;
        private System.Windows.Forms.RadioButton rbAnime;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numQuant;
        private System.Windows.Forms.Label lblQua;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtPreco;
        public System.Windows.Forms.TextBox txtCod;
    }
}