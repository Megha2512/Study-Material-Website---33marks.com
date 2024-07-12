using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for count
/// </summary>
public class count
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

    public  count()
    {
       
    }

    public int TotalCount(string table)
    {
        int count = 0;
        try
        { 
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            string sql = "select * from "+ table;

            SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@table", table.Trim());
            //cmd.Parameters.AddWithValue("@status", 1);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
           count = dt.Rows.Count;


        }
        catch (Exception ex)
        {
            return 6;
        }
        finally
        {
            con.Close();
        }
        return count;
    }
}