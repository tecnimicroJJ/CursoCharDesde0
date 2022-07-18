using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEstudiantes
{
    public class Conexion : DataConnection
    {
        //para hacer la conexion y se debe indicar la cadena de conexion de app.config.
        public Conexion(): base("PRUEBASCHAR") { }

        public ITable<Estudiante> _Estudiante {get { return GetTable<Estudiante>(); } }
           

    }
}
