namespace BANCO
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.porcentagem1 = new System.Windows.Forms.Label();
            this.horadata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnconta = new System.Windows.Forms.TextBox();
            this.txbdgconta = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.Debito = new System.Windows.Forms.PictureBox();
            this.Cartoes = new System.Windows.Forms.PictureBox();
            this.Pagamentos = new System.Windows.Forms.PictureBox();
            this.Contatos = new System.Windows.Forms.PictureBox();
            this.labelDebito = new System.Windows.Forms.Label();
            this.labelCartoes = new System.Windows.Forms.Label();
            this.labelPagamentos = new System.Windows.Forms.Label();
            this.labelContatos = new System.Windows.Forms.Label();
            this.labelSair = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Debito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pagamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contatos)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1355, 822);
            this.progressBar1.Maximum = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // porcentagem1
            // 
            this.porcentagem1.AutoSize = true;
            this.porcentagem1.Location = new System.Drawing.Point(1401, 831);
            this.porcentagem1.Name = "porcentagem1";
            this.porcentagem1.Size = new System.Drawing.Size(0, 13);
            this.porcentagem1.TabIndex = 3;
            // 
            // horadata
            // 
            this.horadata.AutoSize = true;
            this.horadata.BackColor = System.Drawing.Color.Transparent;
            this.horadata.ForeColor = System.Drawing.Color.White;
            this.horadata.Location = new System.Drawing.Point(983, 7);
            this.horadata.Name = "horadata";
            this.horadata.Size = new System.Drawing.Size(0, 13);
            this.horadata.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Conta:";
            // 
            // txbnconta
            // 
            this.txbnconta.Location = new System.Drawing.Point(416, 34);
            this.txbnconta.Name = "txbnconta";
            this.txbnconta.Size = new System.Drawing.Size(76, 20);
            this.txbnconta.TabIndex = 8;
            this.txbnconta.TextChanged += new System.EventHandler(this.txbnconta_TextChanged);
            this.txbnconta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbnconta_KeyPress);
            // 
            // txbdgconta
            // 
            this.txbdgconta.Location = new System.Drawing.Point(502, 34);
            this.txbdgconta.Name = "txbdgconta";
            this.txbdgconta.Size = new System.Drawing.Size(22, 20);
            this.txbdgconta.TabIndex = 9;
            this.txbdgconta.TextChanged += new System.EventHandler(this.txbdgconta_TextChanged);
            this.txbdgconta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdgconta_KeyPress);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.SystemColors.Control;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Location = new System.Drawing.Point(536, 33);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(31, 23);
            this.btnok.TabIndex = 10;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtnome
            // 
            this.txtnome.AutoSize = true;
            this.txtnome.Location = new System.Drawing.Point(904, 55);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(0, 13);
            this.txtnome.TabIndex = 11;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 79);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            // 
            // img1
            // 
            this.img1.Location = new System.Drawing.Point(704, 561);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(100, 77);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img1.TabIndex = 13;
            this.img1.TabStop = false;
            this.img1.Click += new System.EventHandler(this.img1_Click);
            this.img1.MouseLeave += new System.EventHandler(this.tirar);
            this.img1.MouseHover += new System.EventHandler(this.mostrar);
            // 
            // img2
            // 
            this.img2.Location = new System.Drawing.Point(848, 561);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(100, 77);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img2.TabIndex = 14;
            this.img2.TabStop = false;
            this.img2.Click += new System.EventHandler(this.img2_Click);
            this.img2.MouseLeave += new System.EventHandler(this.tirar2);
            this.img2.MouseHover += new System.EventHandler(this.mostrar2);
            // 
            // img3
            // 
            this.img3.Location = new System.Drawing.Point(990, 561);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(100, 77);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img3.TabIndex = 15;
            this.img3.TabStop = false;
            this.img3.Click += new System.EventHandler(this.img3_Click);
            this.img3.MouseLeave += new System.EventHandler(this.tirar3);
            this.img3.MouseHover += new System.EventHandler(this.mostrar3);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.Color.Red;
            this.progressBar2.Location = new System.Drawing.Point(704, 643);
            this.progressBar2.MarqueeAnimationSpeed = 101;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 2);
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 16;
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.Red;
            this.progressBar3.Location = new System.Drawing.Point(848, 643);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Minimum = 100;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 2);
            this.progressBar3.TabIndex = 17;
            this.progressBar3.Value = 100;
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.Red;
            this.progressBar4.Location = new System.Drawing.Point(990, 643);
            this.progressBar4.Maximum = 300;
            this.progressBar4.Minimum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(100, 2);
            this.progressBar4.TabIndex = 18;
            this.progressBar4.Value = 200;
            // 
            // Debito
            // 
            this.Debito.BackColor = System.Drawing.Color.Transparent;
            this.Debito.Location = new System.Drawing.Point(32, 684);
            this.Debito.Name = "Debito";
            this.Debito.Size = new System.Drawing.Size(82, 56);
            this.Debito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Debito.TabIndex = 19;
            this.Debito.TabStop = false;
            // 
            // Cartoes
            // 
            this.Cartoes.BackColor = System.Drawing.Color.Transparent;
            this.Cartoes.Location = new System.Drawing.Point(367, 684);
            this.Cartoes.Name = "Cartoes";
            this.Cartoes.Size = new System.Drawing.Size(82, 56);
            this.Cartoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cartoes.TabIndex = 20;
            this.Cartoes.TabStop = false;
            // 
            // Pagamentos
            // 
            this.Pagamentos.BackColor = System.Drawing.Color.Transparent;
            this.Pagamentos.Location = new System.Drawing.Point(733, 684);
            this.Pagamentos.Name = "Pagamentos";
            this.Pagamentos.Size = new System.Drawing.Size(82, 56);
            this.Pagamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pagamentos.TabIndex = 21;
            this.Pagamentos.TabStop = false;
            // 
            // Contatos
            // 
            this.Contatos.BackColor = System.Drawing.Color.Transparent;
            this.Contatos.Location = new System.Drawing.Point(1080, 684);
            this.Contatos.Name = "Contatos";
            this.Contatos.Size = new System.Drawing.Size(82, 56);
            this.Contatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Contatos.TabIndex = 22;
            this.Contatos.TabStop = false;
            // 
            // labelDebito
            // 
            this.labelDebito.AutoSize = true;
            this.labelDebito.BackColor = System.Drawing.Color.Transparent;
            this.labelDebito.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebito.ForeColor = System.Drawing.Color.Transparent;
            this.labelDebito.Location = new System.Drawing.Point(120, 703);
            this.labelDebito.Name = "labelDebito";
            this.labelDebito.Size = new System.Drawing.Size(104, 19);
            this.labelDebito.TabIndex = 23;
            this.labelDebito.Text = "Débito Online";
            // 
            // labelCartoes
            // 
            this.labelCartoes.AutoSize = true;
            this.labelCartoes.BackColor = System.Drawing.Color.Transparent;
            this.labelCartoes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCartoes.ForeColor = System.Drawing.Color.Transparent;
            this.labelCartoes.Location = new System.Drawing.Point(455, 703);
            this.labelCartoes.Name = "labelCartoes";
            this.labelCartoes.Size = new System.Drawing.Size(180, 19);
            this.labelCartoes.TabIndex = 24;
            this.labelCartoes.Text = "Cartões Débito e Crédito ";
            // 
            // labelPagamentos
            // 
            this.labelPagamentos.AutoSize = true;
            this.labelPagamentos.BackColor = System.Drawing.Color.Transparent;
            this.labelPagamentos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagamentos.ForeColor = System.Drawing.Color.Transparent;
            this.labelPagamentos.Location = new System.Drawing.Point(821, 703);
            this.labelPagamentos.Name = "labelPagamentos";
            this.labelPagamentos.Size = new System.Drawing.Size(142, 19);
            this.labelPagamentos.TabIndex = 25;
            this.labelPagamentos.Text = "Pagamentos Online";
            // 
            // labelContatos
            // 
            this.labelContatos.AutoSize = true;
            this.labelContatos.BackColor = System.Drawing.Color.Transparent;
            this.labelContatos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContatos.ForeColor = System.Drawing.Color.Transparent;
            this.labelContatos.Location = new System.Drawing.Point(1168, 703);
            this.labelContatos.Name = "labelContatos";
            this.labelContatos.Size = new System.Drawing.Size(97, 19);
            this.labelContatos.TabIndex = 26;
            this.labelContatos.Text = "Fale Conosco";
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.BackColor = System.Drawing.Color.Transparent;
            this.labelSair.ForeColor = System.Drawing.Color.Transparent;
            this.labelSair.LinkColor = System.Drawing.Color.White;
            this.labelSair.Location = new System.Drawing.Point(1335, 7);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(25, 13);
            this.labelSair.TabIndex = 27;
            this.labelSair.TabStop = true;
            this.labelSair.Text = "Sair";
            this.labelSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelSair_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.labelSair);
            this.Controls.Add(this.labelContatos);
            this.Controls.Add(this.labelPagamentos);
            this.Controls.Add(this.labelCartoes);
            this.Controls.Add(this.labelDebito);
            this.Controls.Add(this.Contatos);
            this.Controls.Add(this.Pagamentos);
            this.Controls.Add(this.Cartoes);
            this.Controls.Add(this.Debito);
            this.Controls.Add(this.progressBar4);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txbdgconta);
            this.Controls.Add(this.txbnconta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.horadata);
            this.Controls.Add(this.porcentagem1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Debito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cartoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pagamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label porcentagem1;
        private System.Windows.Forms.Label horadata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnconta;
        private System.Windows.Forms.TextBox txbdgconta;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label txtnome;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.PictureBox Debito;
        private System.Windows.Forms.PictureBox Cartoes;
        private System.Windows.Forms.PictureBox Pagamentos;
        private System.Windows.Forms.PictureBox Contatos;
        private System.Windows.Forms.Label labelDebito;
        private System.Windows.Forms.Label labelCartoes;
        private System.Windows.Forms.Label labelPagamentos;
        private System.Windows.Forms.Label labelContatos;
        private System.Windows.Forms.LinkLabel labelSair;
    }
}

