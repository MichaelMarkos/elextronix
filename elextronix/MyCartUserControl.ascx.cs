using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class MyCartUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private int _ProdID;
    public int ProdID
    {
        set
        {
            _ProdID = value;
        }
        get
        {
            return _ProdID;
        }
    }
    public decimal GetPriceFromProd()
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con2 = new SqlConnection(constr);
        SqlCommand cmd2 = new SqlCommand();
        cmd2.Connection = con2;
       
       cmd2.CommandText = "Select Price from Product Where ProdID=@ProdID";
       cmd2.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        decimal SellPrice=0;
        con2.Open();
        Object PriceOBJ = cmd2.ExecuteScalar();
        if (PriceOBJ != null)
        {
            if (!(PriceOBJ is DBNull))
            {
                SellPrice = (decimal)PriceOBJ;
            }
        }
        con2.Close();
        return SellPrice;
    }
    public decimal GetNewSellPrice(decimal NewSellPrice)
    {
       decimal NSP = NewSellPrice + (NewSellPrice * 10 / 100);
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con2 = new SqlConnection(constr);
        SqlCommand cmd2 = new SqlCommand();
        cmd2.Connection = con2;
        cmd2.CommandText = "Update OrderDetails set Price=@Price Where ProdID=@ProdID";
        cmd2.Parameters.Add("@Price", SqlDbType.Money, 8).Value = NSP;
        cmd2.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con2.Open();
        cmd2.ExecuteNonQuery();
        con2.Close();
        return NSP;
    }


    public void ShowMycartProd()
    {
        Label_Price.Text = GetNewSellPrice(GetPriceFromProd()).ToString();
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con1 = new SqlConnection(constr);
        SqlCommand cmd1 = new SqlCommand();
        cmd1.Connection = con1;
        cmd1.Connection = con1;
        cmd1.CommandText = "Select Product.ProdName,OrderDetails.Price,OrderDetails.Quantity,OrderDetails.SubTotalPrice from Product inner join OrderDetails on Product.ProdID=orderDetails.ProdID Where Product.ProdID=@ProdID and OrderDetails.OrderID=@OrderID";
        cmd1.Parameters.Add("ProdID", SqlDbType.Int, 4).Value = ProdID;
        cmd1.Parameters.Add("OrderID", SqlDbType.Int, 4).Value = ExecuteQuant.GiveMeNotCompletedOrderID();

       con1.Open();
            SqlDataReader reader = cmd1.ExecuteReader();
        
        if (reader.Read())
        {
            if (!reader.IsDBNull(0))
            {
                Label_ProductName.Text = reader.GetString(0);
            }
            if(!(reader.IsDBNull(1)))
            {
                Label_Price.Text = reader.GetDecimal(1).ToString();
            }
            if(!(reader.IsDBNull(2)))
            {
                int PQ=reader.GetInt32(2);
                QuantityProdTB.Text = PQ.ToString();
            }
            if(!reader.IsDBNull(3))
            {
                Label_TotalPrice.Text = reader.GetDecimal(3).ToString();
            }
        }
        reader.Close();
        con1.Close();
    }

    protected void EditQuantity_But_Click(object sender, EventArgs e)
    {
        int NewQuntity;
        int.TryParse(QuantityProdTB.Text, out NewQuntity);
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Update OrderDetails set Quantity=@Quantity where ProdID=@ProdId";
        cmd.Parameters.Add("@Quantity",SqlDbType.Int,8).Value=NewQuntity;
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("~/MY_Cart.aspx");
    }
    protected void Remove_But_Click(object sender, EventArgs e)
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "delete from OrderDetails Where ProdID=@ProdID";
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        Response.Redirect("~/MY_Cart.aspx");
    }
}