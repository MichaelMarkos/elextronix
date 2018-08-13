using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    public string Name
    {
        get
        {
            return NameTB.Text;
        }
        set
        {
            NameTB.Text = value;
        }
    }


    public string EMail
    {
        get
        {
            return EmailTB.Text;
        }
        set
        {
            EmailTB.Text = value;
        }
    }


    public string age
    {
        get
        {
            return AgeTB.Text;
        }
        set
        {
            AgeTB.Text = value;
        }
    }


    public string Address
    {
        get
        {
            return AddressTB.Text;
        }
        set
        {
            AddressTB.Text = value;
        }
    }


    public string password
    {
        get
        {
            return PasswordTB.Text;
        }

    }


    public string Repassword
    {
        get
        {
            return REPasswordTB.Text;
        }

    }

    public bool GenderIsMale
    {

        get
        {
            if (RadioButtonList1.SelectedValue == "M")
                return true;
            else
                return false;
        }

        set
        {
            if (value)
            {
                RadioButtonList1.SelectedValue = "M";
            }
            else
            {
                RadioButtonList1.SelectedValue = "F";
            }

        }
    }


}