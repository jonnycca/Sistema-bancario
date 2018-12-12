using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace BANCO
{
    //Classe Contabancaria
    public class ContaBancaria
    {
        public decimal Saldo { get; set; }
        public int Nro_conta { get; set; }  //Atributos
        public int Nro_digito { get; set; }
        public int Nro_Senha { get; set; }
        public string nomeusu { get; set; }
        public string email { get; set; }

        // Metodo para verificar se a conta existe recebendo os parâmetros numero da conta e digito
        public int verificar(int qualconta, int qualdigito)
        {
            string codigo;
            OleDbConnection cnn = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmd = new OleDbCommand();
            cnn.Open();
            cmd.Connection = cnn;
            codigo = "Select *from Conta where Nconta = " + qualconta + "and ID =" + qualdigito;
            cmd.CommandText = codigo;
            OleDbDataReader resp = cmd.ExecuteReader();
            if (resp.HasRows)
            {
                resp.Read();
                this.nomeusu = Convert.ToString(resp["Nome"]);
                this.Nro_conta = Convert.ToInt32(resp["Nconta"]);
                this.Nro_digito = Convert.ToInt32(resp["ID"]);
                this.Saldo = Convert.ToDecimal(resp["saldo"]);
                this.email = Convert.ToString(resp["Email"]);
                resp.Close();

                return this.Nro_conta;  // retornando o numero da conta
            }
            else
            {
                this.Nro_conta = -1;  // se a conta não exite o atributo Nro_conta recebe o numero -1 para retornar 
                this.nomeusu = string.Empty;
                this.Nro_digito = -1; 
            }
            cnn.Close();
            return this.Nro_conta; // retornando o numero da conta
        }


        // Metodo para verificar se a senha existe ou esta correta recebendo os parâmetros numero da conta e senha
        public int verificarsenha(int qualconta, int senha)
        {
            string codigo;
            OleDbConnection cnn = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmd = new OleDbCommand();
            cnn.Open();
            cmd.Connection = cnn;
            codigo = "Select *from Conta where Nconta = " + qualconta + "and senha =" + senha;
            cmd.CommandText = codigo;
            OleDbDataReader resp = cmd.ExecuteReader();
            if (resp.HasRows)
            {
                resp.Read();
                this.Nro_conta = Convert.ToInt32(resp["Nconta"]);
                this.Nro_Senha = Convert.ToInt32(resp["senha"]);
                resp.Close();

                return this.Nro_Senha; // retornando o numero da senha
            }
            else
            {
                this.Nro_Senha = -1;// se a senha não exite ou incorreta o atributo Nro_Senha recebe o numero -1 para retornar 

            }

            cnn.Close();
            return this.Nro_Senha; // retornando o numero da senha
        }


        // Metodo para buscar Email recebendo os parâmetro numero da conta 
        public string verificaremail(int qualconta)
        {
            
            OleDbConnection cnn = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmd = new OleDbCommand();
            cnn.Open();
            cmd.Connection = cnn;                     
            cmd.CommandText = "select  *from Conta where Nconta = " + qualconta;
            OleDbDataReader resp = cmd.ExecuteReader();
            if (resp.HasRows)
            {
                resp.Read();        
                this.email = Convert.ToString(resp["Email"]);
                resp.Close();
            }

            cnn.Close();
            return this.email; // retornando o email
        }

    }
}
