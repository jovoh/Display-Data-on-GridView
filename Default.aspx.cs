using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
//test
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet(); //gawa ng dataset
        DataTable dt = null;//gawa ng data table
        DataRow dr = null; //gawa ng data row
        
        DataColumn idCoulumn = null; //field para sa temporary table
        DataColumn nameCoulumn = null; //field para sa temporary table
        int i = 0; //initialize

        dt = new DataTable();
        idCoulumn = new DataColumn("ID", Type.GetType("System.Int32"));  //define ano data type ng field
        nameCoulumn = new DataColumn("Name", Type.GetType("System.String")); //define ano data type ng field

        dt.Columns.Add(idCoulumn); //tapos add ang column sa data table
        dt.Columns.Add(nameCoulumn); //tapos add ang column sa data table

        dr = dt.NewRow(); //ihanda para mag dagdag ng row
        dr["ID"] = 1; //add ng ID number
        dr["Name"] = "Name1";  //add ng name
        dt.Rows.Add(dr); //salpak sa datatable

        dr = dt.NewRow(); //ihanda para mag dagdag ng row
        dr["ID"] = 2; //add ng ID number
        dr["Name"] = "Name2"; //add ng name
        dt.Rows.Add(dr); //salpak sa datatable

    //    ds.Tables.Add(dt); //isalppak ang  data wet ang nagawang table
        /* pwedeng gamitin ang loop na to para mag insert sa isang buhay na database
       for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        {
           Console.Write  (ds.Tables[0].Rows[i][0] + "   --   " + ds.Tables[0].Rows[i][1]);
        }
        */
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}
