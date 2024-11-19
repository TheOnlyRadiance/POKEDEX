using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MvvmGuia.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmguia-281c7-default-rtdb.firebaseio.com/");
    }
}
