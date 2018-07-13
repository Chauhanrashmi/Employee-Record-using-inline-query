using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace nsemployee
{
    public interface intemp
    {
        Int32 Empno { get; set; }
        String Empname { get; set; }
        String Empad { get; set; }
        Int32 Empsal { get; set; }
    }

    public class clsempprp : intemp
    {
        private Int32 prvEmpno, prvEmpsal;
        private String prvEmpname, prvEmpad;

        public int Empno
        {
            get
            {
                return prvEmpno;
            }

            set
            {
                prvEmpno = value;
            }
        }

        public string Empname
        {
            get
            {
                return prvEmpname;
            }
            set
            {
                prvEmpname = value;
            }
        }
        public string Empad
        {
            get
            {
                return prvEmpad;
            }
            set
            {
                prvEmpad = value;
            }
        }
        public int Empsal
        {
            get
            {
                return prvEmpsal;
            }
            set
            {
                prvEmpsal = value;
            }
        }

    }
        public abstract class clscon
        {
            protected SqlConnection con = new SqlConnection();
            public clscon()
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            }
        }

        public class clsemp : clscon
        {
            public void save_rec(clsempprp p)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("insertemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Empno",SqlDbType.Int).Value=p.Empno;
                cmd.Parameters.Add("@Empname",SqlDbType.VarChar,50).Value=p.Empname;
                cmd.Parameters.Add("@Empad", SqlDbType.VarChar, 50).Value = p.Empad;
                cmd.Parameters.Add("@Empsal",SqlDbType.Int).Value=p.Empsal;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            public void update_rec(clsempprp p)
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("updateemp",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = p.Empno;
                cmd.Parameters.Add("@Empname", SqlDbType.VarChar,50).Value = p.Empname;
                cmd.Parameters.Add("@Empad", SqlDbType.VarChar,50).Value = p.Empad;
                cmd.Parameters.Add("@Empsal", SqlDbType.Int).Value = p.Empsal;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            public void delete_rec(clsempprp p)
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("deleteemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = p.Empno;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

            }
            public List<clsempprp> disp_rec()
            {
              if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("displayemp",con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsempprp> obj = new List<clsempprp>();
                while(dr.Read())
                {
                    clsempprp k = new clsempprp();
                    k.Empno = Convert.ToInt32(dr[0]);
                    k.Empname = dr[1].ToString();
                    k.Empad = dr[2].ToString();
                    k.Empsal=Convert.ToInt32(dr[3]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
            public List<clsempprp> find_rec(Int32 Empno)
            {
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("findemp",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Empno;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsempprp> obj = new List<clsempprp>();
                if(dr.HasRows)
                {
                    dr.Read();
                    clsempprp k = new clsempprp();
                    k.Empno = Convert.ToInt32(dr[0]);
                    k.Empname = dr[1].ToString();
                    k.Empad = dr[2].ToString();
                    k.Empsal = Convert.ToInt32(dr[3]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
    }

