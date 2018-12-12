using System;
using System.Windows.Forms;
using System.Globalization;  //Biblioteca usada para colocar data e hora no idioma local

namespace BANCO
{

    public partial class frmPrincipal : Form
    {
        BancoImagens img = new BancoImagens();       // instância do objeto da classe BancoImagens
        ContaBancaria novo = new ContaBancaria();    // instância do objeto da classe ContaBancria
        public string uper { get; set; }             // Atributo do tipo string para receber a data e hora atual

        public frmPrincipal()
        {
            InitializeComponent();
            img.imagens(1);
            img1.Load(img.imagem);
            img.imagens(5);
            img2.Load(img.imagem);
            img.imagens(6);            // Carregando todas as imagens puxando enderecos do banco de dados no contrutor do form principal 
            img3.Load(img.imagem);
            img.imagens(7);
            Debito.Load(img.imagem);
            img.imagens(8);
            Cartoes.Load(img.imagem);
            img.imagens(9);
            Pagamentos.Load(img.imagem);
            img.imagens(10);
            Contatos.Load(img.imagem);
            img.imagens(11);
            logo.Load(img.imagem);

        }

    

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (progressBar1.Value < 300)        //se a progressbar1.value for menor que 300 o atributo uper vai 
            {                                    // receber a data e hora em um intervalo de 100 milésimos de segundo
                this.uper = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy        HH:mm:ss", CultureInfo.CreateSpecificCulture("pt-BR"));
                horadata.Text = char.ToUpper(uper[0]) + uper.Substring(1); // colocando a primeira letra do mes em caixa alta
            }

            if (progressBar1.Value < 100)
            {                                //se a progressbar1.value for menor que 100 a imagem com ID 1 permanecera na tela principal 
                img.imagens(1);              // o progreesbar1.value recebe ele mais 2 e o progressbar4.value recebe o valor 200
                img1.Load(img.imagem);       // e o progressbar2.value recebebe o valor do progressbar1.value e a img carrega a imagem com ID 1 
                progressBar4.Value = 200;    // em um intervalo de 100 milésimos de segundo
                progressBar1.Value = progressBar1.Value + 2;              
                progressBar2.Value = progressBar1.Value;           
                img.imagens(1);
                pictureBox1.Load(img.imagem);        
            }
            else if (progressBar1.Value < 200)
            {                                 //se a progressbar1.value for menor que 200 a imagem com ID 2 permanecera na tela principal 
                img.imagens(2);               // o progreesbar1.value recebe ele mais 2 e o progressbar2.value recebe o valor 0
                img2.Load(img.imagem);        // e o progressbar3.value recebebe o valor do progressbar1.value e a img carrega a imagem com ID 2
                progressBar2.Value = 0;       // em um intervalo de 100 milésimos de segundo
                progressBar1.Value = progressBar1.Value + 2;
                progressBar3.Value = progressBar1.Value;
                img.imagens(2);
                pictureBox1.Load(img.imagem);
            }
            else if (progressBar1.Value < 300)
            {                                //se a progressbar1.value for menor que 300 a imagem com ID 3 permanecera na tela principal
                img.imagens(3);              // o progreesbar1.value recebe ele mais 2 e o progressbar3.value recebe o valor 100
                img3.Load(img.imagem);       // e o progressbar4.value recebebe o valor do progressbar1.value e a img carrega a imagem com ID 3
                progressBar3.Value = 100;    // em um intervalo de 100 milésimos de segundo
                progressBar1.Value = progressBar1.Value + 2;             
                progressBar4.Value = progressBar1.Value;            
                img.imagens(3);
                pictureBox1.Load(img.imagem);
            }
            else
                progressBar1.Value = 0;      // Aqui é zerado o valor do progressbar1 para que todo o processo de trocas de imagens
                                             // na tela fiquem continuo e nunca pare

