using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.Identity.Name == string.Empty)
        {

            MultiView1.SetActiveView(ViewUnknow);
        }
        else
        {
            MultiView1.SetActiveView(ViewUser);
            Name_for_user.Text = HttpContext.Current.User.Identity.Name;
        }
   




     if (HttpContext.Current.User.Identity.Name != string.Empty)
        {
            int Cust_ID;
            int.TryParse(HttpContext.Current.User.Identity.Name, out Cust_ID);



            Name_for_user.Text = " " + UserData.GetUserNameFromID(Cust_ID);

        }
        else
        {
            Name_for_user.Text = "Please Login.";

        }

    }



    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        System.Web.Security.FormsAuthentication.SignOut();
        Response.Redirect("~/");
    }
}
