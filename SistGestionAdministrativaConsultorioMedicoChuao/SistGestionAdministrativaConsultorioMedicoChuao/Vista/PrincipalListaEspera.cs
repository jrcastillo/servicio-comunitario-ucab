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
    public partial class PrincipalListaEspera : Form
    {
        public PrincipalListaEspera()
        {
            InitializeComponent();           
            datosListaEspera();
            Utilitaria.Utilitaria.reiniciarBanderaUpdateRegistroListaEspera();
            Utilitaria.Utilitaria.reiniciarIdentificadorRegistroListaEspera();
            nombreCargoTerapeuta();
        }
 
        private void datosListaEspera()
        {
            try
            {
                int lugarEspera = 0;
                string nombrePaciente = "";
                string nombreRepresentante = "";
                string numeroTelefono = "";
                string detallesReferencia = "";
                string referidoPor = "" ;
                string numeroOpcional = "";
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosListaEspera = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaListaEspera(Utilitaria.Utilitaria.identificadorTerapeuta), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosListaEspera.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
                for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
                {
                    if (!datosObtenidos.Tables[0].Rows[i][0].ToString().Equals(""))
                         nombrePaciente = datosObtenidos.Tables[0].Rows[i][0].ToString();
                   
                    if (!datosObtenidos.Tables[0].Rows[i][1].ToString().Equals(""))
                        nombreRepresentante = datosObtenidos.Tables[0].Rows[i][1].ToString();
                    
                    if (!datosObtenidos.Tables[0].Rows[i][2].ToString().Equals(""))
                        numeroTelefono = datosObtenidos.Tables[0].Rows[i][2].ToString();
                    
                    if (!datosObtenidos.Tables[0].Rows[i][3].ToString().Equals(""))
                        numeroOpcional = datosObtenidos.Tables[0].Rows[i][3].ToString();
                    else
                        numeroOpcional = "No asignado";

                    if (!datosObtenidos.Tables[0].Rows[i][4].ToString().Equals(""))
                        referidoPor = datosObtenidos.Tables[0].Rows[i][4].ToString();
                    else
                        referidoPor = "No asignado";

                    if (!datosObtenidos.Tables[0].Rows[i][5].ToString().Equals(""))
                        detallesReferencia = datosObtenidos.Tables[0].Rows[i][5].ToString();
                    else
                        detallesReferencia = "No asignado";

                    lugarEspera ++;
                    LB_ListaEspera.Items.Add(lugarEspera.ToString()+".- "+ "Nombre del paciente: " + nombrePaciente 
                    + ". Nombre del representante: " + nombreRepresentante + ". Telefono: " + numeroTelefono + ". Telefono Opcional: " +
                    numeroOpcional +". Referido por: " + referidoPor + ". Detalles de por lo que fue referido: " + detallesReferencia); // Mostrar los datos en el lb
                  }
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
                MessageBox.Show("No tiene pacientes en lista de espera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string seleccionItemListaEspera() 
        {
            Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
            DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
            NpgsqlDataAdapter datosListaEspera = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaIdItemListaEspera(Utilitaria.Utilitaria.identificadorTerapeuta), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
            datosListaEspera.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
            Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            return datosObtenidos.Tables[0].Rows[LB_ListaEspera.SelectedIndex][0].ToString();
        }
        
        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea salir y volver al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            int seleccionado = LB_ListaEspera.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Primero debe seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea dirigirse a la ventana de composición de registro para modificar el registro seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    Utilitaria.Utilitaria.agregarValorIdentificadorRegistroListaEspera(Convert.ToInt32(seleccionItemListaEspera()));
                    Utilitaria.Utilitaria.encenderBanderaUpdateRegistroListaEspera();
                    SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionRegistroListaEspera nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionRegistroListaEspera();
                    nuevaVentana.Show();
                    this.Close();
                }
            }
        }

        private void B_Borrar_Click(object sender, EventArgs e)
        {

            int seleccionado = LB_ListaEspera.SelectedIndex;
            if (seleccionado == -1)
                MessageBox.Show("Primero debe seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    borrarRegistro();
                }
            }

        }

        private void borrarRegistro() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand BorrarRegistro = conexion.CreateCommand();
                BorrarRegistro.CommandText = Utilitaria.Utilitaria.borrarRegistroListaEspera(Convert.ToInt32(seleccionItemListaEspera()));
                BorrarRegistro.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Registro borrado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalListaEspera nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalListaEspera();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                string exepcion = exp.ToString();
                MessageBox.Show("No se pudo borrar el registro, intentelo luego", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea agregar un registro a la lista de espera?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionRegistroListaEspera nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.ComposicionRegistroListaEspera();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void nombreCargoTerapeuta()
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosTerapeuta = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaNombreTerapeuta(Utilitaria.Utilitaria.identificadorTerapeuta), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosTerapeuta.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
                for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
                {
                    L_NombreTerapeuta.Text = "Lista de espera de: " + datosObtenidos.Tables[0].Rows[i][0].ToString();
                }
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        
    
    }
}
