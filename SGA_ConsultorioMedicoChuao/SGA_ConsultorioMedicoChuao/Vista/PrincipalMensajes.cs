﻿using System;
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
    public partial class PrincipalMensajes : Form
    {
        public PrincipalMensajes()
        {
            InitializeComponent();
            datosMensajes(); // Cargado de los datos de los mensajes 
            nombreCargoTerapeuta(); // Cargando los datos del terapeuta 
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SGA_ConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void DGV_Mensajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                Utilitaria.Utilitaria.agregarValorIdentificadorMensaje(Convert.ToInt32(DGV_Mensajes.Rows[e.RowIndex].Cells[3].Value.ToString()));
                SGA_ConsultorioMedicoChuao.Vista.VistaMensajes nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.VistaMensajes();
                nuevaVentana.Show();
                this.Close();
                
            }
        }

        private void datosMensajes()
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosMensajes = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaMensajes(Utilitaria.Utilitaria.identificadorTerapeuta), Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosMensajes.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
                for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
                {
                    DGV_Mensajes.Rows.Add(Utilitaria.Utilitaria.diaSemana(Convert.ToInt32(datosObtenidos.Tables[0].Rows[i][3].ToString()))+datosObtenidos.Tables[0].Rows[i][2].ToString(), datosObtenidos.Tables[0].Rows[i][0].ToString(), "OK", datosObtenidos.Tables[0].Rows[i][1].ToString()); // Mostrar los datos en el dgv, en la colunma 4 se guardara de manera oculta el id del mensaje 
                }
                Utilitaria.ConexionBD.conectarBD().Close(); //Cierro conexión
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void B_MensajeNuevo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea crear un nuevo mensaje?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SGA_ConsultorioMedicoChuao.Vista.ComposicionMensajes nuevaVentana = new SGA_ConsultorioMedicoChuao.Vista.ComposicionMensajes();
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
                    L_NombreTerapeuta.Text = "Mensajes de: " + datosObtenidos.Tables[0].Rows[i][0].ToString();
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
