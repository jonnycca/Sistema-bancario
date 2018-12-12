using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;


namespace BANCO
{
    public partial class frmResulOp : Form
    {
        Bancooperacoes extra = new Bancooperacoes(); // instância do objeto da classe Bancooperacoes
        BancoImagens img = new BancoImagens();       // instância do objeto da classe BancoImagens
        ContaBancaria Objemail = new ContaBancaria();// instância do objeto da classe ContaBancaria
        private StringReader leitor;   // leitor para visualização e impressão de string
        public string TodoResultado { get; set; }
        public string Tipooperacoes { get; set; }
        public int ContaTrans { get; set; }
        public int conta { get; set; }               //Atributos
        public int digi { get; set; }
        public decimal valorsaque { get; set; }
        public string nome { get; set; }
        public decimal valorsaldo { get; set; }
        public string NomeTrans { get; set; }
        public int DigiTrans { get; set; }
        public int Contaextra { get; set; }
        public frmResulOp()
        {
            InitializeComponent();
            this.conta = Properties.Settings.Default.NroContaGlobal;
            this.digi = Properties.Settings.Default.NroDigitoGlobal;
            this.valorsaque = Properties.Settings.Default.ValoresSaquedep;
            this.nome = Properties.Settings.Default.NomeGlobal;              //Atributos recebendo valores das Configurações de  Propriedades Global
            this.valorsaldo = Properties.Settings.Default.SaldoGlobal;
            this.ContaTrans = Properties.Settings.Default.NroContaDesGlobal;
            this.Tipooperacoes = Properties.Settings.Default.TipoopGlobal;
            this.NomeTrans = Properties.Settings.Default.Nome2Global;
            this.DigiTrans = Properties.Settings.Default.NroDigito2Global;

            if (this.Tipooperacoes == "TR") // Se o tipo de operarção for transferência então o atributo todo resultado 
            {                               // do tipo string recebe todos valores das duas contas
                this.TodoResultado = "         Auto Atendimento\n" +
                                 "        Recibo da Operação\n" +
                                 "   Data: " + DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR")) + "   Hora: " + DateTime.Now.ToString("HH:mm", CultureInfo.CreateSpecificCulture("pt-BR")) + "\n\n\n" +
                                 "   Numero da Conta Origem: " + Convert.ToString(this.conta) + " - " + this.digi + "\n" +
                                 "   Valor da Operação: " + Convert.ToString(this.valorsaque) + "\n" +
                                 "   Saldo Atual da Conta: " + Convert.ToString(this.valorsaldo) + "\n" +
                                 "   Nome do Emitente: " + this.nome + "\n\n\n" +
                                 "   Numero da Conta Destino: " + this.ContaTrans + " - " + this.DigiTrans + "\n" +
                                 "   Nome do Destinatário: " + this.NomeTrans + "\n\n\n";
            }
            else
            {
                // Se o tipo de operarção for diferente de transferência então o atributo todo resultado 
                // do tipo string recebe todos valores da conta em operação
                this.TodoResultado = "         Auto Atendimento\n" +
                                 "        Recibo da Operação\n" +
                                 "   Data: " + DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.CreateSpecificCulture("pt-BR")) + "   Hora: " + DateTime.Now.ToString("HH:mm", CultureInfo.CreateSpecificCulture("pt-BR")) + "\n\n\n" +
                                 "   Numero da Conta: " + Convert.ToString(this.conta) + " - " + this.digi + "\n" +
                                 "   Valor da Operação: " + Convert.ToString(this.valorsaque) + "\n" +
                                 "   Saldo Atual da Conta: " + Convert.ToString(this.valorsaldo) + "\n" +
                                 "   Titular da Conta: " + this.nome + "\n\n\n";

                // Se o tipo de operação for saque e o progressbar for igual a 0 então chama o som de contagem do caixa
                if ((this.Tipooperacoes == "SA") && (progressBar1.Value == 0))
                {
                    System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Contagem.wav");
                    Player.Play();
                }
                // Se o tipo de operação for deposito e o progressbar for igual a 0 então chama o som de deposito do caixa
                else if ((this.Tipooperacoes == "DEP") && (progressBar1.Value == 0))
                {
                    System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Somdeposito.wav");
                    Player.Play();
                }

            }
        }

