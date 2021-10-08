using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace PruebaB2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source = DESKTOP-73KSAG3\\SQLEXPRESS;" + "Initial Catalog = VENTAS; Integrated Security = True";
            string selectSQL = "SELECT * FROM Clientes";
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(selectSQL, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            // llenando el dataset
            DataSet ventas = new DataSet();
            adapter.Fill(ventas, "CLIENTES");
            // enlazar el gridview
            GridView1.DataSource = ventas;
            GridView1.DataBind();


        }
    }
}