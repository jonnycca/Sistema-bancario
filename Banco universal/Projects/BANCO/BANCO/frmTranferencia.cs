using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    public partial class frmTranferencia : Form
    {
        ContaBancaria veri = new ContaBancaria(); // instância do objeto da classe ContaBancaria
        string pasta_imagens = "";
        Image img_Enter;          // Variaveis do tipo imagem para receber as imagens pelo endereco que esta na string de enderecos
        Image img_Corrige;
        public int contas { get; set; }
        public int digitos { get; set; }  //Atributos
        public string nomes { get; set; }
        public decimal saldos { get; set; }
        public frmTranferencia()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\"; //Atributo string rebendo o endereco das imagens
            img_Enter = Image.FromFile(pasta_imagens + "Enter.png");
            img_Corrige = Image.FromFile(pasta_imagens + "btnCorrige.png"); //Variaveis do tipo imagem recebendo as imagens pelos enderecos
            btnEntra.BackgroundImage = img_Enter;      // botoes recebendo as variaveis do tipo imagem
            btnCorrige.BackgroundImage = img_Corrige;
            this.contas = Properties.Settings.Default.NroContaGlobal;
            this.digitos = Properties.Settings.Default.NroDigitoGlobal;
            this.nomes = Properties.Settings.Default.NomeGlobal;   //Atributos recebendo valores das Configurações de  Propriedades Global da conta Emitente
            this.saldos = Properties.Settings.Default.SaldoGlobal;
            txtConta.Text = Convert.ToString(this.contas);
            txtDigito.Text = Convert.ToString(this.digitos);
            lbvalorsaldo.Text = "R$" + Convert.ToString(this.saldos);
            lbNome.Text = this.nomes;    // Label lbNome recebendo o nome da conta emitente
            txtConta.Enabled = false;    // Desabilitando txtConta e txtDigito da Conta emitente
            txtDigito.Enabled = false;
            txContadestino.Focus();   //Colocado Foco e Select na Textbox txtContadestino
            txContadestino.Select();
        }

        private void txtTrans_KeyPress(object sender, KeyPressEventArgs e)
        {                                                   // Evento KeyPress do textbox txtTrans
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtTrans.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav");// Som ao digitar no textbox txtTrans
            Player.Play();
        }

        private void txtTrans_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntra_Click(this, new EventArgs());   // Se apertar enter chama o evento Click do botao entra
            }
        }

        private void txContadestino_KeyPress(object sender, KeyPressEventArgs e)
        {                                                   //Evento KeyPress do txContadestino
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;  //aceita apenas números, tecla backspace no textbox txContadestino

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
        }

        private void txContadestino_TextChanged(object sender, EventArgs e)
        {
            if (txContadestino.Text.Length == 2)
            {                               // Como a conta so possui dois digitos automaticamente após digitar dois digitos
                SendKeys.Send("{Tab}");     // da um Tab Automatico e vai para o digito
            }
        }

        private void txDigitodestino_TextChanged(object sender, EventArgs e)
        {
            if (txDigitodestino.Text.Length == 1)
            {                               // Como o Digito so possui um caracter numero, automaticamente após digitar
                SendKeys.Send("{Tab}");     // da um Tab Automatico e vai para o Entra
            }
        }

        private void btnEntra_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();                                // Verifica se os campos estão vazios
            if ((txContadestino.Text == string.Empty) || (txDigitodestino.Text == string.Empty) || (txtTrans.Text == string.Empty))
                MessageBox.Show("Não foi Digitado Valores em um dos Campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                          // Verifica se o valor de transferência não e maior que o saldo do emitente
            else if (Convert.ToDecimal(txtTrans.Text) > this.saldos)
            {
                MessageBox.Show("Valor da Transferência Maior que o Saldo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTrans.Text = string.Empty;
                txtTrans.Focus();
            } 
                                                           // Verifica se o numero da conta digitada é igual a do emitente             
            else if (txtConta.Text == txContadestino.Text)
                MessageBox.Show("Conta de Origem e Destino São Iguais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                                                           // Verifica se a conta existe
                int foiveri = veri.verificar(Convert.ToInt32(txContadestino.Text), Convert.ToInt32(txDigitodestino.Text));
                if (foiveri == -1)
                {
                    MessageBox.Show("Conta Destino Inexistente ou Digito Conta Destino Invalido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txContadestino.Text = string.Empty;
                    txDigitodestino.Text = string.Empty;
                    txContadestino.Focus();
                }
                else
                {
                       // Se passou por todas verificações então tira a visibilidade de tudo que esta na tela e coloca e habilita a visiblidade de uma label com
                       // todos os dados do emitente e destinatário
                    lbDados.Text = "Conta Origem: " + txtConta.Text + "  Digito: " + this.digitos + "\nSaldo Atual: R$" + this.saldos + "\nValor da Transferência (R$): " + txtTrans.Text +
                        "\nTitular Origem: " + this.nomes + "\n\n\n\n" + "\nConta Destino: " + txContadestino.Text + "  Digito: " + txDigitodestino.Text + "\nTitular Destino: " + veri.nomeusu;
                    txtTrans.Visible = false; 
                    lborigem.Visible = false;
                    lbnconta.Visible = false;
                    lbaSaldo.Visible = false;              
                    lbContadestino.Visible = false;
                    lbvalor.Visible = false;
                    txtDigito.Visible = false;
                    txtConta.Visible = false;
                    txDigitodestino.Visible = false;
                    txContadestino.Visible = false;
                    lbNome.Visible = false;
                    lbvalorsaldo.Visible = false;               
                    lbconfirma.Visible = false;
                    lbnconta.Visible = false;
                    lbvalor.Visible = false;
                    btnCorrige.Visible = false;
                    btnEntra.Visible = false;
                    lbConfira.Visible = true;
                    lbDados.Visible = true;
                    btnConfirma.BackgroundImage = img_Enter;
                    btnConfirma.Visible = true;
                    Properties.Settings.Default.NroContaDesGlobal = Convert.ToInt32(txContadestino.Text);
                    Properties.Settings.Default.Nome2Global = veri.nomeusu;
                    Properties.Settings.Default.NroDigito2Global = Convert.ToInt32(txDigitodestino.Text); // Configurações de  Propriedades Global da conta destino 
                    Properties.Settings.Default.NroDigito2Global = Convert.ToInt32(txDigitodestino.Text); // recebendo valores da conta destino
                    Properties.Settings.Default.ValorSaquedepdest = Convert.ToDecimal(txtTrans.Text);
                    Properties.Settings.Default.ValoresSaquedep = Convert.ToDecimal(txtTrans.Text);
                }
            }

        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txContadestino.Text = string.Empty;
            txDigitodestino.Text = string.Empty; // Click no botão corrige limpa todos os campos e coloca foco no txtContadestino
            txtTrans.Text = string.Empty;
            txContadestino.Focus();
        }

        private void btnanula_Click(object sender, EventArgs e)
        {                                       // Click no botão anular fecha o form e volta para o form Operações
            DialogResult resultado = MessageBox.Show("Deseja Anular a Operação", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (resultado)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();         
            
            frmSenha verifica = new frmSenha(); // Click do botão entra chama o form de verificação de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void txDigitodestino_KeyPress(object sender, KeyPressEventArgs e)
        {                                   // Evento KeyPress do textBox txDigitodestino
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;   //aceita apenas números, tecla backspace.

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav");// Som ao digitar no textbox txDigitodestino
            Player.Play();
        }
    }
}









