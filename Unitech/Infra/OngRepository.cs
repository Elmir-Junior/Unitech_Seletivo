using Dapper;
using System.Collections.Generic;
using Unitech.Models;

namespace Unitech.Infra
{
    public class OngRepository
    {
        MySQL mySQL = new MySQL();
        
        public void Adicionar(Ong item)
        {
            using (var con = mySQL.connection())
            {
                var query = "INSERT INTO ong (Descricao) VALUES (@Descricao)";
             
                con.Execute(query, new { item.ID, item.Descricao });
            }
        }


        public void Editar(Ong item)
        {
            using (var con = mySQL.connection())
            {
                var query = "update ong set Descricao=@Descricao where ID=@ID ";
                con.Execute(query, new { item.Descricao, item.ID });
            }
        }

        public Ong BuscarporId(int id)
        {
            using (var con = mySQL.connection())
            {
                var query = "SELECT * from ong where ID=@Id";
                return con.QueryFirstOrDefault<Ong>(query, new { ID = id});
            }
        }

        public IEnumerable<int> buscarid(int id)
        {
            using (var con = mySQL.connection())
            {
                var query = "SELECT * from ong where ID=@Id";
                return con.Query<int>(query, new { ID = id});
            }
        }
        public IEnumerable<Ong> ListarOng()
        {
            using (var con = mySQL.connection())
            {
                var query = "select * from ONG";
                return con.Query<Ong>(query);
            }
        }
        public void Remover(int id)
        {
            using (var con = mySQL.connection())
            {
                string query = "DELETE FROM ONG WHERE ID=@Id";
                con.Execute(query, new { ID = id });
            }
        }
    }
}
