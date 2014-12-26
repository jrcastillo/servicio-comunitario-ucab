using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    public partial class ComposicionMensajes : Form
    {
        public ComposicionMensajes()
        {
            InitializeComponent();
            if (Utilitaria.Utilitaria.banderaUpdateMensaje == 1)
                datosMensaje();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver al menú de mensajes?. De ser así no se guardaran los cambios", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Utilitaria.Utilitaria.reiniciarBanderaUpdateMensaje();
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_GuardarMensaje_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea guardar el mensaje?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                bool datos = validaCamposMensaje(TB_Titulo.Text, RTB_CuerpoMensaje.Text);
                if (!datos)
                {
                    string mensajeCampoVacio = verificacionDeCampoVacio(TB_Titulo.Text, RTB_CuerpoMensaje.Text);
                    MessageBox.Show(mensajeCampoVacio, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Utilitaria.Utilitaria.banderaUpdateMensaje == 0)
                        guardaMensaje();
                    else
                    {
                        modificarMensaje();
                        Utilitaria.Utilitaria.reiniciarBanderaUpdateMensaje();
                    }

                }
            }
        }

        private bool validaCamposMensaje(string titulo, string cuerpoMensaje) 
        {
            if (titulo.Equals("") || cuerpoMensaje.Equals(""))
                return false;
            else
                return true;
        }

        private void guardaMensaje()
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                    NpgsqlCommand InsercionMensaje = conexion.CreateCommand();
                    InsercionMensaje.CommandText = Utilitaria.Utilitaria.insercionMensaje(TB_Titulo.Text, RTB_CuerpoMensaje.Text, Utilitaria.Utilitaria.identificadorTerapeuta);
                    InsercionMensaje.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Mensaje guardado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                    nuevaVentana.Show();
                    this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private string verificacionDeCampoVacio(string titulo, string cuerpoMensaje) 
        {
            string mensajeCampoVacio = "";
            if (titulo.Equals(""))
                {
                    if (cuerpoMensaje.Equals(""))
                        mensajeCampoVacio = "No puede dejar el título ni el cuerpo del mensaje vacío";
                    else
                        mensajeCampoVacio = "No puede dejar el título vacío";
                }
            else
                    mensajeCampoVacio = "No puede dejar el cuerpo del mensaje vacío";

            return mensajeCampoVacio;
        }

        private void TB_Titulo_KeyPress(object sender, KeyPressEventArgs e) // Solo letras, numeros y algunos caracteres 
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.'
                && e.KeyChar != ',' && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            { 
                e.Handled = true; 
            }
        }

        private void RTB_CuerpoMensaje_KeyPress(object sender, KeyPressEventArgs e) // Solo letras, numeros y algunos caracteres
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.'
                && e.KeyChar != ',' && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void modificarMensaje() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand ModificarMensaje = conexion.CreateCommand();
                ModificarMensaje.CommandText = Utilitaria.Utilitaria.modificarMensaje(TB_Titulo.Text, RTB_CuerpoMensaje.Text, Utilitaria.Utilitaria.identificadorMensaje);
                ModificarMensaje.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Mensaje modificado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void datosMensaje()
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosMensajes = new NpgsqlDataAdapter(Utilitaria.Utilitaria.contenidoMensaje(Utilitaria.Utilitaria.identificadorMensaje), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosMensajes.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos

                TB_Titulo.Text = datosObtenidos.Tables[0].Rows[0][0].ToString();
                RTB_CuerpoMensaje.Text = datosObtenidos.Tables[0].Rows[0][4].ToString();

                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
