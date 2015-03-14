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
using SGA_ConsultorioMedicoChuao.Vista.Horario;
using SGA_ConsultorioMedicoChuao.Utilitaria;

namespace SGA_ConsultorioMedicoChuao.Vista
{
    public partial class PrincipalHorarios : Form
    {

		Utilitaria.SqlConnection conexion = new Utilitaria.SqlConnection();
		DataSet datosObtenidos = new DataSet(); 
		public static bool finalizadoVentanaPrompt = false;

		public PrincipalHorarios()
        {
            InitializeComponent();
			GV_VistaHorarios.Visible = false;
			LlenarComboTerapeutas();
        }

		private void LlenarComboTerapeutas()
		{
			try
			{
				Utilitaria.ConexionBD.conectarBD().Open();
				
				NpgsqlDataAdapter datosTerapeutas = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaTerapeutas, Utilitaria.ConexionBD.conectarBD());
				datosTerapeutas.Fill(datosObtenidos);
				AdaptarDatosComboTerapeuta(datosObtenidos);

				Utilitaria.ConexionBD.conectarBD().Close();
			}
			catch (Exception e)
			{
				string excepcion = e.ToString();
				MessageBox.Show("Se ha producido un error, intente más tarde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
		}

		private void AdaptarDatosComboTerapeuta(DataSet datosObtenidos)
		{
			
			{
				DataRow filaPorDefecto = datosObtenidos.Tables[0].NewRow();
				filaPorDefecto["Identificador"] = "0";
				filaPorDefecto["Persona"] = "Seleccione una Opcion";
				datosObtenidos.Tables[0].Rows.InsertAt(filaPorDefecto, 0);
				CB_Terapeutas.DataSource = datosObtenidos.Tables[0];
				CB_Terapeutas.SelectedIndex = 0;
				CB_Terapeutas.DisplayMember = "Persona";
				CB_Terapeutas.ValueMember = "Identificador";
			}

		}

		private void B_Agregar_Click(object sender, EventArgs e)
		{
			PromptHorario prompt = new PromptHorario(datosObtenidos.Tables[0],true);
			prompt.Show();

		}

		private void B_Salir_Click(object sender, EventArgs e)
		{
			Utilitaria.Utilitaria.ventanaPrincipal.Show();
			this.Close();
		}

		private void CB_Terapeutas_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataSet resultado = new DataSet();
			string idTerapeuta = CB_Terapeutas.SelectedValue.ToString();

			resultado = conexion.BuscarCitasTerapeuta(idTerapeuta);

			LlenarGV_Horarios(resultado);
			
		}

		private void LlenarGV_Horarios(DataSet resultado)
		{
			GV_VistaHorarios.DataSource = resultado.Tables[0];
			GV_VistaHorarios.AutoResizeColumns();
			GV_VistaHorarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

			GV_VistaHorarios.Columns[3].HeaderText = "Fecha Cita";
			GV_VistaHorarios.Columns[4].HeaderText = "Nombre del Paciente";
			GV_VistaHorarios.Columns[5].HeaderText = "Nombre Padre";
			GV_VistaHorarios.Columns[6].HeaderText = "Nombre Madre";

			GV_VistaHorarios.Columns[0].Visible = false;
			GV_VistaHorarios.Columns[1].Visible = false;
			GV_VistaHorarios.Columns[2].Visible = false;

			GV_VistaHorarios.Visible = true;
		}

		private void RecargarGV(object sender, EventArgs e)
		{
			if (finalizadoVentanaPrompt)
			{
				DataSet resultado = new DataSet();
				string idTerapeuta = CB_Terapeutas.SelectedValue.ToString();

				resultado = conexion.BuscarCitasTerapeuta(idTerapeuta);

				LlenarGV_Horarios(resultado);
				finalizadoVentanaPrompt = false;
			}
		}

		private void RecargarGV(object sender, MouseEventArgs e)
		{
			if (finalizadoVentanaPrompt)
			{
				DataSet resultado = new DataSet();
				string idTerapeuta = CB_Terapeutas.SelectedValue.ToString();

				resultado = conexion.BuscarCitasTerapeuta(idTerapeuta);

				LlenarGV_Horarios(resultado);
				finalizadoVentanaPrompt = false;
			}
		}

		private void B_Modificar_Click(object sender, EventArgs e)
		{
			if (CB_Terapeutas.SelectedIndex != 0)
			{
				DataGridViewRow filaSeleccionada = ElegirFila(GV_VistaHorarios);

				if (filaSeleccionada.Index >= 0)
				{
					PromptHorario prompt = new PromptHorario(datosObtenidos.Tables[0], false, filaSeleccionada.Cells[1].Value.ToString(), filaSeleccionada.Cells[3].Value.ToString(), CB_Terapeutas.SelectedIndex);
					prompt.Show();
				}
				else
				{
					MessageBox.Show("Debe seleccionar un registro", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Debe seleccionar un registro", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			
		}

		private DataGridViewRow ElegirFila(DataGridView GV_VistaHorarios)
		{
			DataGridViewRow resultado = new DataGridViewRow();

			if (GV_VistaHorarios.CurrentCell != null || GV_VistaHorarios.CurrentRow != null)
			{
				resultado = GV_VistaHorarios.CurrentRow;
			}

			return resultado;
		}

		private void B_Borrar_Click(object sender, EventArgs e)
		{
			if (CB_Terapeutas.SelectedIndex != 0)
			{
				DataGridViewRow filaSeleccionada = ElegirFila(GV_VistaHorarios);
	
				if (filaSeleccionada.Index >= 0)
				{
					DialogResult result = MessageBox.Show("Desea eliminar el registro seleccionado ?", "Confirmacion", MessageBoxButtons.YesNoCancel);
					if (result == DialogResult.Yes)
					{
						bool resultado = ElminarRegistro(filaSeleccionada.Cells[2].Value.ToString());
						finalizadoVentanaPrompt = true;
					}
					
				}
				else
				{
					MessageBox.Show("Debe seleccionar un registro", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Por favor seleccione un terapeuta", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private bool ElminarRegistro(string idPacTerHor)
		{
			return conexion.EliminarCita(idPacTerHor);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void MC_Calendario_DateChanged(object sender, DateRangeEventArgs e)
		{
		}
 
    }
}
