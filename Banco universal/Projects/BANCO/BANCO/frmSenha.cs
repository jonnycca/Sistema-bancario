using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    public partial class frmSenha : Form
    {
        BancoImagens img = new BancoImagens(); // instância do objeto da classe BancoImagens
        ContaBancaria ver = new ContaBancaria(); // instância do objeto da classe ContaBancaria
        Bancooperacoes operacoes = new Bancooperacoes(); // instância do objeto da classe Bancooperacoes
        Image img_Enter;   // Variaveis do tipo imagem para receber as imagens pelo endereco que esta na string de enderecos
        Image img_Corrige;
        string pasta_imagens = "";
        public int contas;
        public decimal valorsaquedep { get; set; }
        public decimal valorsaquedepdes { get; set; }   //Atributos
        public string tipooperacao { get; set; }
        private int contas2 { get; set; }
        public string Nome1 { get; set; }
      

        public frmSenha()
        {
            InitializeComponent();
            img.imagens(14);
            ptdigito.Load(img.imagem);
            pasta_imagens = Application.StartupPath + @"\imagens\";          //Atributo string rebendo o endereco das imagens
            img_Enter = Image.FromFile(pasta_imagens + "Enter.png");         //Variaveis do tipo imagem recebendo as imagens pelos enderecos
            img_Corrige = Image.FromFile(pasta_imagens + "btnCorrige.png");
            btnentra.BackgroundImage = img_Enter;                            // botoes recebendo as variaveis do tipo imagem
            btnCorrige.BackgroundImage = img_Corrige;
            this.valorsaquedepdes = Properties.Settings.Default.ValorSaquedepdest;
            this.valorsaquedep = Properties.Settings.Default.ValoresSaquedep;
            this.contas = Properties.Settings.Default.NroContaGlobal;       //Atributos recebendo valores das Configurações de  Propriedades Global
            this.tipooperacao = Properties.Settings.Default.TipoopGlobal;
            this.contas2 = Properties.Settings.Default.NroContaDesGlobal;
            this.Nome1 = Properties.Settings.Default.NomeGlobal;
            txtSenha.Focus();   //Colocado Foco e Select na Textbox txtSenha
            txtSenha.Select();
            
       
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {                                         //Evento KeyPress do textbox txtSenha
                                                  //aceita apenas números, tecla backspace no textbox txtSenha
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav");// Som ao digitar no textbox txtSenha
            Player.Play();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {                                         // Click no botão anular fecha o form e volta para o form Operações
            DialogResult resultado = MessageBox.Show("Deseja Anular a Operação", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (resultado)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    txtSenha.Text = string.Empty;
                    txtSenha.Focus();
                    break;
            }
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;  // Click no botão corrige limpa o campo txtSenha e coloca foco 
            txtSenha.Focus();
        }



        private void btnentra_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();
                                 // Verifica se o campo esta vazio
            if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("O Campo esta Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
            }
            else
            {                    // Verifica se a senha digitada está correta
                int retorno = ver.verificarsenha(this.contas, Convert.ToInt32(txtSenha.Text));
                if (retorno == Convert.ToInt32(txtSenha.Text))
                {
                    decimal retornou;
                    if (tipooperacao == "SA") // Se o tipo de operação for saque chama o metodo sacar da classe Bancooperacoes
                    {                         // passando o parametro do tipo de operação SA -
                        retornou = operacoes.Sacar(this.contas, this.valorsaquedep, "SA -");
                        Properties.Settings.Default.SaldoGlobal = operacoes.Saldo;
                        if (retornou == -2)
                        {
                            frmResulOp resultado = new frmResulOp();  
                            resultado.ShowDialog();                  //Abre o Form de resultado das operações
                            DialogResult = DialogResult.OK; 

                        }
                        else
                        {                                           // se o retorno for diferente de -2 então o saldo esta indisponivel para esse valor de saque
                            DialogResult resultado = MessageBox.Show("Saldo indisponivel Para Saque", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (resultado == DialogResult.OK)
                                this.Close();
                        }
                    }
                    else if (tipooperacao == "DEP") // Se o tipo de operação for deposito chama o metodo depositar da classe Bancooperacoes
                    {                               // passando o parametro do tipo de operação DEP +
                        retornou = operacoes.depositar(this.contas, this.valorsaquedep, "DEP +");
                        Properties.Settings.Default.SaldoGlobal = operacoes.Saldo;
                        if (retornou == -3)
                        {
                            frmResulOp resultado = new frmResulOp();
                            resultado.ShowDialog();                  //Abre o Form de resultado das operações
                            DialogResult = DialogResult.OK;
                        }

                    }
                    else if (tipooperacao == "TR") // Se o tipo de operação for transferência chama o metodo depositar e sacar 
                    {                              // passando o parametro do tipo de operação TR + e TR-
                        operacoes.depositar(this.contas2, this.valorsaquedepdes, "TR +");                       
                        operacoes.Sacar(this.contas, this.valorsaquedep, "TR -");
                        Properties.Settings.Default.SaldoGlobal = operacoes.Saldo;
                        frmResulOp resultado = new frmResulOp();
                        resultado.ShowDialog();                      //Abre o Form de resultado das operações
                        DialogResult = DialogResult.OK;
                    }
                    else if (tipooperacao == "SALDO") // Se o tipo de operação for Saldo chama o metodo mostrasaldo para colocar o valor 
                    {                                 // nas  Configurações de  Propriedades Global SaldoGlobal
                        Properties.Settings.Default.SaldoGlobal = operacoes.mostrasaldo(this.contas);
                        frmResulOp resultado = new frmResulOp();
                        resultado.ShowDialog();                      //Abre o Form de resultado das operações
                        DialogResult = DialogResult.OK;

                    }
                    else if(tipooperacao == "EXTRA") // Se o tipo de operação for Extrato apenas abre o Form de resultado das operações
                    {
                        frmResulOp resultado = new frmResulOp();
                        resultado.ShowDialog();
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {                                    // Se não a senha esta incorreta
                    MessageBox.Show("Senha Incorreta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Text = string.Empty;
                    txtSenha.Focus();
                }
            }
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            txtSenha.PasswordChar = '*';  //Mascarar a semha com *
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                btnentra_Click(this, new EventArgs()); // Se apertar enter chama o evento Click do botao entra
            } 
        }
    }
}
