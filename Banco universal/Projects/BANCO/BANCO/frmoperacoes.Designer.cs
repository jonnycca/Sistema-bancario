namespace BANCO
{
    partial class frmoperacoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmoperacoes));
            this.txtcronometro = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbTempoFinal = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbNome = new System.Windows.Forms.Label();
            this.btnsaldo = new System.Windows.Forms.PictureBox();
            this.btnextrato = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnsaque = new System.Windows.Forms.PictureBox();
            this.btndeposito = new System.Windows.Forms.PictureBox();
            this.btnencerrar = new System.Windows.Forms.PictureBox();
            this.btntrans = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnsaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnextrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsaque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnencerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntrans)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcronometro
            // 
            this.txtcronometro.AutoSize = true;
            this.txtcronometro.BackColor = System.Drawing.Color.Transparent;
            this.txtcronometro.ForeColor = System.Drawing.Color.Black;
            this.txtcronometro.Location = new System.Drawing.Point(947, 4);
            this.txtcronometro.Name = "txtcronometro";
            this.txtcronometro.Size = new System.Drawing.Size(0, 13);
            this.txtcronometro.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbTempoFinal
            // 
            this.lbTempoFinal.AutoSize = true;
            this.lbTempoFinal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTempoFinal.ForeColor = System.Drawing.Color.Red;
            this.lbTempoFinal.Location = new System.Drawing.Point(537, 288);
            this.lbTempoFinal.Name = "lbTempoFinal";
            this.lbTempoFinal.Size = new System.Drawing.Size(0, 19);
            this.lbTempoFinal.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.Location = new System.Drawing.Point(646, 702);
            this.progressBar1.Maximum = 6;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 5;
            this.progressBar1.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.BackColor = System.Drawing.Color.Transparent;
            this.lbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.Black;
            this.lbNome.Location = new System.Drawing.Point(115, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(0, 19);
            this.lbNome.TabIndex = 5;
            // 
            // btnsaldo
            // 
            this.btnsaldo.BackColor = System.Drawing.Color.Transparent;
            this.btnsaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaldo.Location = new System.Drawing.Point(849, 184);
            this.btnsaldo.Name = "btnsaldo";
            this.btnsaldo.Size = new System.Drawing.Size(395, 74);
            this.btnsaldo.TabIndex = 6;
            this.btnsaldo.TabStop = false;
            this.btnsaldo.Click += new System.EventHandler(this.btnsaldo_Click);
            this.btnsaldo.MouseEnter += new System.EventHandler(this.btnsaldo_MouseEnter);
            this.btnsaldo.MouseLeave += new System.EventHandler(this.btnsaldo_MouseLeave);
            // 
            // btnextrato
            // 
            this.btnextrato.BackColor = System.Drawing.Color.Transparent;
            this.btnextrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnextrato.Location = new System.Drawing.Point(849, 329);
            this.btnextrato.Name = "btnextrato";
            this.btnextrato.Size = new System.Drawing.Size(395, 74);
            this.btnextrato.TabIndex = 7;
            this.btnextrato.TabStop = false;
            this.btnextrato.Click += new System.EventHandler(this.btnextrato_Click);
            this.btnextrato.MouseEnter += new System.EventHandler(this.btnextrato_MouseEnter);
            this.btnextrato.MouseLeave += new System.EventHandler(this.btnextrato_MouseLeave);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.ImageLocation = "";
            this.logo.Location = new System.Drawing.Point(2, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(96, 73);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            // 
            // btnsaque
            // 
            this.btnsaque.BackColor = System.Drawing.Color.Transparent;
            this.btnsaque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsaque.Location = new System.Drawing.Point(101, 184);
            this.btnsaque.Name = "btnsaque";
            this.btnsaque.Size = new System.Drawing.Size(395, 74);
            this.btnsaque.TabIndex = 14;
            this.btnsaque.TabStop = false;
            this.btnsaque.Click += new System.EventHandler(this.btnsaque_Click);
            this.btnsaque.MouseEnter += new System.EventHandler(this.btnsaque_MouseEnter);
            this.btnsaque.MouseLeave += new System.EventHandler(this.btnsaque_MouseLeave);
            // 
            // btndeposito
            // 
            this.btndeposito.BackColor = System.Drawing.Color.Transparent;
            this.btndeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeposito.Location = new System.Drawing.Point(101, 329);
            this.btndeposito.Name = "btndeposito";
            this.btndeposito.Size = new System.Drawing.Size(395, 74);
            this.btndeposito.TabIndex = 15;
            this.btndeposito.TabStop = false;
            this.btndeposito.Click += new System.EventHandler(this.btndeposito_Click);
            this.btndeposito.MouseEnter += new System.EventHandler(this.btndeposito_MouseEnter);
            this.btndeposito.MouseLeave += new System.EventHandler(this.btndeposito_MouseLeave);
            // 
            // btnencerrar
            // 
            this.btnencerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnencerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnencerrar.Location = new System.Drawing.Point(849, 477);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(395, 74);
            this.btnencerrar.TabIndex = 16;
            this.btnencerrar.TabStop = false;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            this.btnencerrar.MouseEnter += new System.EventHandler(this.btnencerrar_MouseEnter);
            this.btnencerrar.MouseLeave += new System.EventHandler(this.btnencerrar_MouseLeave);
            // 
            // btntrans
            // 
            this.btntrans.BackColor = System.Drawing.Color.Transparent;
            this.btntrans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrans.Location = new System.Drawing.Point(101, 477);
            this.btntrans.Name = "btntrans";
            this.btntrans.Size = new System.Drawing.Size(395, 74);
            this.btntrans.TabIndex = 17;
            this.btntrans.TabStop = false;
            this.btntrans.Click += new System.EventHandler(this.btntrans_Click);
            this.btntrans.MouseEnter += new System.EventHandler(this.btntrans_MouseEnter);
            this.btntrans.MouseLeave += new System.EventHandler(this.btntrans_MouseLeave);
            // 
            // frmoperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btntrans);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.btndeposito);
            this.Controls.Add(this.btnsaque);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnextrato);
            this.Controls.Add(this.btnsaldo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbTempoFinal);
            this.Controls.Add(this.txtcronometro);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(277, 215);
            this.Name = "frmoperacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPERACOES";
            ((System.ComponentModel.ISupportInitialize)(this.btnsaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnextrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsaque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnencerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btntrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtcronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTempoFinal;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox btnsaldo;
        private System.Windows.Forms.PictureBox btnextrato;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox btnsaque;
        private System.Windows.Forms.PictureBox btndeposito;
        private System.Windows.Forms.PictureBox btnencerrar;
        private System.Windows.Forms.PictureBox btntrans;
    }
}