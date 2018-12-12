using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace BANCO
{

    public class Bancooperacoes
    {
        public decimal valorop { get; set; }
        public decimal Saldo { get; set; }
        public string nomesaque { get; set; }
        public string nomedeposito { get; set; } //Atributos
        public string nomesaldo { get; set; }
        public string op { get; set; }
        public string extratototal =  "   HISTORICO     VALOR  OPERAÇÃO\n";
        public int Nro_conta { get; set; }
        public int Digito { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
       public string Tipoescrito { get; set; }


        //Metodo mostrarsaldo que recebe como parâmetro o numero da conta
        public decimal mostrasaldo(int qualconta)
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
                this.Saldo = Convert.ToDecimal(resp["saldo"]);
                this.nomesaldo = Convert.ToString(resp["Nome"]);
                this.Digito = Convert.ToInt32(resp["ID"]);
                resp.Close();
            }
            cnn.Close();

            return this.Saldo; // Retorna o saldo
        }

        //Metodo Sacar que recebe como parâmetro o numero da conta , Valor do saque e tipo de operação que pode ser SA - ou TR -
        // Ou seja o mesmo metodo pode sacar e transferir
        public decimal Sacar(int qualconta, decimal valorsaque, string tipoop)
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
                this.Saldo = Convert.ToDecimal(resp["saldo"]);
                this.nomesaque = Convert.ToString(resp["Nome"]);
                this.Digito = Convert.ToInt32(resp["ID"]);
                this.Nro_conta = Convert.ToInt32(resp["Nconta"]);
                resp.Close();
                if (this.Saldo >= valorsaque)
                {
                    this.Saldo -= valorsaque;
                    cmd.CommandText = "update Conta set saldo =\"" + this.Saldo + "\" where Nconta = " + qualconta;
                    cmd.ExecuteNonQuery();
                    if (tipoop == "SA -")
                    {
                        cmd.CommandText = "Insert into operacoes (Nconta, saq_dep, valorop, Dataop, saldo) values (" + qualconta + ",\'SA -\',\'" + valorsaque + "\',\'" + DateTime.Now + "\',\'" + this.Saldo + "\')";
                        cmd.ExecuteNonQuery();
                        return -2;
                    }
                    else if (tipoop == "TR -")
                    {
                        cmd.CommandText = "Insert into operacoes (Nconta, saq_dep, valorop, Dataop, saldo) values (" + qualconta + ",\'TR -\',\'" + valorsaque + "\',\'" + DateTime.Now + "\',\'" + this.Saldo + "\')";
                        cmd.ExecuteNonQuery();

                        return -2;
                    }
                }
                else
                    return -1;
            }
            cnn.Close();
            return this.Saldo; // Retorna o saldo
        }


        //Metodo depositar que recebe como parâmetro o numero da conta , Valor do deposito e tipo de operação que pode ser DEP + ou TR +
        // Ou seja o mesmo metodo pode depositar ou receber transferência
        public decimal depositar(int qualconta, decimal valordeposito, string tipoop)
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
                this.Saldo = Convert.ToDecimal(resp["saldo"]);
                this.Nro_conta = Convert.ToInt32(resp["Nconta"]);
                this.nomedeposito = Convert.ToString(resp["Nome"]);
                this.Digito = Convert.ToInt32(resp["ID"]);
                resp.Close();
                this.Saldo += valordeposito;
                cmd.CommandText = "update Conta set saldo =\"" + this.Saldo + "\" where Nconta = " + qualconta;
                cmd.ExecuteNonQuery();
                if (tipoop == "DEP +")
                {
                    cmd.CommandText = "Insert into operacoes (Nconta, saq_dep, valorop, Dataop, saldo) values (" + qualconta + ",\'DEP +\',\'" + valordeposito + "\',\'" + DateTime.Now + "\',\'" + this.Saldo + "\')";
                    cmd.ExecuteNonQuery();
                    return -3;
                }
                else if (tipoop == "TR +")
                {
                    cmd.CommandText = "Insert into operacoes (Nconta, saq_dep, valorop, Dataop, saldo) values (" + qualconta + ",\'TR +\',\'" + valordeposito + "\',\'"  + DateTime.Now + "\',\'" + this.Saldo + "\')";
                    cmd.ExecuteNonQuery();
                    return -3;
                }
            }
            cnn.Close();
            return this.Saldo;
        }

        //Metodo para retornar um Data table com tudo referente a conta que foi passada por parâmetro
        public DataTable Extrato(int qualconta)
        {

            ContaBancaria conta = new ContaBancaria();
            OleDbConnection cnn = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmd = new OleDbCommand();
            cnn.Open();
            cmd.Connection = cnn;                              
            cmd.CommandText = "select saq_dep as Operação,valorop as Valor,Format([Dataop],'dd/mm/yyyy') as Data,Format([Dataop],'hh:mm:ss') as Hora,saldo as Saldo from operacoes where Nconta = " + qualconta;
            OleDbDataAdapter resp = new OleDbDataAdapter(cmd);
            DataTable de = new DataTable();
            resp.Fill(de);
            cnn.Close();
            return de;
        }

        // Metodo  Extratotodo que retorna uma string com tudo referente a conta passada por parâmetro esse metodo é usado
        // para geração de PDF, envio de PDF, Impressão e Visualização referente ao extrato
        public string Extratotodo(int qualconta)
        {

            ContaBancaria conta = new ContaBancaria();
            OleDbConnection cnn = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmd = new OleDbCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "select saq_dep as Operação,valorop as Valor,Format([Dataop],'dd/mm/yyyy') as Data,Format([Dataop],'hh:mm:ss') as Hora,saldo as Saldo from operacoes where Nconta = " + qualconta;
            OleDbDataReader resp2 = cmd.ExecuteReader();
            if (resp2.HasRows)
            {
                while (resp2.Read())
                {
                    if (Convert.ToString(resp2["Operação"]) == "SA -")
                        this.Tipoescrito = "SAQUE          ";
                    else if (Convert.ToString(resp2["Operação"]) == "TR -")
                        this.Tipoescrito = "TRANSFERÊNCIA -";
                    else if (Convert.ToString(resp2["Operação"]) == "DEP +")
                        this.Tipoescrito = "DEPÓSITO       ";
                    else if (Convert.ToString(resp2["Operação"]) == "TR +")
                        this.Tipoescrito = "TRANSFERÊNCIA +";

                    this.extratototal += "  -------" + Convert.ToString(resp2["Data"]) + "--" + Convert.ToString(resp2["Hora"]) + "-------\n" +
                                         "  "+ this.Tipoescrito+"  " + Convert.ToString(resp2["Valor"]) + "     " + Convert.ToString(resp2["Operação"]) + "\n\n" +
                                         "   Saldo        " + Convert.ToString(resp2["Saldo"])+"\n"+
                                         "  ----------------------------------\n";
                }
                resp2.Close();

            }

            
            cnn.Close();
            return this.extratototal;
        }


    }
}