            if (progressBar1.Value == 100)
            {
                img.imagens(4);          // Se o progressbar1.value é igual a 100 entao a img1 vai carregar a imagem normal com 
                img1.Load(img.imagem);   // numero de ID 4 e tiro a borda que coloco mais a frente no codigo
                img1.BorderStyle = BorderStyle.None;
            }
            else if (progressBar1.Value == 200)
            {
                img.imagens(5);          // Se o progressbar1.value é igual a 200 entao a img1 vai carregar a imagem normal com 
                img2.Load(img.imagem);   // numero de ID 5 e tiro a borda que coloco mais a frente no codigo
                img2.BorderStyle = BorderStyle.None;
            }
            else if (progressBar1.Value == 0)
            {
                img.imagens(6);          // Se o progressbar1.value é igual a 0 entao a img1 vai carregar a imagem normal com 
                img3.Load(img.imagem);   // numero de ID 6 e tiro a borda que coloco mais a frente no codigo
                img3.BorderStyle = BorderStyle.None;
            }
        }

        public void btnok_Click(object sender, EventArgs e) 
        {                                                                              //Verificando campos vazios
            if ((txbnconta.Text == string.Empty) || (txbdgconta.Text == string.Empty))  
            {                                                                           
                MessageBox.Show("Não foi colocado o numero da conta ou digito", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbnconta.Text = string.Empty;
                txbdgconta.Text = string.Empty;
                txtnome.Text = string.Empty;
                txbnconta.Focus();
            }
            else if ((Convert.ToInt32(txbnconta.Text) < 0) || (Convert.ToInt32(txbdgconta.Text) < 0)) // Verificando numeros negativos
            {
                MessageBox.Show("Não existe conta ou digito com numero negativo!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbnconta.Text = string.Empty;
                txtnome.Text = string.Empty;
                txbdgconta.Text = string.Empty;
                txbnconta.Focus();
            }
            else
            {
                novo.verificar(Convert.ToInt32(txbnconta.Text), Convert.ToInt32(txbdgconta.Text)); //Verificando numero da conta se existe
                if ((Convert.ToInt32(txbnconta.Text) == novo.Nro_conta) && (Convert.ToInt32(txbdgconta.Text) == novo.Nro_digito))
                {              
                    Properties.Settings.Default.NroContaGlobal = novo.Nro_conta;
                    Properties.Settings.Default.NomeGlobal = novo.nomeusu;           // Configurações de  Propriedades Global recebendo valores dos atributos
                    Properties.Settings.Default.NroDigitoGlobal = novo.Nro_digito;   // para usar onde for preciso
                    Properties.Settings.Default.SaldoGlobal = novo.Saldo;
                    frmoperacoes outroform = new frmoperacoes();
                    txbnconta.Text = string.Empty;
                    txbdgconta.Text = string.Empty;
                    txbnconta.Focus();
                    outroform.ShowDialog();
                    // this.Close();
                }
                else
                {
                    // se caso não existir a conta ou digito relacionados Exibirá uma mensagem
                    MessageBox.Show("Acesso negado\nConta ou Digito \nnão encontrado(a)s", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnome.Text = string.Empty;
                    txbnconta.Text = string.Empty;
                    txbdgconta.Text = string.Empty;
                    txbnconta.Focus();
                }
            }
        }

        private void mostrar(object sender, EventArgs e)
        {
            img.imagens(1);                           // Se colocar o mouse em cima da img1 ela carrega a imagem normal com ID 1 
            img1.Load(img.imagem);                    // a borda fixed3d
            img1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void mostrar2(object sender, EventArgs e)
        {
            img.imagens(2);                          // Se colocar o mouse em cima da img2 ela carrega a imagem normal com ID 2  
            img2.Load(img.imagem);                  // e coloca a borda fixed3d
            img2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void mostrar3(object sender, EventArgs e)
        { 
            img.imagens(3);                         // Se colocar o mouse em cima da img3 ela carrega a imagem normal com ID 3 
            img3.Load(img.imagem);                  // e coloca a borda fixed3d
            img3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void tirar(object sender, EventArgs e)
        {                                                // Se tirar o mouse de cima da img1
            if (progressBar1.Value < 100) // se o progressbar1.value for menor que 100 permanece a imagem normal carregada na img1
            {                            // com ID 1
                img.imagens(1);
                img1.Load(img.imagem);
            }
            else
            {                           // se não carrega a imagem High no img1 com ID 4 e tira a borda
                img.imagens(4);
                img1.Load(img.imagem);
                img1.BorderStyle = BorderStyle.None;
            }
        }

        private void tirar2(object sender, EventArgs e)
        {                                                 // Se tirar o mouse de cima da img2
            if ((progressBar1.Value > 100) && (progressBar1.Value < 200))
            {                                      // se o progressbar1.value estiver entre 101 e 199 permanece a imagem normal carregada na img2
                img.imagens(2);                    // com ID 2
                img2.Load(img.imagem);
            }
            else
            {                              // se não carrega a imagem High no img2 com ID 5 e tira a borda
                img.imagens(5);
                img2.Load(img.imagem);
                img2.BorderStyle = BorderStyle.None;
            }
        }

        private void tirar3(object sender, EventArgs e)
        {                                                 // Se tirar o mouse de cima da img3
            if ((progressBar1.Value > 200) && (progressBar1.Value < 300))
            {                                    // se o progressbar1.value estiver entre 201 e 299 permanece a imagem normal carregada na img3
                img.imagens(3);                  // com ID 3
                img3.Load(img.imagem);
            }
            else
            {                             // se não carrega a imagem High no img3 com ID 6 e tira a borda
                img.imagens(6);
                img3.Load(img.imagem);
                img3.BorderStyle = BorderStyle.None;
            }
        }

        private void img1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            img.imagens(5);              // se clicar na img1 o progressbar1.value recebe o valor 0
            img2.Load(img.imagem);       // e o img1 carrega a imagem normal pois o progressbar1 foi tratado antes se o valor igual a 0
            img.imagens(6);              // e o img2 carrega a imagem high com ID 5
            img3.Load(img.imagem);       // e o img3 carrega a imagem high com ID 6
        }

        private void img2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            img.imagens(4);               // se clicar na img1 o progressbar1.value recebe o valor 100
            img1.Load(img.imagem);        // e o img2 carrega a imagem normal pois o progressbar1 foi tratado antes se o valor igual a 100
            img.imagens(6);               // e o img1 carrega a imagem high com ID 4
            img3.Load(img.imagem);        // e o img3 carrega a imagem high com ID 6
        }

        private void img3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 200;
            img.imagens(4);               // se clicar na img3 o progressbar1.value recebe o valor 200
            img1.Load(img.imagem);        // e o img3 carrega a imagem normal pois o progressbar1 foi tratado antes se o valor igual a 200
            img.imagens(5);               // e o img1 carrega a imagem high com ID 4
            img2.Load(img.imagem);        // e o img2 carrega a imagem high com ID 5
        }

        private void labelSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();           // Click na laber sair fecha a aplicação
        }

        private void txbnconta_TextChanged(object sender, EventArgs e)
        {
            if (txbnconta.Text.Length == 2)   // Como a conta so possui dois digitos automaticamente após digitar dois digitos
            {                                 // da um Tab Automatico e vai para o digito
                SendKeys.Send("{Tab}");
            }
        }

        private void txbdgconta_TextChanged(object sender, EventArgs e)
        {
            if (txbdgconta.Text.Length == 1)  // Como o Digito so possui um caracter numero automaticamente após digitar       
            {                                 // da um Tab Automatico e vai para o OK
                SendKeys.Send("{Tab}");
            }
        }

        private void txbnconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas numeros e backespace no envento KeyPress do numero da conta
             if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void txbdgconta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas numeros e backespace no envento KeyPress do numero do digito
            if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
        }
    }
}
