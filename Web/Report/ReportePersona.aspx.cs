using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report_ReportePersona : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void buscar_Click(object sender, EventArgs e)
    {
        //Populating a DataTable from database.
        leerReferencia.LeerPersonaClient cliente = new leerReferencia.LeerPersonaClient();
        string salida = cliente.f_leerPersona();
       DataTable dt = GetData(salida);

            //Building an HTML string.
       StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table border = '1'>");
 
                //Building the Header row.
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
        html.Append("</tr>");

        //Building the Data rows.
        foreach (DataRow row in dt.Rows)
        {
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                html.Append("<td>");
                html.Append(row[column.ColumnName]);
                html.Append("</td>");
            }
            html.Append("</tr>");
        }

        //Table end.
        html.Append("</table>");

        //Append the HTML string to Placeholder.
        PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
    }

    public DataTable GetData(string data)
    {
        DataTable dataTable = new DataTable(); 
        string[] keyValue = { "nombre", "razon social", "Tipo documento", "pass" };
        DataColumn dataColumn0 = new DataColumn(keyValue[0]);
        DataColumn dataColumn1 = new DataColumn(keyValue[1]);
        DataColumn dataColumn2 = new DataColumn(keyValue[2]);
        DataColumn dataColumn3 = new DataColumn(keyValue[3]);
        dataTable.Columns.Add(dataColumn0);
        dataTable.Columns.Add(dataColumn1);
        dataTable.Columns.Add(dataColumn2);
        dataTable.Columns.Add(dataColumn3);

        foreach (string row in data.Split('\r'))
        {
            DataRow dataRow = dataTable.NewRow();
           
            int i = 0;
            foreach (string cell in row.Split(';'))
            {
                dataRow[i] = cell;
                i++;
            }
            dataTable.Rows.Add(dataRow);
        }
        return dataTable;
    }


}