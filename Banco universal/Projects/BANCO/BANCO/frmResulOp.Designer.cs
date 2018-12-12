namespace BANCO
{
    partial class frmResulOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResulOp));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptContagem = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ptsacou = new System.Windows.Forms.PictureBox();
            this.labelImprimir = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.lbvisual = new System.Windows.Forms.Label();
            this.lbImprimir = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lbexit = new System.Windows.Forms.Label();
            this.btPDF = new System.Windows.Forms.Button();
            this.lbPDF = new System.Windows.Forms.Label();
            this.dgExtrato = new System.Windows.Forms.DataGridView();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptContagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptsacou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtrato)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptContagem
            // 
            this.ptContagem.BackColor = System.Drawing.Color.Transparent;
            this.ptContagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptContagem.Location = new System.Drawing.Point(403, 63);
            this.ptContagem.Name = "ptContagem";
            this.ptContagem.Size = new System.Drawing.Size(497, 99);
            this.ptContagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptContagem.TabIndex = 0;
            this.ptContagem.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(569, 493);
            this.progressBar1.Maximum = 7;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // ptsacou
            // 
            this.ptsacou.BackColor = System.Drawing.Color.Transparent;
            this.ptsacou.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptsacou.Location = new System.Drawing.Point(402, 179);
            this.ptsacou.Name = "ptsacou";
            this.ptsacou.Size = new System.Drawing.Size(497, 278);
            this.ptsacou.TabIndex = 2;
            this.ptsacou.TabStop = false;
            this.ptsacou.Visible = false;
            // 
            // labelImprimir
            // 
            this.labelImprimir.AutoSize = true;
            this.labelImprimir.BackColor = System.Drawing.Color.Transparent;
            this.labelImprimir.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImprimir.Location = new System.Drawing.Point(101, 61);
            this.labelImprimir.Name = "labelImprimir";
            this.labelImprimir.Size = new System.Drawing.Size(0, 16);
            this.labelImprimir.TabIndex = 3;
            this.labelImprimir.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = global::BANCO.Properties.Resources.exit;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.Location = new System.Drawing.Point(1212, 477);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 77);
            this.btnOk.TabIndex = 4;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnimprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnimprimir.BackgroundImage")));
            this.btnimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnimprimir.Location = new System.Drawing.Point(1074, 477);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(106, 77);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Visible = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnvisualizar.BackgroundImage = global::BANCO.Properties.Resources.visuimpri;
            this.btnvisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnvisualizar.Location = new System.Drawing.Point(936, 477);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(106, 77);
            this.btnvisualizar.TabIndex = 7;
            this.btnvisualizar.UseVisualStyleBackColor = false;
            this.btnvisualizar.Visible = false;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click);
            // 
            // lbvisual
            // 
            this.lbvisual.AutoSize = true;
            this.lbvisual.BackColor = System.Drawing.Color.Transparent;
            this.lbvisual.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvisual.Location = new System.Drawing.Point(921, 456);
            this.lbvisual.Name = "lbvisual";
            this.lbvisual.Size = new System.Drawing.Size(135, 18);
            this.lbvisual.TabIndex = 8;
            this.lbvisual.Text = "Visualizar Impressão";
            this.lbvisual.Visible = false;
            // 
            // lbImprimir
            // 
            this.lbImprimir.AutoSize = true;
            this.lbImprimir.BackColor = System.Drawing.Color.Transparent;
            this.lbImprimir.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImprimir.Location = new System.Drawing.Point(1090, 456);
            this.lbImprimir.Name = "lbImprimir";
            this.lbImprimir.Size = new System.Drawing.Size(62, 18);
            this.lbImprimir.TabIndex = 9;
            this.lbImprimir.Text = "Imprimir";
            this.lbImprimir.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lbexit
            // 
            this.lbexit.AutoSize = true;
            this.lbexit.BackColor = System.Drawing.Color.Transparent;
            this.lbexit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbexit.Location = new System.Drawing.Point(1243, 456);
            this.lbexit.Name = "lbexit";
            this.lbexit.Size = new System.Drawing.Size(31, 18);
            this.lbexit.TabIndex = 10;
            this.lbexit.Text = "Sair";
            this.lbexit.Visible = false;
            // 
            // btPDF
            // 
            this.btPDF.BackColor = System.Drawing.Color.Transparent;
            this.btPDF.BackgroundImage = global::BANCO.Properties.Resources.pdf;
            this.btPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btPDF.Location = new System.Drawing.Point(794, 477);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(106, 77);
            this.btPDF.TabIndex = 11;
            this.btPDF.UseVisualStyleBackColor = false;
            this.btPDF.Visible = false;
            this.btPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPDF
            // 
            this.lbPDF.AutoSize = true;
            this.lbPDF.BackColor = System.Drawing.Color.Transparent;
            this.lbPDF.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPDF.Location = new System.Drawing.Point(811, 456);
            this.lbPDF.Name = "lbPDF";
            this.lbPDF.Size = new System.Drawing.Size(70, 18);
            this.lbPDF.TabIndex = 12;
            this.lbPDF.Text = "Gerar PDF";
            this.lbPDF.Visible = false;
            // 
            // dgExtrato
            // 
            this.dgExtrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgExtrato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgExtrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExtrato.Location = new System.Drawing.Point(1, 1);
            this.dgExtrato.Name = "dgExtrato";
            this.dgExtrato.Size = new System.Drawing.Size(548, 565);
            this.dgExtrato.TabIndex = 13;
            this.dgExtrato.Visible = false;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnEmail.BackgroundImage = global::BANCO.Properties.Resources.email;
            this.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmail.Location = new System.Drawing.Point(652, 477);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(106, 77);
            this.btnEmail.TabIndex = 14;
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Visible = false;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(649, 456);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(110, 18);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Enviar PDF Email";
            this.lbEmail.Visible = false;
            // 
            // frmResulOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BANCO.Properties.Resources.menusaque1;
            this.ClientSize = new System.Drawing.Size(1350, 566);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.dgExtrato);
            this.Controls.Add(this.lbPDF);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.lbexit);
            this.Controls.Add(this.lbImprimir);
            this.Controls.Add(this.lbvisual);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.labelImprimir);
            this.Controls.Add(this.ptsacou);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ptContagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResulOp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResulOp";
            this.Load += new System.EventHandler(this.frmResulOp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptContagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptsacou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgExtrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptContagem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox ptsacou;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelImprimir;
        private System.Windows.Forms.Button btnOk;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Label lbvisual;
        private System.Windows.Forms.Label lbImprimir;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lbexit;
        private System.Windows.Forms.Button btPDF;
        private System.Windows.Forms.Label lbPDF;
        private System.Windows.Forms.DataGridView dgExtrato;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lbEmail;
    }
}