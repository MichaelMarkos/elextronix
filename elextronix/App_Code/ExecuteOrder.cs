using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ExecuteOrder
/// </summary>

public static class ExecuteOrder
{
	public static bool CheckOrderCreation(int OrderID,int Cust_ID)
    {
        bool Cheacker = true;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select Orders.IsCompleted from Orders Where Orders.Cust_ID=@Cust_ID Orders.OrderID=@OrderID";
        cmd.Parameters.Add("@Cust_ID",SqlDbType.Int,4).Value=Cust_ID;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        con.Open();
        Object CheackerOBJ = cmd.ExecuteScalar();
        if(CheackerOBJ !=null)
        {
            if(! (CheackerOBJ is DBNull))
            {
                Cheacker = (bool)CheackerOBJ;
            }
        }
        con.Close();
        return Cheacker;
    }
    
    
  
    public static float TotalOfBill(int OrderID)
    {
        float Total = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select Sum(SubTotalPrice) As 'Total Bill' from OrderDetails Where OrderID=@OrderID";
        cmd.Parameters.Add("@OrderID",SqlDbType.Int,4).Value=OrderID;
        con.Open();
        object TotalOBJ = cmd.ExecuteScalar();
        if(TotalOBJ !=null)
        {
            if(! (TotalOBJ is DBNull))
            {
                Total = (float)TotalOBJ;
            }
        }
        con.Close();
        return Total;
    }
    public static int ROWID(int OrderID,int ProdID)
    {
       int ROWID = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select OrderDetailsID from OrderDetails Where ProdID=@ProdID and OrderID=@OrderID";
        cmd.Parameters.Add("@ProdID",SqlDbType.Int,4).Value=ProdID;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        con.Open();
        object ROWIDOBJ = cmd.ExecuteScalar();
    if(ROWIDOBJ !=null)
    {
        if(!(ROWIDOBJ is DBNull))
        {
            ROWID = (int)ROWIDOBJ;
        }
    }
    con.Close();
    return ROWID;
    }
    public static bool CheckThisProduct(int OrderID,int ROW, int ProdID)
    {
        bool CheckProduct = false ;
        int IDOfProd = 0;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select ProdID from OrderDetails Where ProdID=@ProdID and OrderID=@OrderID";
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        con.Open();
        Object ChecKPRoOBJ = cmd.ExecuteScalar();
        if (ChecKPRoOBJ !=null)
        {
            if(!(ChecKPRoOBJ is DBNull))
            {
                IDOfProd = (int)ChecKPRoOBJ;
                if(IDOfProd==0)
                {
                    CheckProduct = false;
                }
                else
                {
                    CheckProduct = true;
                }
            }
        }
        con.Close();
        return CheckProduct;
       
    }

    public static void UPdateProdeInMYOrder(int OrderID,int ProdID,int Quantity,int ROWID)
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "RenewQuantity";
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@Quantity", SqlDbType.Int, 4).Value = Quantity;
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        cmd.Parameters.Add("@ProdID", SqlDbType.Int, 4).Value = ProdID;
        cmd.Parameters.Add("@ROWID", SqlDbType.Int, 4).Value = ROWID;
        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public static int GiveMEQuantity(int OrderID, int ROWID)
    {
        int Quant = 1;
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Select Quantity from OrderDetails Where OrderID=@OrderID and OrderDetailsID=@ROWID";
        cmd.Parameters.Add("@OrderID", SqlDbType.Int, 4).Value = OrderID;
        cmd.Parameters.Add("@ROWID", SqlDbType.Int, 4).Value = ROWID;
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


    //public static int ROWID(int p, int ProdID1, int ProdID2)
    //{
    //    throw new NotImplementedException();
    //}
}