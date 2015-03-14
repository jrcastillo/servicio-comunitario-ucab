using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGA_ConsultorioMedicoChuao.Utilitaria;

namespace SGA_ConsultorioMedicoChuao.Vista.Horario
{
	public partial class PromptHorario : Form
	{
		bool Insertar;
		SqlConnection conexion = new SqlConnection();
		string fecha_modificar;

		public PromptHorario()
		{
			InitializeComponent();
			L_error.Visible = false;
		}

		public PromptHorario(DataTable CB_terapeuta, bool insertar)
		{
			InitializeComponent();
			IncializarTerapeutas(CB_terapeuta);
			Insertar = insertar;
			L_error.Visible = false;
		}

		public PromptHorario(DataTable CB_terapeuta, bool insertar, string idPaciente, string fechaCita, int indiceTerapeuta)
		{
			InitializeComponent();
			IncializarTerapeutas(CB_terapeuta);
			Insertar = insertar;
			LlenarComponentes(idPaciente, fechaCita, indiceTerapeuta);
			L_error.Visible = false;
		}

		private void LlenarComponentes(string idPaciente, string fechaCita, int indiceTerapeuta)
		{
			CB_ElegirTerapeuta.SelectedIndex = indiceTerapeuta;
			fecha_modificar = ArreglarFormatoFecha(fechaCita);
			string[] fecha_hora = fechaCita.Split(' ');
			DateTime fechaSelecionada = DateTime.ParseExact(fecha_hora[0], "dd-MMM-yy", CultureInfo.InvariantCulture);
			MC_Calendario.SelectionStart = fechaSelecionada;
			TP_HoraCita.Text = fecha_hora[1] + ' ' + fecha_hora[2];
			CB_ElegirTerapeuta.SelectedIndex = indiceTerapeuta;
			CB_ElegirPaciente.SelectedIndex = getPacientePorId(idPaciente);

		}

		private string ArreglarFormatoFecha(string fechaCita)
		{
			string[] modificar = fechaCita.Split(' ');
			string horaCambio = DateTime.Parse(modificar[1]+' '+modificar[2]).ToString("HH:mm:ss");

			if (modificar[2].Equals("PM"))
			{
				return modificar[0] + " " + horaCambio;
			}

			return fechaCita;
		}

		private int getPacientePorId(string idPaciente)
		{
			for (int i = 0; i < CB_ElegirPaciente.Items.Count; i++)
			{
				CB_ElegirPaciente.SelectedIndex = i;
				if (CB_ElegirPaciente.SelectedValue.ToString().Equals(idPaciente))
				{
					return i;
				}
			}

			return 0;
		}

		private void IncializarTerapeutas(DataTable CB_terapeuta)
		{
			CB_ElegirTerapeuta.DataSource = CB_terapeuta;
			CB_ElegirTerapeuta.DisplayMember = "Persona";
			CB_ElegirTerapeuta.ValueMember = "Identificador";
		}

		private void B_Cancelar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CB_ElegirTerapeuta_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable datos = new DataTable();
			datos = conexion.BuscarPacientes(CB_ElegirTerapeuta.SelectedValue.ToString());
			CB_ElegirPaciente.DataSource = datos;
			CB_ElegirPaciente.AutoCompleteCustomSource = LlenarListaAutoCompletado(datos);
			CB_ElegirPaciente.DisplayMember = "Nombre";
			CB_ElegirPaciente.ValueMember = "Id";
			L_error.Visible = false;

		}

		private AutoCompleteStringCollection LlenarListaAutoCompletado(DataTable datos)
		{
			AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
			
			for (int i = 0; i < datos.Rows.Count; i++)
			{
				coleccion.Add(datos.Rows[i][0].ToString());
			}
			
			return coleccion;
		}