        private void frmResulOp_Load(object sender, EventArgs e)
        {
            // Se o tipo de operação for saque carrega a imagem de operação de saque com ID 12
            if (this.Tipooperacoes == "SA")
            {
                img.imagens(12);
                ptContagem.Load(img.imagem);

            }
            // Se o tipo de operação for deposito carrega a imagem de operação de deposito com ID 16
            else if (this.Tipooperacoes == "DEP")
            {
                img.imagens(16);
                ptContagem.Load(img.imagem);

            }
            // Se o tipo de operação for Saldo a labelImprimir recebe a string todo resultado e torna visivel
            else if (this.Tipooperacoes == "SALDO")
            {
                labelImprimir.Text = this.TodoResultado + "\n" + "        Tipo de Operação SALDO" + "\n  **********************************";
                labelImprimir.Visible = true;

                //Se desejar imprimir e a resposta for sim vão se tornar visiveis todos os botões e label de gerar PDF, Enviar PDF Email, Sair, Imprimir
                // Visualizar impressão
                DialogResult resultado = MessageBox.Show("Deseja Imprimir o recibo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        btnOk.Visible = true;
                        lbvisual.Visible = true;
                        lbImprimir.Visible = true;
                        lbexit.Visible = true;
                        btnvisualizar.Visible = true;
                        btnimprimir.Visible = true;
                        btPDF.Visible = true;
                        lbPDF.Visible = true;
                        btnEmail.Visible = true;
                        lbEmail.Visible = true;
                        break;
                    case DialogResult.No:  // Se não só se tornara visivel a label imprimir e a label exit e o botão Sair
                        labelImprimir.Visible = true;
                        lbexit.Visible = true;
                        btnOk.Visible = true;
                        break;
                }


            }
            // Se o tipo de operação for Extrato então habilitamos a visibilidade do Datagrid dgExtrato
            // e chamamos o metodo Extrato da classe operações que nos retorna um data table com os valores das colunas
            // e tambem chamamos o metodo Extratotodo para colocar todo extrato em uma string para fazer o recibo em PDF
            else if (this.Tipooperacoes == "EXTRA")
            {
                ptsacou.Visible = false;

                DataTable ext = extra.Extrato(this.conta);
                string ex = extra.Extratotodo(this.conta);
                dgExtrato.DefaultCellStyle.Font = new System.Drawing.Font("COURIER", 9);
                dgExtrato.CellBorderStyle = DataGridViewCellBorderStyle.None;
                dgExtrato.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Mudando estilo do Datagrid
                dgExtrato.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgExtrato.Visible = true;
                dgExtrato.DataSource = ext;

                // Se desejar imprimir e a resposta for sim vão se tornar visiveis todos os botões e label de gerar PDF, Enviar PDF Email, Sair, Imprimir
                // Visualizar impressão
                DialogResult resultado = MessageBox.Show("Deseja Ver o Extrato", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (resultado)
                {
                    case DialogResult.Yes:
                        btnOk.Visible = true;
                        lbvisual.Visible = true;
                        labelImprimir.Text = this.TodoResultado + "\n" + ex + "\n" + "        Tipo de Operação EXTRATO" + "\n  **********************************";
                        lbImprimir.Visible = true;
                        lbexit.Visible = true;
                        btnvisualizar.Visible = true;
                        btnimprimir.Visible = true;
                        btPDF.Visible = true;
                        lbPDF.Visible = true;
                        btnEmail.Visible = true;
                        lbEmail.Visible = true;
                        break;
                    case DialogResult.No:           // Se não só se tornara visivel a label imprimir e a label exit e o botão Sair
                        labelImprimir.Visible = true;
                        lbexit.Visible = true;
                        btnOk.Visible = true;
                        break;
                }


            }
            // Se o tipo de operação for Transferência carrega a imagem de operação de Transferência com ID 17
            else if (this.Tipooperacoes == "TR")
            {
                img.imagens(17);
                ptContagem.Load(img.imagem);
            }


        }

        // Esse timer foi colocado para apresentar as opções de acordo com termino dos audios e apresentacoes de imagens
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 7)
            {
                progressBar1.Value += 1;
            }
            else
            {
                ptContagem.Visible = false;
                ptsacou.Visible = true;
                timer1.Enabled = false;
                // Se o tipo de operação for saque então ptsacou vai carregar a imagem com ID 13 e uma mensagem logo apos se vai querer 
                // imprimir
                if (this.Tipooperacoes == "SA")
                {
                    img.imagens(13);
                    ptsacou.Load(img.imagem);
                    //Se desejar imprimir e a resposta for sim vão se tornar visiveis todos os botões e label de gerar PDF, Enviar PDF Email, Sair, Imprimir
                    // Visualizar impressão e vai desabilitar a visualização da imagem ptsacou
                    DialogResult resultado = MessageBox.Show("Deseja Imprimir o recibo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (resultado)
                    {
                        case DialogResult.Yes:
                            ptsacou.Visible = false;
                            img.imagens(15);

                            //Concatenação da string todo  resultado mais texto para ser recebido pela labelImprimir
                            labelImprimir.Text = this.TodoResultado + "\n" + "        Tipo de Operação SAQUE" + "\n   ********************************";
                            labelImprimir.Visible = true;
                            lbvisual.Visible = true;
                            lbImprimir.Visible = true;
                            lbexit.Visible = true;
                            btnvisualizar.Visible = true;
                            btnimprimir.Visible = true;
                            btnOk.Visible = true;
                            btPDF.Visible = true;
                            lbPDF.Visible = true;
                            btnEmail.Visible = true;
                            lbEmail.Visible = true;
                            break;
                        case DialogResult.No:
                            labelImprimir.Visible = true;  // Se não só se tornara visivel a label imprimir e a label exit e o botão Sair
                            lbexit.Visible = true;
                            btnOk.Visible = true;
                            break;
                    }
                }
                // Se o tipo de operação for deposito então ptsacou vai ser desabilitado sua visualização 
                // e uma mensagem logo apos se vai querer imprimir
                else if (this.Tipooperacoes == "DEP")
                {
                    ptsacou.Visible = false;
                    //Se desejar imprimir e a resposta for sim vão se tornar visiveis todos os botões e label de gerar PDF, Enviar PDF Email, Sair, Imprimir
                    // Visualizar impressão e vai desabilitar a visualização da imagem ptsacou
                    DialogResult resultado = MessageBox.Show("Deseja Imprimir o recibo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (resultado)
                    {
                        case DialogResult.Yes:
                            ptsacou.Visible = false;
                            img.imagens(15);
                            lbvisual.Visible = true;
                            lbImprimir.Visible = true;
                            lbexit.Visible = true;
                            btnvisualizar.Visible = true;
                            btnimprimir.Visible = true;
                            labelImprimir.Text = this.TodoResultado + "\n" + "      Tipo de Operação DEPÓSITO" + "\n  *********************************";
                            labelImprimir.Visible = true;
                            btnOk.Visible = true;
                            btPDF.Visible = true;
                            lbPDF.Visible = true;
                            btnEmail.Visible = true;
                            lbEmail.Visible = true;
                            break;
                        case DialogResult.No:
                            labelImprimir.Visible = true; // Se não só se tornara visivel a label imprimir e a label exit e o botão Sair
                            lbexit.Visible = true;
                            btnOk.Visible = true;
                            break;
                    }
                }
                // Se o tipo de operação for Transferência então uma mensagem vai aparecer perguntando para impressão se sim ou não  
                // e 
                else if (this.Tipooperacoes == "TR")
                {
                    ptsacou.Visible = false;
                    //Se desejar imprimir e a resposta for sim vão se tornar visiveis todos os botões e label de gerar PDF, Enviar PDF Email, Sair, Imprimir
                    // Visualizar impressão e vai desabilitar a visualização da imagem ptsacou
                    DialogResult resultado = MessageBox.Show("Deseja Imprimir o recibo", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    switch (resultado)
                    {
                        case DialogResult.Yes:
                            ptsacou.Visible = false;
                            img.imagens(15);
                            lbvisual.Visible = true;
                            lbImprimir.Visible = true;
                            lbexit.Visible = true;
                            btnvisualizar.Visible = true;
                            btnimprimir.Visible = true;
                            labelImprimir.Text = this.TodoResultado + "   Tipo de Operação TRANSFERÊNCIA" + "\n  *********************************";
                            labelImprimir.Visible = true;
                            btnOk.Visible = true;
                            btPDF.Visible = true;
                            lbPDF.Visible = true;
                            btnEmail.Visible = true;
                            lbEmail.Visible = true;
                            break;
                        case DialogResult.No:
                            labelImprimir.Visible = true;
                            lbexit.Visible = true;
                            btnOk.Visible = true;
                            break;
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Evento Click do botão Sair 
            DialogResult resultado = MessageBox.Show("Deseja Realizar Outra Operação", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (resultado)
            {
                case DialogResult.Yes:

                    this.Close();   // Se a resposta for sim do DialogResult então vai fechar o form e voltar nas operações se o tempo não tiver acabado
                    break;
                case DialogResult.No:
                    Application.Exit(); // Se a resposta for não do DialogResult então vai fechar toda a aplicação
                    break;
            }
        }

        // Metodo para a impressao do recibo
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //variaveis usadas para definir as configurações da impressão
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            System.Drawing.Font fonteImpressao = this.labelImprimir.Font;
            SolidBrush mCaneta = new SolidBrush(Color.Black);
            // Imagem colocada no recibo no ponto (140,10)
            e.Graphics.DrawImage(System.Drawing.Image.FromFile(Application.StartupPath + @"\imagens\recibo.png"), new Point(140, 10));
            // Define o numero de linhas por pagina, usando MarginBounds.
            linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

            // Itera sobre a string usando StringReader, imprimindo cada linha
            while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            {
                // calcula a posicao da proxima linha baseada
                // na altura da fonte de acordo com o dispositivo de impressão
                yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));

                // desenha a proxima linha 
                e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
                contador++;
            }
            // Verifica se existe mais linhas para imprimir
            if (linha != null)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

            //libera recursos		
            mCaneta.Dispose();
        }

        // Click do botão imprimir passa a labelImprimir para o leitor do tipo StringReader e faz um print no documento 
        private void btnimprimir_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            leitor = new StringReader(this.labelImprimir.Text);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        // Click do botão para visualizar a impressão no PrintPreviewDialog
        private void btnvisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                leitor = new StringReader(this.labelImprimir.Text);//passando a labelImprimir para o leitor do tipo StringReader
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.ClientSize = new System.Drawing.Size(1366, 566);// Tamanho do PrintPreviewDialog
                printPreviewDialog1.Document = this.printDocument1;  // PrintPreviewDialog recebendo o documento
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.None; // PrintPreviewDialog sem borda
                printPreviewDialog1.FindForm().StartPosition = FormStartPosition.CenterScreen; // PrintPreviewDialog no centro da tela
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Erro : " + exp.Message.ToString());
            }
        }
        // Click do botão de GerarPDF
        private void button1_Click(object sender, EventArgs e)
        {

            // Variavel do Nome e caminho do arquivo

            string vArq = "";

            // Abre janela para usuário escolher a pasta onde o arquivo será gerado

            FolderBrowserDialog vSalvar = new FolderBrowserDialog();

            // Verifica se o usuário clicou em ok ou cancelar na janela de seleção da pasta

            if (vSalvar.ShowDialog() == DialogResult.Cancel)

                return; // Cancela todo processo

            // Insere na variavel o caminho selecionado pelo usuário e concatena com o nome do arquivo
            string geracod = Convert.ToString(DateTime.Now.Day + "" + DateTime.Now.Month + "" + DateTime.Now.Year + "" + DateTime.Now.Hour + "" + DateTime.Now.Minute + "" + DateTime.Now.Second);

            vArq = vSalvar.SelectedPath + "\\" + ("Recibo") + " " + geracod.Trim() + ".pdf";
            try

            {  // Chamando o metodo GerarPDF e passando o caminho como parâmetro
                GerarPDF(vArq);
                MessageBox.Show("Arquivo Gerado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro ao Gerar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        // metodo de GerarPDF
        private void GerarPDF(string Pcaminho)
        {
            Document documento = new Document(); //Instanciando um ojeto do tipo documento
            //Escrevendo o documento e seu caminho
            PdfWriter.GetInstance(documento, new FileStream(Pcaminho, FileMode.Create, FileAccess.Write, FileShare.Delete));
            // Criando o tipo de fonte que ira usar no PDF
            iTextSharp.text.Font contentFont = iTextSharp.text.FontFactory.GetFont("COURIER", 10, iTextSharp.text.Font.NORMAL);
            try
            {
                // O paragrafo recebendo a labelImprimir e a fonte criada anteriormente
                Paragraph p = new Paragraph(this.labelImprimir.Text, contentFont);
                documento.Open();
                // Colocado a imagem do logo tambem no documento
                var image = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\imagens\recibo.png");
                image.SetAbsolutePosition(60, 805);  // Localização da imgem em uma folha A4

                image.ScaleToFit(150, 40);  // Tamanho que a imagem vai ter no documento
                documento.Add(image); //Adicionando a imagem ao documento
                documento.Add(p); //Adicionando o paragrafo ao documento
                documento.Close(); // Fechando o documento
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);

            }
        }
        // Click para o envio de email
        private void btnEmail_Click(object sender, EventArgs e)
        {   
            
            string email = Objemail.verificaremail(this.conta); //recebendo email pelo metodo verificaremail

            // Gerador de numero para o recibo nunca ser igual ao outro
            string geracod = Convert.ToString(DateTime.Now.Day + "" + DateTime.Now.Month + "" + DateTime.Now.Year + "" + DateTime.Now.Hour + "" + DateTime.Now.Minute + "" + DateTime.Now.Second);

            Document documento = new Document();//Instanciando um ojeto do tipo documento
            MemoryStream memoryStream = new MemoryStream();//Instanciando um ojeto do tipo MemoryStream
            PdfWriter writer = PdfWriter.GetInstance(documento, memoryStream);//escrevendo o documento na memoria

            // Criando o tipo de fonte que ira usar no PDF
            iTextSharp.text.Font contentFont = iTextSharp.text.FontFactory.GetFont("COURIER", 10, iTextSharp.text.Font.NORMAL);

            // O paragrafo recebendo a labelImprimir e a fonte criada anteriormente
            Paragraph p = new Paragraph(this.labelImprimir.Text, contentFont);//Co
            documento.Open();// Abrindo o documento

            // Colocado a imagem do logo tambem no documento
            var image = iTextSharp.text.Image.GetInstance(Application.StartupPath + @"\imagens\recibo.png");

            image.SetAbsolutePosition(60, 805);  // Localização da imgem em uma folha A4
            image.ScaleToFit(150, 40);  // Tamanho que a imagem vai ter no documento
            documento.Add(image); //Adicionando a imagem ao documento
            documento.Add(p);//Adicionando o paragrafo ao documento
            writer.CloseStream = false;
            documento.Close(); // Fechando o documento
            memoryStream.Position = 0; //define a posição atual dentro do fluxo

            try
            {

                using (SmtpClient cliente = new SmtpClient("mail.odeliojr.com")) //endereco do servidor
                {
                    MailMessage Message = new MailMessage();//Instanciando um ojeto do tipo MailMessage
                    Message.From = new MailAddress("cassiano@odeliojr.com", "Banco Universal");//email que vai enviar e nome
                    Message.To.Add(email);
                    Message.IsBodyHtml = true;
                                                           //Colocando mensagem e imagem no corpo
                    Message.Body = "<p><img src = 'http://i.imgur.com/Gkfk8yN.png' ></p><p> Você acaba de receber um recibo bancário realizado pelo Universal Bank Caixa </p>";
                    Message.Subject = "Recibo"; // Assunto do email
                    Message.Attachments.Add(new Attachment(memoryStream, "Recibo " + geracod + ".pdf"));//Anexando o recibo com nome e extensão
                    cliente.EnableSsl = true; //usando o protocolo SSL para criptografar a conexão
                    cliente.Credentials = new System.Net.NetworkCredential("cassiano@odeliojr.com", "Cassiano.@!");// Usuario e senha
                    cliente.Port = 587; //Porta
                    cliente.Send(Message); // Enviando mensagem
                }
                MessageBox.Show("Arquivo enviado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)

            {

                MessageBox.Show("Erro ao enviar arquivo !!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
