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

namespace SGA_ConsultorioMedicoChuao.Vista
{
    public partial class ComposicionRegistroListaEspera : Form
    {
        public ComposicionRegistroListaEspera()
        {
            InitializeComponent();
            if (Utilitaria.Utilitaria.banderaUpdateRegistroListaEspera == 1)
                cargarDatos();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver a la ventana principal de la lista de espera?. De ser así no se guardaran los cambios", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Utilitaria.Utilitaria.reiniciarBanderaUpdateRegistroListaEspera();
                SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que desea guardar el registro?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    if (Utilitaria.Utilitaria.banderaUpdateRegistroListaEspera == 0)
                        guardarRegistro();
                    else
                        modificarRegistro();
                }
            }
            else
                MessageBox.Show("Los campos de nombre del paciente, nombre del representante y numero de contacto son obligatorios, no puede dejar ninguno de los 3 vacío", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardarRegistro() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand InsercionRegistro = conexion.CreateCommand();
                InsercionRegistro.CommandText = Utilitaria.Utilitaria.insercionRegistroListaEspera(TB_NombreApellidoPaciente.Text, TB_NombreApellidoRepresentante.Text, TB_TelefonoContacto.Text, TB_TelefonoOpcional.Text, TB_ReferidoPor.Text, RTB_DetallesReferencia.Text, Utilitaria.Utilitaria.identificadorTerapeuta);
                InsercionRegistro.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Registro guardado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private bool validarCampos() 
        {
            if (TB_NombreApellidoPaciente.Text.Equals("") || TB_NombreApellidoRepresentante.Text.Equals("") || TB_TelefonoContacto.Text.Equals(""))
                return false;
            else
                return true;   
        }

        private void modificarRegistro() 
        {
            try
            {
                NpgsqlConnection conexion = new NpgsqlConnection(Utilitaria.ConexionBD.cadenaConexion);
                conexion.Open();// Abro la conexión
                NpgsqlCommand ModificarRegistro = conexion.CreateCommand();
                ModificarRegistro.CommandText = Utilitaria.Utilitaria.modificarRegistroListaEspera(TB_NombreApellidoPaciente.Text, TB_NombreApellidoRepresentante.Text, TB_TelefonoContacto.Text, TB_TelefonoOpcional.Text, TB_ReferidoPor.Text, RTB_DetallesReferencia.Text, Utilitaria.Utilitaria.identificadorRegistroListaEspera);
                ModificarRegistro.ExecuteNonQuery();
                conexion.Close(); //Cierro conexión
                MessageBox.Show("Registro modificado con exito", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.PrincipalListaEspera();
                nuevaVentana.Show();
                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void cargarDatos() 
        {
            try
            {
                string nombrePaciente = "";
                string nombreRepresentante = "";
                string numeroTelefono = "";
                string detallesReferencia = "";
                string referidoPor = "";
                string numeroOpcional = "";
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosListaEspera = new NpgsqlDataAdapter(Utilitaria.Utilitaria.contenidoRegistroListaEspera(Utilitaria.Utilitaria.identificadorRegistroListaEspera), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
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

                    TB_NombreApellidoPaciente.Text = nombrePaciente;
                    TB_NombreApellidoRepresentante.Text = nombreRepresentante;
                    TB_ReferidoPor.Text = referidoPor;
                    TB_TelefonoContacto.Text = numeroTelefono;
                    TB_TelefonoOpcional.Text = numeroOpcional;
                    RTB_DetallesReferencia.Text = detallesReferencia;

                }
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                string exepcion = e.ToString();
                MessageBox.Show("No tiene pacientes en lista de espera", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TB_TelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoOpcional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void RTB_DetallesReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.'
               && e.KeyChar != ',' && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_ReferidoPor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_NombreApellidoPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }

        private void TB_NombreApellidoRepresentante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.' && e.KeyChar != ','
                && e.KeyChar != '!' && e.KeyChar != '¡' && e.KeyChar != '?' && e.KeyChar != '¿' && e.KeyChar != '#' && e.KeyChar != '*')
            {
                e.Handled = true;
            }
        }
    }
}
