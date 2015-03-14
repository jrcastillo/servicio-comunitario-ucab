namespace SGA_ConsultorioMedicoChuao.Vista
{
	partial class PrincipalHorarios
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.B_Modificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.B_Borrar = new System.Windows.Forms.Button();
			this.L_Salir = new System.Windows.Forms.Label();
			this.L_Borrar = new System.Windows.Forms.Label();
			this.L_Agregar = new System.Windows.Forms.Label();
			this.L_Modificar = new System.Windows.Forms.Label();
			this.B_Agregar = new System.Windows.Forms.Button();
			this.B_Salir = new System.Windows.Forms.Button();
			this.L_NombreTerapeuta = new System.Windows.Forms.Label();
			this.CB_Terapeutas = new System.Windows.Forms.ComboBox();
			this.MC_Calendario = new System.Windows.Forms.MonthCalendar();
			this.GV_VistaHorarios = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GV_VistaHorarios)).BeginInit();
			this.SuspendLayout();
			// 
			// B_Modificar
			// 
			this.B_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.B_Modificar.FlatAppearance.BorderSize = 0;
			this.B_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.B_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.B_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.B_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Modificar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Modificar;
			this.B_Modificar.Location = new System.Drawing.Point(173, 303);
			this.B_Modificar.Name = "B_Modificar";
			this.B_Modificar.Size = new System.Drawing.Size(75, 66);
			this.B_Modificar.TabIndex = 1;
			this.B_Modificar.UseVisualStyleBackColor = true;
			this.B_Modificar.Click += new System.EventHandler(this.B_Modificar_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(604, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 40);
			this.label1.TabIndex = 3;
			this.label1.Text = "Horarios";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// B_Borrar
			// 
			this.B_Borrar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.B_Borrar.FlatAppearance.BorderSize = 0;
			this.B_Borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.B_Borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.B_Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.B_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Borrar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Borrar;
			this.B_Borrar.Location = new System.Drawing.Point(21, 411);
			this.B_Borrar.Name = "B_Borrar";
			this.B_Borrar.Size = new System.Drawing.Size(75, 66);
			this.B_Borrar.TabIndex = 5;
			this.B_Borrar.UseVisualStyleBackColor = true;
			this.B_Borrar.Click += new System.EventHandler(this.B_Borrar_Click);
			// 
			// L_Salir
			// 
			this.L_Salir.AutoSize = true;
			this.L_Salir.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_Salir.Location = new System.Drawing.Point(185, 480);
			this.L_Salir.Name = "L_Salir";
			this.L_Salir.Size = new System.Drawing.Size(55, 18);
			this.L_Salir.TabIndex = 6;
			this.L_Salir.Text = "SALIR";
			// 
			// L_Borrar
			// 
			this.L_Borrar.AutoSize = true;
			this.L_Borrar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_Borrar.Location = new System.Drawing.Point(25, 474);
			this.L_Borrar.Name = "L_Borrar";
			this.L_Borrar.Size = new System.Drawing.Size(76, 18);
			this.L_Borrar.TabIndex = 7;
			this.L_Borrar.Text = "BORRAR";
			// 
			// L_Agregar
			// 
			this.L_Agregar.AutoSize = true;
			this.L_Agregar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_Agregar.Location = new System.Drawing.Point(18, 372);
			this.L_Agregar.Name = "L_Agregar";
			this.L_Agregar.Size = new System.Drawing.Size(90, 18);
			this.L_Agregar.TabIndex = 8;
			this.L_Agregar.Text = "AGREGAR";
			// 
			// L_Modificar
			// 
			this.L_Modificar.AutoSize = true;
			this.L_Modificar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_Modificar.Location = new System.Drawing.Point(157, 372);
			this.L_Modificar.Name = "L_Modificar";
			this.L_Modificar.Size = new System.Drawing.Size(103, 18);
			this.L_Modificar.TabIndex = 10;
			this.L_Modificar.Text = "MODIFICAR";
			// 
			// B_Agregar
			// 
			this.B_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.B_Agregar.FlatAppearance.BorderSize = 0;
			this.B_Agregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.B_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.B_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.B_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Agregar.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.NuevoListaEspera;
			this.B_Agregar.Location = new System.Drawing.Point(21, 303);
			this.B_Agregar.Name = "B_Agregar";
			this.B_Agregar.Size = new System.Drawing.Size(75, 66);
			this.B_Agregar.TabIndex = 9;
			this.B_Agregar.UseVisualStyleBackColor = true;
			this.B_Agregar.Click += new System.EventHandler(this.B_Agregar_Click);
			// 
			// B_Salir
			// 
			this.B_Salir.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
			this.B_Salir.FlatAppearance.BorderSize = 0;
			this.B_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
			this.B_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.B_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.B_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.B_Salir.Image = global::SGA_ConsultorioMedicoChuao.Properties.Resources.Cancelar;
			this.B_Salir.Location = new System.Drawing.Point(173, 411);
			this.B_Salir.Name = "B_Salir";
			this.B_Salir.Size = new System.Drawing.Size(75, 66);
			this.B_Salir.TabIndex = 4;
			this.B_Salir.UseVisualStyleBackColor = true;
			this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
			// 
			// L_NombreTerapeuta
			// 
			this.L_NombreTerapeuta.AutoSize = true;
			this.L_NombreTerapeuta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.L_NombreTerapeuta.Location = new System.Drawing.Point(17, 85);
			this.L_NombreTerapeuta.Name = "L_NombreTerapeuta";
			this.L_NombreTerapeuta.Size = new System.Drawing.Size(175, 22);
			this.L_NombreTerapeuta.TabIndex = 11;
			this.L_NombreTerapeuta.Text = "Elegir Terapeuta: ";
			// 
			// CB_Terapeutas
			// 
			this.CB_Terapeutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Terapeutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CB_Terapeutas.FormattingEnabled = true;
			this.CB_Terapeutas.Location = new System.Drawing.Point(188, 85);
			this.CB_Terapeutas.Name = "CB_Terapeutas";
			this.CB_Terapeutas.Size = new System.Drawing.Size(289, 21);
			this.CB_Terapeutas.TabIndex = 12;
			this.CB_Terapeutas.SelectedIndexChanged += new System.EventHandler(this.CB_Terapeutas_SelectedIndexChanged);
			// 
			// MC_Calendario
			// 
			this.MC_Calendario.Location = new System.Drawing.Point(21, 129);
			this.MC_Calendario.MaxSelectionCount = 1;
			this.MC_Calendario.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.MC_Calendario.Name = "MC_Calendario";
			this.MC_Calendario.TabIndex = 13;
			this.MC_Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MC_Calendario_DateChanged);
			// 
			// GV_VistaHorarios
			// 
			this.GV_VistaHorarios.AllowUserToAddRows = false;
			this.GV_VistaHorarios.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.NullValue = "N/A";
			this.GV_VistaHorarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.GV_VistaHorarios.BackgroundColor = System.Drawing.Color.MediumTurquoise;
			this.GV_VistaHorarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.GV_VistaHorarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GV_VistaHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.GV_VistaHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GV_VistaHorarios.DefaultCellStyle = dataGridViewCellStyle3;
			this.GV_VistaHorarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.GV_VistaHorarios.Location = new System.Drawing.Point(286, 129);
			this.GV_VistaHorarios.MultiSelect = false;
			this.GV_VistaHorarios.Name = "GV_VistaHorarios";
			this.GV_VistaHorarios.ReadOnly = true;
			this.GV_VistaHorarios.RowHeadersWidth = 80;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.GV_VistaHorarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.GV_VistaHorarios.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.GV_VistaHorarios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.GV_VistaHorarios.Size = new System.Drawing.Size(960, 377);
			this.GV_VistaHorarios.TabIndex = 14;
			this.GV_VistaHorarios.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(18, 390);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 18);
			this.label2.TabIndex = 15;
			this.label2.Text = "REGISTRO";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(162, 390);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 18);
			this.label3.TabIndex = 16;
			this.label3.Text = "REGISTRO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(18, 492);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 18);
			this.label4.TabIndex = 17;
			this.label4.Text = "REGISTRO";
			// 
			// PrincipalHorarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(1258, 528);
			this.ControlBox = false;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.GV_VistaHorarios);
			this.Controls.Add(this.MC_Calendario);
			this.Controls.Add(this.CB_Terapeutas);
			this.Controls.Add(this.L_NombreTerapeuta);
			this.Controls.Add(this.L_Modificar);
			this.Controls.Add(this.B_Agregar);
			this.Controls.Add(this.L_Agregar);
			this.Controls.Add(this.L_Borrar);
			this.Controls.Add(this.L_Salir);
			this.Controls.Add(this.B_Borrar);
			this.Controls.Add(this.B_Salir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.B_Modificar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "PrincipalHorarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MouseEnter += new System.EventHandler(this.RecargarGV);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RecargarGV);
			((System.ComponentModel.ISupportInitialize)(this.GV_VistaHorarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Modificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Button B_Borrar;
        private System.Windows.Forms.Label L_Salir;
        private System.Windows.Forms.Label L_Borrar;
        private System.Windows.Forms.Label L_Agregar;
        private System.Windows.Forms.Button B_Agregar;
		private System.Windows.Forms.Label L_Modificar;
        private System.Windows.Forms.Label L_NombreTerapeuta;
		private System.Windows.Forms.ComboBox CB_Terapeutas;
		private System.Windows.Forms.MonthCalendar MC_Calendario;
		private System.Windows.Forms.DataGridView GV_VistaHorarios;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
    }
}