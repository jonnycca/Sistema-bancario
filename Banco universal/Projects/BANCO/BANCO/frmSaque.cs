using System;
using System.Drawing;
using System.Windows.Forms;

namespace BANCO
{

    public partial class frmSaque : Form
    {
   
    
        string pasta_imagens = "";
        Image img_10normal;
        Image img_10high;
        Image img_20normal;
        Image img_20high;
        Image img_50normal;
        Image img_50high;
        Image img_100normal;    // Variaveis do tipo imagem para receber as imagens pelo endereco que esta na string de enderecos
        Image img_100high;
        Image img_300normal;
        Image img_300high;
        Image img_500normal;
        Image img_500high;
        Image img_800normal;
        Image img_800high;
        Image img_1000normal;
        Image img_1000high;
        Image img_Enter;
        Image img_Corrige;
        public frmSaque()
        {
            InitializeComponent();        
            pasta_imagens = Application.StartupPath + @"\imagens\";  //Atributo string rebendo o endereco das imagens
            img_10normal = Image.FromFile(pasta_imagens + "10normal.png");
            img_10high = Image.FromFile(pasta_imagens + "10high.png");
            img_20normal = Image.FromFile(pasta_imagens + "20normal.png");
            img_20high = Image.FromFile(pasta_imagens + "20high.png");
            img_50normal = Image.FromFile(pasta_imagens + "50normal.png");
            img_50high = Image.FromFile(pasta_imagens + "50high.png");
            img_100normal = Image.FromFile(pasta_imagens + "100normal.png");  //Variaveis do tipo imagem recebendo as imagens pelos enderecos
            img_100high = Image.FromFile(pasta_imagens + "100high.png");
            img_300normal = Image.FromFile(pasta_imagens + "300normal.png");
            img_300high = Image.FromFile(pasta_imagens + "300high.png");
            img_500normal = Image.FromFile(pasta_imagens + "500normal.png");
            img_500high = Image.FromFile(pasta_imagens + "500high.png");
            img_800normal = Image.FromFile(pasta_imagens + "800normal.png");
            img_800high = Image.FromFile(pasta_imagens + "800high.png");
            img_1000normal = Image.FromFile(pasta_imagens + "1000normal.png");
            img_1000high = Image.FromFile(pasta_imagens + "1000high.png");
            img_Enter = Image.FromFile(pasta_imagens + "Enter.png");
            img_Corrige = Image.FromFile(pasta_imagens + "btnCorrige.png");
            btn10.BackgroundImage = img_10normal;
            btn20.BackgroundImage = img_20normal;
            btn50.BackgroundImage = img_50normal;
            btn100.BackgroundImage = img_100normal;
            btn300.BackgroundImage = img_300normal;  // botoes recebendo as variaveis do tipo imagem
            btn500.BackgroundImage = img_500normal;
            btn800.BackgroundImage = img_800normal;
            btn1000.BackgroundImage = img_1000normal;
            btnentra.BackgroundImage = img_Enter;
            btnCorrige.BackgroundImage = img_Corrige;
            txtSaque.Focus();    //Colocado Foco e Select na Textbox txtSaque
            txtSaque.Select();
        }

        private void btn10_MouseEnter(object sender, EventArgs e)
        {
            btn10.BackgroundImage = img_10high; // Se colocar o mouse em cima do botão 10 ele carrega a imagem high
        }

        private void btn10_MouseLeave(object sender, EventArgs e)
        {
            btn10.BackgroundImage = img_10normal; // Se tirar o mouse de cima do botão 10 ele carrega a imagem normal
        }

        private void btn20_MouseEnter(object sender, EventArgs e)
        {
            btn20.BackgroundImage = img_20high; // Se colocar o mouse em cima do botão 20 ele carrega a imagem high
        }

        private void btn20_MouseLeave(object sender, EventArgs e)
        {
            btn20.BackgroundImage = img_20normal; // Se tirar o mouse de cima do botão 20 ele carrega a imagem normal
        }

        private void btn50_MouseEnter(object sender, EventArgs e)
        {
            btn50.BackgroundImage = img_50high; // Se colocar o mouse em cima do botão 50 ele carrega a imagem high
        }

        private void btn50_MouseLeave(object sender, EventArgs e)
        {
            btn50.BackgroundImage = img_50normal; // Se tirar o mouse de cima do botão 50 ele carrega a imagem normal
        }

        private void btn100_MouseEnter(object sender, EventArgs e)
        {
            btn100.BackgroundImage = img_100high; // Se colocar o mouse em cima do botão 100 ele carrega a imagem high
        }

        private void btn100_MouseLeave(object sender, EventArgs e)
        {
            btn100.BackgroundImage = img_100normal; // Se tirar o mouse de cima do botão 100 ele carrega a imagem normal
        }

