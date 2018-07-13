using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    nsemployee.clsempprp objprp = new nsemployee.clsempprp();
    nsemployee.clsemp obj = new nsemployee.clsemp();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        objprp.Empno = Convert.ToInt32(TextBox1.Text);
        objprp.Empname = TextBox2.Text;
        objprp.Empad = TextBox3.Text;
        objprp.Empsal = Convert.ToInt32(TextBox4.Text);
        obj.save_rec(objprp);
        ListBox1.DataBind();
        clear_rec();
    }

    private void clear_rec()
    {
        TextBox1.Text = String.Empty;
        TextBox2.Text = String.Empty;
        TextBox3.Text = String.Empty;
        TextBox4.Text = String.Empty;
        TextBox1.Focus();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<nsemployee.clsempprp> k;
        k = obj.find_rec(Convert.ToInt32(ListBox1.SelectedValue));
        TextBox1.Text = k[0].Empno.ToString();
        TextBox2.Text = k[0].Empname;
        TextBox3.Text = k[0].Empad;
        TextBox4.Text = k[0].Empsal.ToString();
    }



    protected void Button5_Click(object sender, EventArgs e)
    {
        clear_rec();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        objprp.Empno = Convert.ToInt32(TextBox1.Text);
        objprp.Empname = TextBox2.Text;
        objprp.Empad = TextBox3.Text;
        objprp.Empsal = Convert.ToInt32(TextBox4.Text);
        obj.update_rec(objprp);
        ListBox1.DataBind();
        clear_rec();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        objprp.Empno = Convert.ToInt32(TextBox1.Text);
        obj.delete_rec(objprp);
        ListBox1.DataBind();
        clear_rec();
    }
}