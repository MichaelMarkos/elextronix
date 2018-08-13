using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Sign_Up : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=ITC-LAP1-MASTER;Initial Catalog=TEST1;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into  Customers  (Name,Gender_is_male,Password,EMail,Address,Age) values (@Name,@gender_is_male,@Password,@EMail,@Address,@Age) ";

        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = _signWebUserControl.Name;

        cmd.Parameters.Add("@Gender_is_male", SqlDbType.Bit, 1).Value = _signWebUserControl.GenderIsMale;
        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = _signWebUserControl.password;
        cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 100).Value = _signWebUserControl.EMail;

        cmd.Parameters.Add("@Address", SqlDbType.NVarChar,200).Value = _signWebUserControl.Address;

        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = _signWebUserControl.age;




        con.Open();

        cmd.ExecuteNonQuery();

        con.Close();



        System.Web.Security.FormsAuthentication.RedirectToLoginPage();




    }
}