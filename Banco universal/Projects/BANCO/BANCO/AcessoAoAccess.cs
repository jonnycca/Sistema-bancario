using System.Data.OleDb;
namespace BANCO
{
    //Classe Estática para conexão com banco de dados
    public static class AcessoAoAccess
    {
        public static OleDbConnection AbrirConexao()
        {
            return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=d:\Banco.mdb");

        }
    }


}