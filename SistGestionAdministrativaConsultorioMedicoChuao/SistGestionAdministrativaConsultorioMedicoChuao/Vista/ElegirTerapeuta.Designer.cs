namespace SistGestionAdministrativaConsultorioMedicoChuao.Vista
{
    partial class ElegirTerapeuta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.B_Cancelar = new System.Windows.Forms.Button();
            this.B_Aceptar = new System.Windows.Forms.Button();
            this.L_Aceptar = new System.Windows.Forms.Label();
            this.L_Cancelar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_ElegirTerapeuta = new System.Windows.Forms.DataGridView();
            this.DatosTerapeuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Elegir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElegirTerapeuta)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Cancelar
            // 
            this.B_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Cancelar.FlatAppearance.BorderSize = 0;
            this.B_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Cancelar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Cancelar;
            this.B_Cancelar.Location = new System.Drawing.Point(310, 279);
            this.B_Cancelar.Name = "B_Cancelar";
            this.B_Cancelar.Size = new System.Drawing.Size(89, 59);
            this.B_Cancelar.TabIndex = 1;
            this.B_Cancelar.UseVisualStyleBackColor = true;
            this.B_Cancelar.Click += new System.EventHandler(this.B_Cancelar_Click);
            // 
            // B_Aceptar
            // 
            this.B_Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.B_Aceptar.FlatAppearance.BorderSize = 0;
            this.B_Aceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Aceptar.Image = global::SistGestionAdministrativaConsultorioMedicoChuao.Properties.Resources.Aceptar;
            this.B_Aceptar.Location = new System.Drawing.Point(169, 279);
            this.B_Aceptar.Name = "B_Aceptar";
            this.B_Aceptar.Size = new System.Drawing.Size(76, 59);
            this.B_Aceptar.TabIndex = 0;
            this.B_Aceptar.UseVisualStyleBackColor = true;
            // 
            // L_Aceptar
            // 
            this.L_Aceptar.AutoSize = true;
            this.L_Aceptar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Aceptar.Location = new System.Drawing.Point(164, 341);
            this.L_Aceptar.Name = "L_Aceptar";
            this.L_Aceptar.Size = new System.Drawing.Size(85, 18);
            this.L_Aceptar.TabIndex = 2;
            this.L_Aceptar.Text = "ACEPTAR";
            // 
            // L_Cancelar
            // 
            this.L_Cancelar.AutoSize = true;
            this.L_Cancelar.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cancelar.Location = new System.Drawing.Point(309, 341);
            this.L_Cancelar.Name = "L_Cancelar";
            this.L_Cancelar.Size = new System.Drawing.Size(97, 18);
            this.L_Cancelar.TabIndex = 3;
            this.L_Cancelar.Text = "CANCELAR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elegir Terapeuta";
            // 
            // DGV_ElegirTerapeuta
            // 
            this.DGV_ElegirTerapeuta.AllowUserToAddRows = false;
            this.DGV_ElegirTerapeuta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_ElegirTerapeuta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DGV_ElegirTerapeuta.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            this.DGV_ElegirTerapeuta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DGV_ElegirTerapeuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ElegirTerapeuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosTerapeuta,
            this.Elegir,
            this.identificador});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ElegirTerapeuta.DefaultCellStyle = dataGridViewCellStyle26;
            this.DGV_ElegirTerapeuta.GridColor = System.Drawing.SystemColors.Desktop;
            this.DGV_ElegirTerapeuta.Location = new System.Drawing.Point(12, 48);
            this.DGV_ElegirTerapeuta.Name = "DGV_ElegirTerapeuta";
            this.DGV_ElegirTerapeuta.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_ElegirTerapeuta.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGV_ElegirTerapeuta.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DGV_ElegirTerapeuta.Size = new System.Drawing.Size(526, 214);
            this.DGV_ElegirTerapeuta.TabIndex = 5;
            this.DGV_ElegirTerapeuta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_ElegirTerapeuta_CellContentClick);
            // 
            // DatosTerapeuta
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.DatosTerapeuta.DefaultCellStyle = dataGridViewCellStyle24;
            this.DatosTerapeuta.FillWeight = 150F;
            this.DatosTerapeuta.HeaderText = "Datos terapeuta";
            this.DatosTerapeuta.MinimumWidth = 8;
            this.DatosTerapeuta.Name = "DatosTerapeuta";
            this.DatosTerapeuta.ReadOnly = true;
            this.DatosTerapeuta.Width = 382;
            // 
            // Elegir
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            this.Elegir.DefaultCellStyle = dataGridViewCellStyle25;
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.Name = "Elegir";
            this.Elegir.ReadOnly = true;
            this.Elegir.Text = "Elegir";
            this.Elegir.ToolTipText = "Elegir";
            // 
            // identificador
            // 
            this.identificador.HeaderText = "identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            this.identificador.Visible = false;
            // 
            // ElegirTerapeuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(550, 367);
            this.ControlBox = false;
            this.Controls.Add(this.DGV_ElegirTerapeuta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L_Cancelar);
            this.Controls.Add(this.L_Aceptar);
            this.Controls.Add(this.B_Cancelar);
            this.Controls.Add(this.B_Aceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ElegirTerapeuta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ElegirTerapeuta";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ElegirTerapeuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Aceptar;
        private System.Windows.Forms.Button B_Cancelar;
        private System.Windows.Forms.Label L_Aceptar;
        private System.Windows.Forms.Label L_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_ElegirTerapeuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosTerapeuta;
        private System.Windows.Forms.DataGridViewButtonColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
    }
}