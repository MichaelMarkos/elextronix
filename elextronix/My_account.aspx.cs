using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class My_account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (HttpContext.Current.User.Identity.Name == string.Empty)
        {
            Response.Redirect("~/Login.aspx");

        }
        else
        {


            if (!Page.IsPostBack)
            {
                int Cust_ID;
                int.TryParse(HttpContext.Current.User.Identity.Name, out Cust_ID);

                string Name;
                bool Gender_is_Male;
                string Address;
                string EMail;
                string Age;
                string Password;

                UserData.getUserDataByID(Cust_ID, out Name,out Gender_is_Male,out Age,out Address ,out EMail,out Password);


                
                _signWebUserControl.Name = Name;
                _signWebUserControl.GenderIsMale = Gender_is_Male;
                _signWebUserControl.Address = Address;
                _signWebUserControl.EMail = EMail;

                
                _signWebUserControl.age = Age;
               // _signWebUserControl.password = Password;
             
            }

        }



    }
    protected void Button1_Click(object sender, EventArgs e)
    {




        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=ITC-LAP1-MASTER;Initial Catalog=TEST1;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update  Customers   set Name=@Name ,Gender_is_Male=@Gender_is_Male,Age=@Age,Address=@Address,EMail=@EMail ,Password=@Password  where Cust_ID=@Cust_ID";


        int Cust_ID;
        int.TryParse(HttpContext.Current.User.Identity.Name, out Cust_ID);

        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = Cust_ID;
        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 50).Value = _signWebUserControl.Name;
        cmd.Parameters.Add("@Gender_is_male", SqlDbType.Bit, 1).Value = _signWebUserControl.GenderIsMale;

        cmd.Parameters.Add("@Age", SqlDbType.Int).Value = _signWebUserControl.age;

        cmd.Parameters.Add("@Address", SqlDbType.NVarChar,200).Value = _signWebUserControl.Address;
        
        cmd.Parameters.Add("@EMail", SqlDbType.NVarChar, 100).Value = _signWebUserControl.EMail;


        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = _signWebUserControl.password;







        con.Open();

        int M= cmd.ExecuteNonQuery();

        con.Close();

        if (M == 1)
            Label2.Text = "updated success.";
        else
            Label2.Text = "Sorry, Check Please......,";




    }
}