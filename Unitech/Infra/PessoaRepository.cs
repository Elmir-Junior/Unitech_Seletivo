using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unitech.Models;

namespace Unitech.Infra
{
    public class PessoaRepository
    {

        MySQL mySQL = new MySQL();

        public void Adicionar(Pessoa item)
        {
            using (var con = mySQL.connection())
            {
                var query = "INSERT INTO pessoa (Descricao, Telefone, Ong_ID ) VALUES (@Descricao, @Telefone, @Ong_ID)";

                con.Execute(query, new { item.ID, item.Descricao, item.Telefone, item.Ong_ID });
            }
        }


        public void Editar(Pessoa item)
        {
            using (var con = mySQL.connection())
            {
                var query = "update pessoa set Descricao=@Descricao, Telefone=@Telefone, Ong_ID=@Ong_ID where = ID=@ID ";
                con.Execute(query, new { item.Descricao, item.ID, item.Telefone, item.Ong_ID });
            }
        }

        public Pessoa BuscarporId(int id)
        {
            using (var con = mySQL.connection())
            {
                var query = "SELECT * from pessoa where ID=@Id";
                return con.QueryFirstOrDefault<Pessoa>(query, new { ID = id });
            }
        }

        public Pessoa buscarporong(int id)
        {
            using (var con = mySQL.connection())
            {
                string query = "Select * from pessoa where ong_id=@ong_id";
                return con.QueryFirstOrDefault<Pessoa>(query, new { ong_id = id });
            }
        }
        public IEnumerable<Ong> ListarOngId(){

            using (var con = mySQL.connection())
            {
                var query = "select id from ong";
                return con.Query<Ong>(query);
            }

            }

        public IEnumerable<Pessoa> ListarPessoa()
        {
            using (var con = mySQL.connection())
            {
                var query = "select * from pessoa";
                return con.Query<Pessoa>(query);
            }
        }
        public void Remover(int id)
        {
            using (var con = mySQL.connection())
            {
                string query = "DELETE FROM pessoa WHERE ID=@Id";
                con.Execute(query, new { ID = id });
            }
        }

    }
}
