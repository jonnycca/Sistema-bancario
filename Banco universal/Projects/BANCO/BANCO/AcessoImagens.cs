using System;
using System.Data.OleDb;

namespace BANCO
{

    // Classe Banco de Imagens
    public class BancoImagens
    {
        public string imagem { get; set; }

        // Metodo para pegar a imgem no banco a partir do parâmetro passado no caso o ID da imagem
        public void imagens(int idimagen)
        {
            OleDbConnection im = AcessoAoAccess.AbrirConexao();
            OleDbCommand cmdim = new OleDbCommand();
            im.Open();
            cmdim.Connection = im;
            cmdim.CommandText = "Select *from Imagens where ID =  " + idimagen;
            OleDbDataReader resp = cmdim.ExecuteReader();
            if (resp.HasRows)
            {
                resp.Read();
                this.imagem = Convert.ToString(resp["Imagem"]);
                resp.Close();

            }
            im.Close();
        }
    }
}
