using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace SGA_ConsultorioMedicoChuao.Utilitaria
{
	class SqlConnection
	{
		private NpgsqlConnection conexion;
		private string cadenaConexion;
		private DataSet respuesta;
		private NpgsqlDataAdapter adaptadorDataConsulta;

		public SqlConnection()
		{
			conexion = new NpgsqlConnection();
			cadenaConexion = "Server=localhost; Port=5432; Database=ConsultorioMedicoChuao; User Id=postgres; Password=mitologi2;";
			respuesta = new DataSet();
			adaptadorDataConsulta = new NpgsqlDataAdapter();
		}

		public void ConectarBD()
		{
			try
			{
				conexion = new NpgsqlConnection(cadenaConexion);
				conexion.Open();
			}
			catch (Exception e)
			{
				string mensaje = e.Message;
			}
		}

		public void CerrarConexion()
		{
			try
			{
				conexion.Close();
			}
			catch (Exception e)
			{
				string mensaje = e.Message;
			}
		}

		public DataSet BuscarCitasTerapeuta(string idTerapeuta)
		{
			respuesta = new DataSet();
			try
			{
				adaptadorDataConsulta = new NpgsqlDataAdapter(Utilitaria.buscarCitaPacientes(idTerapeuta), cadenaConexion);
				adaptadorDataConsulta.Fill(respuesta);
			}
			catch(NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			CerrarConexion();
			return respuesta;
		}

		public DataTable BuscarPacientes(string idTerapeuta)
		{
			respuesta = new DataSet();
			try
			{
				adaptadorDataConsulta = new NpgsqlDataAdapter(Utilitaria.buscarPacientes(idTerapeuta), cadenaConexion);
				adaptadorDataConsulta.Fill(respuesta);
				DataRow filaPorDefecto = respuesta.Tables[0].NewRow();
				filaPorDefecto["Id"] = "0";
				filaPorDefecto["Nombre"] = "Seleccione un paciente";
				respuesta.Tables[0].Rows.InsertAt(filaPorDefecto, 0);
			}
			catch (NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			CerrarConexion();
			return respuesta.Tables[0];
		}

		public bool AgregarCita(string paciente, string terapeuta, string fecha, string hora)
		{
			bool resultado = false;

			try
			{
				this.ConectarBD();
				NpgsqlCommand agregar = conexion.CreateCommand();
				agregar.CommandType = CommandType.Text;
				DataSet existeHorario = VerificarExistenciaHorario(fecha +" "+hora);
				if (existeHorario.Tables[0].Rows.Count > 1)
				{
					agregar.CommandText = Utilitaria.AgregarCitaHoraio(Int32.Parse(paciente),
																		Int32.Parse(terapeuta),
																		Int32.Parse(existeHorario.Tables[0].Rows[0].ToString()));
					agregar.ExecuteNonQuery();
					resultado = true;
				}
				else
				{
					if (InsertarHorarioNuevo(fecha + " " + hora))
					{
						existeHorario = VerificarExistenciaHorario(fecha + " " + hora);
						int idHorario = Int32.Parse(existeHorario.Tables[0].Rows[0][0].ToString());
						agregar.CommandText = Utilitaria.AgregarCitaHoraio(Int32.Parse(paciente),
																		Int32.Parse(terapeuta),
																		idHorario);
						agregar.ExecuteNonQuery();
						resultado = true;
					}
				}

				this.CerrarConexion();
			}
			catch (NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			return resultado;
		}

		private bool InsertarHorarioNuevo(string hora)
		{
			bool resultado = false;

			try
			{
				NpgsqlCommand agregar = conexion.CreateCommand();
				agregar.CommandText = Utilitaria.AgregarHorarioNuevo(hora);
				agregar.ExecuteNonQuery();
				resultado = true;
			}
			catch(NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			return resultado;
		}

		private DataSet VerificarExistenciaHorario(string hora)
		{
			respuesta = new DataSet();

			try
			{
				//this.ConectarBD();
				adaptadorDataConsulta = new NpgsqlDataAdapter(Utilitaria.buscarHoraExistente(hora), cadenaConexion);
				adaptadorDataConsulta.Fill(respuesta);
				//this.CerrarConexion();
					
			}
			catch (NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			return respuesta;
		}

		public bool ModificarCita(string paciente, string terapeuta, string fecha, string horario, string fecha_modificar)
		{
			bool resultado = false;

			try
			{
				this.ConectarBD();
				NpgsqlCommand agregar = conexion.CreateCommand();
				agregar.CommandType = CommandType.Text;

				agregar.CommandText = Utilitaria.ModificarCitaHorario(Int32.Parse(paciente),
																	Int32.Parse(terapeuta),
																	fecha + " " + horario,
																	fecha_modificar);
				agregar.ExecuteNonQuery();
				resultado = true;

				this.CerrarConexion();
			}
			catch (NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			return resultado;
		}


		public bool EliminarCita(string idPacTerHor)
		{
			bool resultado = false;

			try
			{
				this.ConectarBD();
				NpgsqlCommand agregar = conexion.CreateCommand();
				agregar.CommandType = CommandType.Text;

				agregar.CommandText = Utilitaria.EliminarCitaHorario(idPacTerHor);
				agregar.ExecuteNonQuery();
				resultado = true;

				this.CerrarConexion();
			}
			catch (NpgsqlException e)
			{
				string mensaje = e.Message;
			}
			return resultado;
		}
	}
}
