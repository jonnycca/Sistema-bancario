namespace BANCO
{
    partial class frmTranferencia
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
            this.btnanula = new System.Windows.Forms.Button();
            this.btnConfirma = new System.Windows.Forms.PictureBox();
            this.lbConfira = new System.Windows.Forms.Label();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.lbnconta = new System.Windows.Forms.Label();
            this.btnCorrige = new System.Windows.Forms.PictureBox();
            this.lbconfirma = new System.Windows.Forms.Label();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.lbvalor = new System.Windows.Forms.Label();
            this.lbaSaldo = new System.Windows.Forms.Label();
            this.lbvalorsaldo = new System.Windows.Forms.Label();
            this.lborigem = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txDigitodestino = new System.Windows.Forms.TextBox();
            this.txContadestino = new System.Windows.Forms.TextBox();
            this.lbContadestino = new System.Windows.Forms.Label();
            this.btnEntra = new System.Windows.Forms.PictureBox();
            this.lbDados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnanula
            // 
            this.btnanula.BackColor = System.Drawing.Color.Red;
            this.btnanula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnanula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanula.ForeColor = System.Drawing.Color.White;
            this.btnanula.Location = new System.Drawing.Point(522, 527);
            this.btnanula.Name = "btnanula";
            this.btnanula.Size = new System.Drawing.Size(100, 25);
            this.btnanula.TabIndex = 51;
            this.btnanula.Text = "ANULA";
            this.btnanula.UseVisualStyleBackColor = false;
            this.btnanula.Click += new System.EventHandler(this.btnanula_Click);
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(787, 240);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(100, 54);
            this.btnConfirma.TabIndex = 50;
            this.btnConfirma.TabStop = false;
            this.btnConfirma.Visible = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // lbConfira
            // 
            this.lbConfira.AutoSize = true;
            this.lbConfira.BackColor = System.Drawing.Color.Transparent;
            this.lbConfira.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfira.Location = new System.Drawing.Point(143, 67);
            this.lbConfira.Name = "lbConfira";
            this.lbConfira.Size = new System.Drawing.Size(274, 26);
            this.lbConfira.TabIndex = 49;
            this.lbConfira.Text = "Confira os Dados Da Transação";
            this.lbConfira.Visible = false;
            // 
            // txtDigito
            // 
            this.txtDigito.BackColor = System.Drawing.Color.White;
            this.txtDigito.Enabled = false;
            this.txtDigito.ForeColor = System.Drawing.Color.Black;
            this.txtDigito.Location = new System.Drawing.Point(699, 132);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(28, 20);
            this.txtDigito.TabIndex = 48;
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.White;
            this.txtConta.Enabled = false;
            this.txtConta.ForeColor = System.Drawing.Color.Black;
            this.txtConta.Location = new System.Drawing.Point(590, 132);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 47;
            // 
            // lbnconta
            // 
            this.lbnconta.AutoSize = true;
            this.lbnconta.BackColor = System.Drawing.Color.Transparent;
            this.lbnconta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnconta.ForeColor = System.Drawing.Color.Black;
            this.lbnconta.Location = new System.Drawing.Point(465, 129);
            this.lbnconta.Name = "lbnconta";
            this.lbnconta.Size = new System.Drawing.Size(128, 23);
            this.lbnconta.TabIndex = 46;
            this.lbnconta.Text = "Conta Origem: ";
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrige.Location = new System.Drawing.Point(745, 526);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(100, 25);
            this.btnCorrige.TabIndex = 45;
            this.btnCorrige.TabStop = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // lbconfirma
            // 
            this.lbconfirma.AutoSize = true;
            this.lbconfirma.BackColor = System.Drawing.Color.Transparent;
            this.lbconfirma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirma.ForeColor = System.Drawing.Color.Black;
            this.lbconfirma.Location = new System.Drawing.Point(670, 248);
            this.lbconfirma.Name = "lbconfirma";
            this.lbconfirma.Size = new System.Drawing.Size(111, 46);
            this.lbconfirma.TabIndex = 44;
            this.lbconfirma.Text = "PARA\r\nCONFIRMAR";
            // 
            // txtTrans
            // 
            this.txtTrans.BackColor = System.Drawing.Color.White;
            this.txtTrans.ForeColor = System.Drawing.Color.Black;
            this.txtTrans.Location = new System.Drawing.Point(564, 263);
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(100, 20);
            this.txtTrans.TabIndex = 43;
            this.txtTrans.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTrans_KeyDown);
            this.txtTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrans_KeyPress);
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.BackColor = System.Drawing.Color.Transparent;
            this.lbvalor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalor.ForeColor = System.Drawing.Color.Black;
            this.lbvalor.Location = new System.Drawing.Point(465, 260);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(93, 23);
            this.lbvalor.TabIndex = 42;
            this.lbvalor.Text = "Valor (R$):";
            // 
            // lbaSaldo
            // 
            this.lbaSaldo.AutoSize = true;
            this.lbaSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lbaSaldo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaSaldo.ForeColor = System.Drawing.Color.Black;
            this.lbaSaldo.Location = new System.Drawing.Point(466, 158);
            this.lbaSaldo.Name = "lbaSaldo";
            this.lbaSaldo.Size = new System.Drawing.Size(150, 23);
            this.lbaSaldo.TabIndex = 52;
            this.lbaSaldo.Text = "Saldo Disponível: ";
            // 
            // lbvalorsaldo
            // 
            this.lbvalorsaldo.AutoSize = true;
            this.lbvalorsaldo.BackColor = System.Drawing.Color.Transparent;
            this.lbvalorsaldo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalorsaldo.ForeColor = System.Drawing.Color.Black;
            this.lbvalorsaldo.Location = new System.Drawing.Point(622, 158);
            this.lbvalorsaldo.Name = "lbvalorsaldo";
            this.lbvalorsaldo.Size = new System.Drawing.Size(0, 23);
            this.lbvalorsaldo.TabIndex = 53;
            // 
            // lborigem
            // 
            this.lborigem.AutoSize = true;
            this.lborigem.BackColor = System.Drawing.Color.Transparent;
            this.lborigem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lborigem.ForeColor = System.Drawing.Color.Black;
            this.lborigem.Location = new System.Drawing.Point(466, 94);
            this.lborigem.Name = "lborigem";
            this.lborigem.Size = new System.Drawing.Size(134, 23);
            this.lborigem.TabIndex = 54;
            this.lborigem.Text = "Titular Origem: ";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(593, 94);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 23);
            this.lbNome.TabIndex = 55;
            // 
            // txDigitodestino
            // 
            this.txDigitodestino.BackColor = System.Drawing.Color.White;
            this.txDigitodestino.ForeColor = System.Drawing.Color.Black;
            this.txDigitodestino.Location = new System.Drawing.Point(699, 225);
            this.txDigitodestino.Name = "txDigitodestino";
            this.txDigitodestino.Size = new System.Drawing.Size(28, 20);
            this.txDigitodestino.TabIndex = 58;
            this.txDigitodestino.TextChanged += new System.EventHandler(this.txDigitodestino_TextChanged);
            this.txDigitodestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDigitodestino_KeyPress);
            // 
            // txContadestino
            // 
            this.txContadestino.BackColor = System.Drawing.Color.White;
            this.txContadestino.ForeColor = System.Drawing.Color.Black;
            this.txContadestino.Location = new System.Drawing.Point(590, 225);
            this.txContadestino.Name = "txContadestino";
            this.txContadestino.Size = new System.Drawing.Size(100, 20);
            this.txContadestino.TabIndex = 57;
            this.txContadestino.TextChanged += new System.EventHandler(this.txContadestino_TextChanged);
            this.txContadestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txContadestino_KeyPress);
            // 
            // lbContadestino
            // 
            this.lbContadestino.AutoSize = true;
            this.lbContadestino.BackColor = System.Drawing.Color.Transparent;
            this.lbContadestino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContadestino.ForeColor = System.Drawing.Color.Black;
            this.lbContadestino.Location = new System.Drawing.Point(466, 222);
            this.lbContadestino.Name = "lbContadestino";
            this.lbContadestino.Size = new System.Drawing.Size(130, 23);
            this.lbContadestino.TabIndex = 56;
            this.lbContadestino.Text = "Conta Destino: ";
            // 
            // btnEntra
            // 
            this.btnEntra.BackColor = System.Drawing.Color.Transparent;
            this.btnEntra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntra.Location = new System.Drawing.Point(787, 240);
            this.btnEntra.Name = "btnEntra";
            this.btnEntra.Size = new System.Drawing.Size(100, 54);
            this.btnEntra.TabIndex = 60;
            this.btnEntra.TabStop = false;
            this.btnEntra.Click += new System.EventHandler(this.btnEntra_Click);
            // 
            // lbDados
            // 
            this.lbDados.AutoSize = true;
            this.lbDados.BackColor = System.Drawing.Color.Transparent;
            this.lbDados.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDados.Location = new System.Drawing.Point(153, 94);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(0, 26);
            this.lbDados.TabIndex = 61;
            this.lbDados.Visible = false;
            // 
            // frmTranferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANCO.Properties.Resources.menusaque1;
            this.ClientSize = new System.Drawing.Size(1334, 566);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.btnEntra);
            this.Controls.Add(this.txDigitodestino);
            this.Controls.Add(this.txContadestino);
            this.Controls.Add(this.lbContadestino);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lborigem);
            this.Controls.Add(this.lbvalorsaldo);
            this.Controls.Add(this.lbaSaldo);
            this.Controls.Add(this.btnanula);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lbConfira);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lbnconta);
            this.Controls.Add(this.btnCorrige);
            this.Controls.Add(this.lbconfirma);
            this.Controls.Add(this.txtTrans);
            this.Controls.Add(this.lbvalor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTranferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTranferencia";
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnanula;
        private System.Windows.Forms.PictureBox btnConfirma;
        private System.Windows.Forms.Label lbConfira;
        private System.Windows.Forms.TextBox txtDigito;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.Label lbnconta;
        private System.Windows.Forms.PictureBox btnCorrige;
        private System.Windows.Forms.Label lbconfirma;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.Label lbaSaldo;
        private System.Windows.Forms.Label lbvalorsaldo;
        private System.Windows.Forms.Label lborigem;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txDigitodestino;
        private System.Windows.Forms.TextBox txContadestino;
        private System.Windows.Forms.Label lbContadestino;
        private System.Windows.Forms.PictureBox btnEntra;
        private System.Windows.Forms.Label lbDados;
    }
}