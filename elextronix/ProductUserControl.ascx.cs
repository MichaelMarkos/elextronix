using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Image1.Visible = false;

        if (Page.IsPostBack)
        {
            if (FileUpload1.HasFile)
            {
                Image1.Visible = true;
                string FilePathName = Server.MapPath("~/upload/") + FileUpload1.FileName;
                FileUpload1.SaveAs(FilePathName);
                Image1.ImageUrl = "~/upload/" + FileUpload1.FileName;
            }
        }


    }




    public int CatID
    {
        get
        {
            string CAtstr = DropDownList1.SelectedValue;
            int catID;
            int.TryParse(CAtstr, out catID);
            return catID;
        }

    }




    public FileUpload FileUploadObj
    {
        get
        {
            return FileUpload1;
        }

    }

    public string FileUpload_FileName
    {
        get
        {
            if (FileUpload1.HasFile)
            {
                return FileUpload1.FileName;
            }
            else
            {
                return "";
            }

        }
    }

    public string ProdName
    {
        get
        {
            return ProdNameTB.Text;
        }
    }

    public string Price
    {
        get
        {
            return PriceTB.Text;
        }
    }

    public string Quantity
    {
        get
        {
            return QuantityTB.Text;
        }
    }

    public string Short_Desc
    {
        get
        {
            return ShortDEscTB.Text;

        }
    }
    public string Long_Desc
    {
        get
        {
            return LongDEscTB.Text;
        }
    }
    public string Notes
    {
        get
        {
            return NotesTB.Text;
        }
    }
    
}    

    