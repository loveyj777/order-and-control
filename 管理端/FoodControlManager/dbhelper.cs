using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FoodControlManager
{
    class dbhelper
    {
        const string sql = "data source=LAPTOP-RD1FKFSC\\SQLEXPRESS;initial catalog=OrderSystem;trusted_connection=true";

        private SqlConnection conn;

        public SqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(sql);

                }
                return conn;

            }

        }


        public void open()
        {
            if (Conn.State == ConnectionState.Closed)

            {
                Conn.Open();



            }
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();

            }


        }

        public void close()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }

        }
    }
}
