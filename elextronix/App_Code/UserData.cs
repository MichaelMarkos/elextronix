using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for UserData
/// </summary>
public class UserData
{
    public UserData()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static string GetUserNameFromID(int Cust_ID)
    {

        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=ITC-LAP1-MASTER;Initial Catalog=TEST1;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select Name from  Customers  where Cust_ID=@Cust_ID ";

        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = Cust_ID;



        string Name = "";


        con.Open();

        object NameObj = cmd.ExecuteScalar();

        if (NameObj != null)
        {
            if (!(NameObj is DBNull))
                Name = (string)NameObj;
        }


        return Name;

    }


    public static void getUserDataByID(int Cust_ID, out string Name, out bool Gender_is_Male,out string Age, out string Address, out string EMail,out string Password)
    {

        Name = "";
        Gender_is_Male = false;
        Age = "";
        Address = "";
        EMail = "";
        Password = "";
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString; //"Data Source=ITC-LAP1-MASTER;Initial Catalog=TEST1;Integrated Security=True";

        SqlConnection con = new SqlConnection(constr);

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select Name, Gender_is_Male,Age,Address,EMail,Password from  Customers  where Cust_ID=@Cust_ID ";

        cmd.Parameters.Add("@Cust_ID", SqlDbType.Int, 4).Value = Cust_ID;

        con.Open();
        SqlDataReader reader = cmd.ExecuteReader();


        if (reader.Read())
        {

            if (!reader.IsDBNull(0))
                Name = reader.GetString(0);

            if (!reader.IsDBNull(1))
                Gender_is_Male = reader.GetBoolean(1);

            if (!reader.IsDBNull(2))
                Age = reader.GetInt32(2).ToString();

            if (!reader.IsDBNull(3))
                Address = reader.GetString(3);

            if (!reader.IsDBNull(4))
                EMail = reader.GetString(4);

            if (!reader.IsDBNull(5))
               Password = reader.GetString(5);


            
        }

        reader.Close();
        con.Close();






    }


}