using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.login
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "login" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione login.svc o login.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class login : Ilogin
    {
        public bool validateLogin(string id, string razonsocial)
        {
            bool resp = false;
            string connStr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand("CAJATRUJILLO.AUTH", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@uname", SqlDbType.VarChar).Value = id;
                        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = razonsocial;
                        cmd.Parameters.Add("@respuesta", SqlDbType.Bit);
                        cmd.Parameters["@respuesta"].Direction = ParameterDirection.Output;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        resp = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    }
                    catch (Exception e)
                    {

                    }

                }
            }
            return resp;
        }
    }
}
