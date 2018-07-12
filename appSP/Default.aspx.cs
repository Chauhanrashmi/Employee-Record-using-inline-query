using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    SqlConnection con=new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        if (con.State==ConnectionState.Closed)
        {
            con.Open();
            
        }
        if(Page.IsPostBack==false)
        {
            //display_method();
        }
    }


    //clear the textboxes after action
    private void clear_rec()
    {
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        TextBox3.Text = String.Empty;
        TextBox4.Text = String.Empty;
        TextBox1.Focus();
    }


    //code for listbox
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "findemp";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(ListBox1.SelectedValue);
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.HasRows)
        {
            dr.Read();
            TextBox1.Text = dr[0].ToString();
            TextBox2.Text = dr[1].ToString();
            TextBox3.Text = dr[2].ToString();
            TextBox4.Text = dr[3].ToString();
        }
        dr.Close();
        cmd.Dispose();
    }
//    CREATE PROCEDURE findemp
//    @Empno int
//AS

//    SELECT* from emp where Empno=@Empno
//RETURN 0



    //display code
    protected void Button4_Click(object sender, EventArgs e)
    {
        display_method();
    }

    private void display_method()
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "displayemp";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        SqlDataReader dr = cmd.ExecuteReader();
        ListBox1.DataTextField = "Empname";
        ListBox1.DataValueField = "Empno";
        ListBox1.DataSource = dr;
        ListBox1.DataBind();
        dr.Close();
        cmd.Dispose();
    }
//    CREATE PROCEDURE displayemp
//AS

//    SELECT* from emp
//RETURN 0


    //update code
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "updateemp";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@Empname", SqlDbType.VarChar, 50).Value = TextBox2.Text;
        cmd.Parameters.Add("@Empad", SqlDbType.VarChar, 50).Value = TextBox3.Text;
        cmd.Parameters.Add("@Empsal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        clear_rec();
        display_method();
    }
//    CREATE PROCEDURE updateemp
//    @Empno int,
//	@Empname varchar(50),
//	@Empad varchar(50),
//	@Empsal int
//AS

//    UPDATE emp set Empname = @Empname, Empad = @Empad, Empsal = @Empsal where Empno = @Empno
//RETURN 0



    //delete code
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "deleteemp";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        display_method();
        clear_rec();
    }
//    CREATE PROCEDURE deleteemp
//    @Empno int
//AS

//    delete from emp where Empno=@Empno
//RETURN 0



    //save code
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insertemp";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = con;
        cmd.Parameters.Add("@Empno", SqlDbType.Int).Value = Convert.ToInt32(TextBox1.Text);
        cmd.Parameters.Add("@Empname", SqlDbType.VarChar,50).Value = TextBox2.Text;
        cmd.Parameters.Add("@Empad", SqlDbType.VarChar,50).Value = TextBox3.Text;
        cmd.Parameters.Add("@Empsal", SqlDbType.Int).Value = Convert.ToInt32(TextBox4.Text);
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        clear_rec();
        display_method();
    }
//    CREATE PROCEDURE insertemp
//    @Empno int,
//	@Empname varchar(50),
//	@Empad varchar(50),
//	@Empsal int
//AS

//    INSERT emp values(@Empno, @Empname, @Empad, @Empsal)
//RETURN 0


}