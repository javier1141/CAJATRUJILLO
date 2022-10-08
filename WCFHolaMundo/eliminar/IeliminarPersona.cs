using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.eliminar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IeliminarPersona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IeliminarPersona
    {
        [OperationContract]
        bool f_eliminarPersona(string PERSONA_ID);
    }
}
