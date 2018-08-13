using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.Security;

using System.Data;
using System.Data.SqlClient;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        Label1.Text = "";
        //if (!Page.IsValid)
        //{
        //    //error messsage
        //    return;
        //}


        //if (FormsAuthentication.Authenticate(UsernameLogTb.Text, PaSSwordLogTB.Text))
        //{
        //    FormsAuthentication.RedirectFromLoginPage(UsernameLogTb.Text, Remember_checkbox.Checked);
        //}
        //else
        //{
        //   Wrong_login.Text = "sorry,wrong user name or password.";
        //}








        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=ITC-LAP1-MASTER;Initial Catalog=TEST1;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select Cust_ID from  Customers   where Name=@Name and Password=@Password ";

        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value =UsernameLogTB.Text;

        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = PaSSwordLogTB.Text;


        con.Open();

        object custIDObj = cmd.ExecuteScalar();

        con.Close();

        int Cust_ID = 0;


        if (custIDObj != null)
        {
            if (!(custIDObj is DBNull))
                Cust_ID = (int)custIDObj;
        }


        //------------

        if (Cust_ID == 0)
        {

            Wrong_login.Text = "sorry,wrong user name or password.";
            return;
        }



        // login for user:


        FormsAuthentication.SetAuthCookie(Cust_ID.ToString(), Remember_checkbox.Checked);

        Response.Redirect("~/");



        //if (FormsAuthentication.Authenticate(TextBox1.Text, PassTB.Text))
        //{
        //    FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, CheckBox1.Checked);
        //}
        //else
        //{
        //    Label1.Text = "sorry,wrong user name or password.";
        //}

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}