using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.registroMarcacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "LeerPersona" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione LeerPersona.svc o LeerPersona.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class LeerPersona : ILeerPersona
    {
        public string f_leerPersona()
        {
            string res="";
            string connStr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("CAJATRUJILLO.SHOWALL", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        
                        cmd.Connection = con;
                        using (DataTable dt = new DataTable())
                        {
                            try
                            {
                                sda.SelectCommand = cmd;
                                con.Open();
                                cmd.ExecuteNonQuery();
                                sda.Fill(dt);


                                res = string.Join(Environment.NewLine,
                                dt.Rows.OfType<DataRow>().Select(x => string.Join(" ; ", x.ItemArray)));
                            }
                            catch (Exception) { 
                            
                            }
                            
                        }
                        
                    }

                }
            }
            return res;
        }
    }
}
