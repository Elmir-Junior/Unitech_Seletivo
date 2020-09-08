using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Renci.SshNet.Security.Cryptography;

namespace Unitech.Infra
{
    public class MySQL
    {
        
        public MySqlConnection connection()
        {
            string con = "server=localhost;user id=user;pwd=1234567;database=unitech";
            return new MySqlConnection(con);
        }
    }
}
