namespace BANCO
{
    partial class frmSenha
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
            this.ptdigito = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.PictureBox();
            this.btnentra = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptdigito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnentra)).BeginInit();
            this.SuspendLayout();
            // 
            // ptdigito
            // 
            this.ptdigito.BackColor = System.Drawing.Color.Transparent;
            this.ptdigito.Location = new System.Drawing.Point(159, 115);
            this.ptdigito.Name = "ptdigito";
            this.ptdigito.Size = new System.Drawing.Size(304, 304);
            this.ptdigito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptdigito.TabIndex = 0;
            this.ptdigito.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite Sua Senha";
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.Color.Red;
            this.btnAnula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnula.ForeColor = System.Drawing.Color.White;
            this.btnAnula.Location = new System.Drawing.Point(506, 491);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(100, 25);
            this.btnAnula.TabIndex = 30;
            this.btnAnula.Text = "ANULA";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrige.Location = new System.Drawing.Point(729, 491);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(100, 25);
            this.btnCorrige.TabIndex = 29;
            this.btnCorrige.TabStop = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnentra
            // 
            this.btnentra.BackColor = System.Drawing.Color.Transparent;
            this.btnentra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnentra.Location = new System.Drawing.Point(830, 237);
            this.btnentra.Name = "btnentra";
            this.btnentra.Size = new System.Drawing.Size(100, 54);
            this.btnentra.TabIndex = 34;
            this.btnentra.TabStop = false;
            this.btnentra.Click += new System.EventHandler(this.btnentra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(713, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 46);
            this.label2.TabIndex = 33;
            this.label2.Text = "PARA\r\nCONFIRMAR";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(607, 260);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 26);
            this.txtSenha.TabIndex = 32;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyUp);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.BackColor = System.Drawing.Color.Transparent;
            this.valor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor.ForeColor = System.Drawing.Color.Black;
            this.valor.Location = new System.Drawing.Point(543, 260);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(63, 23);
            this.valor.TabIndex = 31;
            this.valor.Text = "Senha:";
            // 
            // frmSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANCO.Properties.Resources.menusaque1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 566);
            this.Controls.Add(this.btnentra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnCorrige);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptdigito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSenha";
            ((System.ComponentModel.ISupportInitialize)(this.ptdigito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnentra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptdigito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.PictureBox btnCorrige;
        private System.Windows.Forms.PictureBox btnentra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label valor;
    }
}