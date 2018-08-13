using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


public partial class MasterPage2 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Menu_Lit.Text = "";

        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "select CatID, CatName from Cat";

        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();


        Menu_Lit.Text = "<ul class='left_menu'>";
        bool IsOdd = true;

        while (reader.Read())
        {
            int CatID = 0;
            string CatName = "";

            if (!reader.IsDBNull(0))
                CatID = reader.GetInt32(0);

            if (!reader.IsDBNull(1))
                CatName = reader.GetString(1).Trim();


            if (CatName != "")
            {
                if (IsOdd)
                    Menu_Lit.Text += " <li class='odd'><a href='/products.aspx?cat=" + CatID.ToString()+"'>" + CatName + "</a></li>";
                else
                    Menu_Lit.Text += " <li class='even'><a href='/products.aspx?cat=" + CatID.ToString() + "'>" + CatName + "</a></li>";

                IsOdd = !IsOdd;


            }

        }



        Menu_Lit.Text += "</ul>";

        reader.Close();
        con.Close();

    }






}