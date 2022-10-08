using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.registroMarcacion
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ILeerPersona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ILeerPersona
    {
        [OperationContract]
        string f_leerPersona();
    }
}
