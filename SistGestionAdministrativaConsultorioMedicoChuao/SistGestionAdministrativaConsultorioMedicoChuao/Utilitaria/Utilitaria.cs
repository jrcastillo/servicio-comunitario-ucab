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
        public static List<string> listaDatosPacienteFisio = new List<string>();
        public static List<string> listaDatosPacienteLenguaje = new List<string>();
        public static List<string> listaDatosMama = new List<string>();
        public static List<string> listaDatosPapa = new List<string>();
        public static List<string> listaVentana2Fisio = new List<string>();
        public static string nombreProductoSeleccionado = "";
        public static int identificadorOpcion = 0;
        public static int identificadorTerapeuta = 0;
        public static int identificadorRegistroListaEspera = 0;
        public static int identificadorMensaje = 0;
        public static int identificadorProductoInventario = 0;
        public static int banderaUpdateMensaje = 0;
        public static int banderaUpdateRegistroListaEspera = 0;
        public static int cantidadProductoInventario = 0;
        public static string consultaProductosInventario = "select nombre as Producto from \"Inventario\" order by id;";
        public static string consultaTerapeutas = "select nombre ||', '|| apellido ||' ('|| cargo ||').' as Persona, id as Identificador from \"Terapeuta\" order by Persona;";
        public static string consultaInventario = "select nombre, cantidad from \"Inventario\" order by nombre;";
        public static string consultaNombreTerapeuta(int idTerapeuta)
        {
            return "select nombre ||', '|| apellido ||' ('|| cargo ||').' as Persona from \"Terapeuta\" where id = "+idTerapeuta+"order by Persona;";
        }
        public static string consultaCargoTerapeuta(int idTerapeuta)
        {
            return "select cargo from \"Terapeuta\" where id = " + idTerapeuta + ";";
        }
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
        public static string validaExistenciaProducto(string nombre)
        {
            return "select count(*) from \"Inventario\" where nombre='" + nombre + "';";
        }
        public static string insercionMensaje(string titulo, string detalles, int idTerapeuta) 
        {
            return "INSERT INTO \"Mensaje\"(titulo, detalles, fk_terapeuta, \"fechaCreacion\", dia) VALUES ('" + titulo + "', '" + detalles + "', " + idTerapeuta + ", current_timestamp, extract (dow from current_timestamp));";
        }
        public static string agregarProductoInventario(string nombre)
        {
            return "INSERT INTO \"Inventario\"(nombre, cantidad) VALUES ('" + nombre + "', 0);";
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
        public static string borrarProducto(int idProducto)
        {
            return "DELETE FROM \"Inventario\" WHERE id=" + idProducto + ";";
        }
        public static string borrarRegistroListaEspera(int idRegistroListaEspera)
        {
            return "DELETE FROM \"ListaEspera\" WHERE id=" + idRegistroListaEspera + ";";
        }
        public static string modificarMensaje(string titulo, string detalles, int idMensaje)
        {
            return "UPDATE \"Mensaje\" SET titulo='"+titulo+"', detalles='"+detalles+"' WHERE id="+idMensaje+";";
        }
        public static string modificarProductoInventario(string nombre, int cantidad, int idProducto)
        {
            return "UPDATE \"Inventario\" SET nombre='" + nombre + "', cantidad='" + cantidad + "' WHERE id=" + idProducto + ";";
        }
        public static string agregarProductoInventario(int cantidadNueva, int idProducto)
        {
            return "UPDATE \"Inventario\" SET cantidad=cantidad+" + cantidadNueva + " WHERE id=" + idProducto + ";";
        }
        public static string disminuirProductoInventario(int cantidadNueva, int idProducto)
        {
            return "UPDATE \"Inventario\" SET cantidad=cantidad-" + cantidadNueva + " WHERE id=" + idProducto + ";";
        }
        public static string modificarRegistroListaEspera(string nombrePaciente, string nombreRepresentante, string telefono, string telefonoOpcional, string referidoPor, string detallesReferencia, int idRegistro)
        {
            return "UPDATE \"ListaEspera\" SET \"nombreApellidoPaciente\"='"+ nombrePaciente +"', \"nombreApellidoRepresentante\"='"+nombreRepresentante+"', \"referidoPor\"='"+referidoPor+"', \"detallesReferencia\"='"+detallesReferencia+"', \"numeroTelefono\"='"+telefono+"', \"numeroOpcional\"='"+telefonoOpcional+"' WHERE id="+idRegistro+";";
        }
        public static string consultaIdProducto(string nombreProducto)
        {
            return "SELECT id as Identificador FROM \"Inventario\" WHERE nombre = '" + nombreProducto + "'";
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


        public static int agregarCantidadProductoInventario(int valor)
        {
            return cantidadProductoInventario = valor;
        }

        public static void reiniciarCantidadProductoInventario()
        {
            cantidadProductoInventario = 0;
        }

        public static int agregarValorIdentificadorProductoInventario(int valor)
        {
            return identificadorProductoInventario = valor;
        }

        public static void reiniciarIdentificadorProductoInventario()
        {
            identificadorProductoInventario = 0;
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

        public static void reiniciarNombreProductoSeleccionado()
        {
            nombreProductoSeleccionado = "";
        }

        public static string agregarValorNombreProductoSeleccionado(string valor)
        {
            return nombreProductoSeleccionado = valor;
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
