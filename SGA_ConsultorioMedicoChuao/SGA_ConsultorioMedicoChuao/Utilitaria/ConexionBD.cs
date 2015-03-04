using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SGA_ConsultorioMedicoChuao.Utilitaria
{
    class ConexionBD
    {
        public static string cadenaConexion = "Server=localhost; Port=5432; Database=ConsultorioMedicoChuao; User Id=postgres; Password=1234567890;";
        static NpgsqlConnection conexion = new NpgsqlConnection();

            public static NpgsqlConnection conectarBD() 
            {
				try
				{
					conexion = new NpgsqlConnection(cadenaConexion);
				}
				catch (Exception e)
				{
					string mensaje = e.Message;
				}

				return conexion;
            }
    }
}
