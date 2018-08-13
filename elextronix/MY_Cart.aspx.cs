using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class MY_Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SumOfBill_Lit.Text = "Sub Total Price , ";

        if (HttpContext.Current.User.Identity.Name == string.Empty)
        {
            Response.Redirect("~/");
        }


        ViewBayerProduct.Controls.Clear();


        int OrderId = GiveMeNotCompletedOrderID();

        if (OrderId == 0)
        {

            //Label MsgLab = new Label();



            string xx = Request.QueryString["done"];


            if (xx == "true")
            {
                MsgLab.Text = "Congratulation, Thank You for Your Visitor...,";
            }
            else
            {
                MsgLab.Text = "your cart is empty";
            }

        
            ViewBayerProduct.Controls.Add(MsgLab);
            return;

        }

        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "Select ProdID,OrderDetailsID from OrderDetails where OrderID=@OrderID";

        cmd.Parameters.Add("@OrderId", SqlDbType.Int, 4).Value = OrderId;


        // IsCompleted=@IsCompleted
        con.Open();
        SqlDataReader Reader = cmd.ExecuteReader();
        while (Reader.Read())
        {
            if (!Reader.IsDBNull(0))
            {

                MyCartUserControl ShowBuyerProd = (ASP.mycartusercontrol_ascx)Page.LoadControl("~/MyCartUserControl.ascx");
                ShowBuyerProd.ID = "ShowBuyerProd" + Reader.GetInt32(1).ToString();
                ShowBuyerProd.ProdID = Reader.GetInt32(0);
                ShowBuyerProd.ShowMycartProd();
                ViewBayerProduct.Controls.Add(ShowBuyerProd);
            }
        }
        Reader.Close();
        con.Close();
        SumOfBill_Lit.Text += ExecuteOrder.TotalOfBill(ExecuteQuant.GiveMeNotCompletedOrderID()).ToString();


    }
    public int GiveMeNotCompletedOrderID()
    {
        int OrderID = 0;
        int ID;
        int.TryParse(HttpContext.Current.User.Identity.Name, out ID);
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select OrderID from Orders where Cust_ID=@Cust_ID and IsCompleted=@IsCompleted";
        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = ID;
        cmd.Parameters.Add("@IsCompleted", SqlDbType.Bit, 1).Value = false;

        con.Open();
        object OrderIDobj = cmd.ExecuteScalar();

        if (OrderIDobj != null)
        {
            if (!(OrderIDobj is DBNull))
            {
                OrderID = (int)OrderIDobj;
            }
        }
        con.Close();
        return OrderID;
    }

    public int GiveMeProductID()
    {
        int ProdID = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select ProdID from OrderDetails Where OrderID=@OrderID";
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = ExecuteQuant.GiveMeNotCompletedOrderID();
        con.Open();
        object ProdOBJ = cmd.ExecuteScalar();
        if (ProdOBJ != null)
        {
            if (!(ProdOBJ is DBNull))
            {
                ProdID = (int)ProdOBJ;
            }
        }
        con.Close();
        return ProdID;
    }


    protected void PaycartAndEnd_BUT_Click(object sender, EventArgs e)
    {




        int Cust_ID;
        int.TryParse(HttpContext.Current.User.Identity.Name, out  Cust_ID);
        float TotalPrice;
        float.TryParse(SumOfBill_Lit.Text, out TotalPrice);
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "update Orders set IsCompleted=@IsCompleted,TotalPrice=@TotalPrice Where OrderID=@OrderID and Cust_ID=@Cust_ID";
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = ExecuteQuant.GiveMeNotCompletedOrderID();
        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = Cust_ID;
        cmd.Parameters.Add("@TotalPrice", SqlDbType.Money, 8).Value = TotalPrice;
        cmd.Parameters.Add("@IsCompleted", SqlDbType.Bit, 1).Value = true;

        con.Open();
        //int ar = 
            cmd.ExecuteNonQuery();
  
        
        con.Close();
        //if (ar == 1)
        //{
        //    SumOfBill_Lit.Text = "<script type='javascript/text'>window.alert('Thanks For Pay.') </script>";
        //    Response.Redirect("~/MY_Cart.aspx");
        //}




        Response.Redirect("~/MY_Cart.aspx?done=true");
    }

    protected void BackProducts_But_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Products.aspx");
    }
}