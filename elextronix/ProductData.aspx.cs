using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class ProductData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=.;Initial Catalog=Market_Web;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into  Product  (ProdName,CatID,ImageURL,Price,Quantity,ShortDesc,LongDesc,Notes) values (@ProdName,@CatID,@ImageURL,@Price,@Quantity,@ShortDesc,@LongDesc,@Notes) ";

        cmd.Parameters.Add("@ProdName", SqlDbType.NVarChar, 200).Value = ProductUserControl.ProdName;
        cmd.Parameters.Add("@CatID", SqlDbType.Int, 4).Value = ProductUserControl.CatID;
        cmd.Parameters.Add("@Price", SqlDbType.Money).Value = ProductUserControl.Price;
        cmd.Parameters.Add("@Quantity", SqlDbType.Int, 4).Value = ProductUserControl.Quantity;
        cmd.Parameters.Add("@ShortDesc", SqlDbType.NVarChar,200).Value = ProductUserControl.Short_Desc;
        cmd.Parameters.Add("@LongDesc", SqlDbType.NVarChar, 2000).Value = ProductUserControl.Long_Desc;
        cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 200).Value = ProductUserControl.Notes;






        //  FileUpload fu = ProductUserControl1.FileUploadObj;

        //  string FilePathName = Server.MapPath("~/upload/") + fu.FileName;

        //   fu.SaveAs(FilePathName);

        cmd.Parameters.Add("@ImageURL", SqlDbType.NVarChar, 50).Value = ProductUserControl.FileUpload_FileName; //fu.PostedFile.FileName ;//DBNull.Value;



        con.Open();
        int ar=cmd.ExecuteNonQuery();

        con.Close();
        if(ar==1)
        {
            Result_Label.Text="Add Is Done .........";
        }
        else
        {
         Result_Label.Text= "Sorry Your Data not be Saved ,Check Please....,";
        }

    }
    protected void NewPRod_BUt_Click(object sender, EventArgs e)
    {
        controls_view.SetActiveView(new_product_view);
    }
    protected void EDitProd_But_Click(object sender, EventArgs e)
    {
        //controls_view.SetActiveView(edit_product_view);
        //Delete_Panal.Visible = true;


    }
    protected void RemoveProd_But_Click(object sender, EventArgs e)
    {
        controls_view.SetActiveView(remove_product_view);
    }
    protected void EnterID_But_Click(object sender, EventArgs e)
    {
        //check remove id textbox...
         //here must be IF condetion to check from Data Base....
      // Delete_Panal.Visible = true;
        //delet_buttons_panal.Visible = true;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText="Delete from Product Where ProdID=@ProdID";
        cmd.Parameters.Add("ProdID", SqlDbType.Int, 4).Value = DropDownList1.SelectedValue;
        con.Open();
        int ar = cmd.ExecuteNonQuery();
        con.Close();
        if(ar==1)
        {
            Result_Label.Text = "<p style='margin-left:200px;'>Product has been delete succesfully.......</p>";

        }
        else
        {
         Result_Label.Text = "<p style='margin-left:200px;'>Oops You Have an Error...<p>";
        }
    
    
    
    }
}