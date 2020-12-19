using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: Dependency(typeof(SQLite_UWP))]
namespace XF.LocalDB.UWP
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }
        public SQLite.SQLiteConnection GetConexao()
        {
            var arquivodb = "fiapdb.db3";
            string caminho = Path.Combine(
            ApplicationData.Current.LocalFolder.Path,
            arquivodb);
            var conexao = new SQLite.SQLiteConnection(caminho);
            return conexao;
        }
    }
}