        private void btn300_MouseEnter(object sender, EventArgs e)
        {
            btn300.BackgroundImage = img_300high; // Se colocar o mouse em cima do botão 300 ele carrega a imagem high
        }

        private void btn300_MouseLeave(object sender, EventArgs e)
        {
            btn300.BackgroundImage = img_300normal; // Se tirar o mouse de cima do botão 300 ele carrega a imagem normal
        }

        private void btn500_MouseEnter(object sender, EventArgs e)
        {
            btn500.BackgroundImage = img_500high; // Se colocar o mouse em cima do botão 500 ele carrega a imagem high
        }

        private void btn500_MouseLeave(object sender, EventArgs e)
        {
            btn500.BackgroundImage = img_500normal; // Se tirar o mouse de cima do botão 500 ele carrega a imagem normal
        }

        private void btn800_MouseEnter(object sender, EventArgs e)
        {
            btn800.BackgroundImage = img_800high; // Se colocar o mouse em cima do botão 800 ele carrega a imagem high
        }

        private void btn800_MouseLeave(object sender, EventArgs e)
        {
            btn800.BackgroundImage = img_800normal; // Se tirar o mouse de cima do botão 800 ele carrega a imagem normal
        }

        private void btn1000_MouseEnter(object sender, EventArgs e)
        {
            btn1000.BackgroundImage = img_1000high; // Se colocar o mouse em cima do botão 1000 ele carrega a imagem high
        }

        private void btn1000_MouseLeave(object sender, EventArgs e)
        {
            btn1000.BackgroundImage = img_1000normal; // Se tirar o mouse de cima do botão 1000 ele carrega a imagem normal
        }

        private void btnAnula_Click(object sender, EventArgs e)
        {                                                       // Click no botão anular fecha o form e volta para o form Operações
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

        private void txtSaque_KeyPress(object sender, KeyPressEventArgs e)
        {                                                // Evento KeyPress para o textbox txtSaque
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtSaque.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav");// Som ao digitar no textbox txtSaque
            Player.Play();
        }

        private void btnCorrige_Click(object sender, EventArgs e)
        {
            txtSaque.Text = string.Empty; // Click no botão corrige limpa o campo txtsaque e coloca foco
            txtSaque.Focus();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();            
            Properties.Settings.Default.ValoresSaquedep = 10; // Configurações de  Propriedades Global Saque recebendo valor 10     
            frmSenha verifica = new frmSenha(); // Click no botão 10 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 20; // Configurações de  Propriedades Global Saque recebendo valor 20   
            frmSenha verifica = new frmSenha(); // Click no botão 20 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK; ;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 50; // Configurações de  Propriedades GlobalSaque recebendo valor 50  
            frmSenha verifica = new frmSenha(); // Click no botão 50 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 100; // Configurações de  Propriedades Global Saque recebendo valor 100  
            frmSenha verifica = new frmSenha(); // Click no botão 100 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btn300_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 300; // Configurações de  Propriedades Global Saque recebendo valor 300   
            frmSenha verifica = new frmSenha(); // Click no botão 300 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

 
        private void btn500_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 500; // Configurações de  Propriedades Global Saque recebendo valor 500   
            frmSenha verifica = new frmSenha(); // Click no botão 500 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btn800_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 800; // Configurações de  Propriedades Global Saque recebendo valor 800   
            frmSenha verifica = new frmSenha(); // Click no botão 800 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotao.wav"); // Som ao apertar o botão
            Player.Play();
            Properties.Settings.Default.ValoresSaquedep = 1000; // Configurações de  Propriedades Global Saque recebendo valor 1000   
            frmSenha verifica = new frmSenha(); // Click no botão 1000 chama o formulario de senha
            verifica.ShowDialog();
            DialogResult = DialogResult.OK;
        }

        private void btnentra_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("Sound/Sombotaoentra.wav"); // Som ao apertar o botão
            Player.Play();
            

           
            if (txtSaque.Text == string.Empty)       //Verificando se foi digitado valores
                MessageBox.Show("Não foi Digitado Valores no Campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Convert.ToDecimal(txtSaque.Text) > 2000) // Verificando se o valor do saque não passou de 2000
                MessageBox.Show("Limite Máximo para Saque R$ 2000,00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                Properties.Settings.Default.ValoresSaquedep = Convert.ToDecimal(txtSaque.Text); // Configurações de  Propriedades Global Saque recebendo valor do txtSaque
                frmSenha verifica = new frmSenha(); // Click no botão Entra chama o formulario de senha
                verifica.ShowDialog();
                DialogResult = DialogResult.OK;
            }
        }

        private void txtSaque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   // Se apertar enter chama o evento Click do botao entra
            {
                btnentra_Click(this, new EventArgs());
            }
        }
    }
}