		private void B_Aceptar_Click(object sender, EventArgs e)
		{
			try
			{
				string hora = TP_HoraCita.Text;
				string fecha = MC_Calendario.SelectionStart.ToShortDateString();
				string dia = MC_Calendario.SelectionStart.DayOfWeek.ToString();

				string[] horaSeparada = hora.Split(':');
				int valorHoras = Int32.Parse(horaSeparada[0]);

				string[] formatoTiempo = horaSeparada[1].Split(' ');
				string AmPm = formatoTiempo[1];

				int h = DateTime.Parse(valorHoras.ToString() + AmPm).Hour;

				DateTime fechaFormateada = Convert.ToDateTime(fecha);

				if (fechaFormateada.Date >= DateTime.Now.Date)
				{
					if (h > 7 && h < 21 && !dia.Equals("Sunday"))
					{
						if (CB_ElegirPaciente.SelectedIndex != 0 && CB_ElegirTerapeuta.SelectedIndex != 0)
						{

							string idTerapeuta = CB_ElegirTerapeuta.SelectedValue.ToString();
							string idPaciente = CB_ElegirPaciente.SelectedValue.ToString();

							if (Insertar)
							{
								InsertarHorarioNuevo(CB_ElegirPaciente.SelectedValue.ToString(),
													CB_ElegirTerapeuta.SelectedValue.ToString(),
													fecha,
													(hora = horaSeparada[0] + ":" + horaSeparada[1]));

							}
							else
							{
								ModificarRegistroExistente(CB_ElegirPaciente.SelectedValue.ToString(),
															CB_ElegirTerapeuta.SelectedValue.ToString(),
															fecha,
															(hora = horaSeparada[0] + ":" + horaSeparada[1]));
							}
						}
						else
						{
							L_error.Text = "Seleccione un paciente o terapeuta";
							L_error.Visible = true;
						}
					}
					else
					{
						L_error.Text = "Hora no Valida";
						L_error.Visible = true;
					}
				}
				else
				{
					L_error.Text = "Fecha elegida debe ser igual o despues de hoy y distinta de domingos";
					L_error.Visible = true;
				}
			}
			catch (Exception ex)
			{
				string mensaje = ex.Message;
				ResetComponentes();
			}
			
		}

		private void ModificarRegistroExistente(string paciente, string terapeuta, string fecha, string horario)
		{
			try
			{
				if (conexion.ModificarCita(paciente, terapeuta, fecha, horario, fecha_modificar))
				{
					MessageBox.Show("Cita Modificada Exitosamente", "Transaccion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					PrincipalHorarios.finalizadoVentanaPrompt = true;
					this.Close();
				}
				else
				{
					MessageBox.Show("No se pudo procesar su solicitud, intente de nuevo", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					PrincipalHorarios.finalizadoVentanaPrompt = true;
					this.Close();
				}
			}
			catch (Exception e)
			{
				string mensaje = e.Message;
				ResetComponentes();
			}
		}

		private void InsertarHorarioNuevo(string p1, string p2, string fecha, string p3)
		{
			try
			{
				if (conexion.AgregarCita(p1, p2, fecha, p3))
				{
					MessageBox.Show("Cita Agregada Exitosamente", "Transaccion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					PrincipalHorarios.finalizadoVentanaPrompt = true;
					this.Close();
				}
				else
				{
					MessageBox.Show("No se pudo procesar su solicitud, intente de nuevo", "Transaccion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					PrincipalHorarios.finalizadoVentanaPrompt = true;
					this.Close();
				}
			}
			catch (Exception e)
			{
				string mensaje = e.Message;
				ResetComponentes();
			}
		}

		private void ResetComponentes()
		{
			CB_ElegirTerapeuta.SelectedIndex = 0;
			CB_ElegirPaciente.DataSource = new DataSet();
			MC_Calendario.SelectionStart = MC_Calendario.TodayDate;
			TP_HoraCita.Text = "12:00 PM";
		}

		private void TP_HoraCita_ValueChanged(object sender, EventArgs e)
		{
			L_error.Visible = false;
		}

		private void CB_ElegirPaciente_SelectedIndexChanged(object sender, EventArgs e)
		{
			L_error.Visible = false;
		}

		private void MC_Calendario_DateChanged(object sender, DateRangeEventArgs e)
		{
			L_error.Visible = false;
		}

		
	}
}
