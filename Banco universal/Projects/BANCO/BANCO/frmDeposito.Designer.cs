namespace BANCO
{
    partial class frmDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposito));
            this.btnAnula = new System.Windows.Forms.Button();
            this.btnCorrige = new System.Windows.Forms.PictureBox();
            this.btnentra = new System.Windows.Forms.PictureBox();
            this.lbconfirma = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lbvalor = new System.Windows.Forms.Label();
            this.lbnconta = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.lbDados = new System.Windows.Forms.Label();
            this.lbConfira = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnentra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnula
            // 
            this.btnAnula.BackColor = System.Drawing.Color.Red;
            this.btnAnula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnula.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnula.ForeColor = System.Drawing.Color.White;
            this.btnAnula.Location = new System.Drawing.Point(522, 528);
            this.btnAnula.Name = "btnAnula";
            this.btnAnula.Size = new System.Drawing.Size(100, 25);
            this.btnAnula.TabIndex = 34;
            this.btnAnula.Text = "ANULA";
            this.btnAnula.UseVisualStyleBackColor = false;
            this.btnAnula.Click += new System.EventHandler(this.btnAnula_Click);
            // 
            // btnCorrige
            // 
            this.btnCorrige.BackColor = System.Drawing.Color.Transparent;
            this.btnCorrige.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCorrige.Location = new System.Drawing.Point(745, 528);
            this.btnCorrige.Name = "btnCorrige";
            this.btnCorrige.Size = new System.Drawing.Size(100, 25);
            this.btnCorrige.TabIndex = 33;
            this.btnCorrige.TabStop = false;
            this.btnCorrige.Click += new System.EventHandler(this.btnCorrige_Click);
            // 
            // btnentra
            // 
            this.btnentra.BackColor = System.Drawing.Color.Transparent;
            this.btnentra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnentra.Location = new System.Drawing.Point(787, 242);
            this.btnentra.Name = "btnentra";
            this.btnentra.Size = new System.Drawing.Size(100, 54);
            this.btnentra.TabIndex = 32;
            this.btnentra.TabStop = false;
            this.btnentra.Click += new System.EventHandler(this.btnentra_Click);
            // 
            // lbconfirma
            // 
            this.lbconfirma.AutoSize = true;
            this.lbconfirma.BackColor = System.Drawing.Color.Transparent;
            this.lbconfirma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirma.ForeColor = System.Drawing.Color.Black;
            this.lbconfirma.Location = new System.Drawing.Point(670, 250);
            this.lbconfirma.Name = "lbconfirma";
            this.lbconfirma.Size = new System.Drawing.Size(111, 46);
            this.lbconfirma.TabIndex = 31;
            this.lbconfirma.Text = "PARA\r\nCONFIRMAR";
            // 
            // txtDeposito
            // 
            this.txtDeposito.BackColor = System.Drawing.Color.White;
            this.txtDeposito.ForeColor = System.Drawing.Color.Black;
            this.txtDeposito.Location = new System.Drawing.Point(564, 265);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(100, 20);
            this.txtDeposito.TabIndex = 30;
            this.txtDeposito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeposito_KeyDown);
            this.txtDeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposito_KeyPress);
            // 
            // lbvalor
            // 
            this.lbvalor.AutoSize = true;
            this.lbvalor.BackColor = System.Drawing.Color.Transparent;
            this.lbvalor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvalor.ForeColor = System.Drawing.Color.Black;
            this.lbvalor.Location = new System.Drawing.Point(465, 262);
            this.lbvalor.Name = "lbvalor";
            this.lbvalor.Size = new System.Drawing.Size(93, 23);
            this.lbvalor.TabIndex = 29;
            this.lbvalor.Text = "Valor (R$):";
            // 
            // lbnconta
            // 
            this.lbnconta.AutoSize = true;
            this.lbnconta.BackColor = System.Drawing.Color.Transparent;
            this.lbnconta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnconta.ForeColor = System.Drawing.Color.Black;
            this.lbnconta.Location = new System.Drawing.Point(465, 213);
            this.lbnconta.Name = "lbnconta";
            this.lbnconta.Size = new System.Drawing.Size(157, 23);
            this.lbnconta.TabIndex = 35;
            this.lbnconta.Text = "Numero da Conta: ";
            // 
            // txtConta
            // 
            this.txtConta.BackColor = System.Drawing.Color.White;
            this.txtConta.ForeColor = System.Drawing.Color.Black;
            this.txtConta.Location = new System.Drawing.Point(628, 216);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(100, 20);
            this.txtConta.TabIndex = 36;
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            this.txtConta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConta_KeyPress);
            // 
            // txtDigito
            // 
            this.txtDigito.BackColor = System.Drawing.Color.White;
            this.txtDigito.ForeColor = System.Drawing.Color.Black;
            this.txtDigito.Location = new System.Drawing.Point(734, 217);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(28, 20);
            this.txtDigito.TabIndex = 37;
            this.txtDigito.TextChanged += new System.EventHandler(this.txtDigito_TextChanged);
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // lbDados
            // 
            this.lbDados.AutoSize = true;
            this.lbDados.BackColor = System.Drawing.Color.Transparent;
            this.lbDados.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDados.Location = new System.Drawing.Point(154, 110);
            this.lbDados.Name = "lbDados";
            this.lbDados.Size = new System.Drawing.Size(0, 26);
            this.lbDados.TabIndex = 38;
            this.lbDados.Visible = false;
            // 
            // lbConfira
            // 
            this.lbConfira.AutoSize = true;
            this.lbConfira.BackColor = System.Drawing.Color.Transparent;
            this.lbConfira.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfira.Location = new System.Drawing.Point(143, 69);
            this.lbConfira.Name = "lbConfira";
            this.lbConfira.Size = new System.Drawing.Size(284, 26);
            this.lbConfira.TabIndex = 39;
            this.lbConfira.Text = "Confira os Dados Do Favorecido";
            this.lbConfira.Visible = false;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirma.Location = new System.Drawing.Point(787, 242);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(100, 54);
            this.btnConfirma.TabIndex = 40;
            this.btnConfirma.TabStop = false;
            this.btnConfirma.Visible = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // frmDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 566);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lbConfira);
            this.Controls.Add(this.lbDados);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.lbnconta);
            this.Controls.Add(this.btnAnula);
            this.Controls.Add(this.btnCorrige);
            this.Controls.Add(this.btnentra);
            this.Controls.Add(this.lbconfirma);
            this.Controls.Add(this.txtDeposito);
            this.Controls.Add(this.lbvalor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeposito";
            ((System.ComponentModel.ISupportInitialize)(this.btnCorrige)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnentra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnula;
        private System.Windows.Forms.PictureBox btnCorrige;
        private System.Windows.Forms.PictureBox btnentra;
        private System.Windows.Forms.Label lbconfirma;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lbvalor;
        private System.Windows.Forms.Label lbnconta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtDigito;
        private System.Windows.Forms.Label lbDados;
        private System.Windows.Forms.Label lbConfira;
        private System.Windows.Forms.PictureBox btnConfirma;
    }
}