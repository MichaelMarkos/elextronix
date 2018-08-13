using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OneProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowOnlyProdPleaseHolder.Controls.Clear();
        if (Request.QueryString["prodid"] != null)
        {
            int prodid;
            int.TryParse(Request.QueryString["prodid"], out prodid);
            OnlyOneProdShowUserControl ShowOnlyOneProd = (ASP.onlyoneprodshowusercontrol_ascx)Page.LoadControl("~/OnlyOneProdShowUserControl.ascx");
            ShowOnlyOneProd.ID = "productID" + prodid.ToString();
            ShowOnlyOneProd.ProdID = prodid;
            ShowOnlyOneProd.SetData();
            ShowOnlyProdPleaseHolder.Controls.Add(ShowOnlyOneProd);
        }
    }
}