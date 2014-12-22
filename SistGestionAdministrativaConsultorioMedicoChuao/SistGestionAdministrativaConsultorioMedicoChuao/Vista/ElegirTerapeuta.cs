﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistGestionAdministrativaConsultorioMedicoChuao.Utilitaria;
using Npgsql;
	
namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    public partial class ElegirTerapeuta : Form
    {
        public ElegirTerapeuta()
        {
            InitializeComponent();
            datosTerapeutas(); // Función en la que consigo los datos de los terapeutas       
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro que desea cancelar la operación y volver al menú principal?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.VentanaPrincipal();
                nuevaVentana.Show();
                this.Close();
            }
        }

        private void DGV_ElegirTerapeuta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Utilitaria.Utilitaria.agregarValorIdentificadorTerapeuta(Convert.ToInt32(DGV_ElegirTerapeuta.Rows[e.RowIndex].Cells[2].Value.ToString()));
                MessageBox.Show(Utilitaria.Utilitaria.identificadorTerapeuta.ToString());

                    if (Utilitaria.Utilitaria.identificadorOpcion == 2)
                    { 
                    }

                    if (Utilitaria.Utilitaria.identificadorOpcion == 3)
                    {
                    }

                    if (Utilitaria.Utilitaria.identificadorOpcion == 4)
                    {
                    }

                    if (Utilitaria.Utilitaria.identificadorOpcion == 5)
                    {
                        SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes nuevaVentana = new SistGestionAdministrativaConsultorioMedicoChuao.Vista.PrincipalMensajes();
                        nuevaVentana.Show();
                        this.Close();
                    }

                    if (Utilitaria.Utilitaria.identificadorOpcion == 6)
                    { 
                    }
            }
        }

        public void datosTerapeutas()
        {
            try
            {
                Utilitaria.ConexionBD.conectarBD().Open(); //Abro conexión
                DataSet datosObtenidos = new DataSet(); //Almacen de los datos que se obtengan en la consulta
                NpgsqlDataAdapter datosTerapeutas = new NpgsqlDataAdapter(Utilitaria.Utilitaria.consultaTerapeutas, Utilitaria.ConexionBD.conectarBD()); //Ejecución de la consulta
                datosTerapeutas.Fill(datosObtenidos); // Volcado de los datos en el almacen de datos
                    for (int i = 0; i < datosObtenidos.Tables[0].Rows.Count; i++)
                    {
                        DGV_ElegirTerapeuta.Rows.Add(datosObtenidos.Tables[0].Rows[i][0], "OK", datosObtenidos.Tables[0].Rows[i][1]); // Mostrar los datos en el dgv, en la colunma 2 se guardara de manera oculta el id del terapeuta 
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