﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class Connectiondk
    {
        public static SqlConnection ChuoiKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-I3BFESS\MSSQLSERVER01;Initial Catalog=QLNhansu1;Integrated Security=True");
            return Conn;
        }
    }
}
