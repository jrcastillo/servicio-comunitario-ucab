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
    public partial class VistaMensajes : Form
    {
        public VistaMensajes()
        {
            InitializeComponent();
            datosMensaje();
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir y volver al menú de mensajes?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                nuevaVentana.Show();
                this.Close();
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
                
                    TB_FechaHoraCreacion.Text = Utilitaria.Utilitaria.diaSemana(Convert.ToInt32(datosObtenidos.Tables[0].Rows[0][3].ToString())) + datosObtenidos.Tables[0].Rows[0][2].ToString();
                    TB_Titulo.Text = datosObtenidos.Tables[0].Rows[0][0].ToString();
                    RTB_CuerpoMensaje.Text = datosObtenidos.Tables[0].Rows[0][4].ToString();
                
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void B_BorrarMensaje_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea borrar el mensajes?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                borrarMensaje();
                Utilitaria.Utilitaria.reiniciarIdentificadorMensaje();
            }
        }

        private void borrarMensaje()
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand BorrarMensaje = conexion.CreateCommand();
                BorrarMensaje.CommandText = Utilitaria.Utilitaria.borrarMensaje(Utilitaria.Utilitaria.identificadorMensaje);
                BorrarMensaje.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Mensaje borrado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea ir a la ventana de modificación de mensajes?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Utilitaria.Utilitaria.encenderBanderaUpdateMensaje();
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionMensajes();
                nuevaVentana.Show();
                this.Close();
            }
        }


    }
        
}
