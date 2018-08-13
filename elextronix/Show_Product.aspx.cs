using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Show_Product : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string constr = System.Configuration.ConfigurationManager.ConnectionStrings["test1ConStr"].ConnectionString;

        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

        cmd.CommandText = "select ProdID from Product";

        con.Open();

        SqlDataReader reader = cmd.ExecuteReader();

        //For Table 

        Table1.Rows.Clear();

        TableRow tr = new TableRow();

        Table1.Rows.Add(tr);

        int Counter = 1;

        while (reader.Read())
        {
            int Prodid = 0;

            if (!reader.IsDBNull(0))
            {
                Prodid = reader.GetInt32(0);

            }

            Show_productUserControl sp = (ASP.show_productusercontrol_ascx)Page.LoadControl("~/Show_productUserControl.ascx");


            sp.ID = "Psuc" + Prodid.ToString();
            sp.ProdID = Prodid;
            sp.SetData();

            //...........cells
            TableCell tc = new TableCell();
            tr.Cells.Add(tc);
            tc.Controls.Add(sp);

            Counter++;

            if (Counter > 3)
            {
                TableRow trx = new TableRow();
                Table1.Rows.Add(trx);
                tr = trx;
                Counter = 1;
            }


        }
        reader.Close();
        con.Close();



    }
}