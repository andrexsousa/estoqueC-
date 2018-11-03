namespace estoque
{
    partial class imagem
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
            this.pctWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctWin)).BeginInit();
            this.SuspendLayout();
            // 
            // pctWin
            // 
            this.pctWin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctWin.Location = new System.Drawing.Point(0, 0);
            this.pctWin.Name = "pctWin";
            this.pctWin.Size = new System.Drawing.Size(178, 221);
            this.pctWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWin.TabIndex = 0;
            this.pctWin.TabStop = false;
            // 
            // imagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(178, 221);
            this.Controls.Add(this.pctWin);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "imagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagem";
            this.Load += new System.EventHandler(this.imagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctWin;
    }
}