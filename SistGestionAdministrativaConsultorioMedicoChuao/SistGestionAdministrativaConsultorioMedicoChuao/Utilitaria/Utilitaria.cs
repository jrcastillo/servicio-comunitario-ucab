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
        public static int identificadorMensaje = 0;
        public static string consultaTerapeutas = "select nombre ||', '|| apellido ||' ('|| cargo ||')' as Persona, id as Identificador from \"Terapeuta\" order by Persona;";
        public static string consultaMensajes(int idTerapeuta) 
        {
            return "select titulo as Titulo, id as IdMensaje, to_char(\"fechaCreacion\",'dd/mm/yyyy') || ' a la(s) ' || to_char(\"fechaCreacion\",'hh:mi AM') as Fecha, dia as Dia from \"Mensaje\" where fk_terapeuta=" + idTerapeuta + " order by Fecha;"; 
        }
        public static string insercionMensaje(string titulo, string detalles, int idTerapeuta) 
        {
            return "INSERT INTO \"Mensaje\"(titulo, detalles, fk_terapeuta, \"fechaCreacion\", dia) VALUES ('" + titulo + "', '" + detalles + "', " + idTerapeuta + ", current_timestamp, extract (dow from current_timestamp));";

        }
       
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

        public static void reiniciarIdentificadorMensaje()
        {
            identificadorMensaje = 0;
        }

        public static int agregarValorIdentificadorMensaje(int valor)
        {
            return identificadorMensaje = valor;
        }

        public static string diaSemana (int dia)
        {
            string nombreDia = "";
                switch (dia)
                {
                    case 1:
                        nombreDia = "Lunes ";
                        break;
                    case 2:
                        nombreDia = "Martes ";
                        break;
                    case 3:
                        nombreDia = "Miércoles ";
                        break;
                    case 4:
                        nombreDia = "Jueves ";
                        break;
                    case 5:
                        nombreDia = "Viernes ";
                        break;
                    case 6:
                        nombreDia = "Sabado ";
                        break;
                    case 7:
                        nombreDia= "Domingo";
                        break;
                }
            return nombreDia;
        }

    }
}
