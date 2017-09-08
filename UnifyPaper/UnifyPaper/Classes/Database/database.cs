﻿using System;
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
        protected OleDbConnection conn = null;
        protected OleDbDataReader dr = null;
        protected OleDbCommand cmd = null;

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

        public bool addNewUser(Classes.Entities.users u)
        {
            Classes.Entities.users user = new Classes.Entities.users();
            bool result = false;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE fullname LIKE @fullname AND username LIKE @username";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fullname", u.fullname);
                cmd.Parameters.AddWithValue("@username", u.username);                
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Record already exist!");
                }
                else
                {
                    dr.Close();
                    sql = "INSERT INTO usertbl (fullname, username, userlevel) VALUES (@fullname, @fullname, @username, @userlevel)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@fullname", u.fullname);
                    cmd.Parameters.AddWithValue("@username", u.username);
                    cmd.Parameters.AddWithValue("@userlevel", u.userlevel);
                    int add = cmd.ExecuteNonQuery();
                        
                    if (add <= 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error addNewUser: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return result;
        }

        public List <Classes.Entities.users> getAllUser()
        {
            List<Classes.Entities.users> userList = new List<Classes.Entities.users>();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE userlevel NOT LIKE @admin";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@admin", "99");
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Classes.Entities.users u = new Classes.Entities.users();
                        u.ID = dr["ID"].ToString();
<<<<<<< HEAD
                        u.fullname = dr["fullname"].ToString();
                        u.username = dr["username"].ToString();
=======
                        u.lastname = dr["lastname"].ToString();
                        u.firstname = dr["firstname"].ToString();
                        u.middlename = dr["middlename"].ToString();
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
                        userList.Add(u);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error getAllUser: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return userList;
        }

        public bool updateUser(Classes.Entities.users u)
        {
            Classes.Entities.users user = new Classes.Entities.users();
            bool result = false;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", u.ID);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    sql = "SELECT * FROM usertbl WHERE ID NOT LIKE @ID AND fullname=@fullname AND username=@username";
                    cmd = new OleDbCommand(sql, conn);
<<<<<<< HEAD
                    cmd.Parameters.AddWithValue("@ID", u.ID);
                    cmd.Parameters.AddWithValue("fullname", u.fullname);
                    cmd.Parameters.AddWithValue("usernmae", u.username);
=======
                    cmd.Parameters.AddWithValue("ID", u.ID);
                    cmd.Parameters.AddWithValue("lastname", u.lastname);
                    cmd.Parameters.AddWithValue("firstname", u.firstname);
                    cmd.Parameters.AddWithValue("middlename", u.middlename);
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Record already exist!");
                    }
                    else
                    {
                        dr.Close();
                        sql = "UPDATE usertbl SET fullname=@fullname, username=@username, WHERE ID LIKE @ID";
                        cmd = new OleDbCommand();
<<<<<<< HEAD
                        cmd.Parameters.AddWithValue("fullname", u.fullname);
                        cmd.Parameters.AddWithValue("username", u.username);
                        cmd.Parameters.AddWithValue("@ID", u.ID);
=======
                        cmd.Parameters.AddWithValue("lastname", u.lastname);
                        cmd.Parameters.AddWithValue("firstname", u.firstname);
                        cmd.Parameters.AddWithValue("middlename", u.middlename);
                        cmd.Parameters.AddWithValue("ID", u.ID);
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
                        int update = cmd.ExecuteNonQuery();

                        if (update <= 0)
                        {
                            result = false;
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in updateUser: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return result;
        }

        public Classes.Entities.users getUserByID(string ID)
        {
<<<<<<< HEAD

=======
            
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
            Classes.Entities.users u = new Classes.Entities.users();
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", ID);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    u.ID = dr["ID"].ToString();
<<<<<<< HEAD
                    u.ID = dr["fullname"].ToString();
                    u.username = dr["username"].ToString();   
=======
                    u.lastname = dr["lastname"].ToString();
                    u.firstname = dr["firstname"].ToString();
                    u.middlename = dr["middlename"].ToString();
>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in getUserByID: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return u;
        }

<<<<<<< HEAD
        public bool deleteUserByID(string ID)
        {
            Classes.Entities.users u = new Classes.Entities.users();
            bool result = false;
            try
            {
                conn.Open();
                string sql = "SELECT * FROM usertbl WHERE ID LIKE @ID";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("ID", ID);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {                  
                    dr.Close();
                    sql = "DELETE FROM usertbl WHERE ID LIKE @ID";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    int delete = cmd.ExecuteNonQuery();

                    if (delete > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in deleteUserByID: " + e.ToString());
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return result;
        }
=======
        

>>>>>>> 22c97dd20bcbcfc3af41f4ec3c3aac97838afe5b
    }
}
