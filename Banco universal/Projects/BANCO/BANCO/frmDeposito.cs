using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{
    public partial class frmDeposito : Form
    {
        ContaBancaria veri = new ContaBancaria(); // instância do objeto da classe ContaBancria
        Bancooperacoes novo = new Bancooperacoes(); // instância do objeto da classe Bancooperacoes
        public int contas { get; set; }   
        string pasta_imagens = "";                // String para pegar os enderecos das imagens 
        Image img_Enter;                          // Variaveis do tipo imagem para receber as imagens pelo endereco que esta na string de enderecos
        Image img_Corrige;
        public frmDeposito()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\imagens\"; //Atributo string rebendo o endereco das imagens
            img_Enter = Image.FromFile(pasta_imagens + "Enter.png"); //Variaveis do tipo imagem recebendo as imagens pelos enderecos
            img_Corrige = Image.FromFile(pasta_imagens + "btnCorrige.png");
            this.contas = Properties.Settings.Default.NroContaGlobal;  //Atributo recebendo Numero da conta das Configurações de  Propriedades Global NroContaGlobal
            btnentra.BackgroundImage = img_Enter;
            btnCorrige.BackgroundImage = img_Corrige; // botoes recebendo as variaveis do tipo imagem
            txtConta.Focus();  //Colocado Foco e Select na Textbox txtConta
            txtConta.Select();
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {                                                        // Click no botão anular fecha o form e volta para o form Operações
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

        private void txtDeposito_KeyPress(object sender, KeyPressEventArgs e)
        {                                               //Evento KeyPress do textbox txtDeposito
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtDeposito.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav");// Som ao digitar no textbox txtDeposito
            Player.Play();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtDeposito.Text = string.Empty;
            txtConta.Text = string.Empty;       // Click no botão corrige limpa todos os campos e coloca foco no txtConta
            txtDigito.Text = string.Empty;
            txtConta.Focus();
        }

        private void txtDeposito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnentra_Click(this, new EventArgs());  // Se apertar enter chama o evento Click do botao entra
            }
        }

        private void btnentra_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();                    
                                                  // Verifica se os campos estão vazios
            if ((txtConta.Text == string.Empty) || (txtDigito.Text == string.Empty) || (txtDeposito.Text == string.Empty))
                MessageBox.Show("Não foi Digitado Valores em Algum Campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {                                    // Verifica se a conta Existe
                int foiveri = veri.verificar(Convert.ToInt32(txtConta.Text), Convert.ToInt32(txtDigito.Text));
                if (foiveri == -1)
                    MessageBox.Show("Conta Inexistente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    lbDados.Text = "Conta: " + txtConta.Text + "\nValor(R$): " + txtDeposito.Text + "\nTitular: " + veri.nomeusu;
                    txtDeposito.Visible = false;
                    txtDigito.Visible = false;
                    txtConta.Visible = false;
                    lbconfirma.Visible = false;
                    lbnconta.Visible = false;          // Tira a visibilidade de todos os labels e textbox
                    lbvalor.Visible = false;
                    btnCorrige.Visible = false;
                    btnentra.Visible = false;
                    lbConfira.Visible = true;
                    lbDados.Visible = true;
                    btnConfirma.BackgroundImage = img_Enter; 
                    btnConfirma.Visible = true;               // o botão Confirma fica visivel e recebe a imagem
                }
            }
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {                                              // Evento keyPress do textbox txtConta
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;         //Só aceita digitar numeros e backspace

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao digitar no textbox txtConta
            Player.Play();
        }

        private void txtDigito_KeyPress(object sender, KeyPressEventArgs e)
        {                                               // Evento keyPress do textbox txtDigito
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;        //Só aceita digitar numeros e backspace

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao digitar no textbox txtDigito
            Player.Play();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();
            if (this.contas == Convert.ToInt32(txtConta.Text))
            {                                                     
                Properties.Settings.Default.ValoresSaquedep = Convert.ToDecimal(txtDeposito.Text);
                frmSenha verifica = new frmSenha();       //Se a conta digitada for igual a que esta logada então verifica senha
                verifica.ShowDialog();
                DialogResult = DialogResult.OK;
            }                                        
            else
            {
                Properties.Settings.Default.NomeGlobal = veri.nomeusu;
                Properties.Settings.Default.SaldoGlobal = veri.Saldo;
                Properties.Settings.Default.NroDigitoGlobal = veri.Nro_digito;  // Configurações de  Propriedades Global recebendo valores dos atributos da conta destino
                Properties.Settings.Default.NroContaGlobal = veri.Nro_conta;
                Properties.Settings.Default.ValoresSaquedep= Convert.ToDecimal(txtDeposito.Text);
                novo.depositar(Convert.ToInt32(txtConta.Text), Convert.ToDecimal(txtDeposito.Text), "DEP +");
                frmResulOp diferente = new frmResulOp();
                diferente.ShowDialog();
                DialogResult = DialogResult.OK;
            }

        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            if (txtConta.Text.Length == 2)
            {                               // Como a conta so possui dois digitos automaticamente após digitar dois digitos
                SendKeys.Send("{Tab}");     // da um Tab Automatico e vai para o digito
            }
        }

        private void txtDigito_TextChanged(object sender, EventArgs e)
        {
            if (txtDigito.Text.Length == 1)
            {                               // Como o Digito so possui um caracter numero, automaticamente após digitar
                SendKeys.Send("{Tab}");     // da um Tab Automatico e vai para o Entra
            }
        }
    }
}
