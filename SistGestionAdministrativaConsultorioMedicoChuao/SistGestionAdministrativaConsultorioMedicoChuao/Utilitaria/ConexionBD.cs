using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Utilitaria
{
    class ConexionBD
    {
        public static string cadenaConexion = "Server=localhost; Port=5432; Database=ConsultorioMedicoChuao; User Id=postgres; Password=1234567890;";
        static NpgsqlConnection conexion;

            public static NpgsqlConnection conectarBD() 
            {
                return conexion = new NpgsqlConnection(cadenaConexion);
            }
    }
}
