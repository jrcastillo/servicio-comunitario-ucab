namespace SGA_ConsultorioMedicoChuao.Vista.Horario
{
	partial class PromptHorario
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.B_Cancelar = new System.Windows.Forms.Button();
			this.B_Aceptar = new System.Windows.Forms.Button();
			this.MC_Calendario = new System.Windows.Forms.MonthCalendar();
			this.label1 = new System.Windows.Forms.Label();
			this.CB_ElegirTerapeuta = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.CB_ElegirPaciente = new System.Windows.Forms.ComboBox();
			this.TP_HoraCita = new System.Windows.Forms.DateTimePicker();
			this.L_error = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// B_Cancelar
			// 
			this.B_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.B_Cancelar.FlatAppearance.BorderSize = 0;
			this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.B_Cancelar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
			this.B_Cancelar.Location = new System.Drawing.Point(289, 192);
			this.B_Cancelar.Name = "B_Cancelar";
			this.B_Cancelar.Size = new System.Drawing.Size(84, 59);
			this.B_Cancelar.TabIndex = 0;
			this.B_Cancelar.UseVisualStyleBackColor = true;
			this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click_1);
			// 
			// B_Aceptar
			// 
			this.B_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.B_Aceptar.FlatAppearance.BorderSize = 0;
			this.B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.B_Aceptar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Aceptar;
			this.B_Aceptar.Location = new System.Drawing.Point(175, 192);
			this.B_Aceptar.Name = "B_Aceptar";
			this.B_Aceptar.Size = new System.Drawing.Size(82, 59);
			this.B_Aceptar.TabIndex = 1;
			this.B_Aceptar.UseVisualStyleBackColor = true;
			this.B_Aceptar.Click += new System.EventHandler(this.B_Aceptar_Click);
			// 
			// MC_Calendario
			// 
			this.MC_Calendario.Location = new System.Drawing.Point(16, 18);
			this.MC_Calendario.Name = "MC_Calendario";
			this.MC_Calendario.TabIndex = 2;
			this.MC_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MC_Calendario_DateChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(266, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "Elegir Terapeuta";
			// 
			// CB_ElegirTerapeuta
			// 
			this.CB_ElegirTerapeuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_ElegirTerapeuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CB_ElegirTerapeuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.CB_ElegirTerapeuta.FormattingEnabled = true;
			this.CB_ElegirTerapeuta.Location = new System.Drawing.Point(269, 48);
			this.CB_ElegirTerapeuta.Name = "CB_ElegirTerapeuta";
			this.CB_ElegirTerapeuta.Size = new System.Drawing.Size(253, 26);
			this.CB_ElegirTerapeuta.TabIndex = 4;
			this.CB_ElegirTerapeuta.SelectedIndexChanged += new System.EventHandler(this.CB_ElegirTerapeuta_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.label2.Location = new System.Drawing.Point(266, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 18);
			this.label2.TabIndex = 5;
			this.label2.Text = "Elegir Paciente";
			// 
			// CB_ElegirPaciente
			// 
			this.CB_ElegirPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.CB_ElegirPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.CB_ElegirPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CB_ElegirPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.CB_ElegirPaciente.FormattingEnabled = true;
			this.CB_ElegirPaciente.Location = new System.Drawing.Point(269, 115);
			this.CB_ElegirPaciente.Name = "CB_ElegirPaciente";
			this.CB_ElegirPaciente.Size = new System.Drawing.Size(253, 26);
			this.CB_ElegirPaciente.TabIndex = 6;
			this.CB_ElegirPaciente.SelectedIndexChanged += new System.EventHandler(this.CB_ElegirPaciente_SelectedIndexChanged);
			// 
			// TP_HoraCita
			// 
			this.TP_HoraCita.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TP_HoraCita.CustomFormat = "HH:mm tt";
			this.TP_HoraCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TP_HoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.TP_HoraCita.Location = new System.Drawing.Point(269, 156);
			this.TP_HoraCita.Name = "TP_HoraCita";
			this.TP_HoraCita.ShowUpDown = true;
			this.TP_HoraCita.Size = new System.Drawing.Size(109, 24);
			this.TP_HoraCita.TabIndex = 7;
			this.TP_HoraCita.ValueChanged += new System.EventHandler(this.TP_HoraCita_ValueChanged);
			// 
			// L_error
			// 
			this.L_error.AutoSize = true;
			this.L_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			this.L_error.ForeColor = System.Drawing.Color.Red;
			this.L_error.Location = new System.Drawing.Point(384, 161);
			this.L_error.Name = "L_error";
			this.L_error.Size = new System.Drawing.Size(103, 18);
			this.L_error.TabIndex = 8;
			this.L_error.Text = "Hora no valida";
			// 
			// PromptHorario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(534, 263);
			this.ControlBox = false;
			this.Controls.Add(this.L_error);
			this.Controls.Add(this.TP_HoraCita);
			this.Controls.Add(this.CB_ElegirPaciente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CB_ElegirTerapeuta);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.MC_Calendario);
			this.Controls.Add(this.B_Aceptar);
			this.Controls.Add(this.B_Cancelar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "PromptHorario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crear Cita Nueva";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button B_Cancelar;
		private System.Windows.Forms.Button B_Aceptar;
		private System.Windows.Forms.MonthCalendar MC_Calendario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CB_ElegirTerapeuta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CB_ElegirPaciente;
		private System.Windows.Forms.DateTimePicker TP_HoraCita;
		private System.Windows.Forms.Label L_error;
	}
}