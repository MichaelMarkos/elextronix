using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ExecuteQuant
/// </summary>
public class ExecuteQuant
{
    public static void UPdateQuantityOFProdeInMYOrder(int OrderID, int ProdID, int Quantity)
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Update OrderDetails set Quantity=@Quantity Where OrderID=@OrderID and ProdID=@ProdID";
        cmd.Parameters.Add("@Quantity", SqlDbType.Int, 4).Value = Quantity;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }


    public static int GetCountOFProductFromOrder(int OrderID, int ProdID)
    {
        int Quant = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select Quantity from OrderDetails Where OrderID=@OrderID and ProdID=@ProdID";
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        con.Open();
        object QuanOBJ = cmd.ExecuteScalar();
        if (QuanOBJ != null)
        {
            if (!(QuanOBJ is DBNull))
            {
                Quant = (int)QuanOBJ;
            }

        }

        con.Close();
        return Quant;
    }



    public static int GiveMeNotCompletedOrderID()
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
}