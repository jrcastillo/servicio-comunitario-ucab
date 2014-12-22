using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Utilitaria
{
    static class Utilitaria
    {
        public static int identificadorOpcion = 0;
        public static int identificadorTerapeuta = 0;
        public static string consultaTerapeutas = "select nombre ||', '|| apellido ||' ('|| cargo ||')' as Persona, id as Identificador from \"Terapeuta\" order by Persona;";
            
       
        public static void reiniciarIdentificadorOpcion() 
        {
            identificadorOpcion = 0;
        }

        public static int agregarValorIdentificadorOpcion (int valor)
        { 
            return identificadorOpcion = valor;
        }

        public static void reiniciarIdentificadorTerapeuta()
        {
            identificadorTerapeuta = 0;
        }

        public static int agregarValorIdentificadorTerapeuta(int valor)
        {
            return identificadorTerapeuta = valor;
        }

    }
}
