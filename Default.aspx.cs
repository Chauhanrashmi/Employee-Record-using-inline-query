using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }

   

    private void record()
    {
        TextBox1.Text = "";
        TextBox2.Text = string.Empty;
        TextBox3.Text = string.Empty;
        TextBox4.Text = string.Empty;
        TextBox1.Focus();
    }



    protected void Button4_Click(object sender, EventArgs e)
    {
        Dis_rec();
    }

    private void Dis_rec()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "Select * from emp";
        cmd.Connection = con;
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        ListBox1.DataTextField = "Empname";
        ListBox1.DataValueField = "Empno";
        ListBox1.DataSource = dr;
        ListBox1.DataBind();
        dr.Close();
        cmd.Dispose();
    }


    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from emp where Empno=@Empno";
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno",SqlDbType.Int).Value=Convert.ToInt32(ListBox1.SelectedValue);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox1.Text = dr["Empno"].ToString();
            TextBox2.Text = dr["Empname"].ToString();
            TextBox3.Text = dr["Empad"].ToString();
            TextBox4.Text = dr["Empsal"].ToString();
        }
        dr.Close();
        cmd.Dispose();
    }

   

    protected void Button1_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert emp values(@Empno,@Empname,@Empad,@Empsal)";
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@Empname", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@Empad", SqlDbType.VarChar, 50).Value = TextBox3.Text;
        cmd.Parameters.Add("@Empsal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        Dis_rec();
        record();
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update emp set Empname=@Empname,Empad=@Empad,Empsal=@Empsal where Empno=@Empno";
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@Empname", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@Empad", SqlDbType.VarChar, 50).Value = TextBox3.Text;
        cmd.Parameters.Add("@Empsal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        Dis_rec();
        record();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from emp where Empno=@Empno";
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno",SqlDbType.Int).Value=Convert.ToInt32(TextBox1.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        Dis_rec();
        record();
    }
}