using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Show_productUserControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    private int _prodID;


    public int ProdID
    {
        set
        {
            _prodID = value;
        }
        get
        {
            return _prodID;
        }
    }



    public void SetData()
    {
        Name_Prod.Text = "";
        Price_Prod.Text = "";

        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select ProdName,ImageURL,Price from Product where ProdID=@ProdID";
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;

        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            //ProductNAme
            if (!reader.IsDBNull(0))
                Name_Prod.Text = reader.GetString(0);

            //imageURL
            if (!reader.IsDBNull(1))
                Image_Prod.ImageUrl = "~/upload/" + reader.GetString(1);
        }

        //Product_Price
        if (!reader.IsDBNull(2))
            Price_Prod.Text = reader.GetDecimal(2).ToString();

        reader.Close();
        con.Close();

    }

    //.................................................MYCart From Hereeeeeeeeeeeeeeeeeeeeee

    

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        AddToCart();
    }


    private void AddToCart()
    {


        if (HttpContext.Current.User.Identity.Name == string.Empty)
            Response.Redirect("~/Login.aspx");


        //int NQ = ExecuteOrder.GiveMEQuantity( ExecuteQuant.GiveMeNotCompletedOrderID(), ExecuteOrder.ROWID( ExecuteQuant.GiveMeNotCompletedOrderID(), ProdID));

        //NQ++;


        int OrderID= ExecuteQuant.GiveMeNotCompletedOrderID();


        if (CheckOrderISComplete() == true)
        {
            CreationBill();
            InsertProdToMyBill();
            Response.Write("First Once...,");
        }
        else 
        {

            int pc = ExecuteQuant.GetCountOFProductFromOrder(OrderID, ProdID);

            if(pc==0)
            {
                  InsertProdToMyBill();
            }
            else
            {
                ExecuteQuant.UPdateQuantityOFProdeInMYOrder(OrderID, ProdID, pc + 1);
            }

            //// t/f---> chech if this product added to this cart before
            //if (!ExecuteOrder.CheckThisProduct( ExecuteQuant.GiveMeNotCompletedOrderID(), ExecuteOrder.ROWID(  ExecuteQuant.GiveMeNotCompletedOrderID(), ProdID), ProdID))
            //{
            //    //f..................
            //    InsertProdToMyBill();
            //    Response.Write("From first Check on Bill");

            //}
            //else if (ExecuteOrder.CheckThisProduct( ExecuteQuant.GiveMeNotCompletedOrderID(), ExecuteOrder.ROWID( ExecuteQuant.GiveMeNotCompletedOrderID(), ProdID), ProdID) == true)
            //{
            //    //t.................
            //    ExecuteOrder.UPdateProdeInMYOrder(  ExecuteQuant.GiveMeNotCompletedOrderID(), ExecuteOrder.ROWID(  ExecuteQuant.GiveMeNotCompletedOrderID(), ProdID), ProdID, NQ);
            //    Response.Write("from second check......");

            //}

        }

    }



   

   

    // han creat new bill for first action
    public void CreationBill()
    {
        float Price;
        float.TryParse(Price_Prod.Text, out Price);
        if (HttpContext.Current.User.Identity.Name != "")
        {
            int ID;
            int.TryParse(HttpContext.Current.User.Identity.Name, out ID);
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into orders(Cust_ID,OrderData,IsCompleted,TotalPrice) values(@Cust_ID,@OrderData,@IsCompleted,@TotalPrice)";
            cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = ID;
            cmd.Parameters.Add("@OrderData", SqlDbType.DateTime, 8).Value = DateTime.Now;
            cmd.Parameters.Add("IsCompleted", SqlDbType.Bit, 1).Value = false;
            cmd.Parameters.Add("@TotalPrice", SqlDbType.Money, 8).Value = Price;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //   con.Open();
            //int ar = cmd.ExecuteNonQuery();
            //if (ar == 1)
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
            //else
            //{
            //    Response.Write("~/Contact.aspx");
            //}

            //con.Close();
        }

    }
    //This Method to enter order prodID
   
    //This Method to enter order prod Price
    public float GiveMeSellPrice()
    {
        float Price = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select Price from Product where ProdID=@ProdID";
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con.Open();
        object PriceOBJ = cmd.ExecuteScalar();
        if (PriceOBJ != null)
        {
            if (PriceOBJ is DBNull)
            {
                Price = (float)PriceOBJ;
            }
        }
        con.Close();
        return Price;

    }


    //To insert Product To MY Bill
    public void InsertProdToMyBill()
    {


        int OrderID =  ExecuteQuant.GiveMeNotCompletedOrderID();

        if (OrderID != 0)
        {
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into OrderDetails(OrderID,ProdID,Quantity,Price) values(@OrderID,@ProdID,@Quantity,@Price)";



            cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
            cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
            cmd.Parameters.Add("@Quantity", SqlDbType.Int, 4).Value = 1;
            cmd.Parameters.Add("@Price", SqlDbType.Int, 4).Value = GiveMeSellPrice();
            con.Open();
            int ar = cmd.ExecuteNonQuery();
            if (ar == 1)
            {
                Response.Write("Done....,Man");
            }
            else
            {
                Response.Write("Sorry Man You Have error, Check Please,");
            }
        }

    }

    public bool CheckOrderISComplete()
    {
        int currentID;
        int.TryParse(HttpContext.Current.User.Identity.Name, out currentID);
        bool TestISComp = true;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select IsCompleted from Orders where Cust_ID=@Cust_ID and OrderID=@OrderID";
        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = currentID;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value =   ExecuteQuant.GiveMeNotCompletedOrderID();
        con.Open();
        Object ISCompletedOBJ = cmd.ExecuteScalar();
        if (ISCompletedOBJ != null)
        {
            if (!(ISCompletedOBJ is DBNull))
            {
                TestISComp = (bool)ISCompletedOBJ;
            }
        }
        con.Close();
        return TestISComp;
    }


    protected void Button1_Click1(object sender, EventArgs e)
    {
        string Querystring = ProdID.ToString();
        Response.Redirect("~/OneProduct.aspx?prodid=" + Querystring);
    }


   
    protected void ADDTOCart_Click1(object sender, EventArgs e)
    {

          AddToCart();
    }

}
