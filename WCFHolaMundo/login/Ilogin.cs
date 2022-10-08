using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFHolaMundo.login
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "Ilogin" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface Ilogin
    {
        [OperationContract]
        bool validateLogin(string id, string razonsocial);
    }
}
