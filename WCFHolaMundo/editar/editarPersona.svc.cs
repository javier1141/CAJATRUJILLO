using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WCFHolaMundo.editar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "editarPersona" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione editarPersona.svc o editarPersona.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class editarPersona : IeditarPersona
    {
        public void editar(string id,string razonsocial)
        {
           


            //string sentencia = String.Format("UPDATE CAJATRUJILLO.PERSONA SET RAZONSOCIAL ='{0}'  WHERE PERSONA_ID ='{1}'", razonsocial, id) ;

           
        }
    }
}
