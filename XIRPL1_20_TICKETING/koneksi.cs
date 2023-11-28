using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIRPL1_20_TICKETING
{
    internal class koneksi
    {
        public static NpgsqlConnection conn = new NpgsqlConnection
            ("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=ADMINADMIN;");
    }
}
