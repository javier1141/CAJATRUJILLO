using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.editar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IeditarPersona" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IeditarPersona
    {
        [OperationContract]
        void editar(string id, string razonsocial);
    }
}
