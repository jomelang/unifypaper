using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace UnifyPaper.Classes.Database
{
    class database
    {
        OleDbConnection conn = null;
        OleDbDataReader dr = null;
        OleDbCommand cmd = null;

        public database()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=unifypaperdb.accdb";
        }

        public Classes.Entities.users checkLogin(Classes.Entities.users u)
        {
            Classes.Entities.users user = new Classes.Entities.users();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE username LIKE @username AND password LIKE @password";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    user.ID = dr["ID"].ToString();
                    user.username = dr["username"].ToString();
                    user.password = dr["password"].ToString();
                    user.userlevel = dr["userlevel"].ToString();
                    user.created_at = dr["created_at"].ToString();
                    user.updated_at = dr["updated_at"].ToString();

                }

                else
                {
                    user = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error "+e);
                
            }

            finally
            {
                dr.Close();
                conn.Close();
            }

            return user;
        }



    }
}
