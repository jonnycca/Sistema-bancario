using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    public partial class frmoperacoes : Form
    {
        BancoImagens img = new BancoImagens();  // instância do objeto da classe BancoImagens
        string pasta_imagens = "";             // String para pegar os enderecos das imagens            
        private string nomes { get; set; }
        Image img_normalsaldo;
        Image img_disabledsaldo;
        Image img_normalextrato;
        Image img_disabledextrato;
        Image img_normalsaque;
        Image img_disabledsaque;     // Variaveis do tipo imagem para receber as imagens pelo endereco que esta na string de enderecos
        Image img_normaldeposito;
        Image img_disableddeposito;
        Image img_normaltrans;
        Image img_disabledtrans;
        Image img_normalencerrar;
        Image img_disabledencerrar;
        int segundos = 59;
        int minutos = 4;

        public frmoperacoes()
        {
            InitializeComponent();         
            int horas = DateTime.Now.Hour;  //Variavel para pegar hora do Computador
            int minutos2 = DateTime.Now.Minute; //Variavel para pegar Minustos do Computador

            txtcronometro.Text = "Tempo Restante:  " + minutos.ToString("00") + ":" + segundos.ToString("00");

            
            this.nomes = Properties.Settings.Default.NomeGlobal;        //Atributo recebendo nome das Configurações de  Propriedades Global Nome



            if ((horas >= 00) && (horas < 12))
                lbNome.Text = "Bom Dia " + this.nomes;   
            else if ((horas >= 12) && (horas < 18))       //Usado para apresentar o nome da pessoa em conjunto com Bom Dia
                lbNome.Text = "Boa Tarde " + this.nomes;  // Boa Tarde ou Boa Noite
            else
                lbNome.Text = "Boa Noite " + this.nomes;

            pasta_imagens = Application.StartupPath + @"\imagens\";  //Atributo string rebendo o endereco das imagens
            img_normalsaldo = Image.FromFile(pasta_imagens + "btn_normalsaldo.png");
            img_disabledsaldo = Image.FromFile(pasta_imagens + "btn_highsaldo.png");
            img_normalextrato = Image.FromFile(pasta_imagens + "btn_normalextrato.png");
            img_disabledextrato = Image.FromFile(pasta_imagens + "btn_highextrato.png");
            img_normalsaque = Image.FromFile(pasta_imagens + "btn_normalsaque.png");      //Variaveis do tipo imagem recebendo as imagens pelos enderecos
            img_disabledsaque = Image.FromFile(pasta_imagens + "btn_highsaque.png");
            img_normaldeposito = Image.FromFile(pasta_imagens + "btn_normaldeposito.png");
            img_disableddeposito = Image.FromFile(pasta_imagens + "btn_highdeposito.png");
            img_normaltrans = Image.FromFile(pasta_imagens + "btn_normaltrans.png");
            img_disabledtrans = Image.FromFile(pasta_imagens + "btn_hightrans.png");
            img_normalencerrar = Image.FromFile(pasta_imagens + "btn_normalencerrar.png");
            img_disabledencerrar = Image.FromFile(pasta_imagens + "btn_highencerrar.png");
            btnsaldo.BackgroundImage = img_normalsaldo;
            btnextrato.BackgroundImage = img_normalextrato;
            btnsaque.BackgroundImage = img_normalsaque;
            btndeposito.BackgroundImage = img_normaldeposito; // botoes recebendo as variaveis do tipo imagem
            btntrans.BackgroundImage = img_normaltrans;
            btnencerrar.BackgroundImage = img_normalencerrar;
            img.imagens(11);   //logo carregando a imagem do endereco que esta no BD com ID 11
            logo.Load(img.imagem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {                                                   //Timer para um intervalo de 1000 milésimos de segundo
            segundos--;                                     // ou seja a cada 1 segundo de intervalo Decrescenta 1 na variavel segundos
            if ((minutos == 0) && (segundos == 6))      
            {
                timer2.Enabled = true;          // quando for 0 minutos e 6 segundos o timer2 é habilitado
            }
            if (segundos == 00)
            {
                minutos--;
                segundos = 59;
            }
            txtcronometro.Text = "Tempo Restante:  " + minutos.ToString("00") + ":" + segundos.ToString("00");
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)         // A progressbar comeca com valor 5 enquanto for maior que 0 decrementa 1 a cada 1 segundo
            {

                progressBar1.Value = progressBar1.Value - 1;
            }

            else
            {                    // se não for maior que 0 então o form operacoes fecha e volta ao form principal caso não esteja no 
                this.Close();    // meio de uma operação
            }
        }

        private void btnsaque_MouseEnter(object sender, EventArgs e)
        {
            btnsaque.BackgroundImage = img_disabledsaque;   // Se colocar o mouse em cima do botão saque ele carrega a imagem high
        }

        private void btnsaque_MouseLeave(object sender, EventArgs e)
        {
            btnsaque.BackgroundImage = img_normalsaque;  // Se tirar o mouse de cima do botão saque ele carrega a imagem normal
        }

        private void btnsaldo_MouseEnter(object sender, EventArgs e)
        {
            btnsaldo.BackgroundImage = img_disabledsaldo;   // Se colocar o mouse em cima do botão saldo ele carrega a imagem high
        }

        private void btnsaldo_MouseLeave(object sender, EventArgs e)
        {
            btnsaldo.BackgroundImage = img_normalsaldo;   // Se tirar o mouse de cima do botão saldo ele carrega a imagem normal
        }

        private void btndeposito_MouseEnter(object sender, EventArgs e)
        {
            btndeposito.BackgroundImage = img_disableddeposito;  // Se colocar o mouse em cima do botão deposito ele carrega a imagem high
        }

        private void btndeposito_MouseLeave(object sender, EventArgs e)
        {
            btndeposito.BackgroundImage = img_normaldeposito;   // Se tirar o mouse de cima do botão deposito ele carrega a imagem normal
        }

        private void btnextrato_MouseEnter(object sender, EventArgs e)
        {
            btnextrato.BackgroundImage = img_disabledextrato;   // Se colocar o mouse em cima do botão extrato ele carrega a imagem high
        }

        private void btnextrato_MouseLeave(object sender, EventArgs e)
        {
            btnextrato.BackgroundImage = img_normalextrato;   // Se tirar o mouse de cima do botão extrato ele carrega a imagem normal
        }

        private void btntrans_MouseEnter(object sender, EventArgs e)
        {
            btntrans.BackgroundImage = img_disabledtrans;  // Se colocar o mouse em cima do botão transferência ele carrega a imagem high
        }

        private void btntrans_MouseLeave(object sender, EventArgs e)
        {
            btntrans.BackgroundImage = img_normaltrans;  // Se tirar o mouse de cima do botão transferência ele carrega a imagem normal
        }

        private void btnencerrar_MouseEnter(object sender, EventArgs e)
        {
            btnencerrar.BackgroundImage = img_disabledencerrar; // Se colocar o mouse em cima do botão encerrar ele carrega a imagem high
        }

        private void btnencerrar_MouseLeave(object sender, EventArgs e)
        {
            btnencerrar.BackgroundImage = img_normalencerrar;   // Se tirar o mouse de cima do botão encerrar ele carrega a imagem normal
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja mesmo Encerrar", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (resultado)
            {
                case DialogResult.Yes:
                    this.Close();   // Click no botão encerrar fecha o form e volta no principal
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnsaldo_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.TipoopGlobal = "SALDO";   // Variavel Global Tipo recebendo o tipo de operação   
            frmSenha mostrarsaldo = new frmSenha();               // Click no botão saldo chama o formulario de senha
            mostrarsaldo.ShowDialog();
            //this.Close();

        }

        private void btnsaque_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.TipoopGlobal = "SA"; // Variavel Global Tipo recebendo o tipo de operação   
            frmSaque novo = new frmSaque();                  // Click no botão saque chama o formulario de saque
            novo.ShowDialog();
            //this.Close();
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.TipoopGlobal = "DEP"; // Variavel Global Tipo recebendo o tipo de operação   
            frmDeposito novo = new frmDeposito();             // Click no botão deposito chama o formulario de deposito
            novo.ShowDialog();
            //this.Close();
        }

        private void btntrans_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.TipoopGlobal = "TR"; // Variavel Global Tipo recebendo o tipo de operação   
            frmTranferencia novo = new frmTranferencia();    // Click no botão transferência chama o formulario de transferência
            novo.ShowDialog();
            //this.Close();
        }

        private void btnextrato_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();     
            Properties.Settings.Default.TipoopGlobal = "EXTRA"; // Variavel Global Tipo recebendo o tipo de operação   
            frmSenha mostrarsaldo = new frmSenha();             // Click no botão extrato chama o formulario de senha
            mostrarsaldo.ShowDialog();
            // this.Close();
        }
    }
}
