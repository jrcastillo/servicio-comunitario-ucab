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
        public static int identificadorRegistroListaEspera = 0;
        public static int identificadorMensaje = 0;
        public static int banderaUpdateMensaje = 0;
        public static int banderaUpdateRegistroListaEspera = 0;
        public static string consultaTerapeutas = "select nombre ||', '|| apellido ||' ('|| cargo ||').' as Persona, id as Identificador from \"Terapeuta\" order by Persona;";
        public static string consultaListaEspera(int idTerapeuta)
        { 
            return "SELECT \"nombreApellidoPaciente\", \"nombreApellidoRepresentante\",\"numeroTelefono\", \"numeroOpcional\", \"referidoPor\", \"detallesReferencia\", id FROM \"ListaEspera\" WHERE fk_terapeuta ="+idTerapeuta+" order by id;";
        }
        public static string consultaIdItemListaEspera(int idTerapeuta)
        { 
            return "select id as Identificador from \"ListaEspera\" where fk_terapeuta="+ idTerapeuta +" order by Identificador;";
        }
        public static string consultaMensajes(int idTerapeuta) 
        {
            return "select titulo as Titulo, id as IdMensaje, to_char(\"fechaCreacion\",'dd/mm/yyyy') || ' a la(s) ' || to_char(\"fechaCreacion\",'hh:mi AM') as Fecha, dia as Dia from \"Mensaje\" where fk_terapeuta=" + idTerapeuta + " order by Fecha;"; 
        }
        public static string insercionMensaje(string titulo, string detalles, int idTerapeuta) 
        {
            return "INSERT INTO \"Mensaje\"(titulo, detalles, fk_terapeuta, \"fechaCreacion\", dia) VALUES ('" + titulo + "', '" + detalles + "', " + idTerapeuta + ", current_timestamp, extract (dow from current_timestamp));";
        }
        public static string insercionRegistroListaEspera(string nombrePaciente, string nombreRepresentante, string telefono, string telefonoOpcional, string referidoPor, string detallesReferencia, int idTerapeuta)
        {
            return "INSERT INTO \"ListaEspera\"(fk_terapeuta, \"nombreApellidoPaciente\", \"nombreApellidoRepresentante\", \"numeroTelefono\", \"numeroOpcional\", \"referidoPor\", \"detallesReferencia\") VALUES ("+ idTerapeuta +",'"+nombrePaciente+"','"+nombreRepresentante+"','"+telefono+"','"+telefonoOpcional+"','"+referidoPor+"','"+detallesReferencia+"');";
        }
        public static string contenidoMensaje(int idMensaje)
        {
            return "select titulo as Titulo, id as IdMensaje, to_char(\"fechaCreacion\",'dd/mm/yyyy') || ' a la(s) ' || to_char(\"fechaCreacion\",'hh:mi AM') as Fecha, dia as Dia, detalles as Detalles from \"Mensaje\" where id=" + idMensaje + ";";
        }
        public static string contenidoRegistroListaEspera(int idRegistro)
        {
            return "SELECT \"nombreApellidoPaciente\", \"nombreApellidoRepresentante\",\"numeroTelefono\", \"numeroOpcional\", \"referidoPor\", \"detallesReferencia\" from \"ListaEspera\" where id=" + idRegistro + " order by id;";
        }
        public static string borrarMensaje(int idMensaje)
        {
            return "DELETE FROM \"Mensaje\" WHERE id="+ idMensaje +";";
        }
        public static string borrarRegistroListaEspera(int idRegistroListaEspera)
        {
            return "DELETE FROM \"ListaEspera\" WHERE id=" + idRegistroListaEspera + ";";
        }
        public static string modificarMensaje(string titulo, string detalles, int idMensaje)
        {
            return "UPDATE \"Mensaje\" SET titulo='"+titulo+"', detalles='"+detalles+"' WHERE id="+idMensaje+";";
        }
        public static string modificarRegistroListaEspera(string nombrePaciente, string nombreRepresentante, string telefono, string telefonoOpcional, string referidoPor, string detallesReferencia, int idRegistro)
        {
            return "UPDATE \"ListaEspera\" SET \"nombreApellidoPaciente\"='"+ nombrePaciente +"', \"nombreApellidoRepresentante\"='"+nombreRepresentante+"', \"referidoPor\"='"+referidoPor+"', \"detallesReferencia\"='"+detallesReferencia+"', \"numeroTelefono\"='"+telefono+"', \"numeroOpcional\"='"+telefonoOpcional+"' WHERE id="+idRegistro+";";
        }

        public static void reiniciarIdentificadorOpcion() 
        {
            identificadorOpcion = 0;
        }

        public static int agregarValorIdentificadorOpcion (int valor)
        { 
            return identificadorOpcion = valor;
        }

        public static void reiniciarIdentificadorRegistroListaEspera()
        {
            identificadorRegistroListaEspera = 0;
        }

        public static int agregarValorIdentificadorRegistroListaEspera(int valor)
        {
            return identificadorRegistroListaEspera = valor;
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

        public static void encenderBanderaUpdateMensaje()
        {
            banderaUpdateMensaje = 1;
        }

        public static void reiniciarBanderaUpdateMensaje()
        {
            banderaUpdateMensaje = 0;
        }

        public static void encenderBanderaUpdateRegistroListaEspera()
        {
            banderaUpdateRegistroListaEspera = 1;
        }

        public static void reiniciarBanderaUpdateRegistroListaEspera()
        {
            banderaUpdateRegistroListaEspera = 0;
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
