namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class PrincipalMensajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.L_MensajeNuevo = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.L_MenuPplMsj = new System.Windows.Forms.Label();
            this.DGV_Mensajes = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B_Salir = new System.Windows.Forms.Button();
            this.B_MensajeNuevo = new System.Windows.Forms.Button();
            this.L_NombreTerapeuta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // L_MensajeNuevo
            // 
            this.L_MensajeNuevo.AutoSize = true;
            this.L_MensajeNuevo.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MensajeNuevo.Location = new System.Drawing.Point(422, 591);
            this.L_MensajeNuevo.Name = "L_MensajeNuevo";
            this.L_MensajeNuevo.Size = new System.Drawing.Size(144, 18);
            this.L_MensajeNuevo.TabIndex = 2;
            this.L_MensajeNuevo.Text = "MENSAJE NUEVO";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(742, 591);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 3;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // L_MenuPplMsj
            // 
            this.L_MenuPplMsj.AutoSize = true;
            this.L_MenuPplMsj.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_MenuPplMsj.Location = new System.Drawing.Point(446, 9);
            this.L_MenuPplMsj.Name = "L_MenuPplMsj";
            this.L_MenuPplMsj.Size = new System.Drawing.Size(393, 36);
            this.L_MenuPplMsj.TabIndex = 4;
            this.L_MenuPplMsj.Text = "Menú principal mensajes";
            // 
            // DGV_Mensajes
            // 
            this.DGV_Mensajes.AllowUserToAddRows = false;
            this.DGV_Mensajes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Mensajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Mensajes.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Mensajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Mensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Mensajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Titulo,
            this.Ver,
            this.identificador});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Mensajes.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Mensajes.GridColor = System.Drawing.SystemColors.Desktop;
            this.DGV_Mensajes.Location = new System.Drawing.Point(12, 98);
            this.DGV_Mensajes.Name = "DGV_Mensajes";
            this.DGV_Mensajes.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Mensajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_Mensajes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_Mensajes.Size = new System.Drawing.Size(1255, 429);
            this.DGV_Mensajes.TabIndex = 5;
            this.DGV_Mensajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Mensajes_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha y hora de creación";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 315;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título del mesaje";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 796;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Elegir el mensaje";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // identificador
            // 
            this.identificador.HeaderText = "idetificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Visible = false;
            // 
            // B_Salir
            // 
            this.B_Salir.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Salir.FlatAppearance.BorderSize = 0;
            this.B_Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Salir.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Salir.Location = new System.Drawing.Point(745, 524);
            this.B_Salir.Name = "B_Salir";
            this.B_Salir.Size = new System.Drawing.Size(93, 70);
            this.B_Salir.TabIndex = 1;
            this.B_Salir.UseVisualStyleBackColor = true;
            this.B_Salir.Click += new System.EventHandler(this.B_Salir_Click);
            // 
            // B_MensajeNuevo
            // 
            this.B_MensajeNuevo.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_MensajeNuevo.FlatAppearance.BorderSize = 0;
            this.B_MensajeNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_MensajeNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_MensajeNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_MensajeNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_MensajeNuevo.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.MensajeNuevo;
            this.B_MensajeNuevo.Location = new System.Drawing.Point(451, 524);
            this.B_MensajeNuevo.Name = "B_MensajeNuevo";
            this.B_MensajeNuevo.Size = new System.Drawing.Size(85, 70);
            this.B_MensajeNuevo.TabIndex = 0;
            this.B_MensajeNuevo.UseVisualStyleBackColor = true;
            this.B_MensajeNuevo.Click += new System.EventHandler(this.B_MensajeNuevo_Click);
            // 
            // L_NombreTerapeuta
            // 
            this.L_NombreTerapeuta.AutoSize = true;
            this.L_NombreTerapeuta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_NombreTerapeuta.Location = new System.Drawing.Point(12, 63);
            this.L_NombreTerapeuta.Name = "L_NombreTerapeuta";
            this.L_NombreTerapeuta.Size = new System.Drawing.Size(0, 22);
            this.L_NombreTerapeuta.TabIndex = 6;
            // 
            // PrincipalMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1279, 618);
            this.ControlBox = false;
            this.Controls.Add(this.L_NombreTerapeuta);
            this.Controls.Add(this.DGV_Mensajes);
            this.Controls.Add(this.L_MenuPplMsj);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.L_MensajeNuevo);
            this.Controls.Add(this.B_Salir);
            this.Controls.Add(this.B_MensajeNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalMensajes";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mensajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_MensajeNuevo;
        private System.Windows.Forms.Button B_Salir;
        private System.Windows.Forms.Label L_MensajeNuevo;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Label L_MenuPplMsj;
        private System.Windows.Forms.DataGridView DGV_Mensajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.Label L_NombreTerapeuta;
    }
}