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
                string sql = "SELECT * FROM usertbl WHERE lastname LIKE @lastname AND firstname LIKE @firstname AND middlename LIKE @middlename";
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@lastname", u.lastname);
                cmd.Parameters.AddWithValue("@firstname", u.firstname);
                cmd.Parameters.AddWithValue("@middlename", u.middlename);                
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Record already exist!");
                }
                else
                {
                    dr.Close();
                    sql = "INSERT INTO usertbl (lastname, firstname, middlename) VALUES (@lastname, @firstname, @middlename)";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@lastname", u.lastname);
                    cmd.Parameters.AddWithValue("@firstname", u.firstname);
                    cmd.Parameters.AddWithValue("@middlename", u.middlename);
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
                cmd.Parameters.AddWithValue("@admin", "1");
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Classes.Entities.users u = new Classes.Entities.users();
                        u.ID = dr["ID"].ToString();
                        u.lastname = dr["lastname"].ToString();
                        u.firstname = dr["firstname"].ToString();
                        u.middlename = dr["middlename"].ToString();
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
                    sql = "SELECT * FROM usertbl WHERE ID NOT LIKE @ID AND lastname=@lastname AND firstname=@firstname AND middlename=@middlename";
                    cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("ID", u.ID);
                    cmd.Parameters.AddWithValue("lastname", u.lastname);
                    cmd.Parameters.AddWithValue("firstname", u.firstname);
                    cmd.Parameters.AddWithValue("middlename", u.middlename);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Record already exist!");
                    }
                    else
                    {
                        dr.Close();
                        sql = "UPDATE usertbl SET lastname=@lastname, firstname=@firstname, middlename=@middlename WHERE ID LIKE @ID";
                        cmd = new OleDbCommand();
                        cmd.Parameters.AddWithValue("lastname", u.lastname);
                        cmd.Parameters.AddWithValue("firstname", u.firstname);
                        cmd.Parameters.AddWithValue("middlename", u.middlename);
                        cmd.Parameters.AddWithValue("ID", u.ID);
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
                    u.lastname = dr["lastname"].ToString();
                    u.firstname = dr["firstname"].ToString();
                    u.middlename = dr["middlename"].ToString();
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

        

    }
}
