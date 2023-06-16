namespace pryGestion_Molina
{
    partial class frmTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareas));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblOrgano = new System.Windows.Forms.Label();
            this.lstOrgano = new System.Windows.Forms.ComboBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.lstDetalles = new System.Windows.Forms.ListBox();
            this.mrcReunion = new System.Windows.Forms.GroupBox();
            this.optSi = new System.Windows.Forms.RadioButton();
            this.optNo = new System.Windows.Forms.RadioButton();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.chkEnmienda = new System.Windows.Forms.CheckBox();
            this.chkTratados = new System.Windows.Forms.CheckBox();
            this.chkDebate = new System.Windows.Forms.CheckBox();
            this.chkNotas = new System.Windows.Forms.CheckBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcReunion.SuspendLayout();
            this.mrcTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(29, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(328, 27);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(25, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 23);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblOrgano
            // 
            this.lblOrgano.AutoSize = true;
            this.lblOrgano.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgano.Location = new System.Drawing.Point(25, 79);
            this.lblOrgano.Name = "lblOrgano";
            this.lblOrgano.Size = new System.Drawing.Size(80, 23);
            this.lblOrgano.TabIndex = 2;
            this.lblOrgano.Text = "Organo";
            this.lblOrgano.Click += new System.EventHandler(this.lblOrgano_Click);
            // 
            // lstOrgano
            // 
            this.lstOrgano.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrgano.FormattingEnabled = true;
            this.lstOrgano.Items.AddRange(new object[] {
            "Asamblea General",
            "Consejo de Embajadores",
            "Consejo de Jefes de Estado",
            "Consejo de Ministros de RREE",
            "Consejo de Delegados",
            "Consejo de Desarrollo Sostenible",
            "Consejo del Futuro"});
            this.lstOrgano.Location = new System.Drawing.Point(29, 105);
            this.lstOrgano.Name = "lstOrgano";
            this.lstOrgano.Size = new System.Drawing.Size(237, 24);
            this.lstOrgano.TabIndex = 3;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalles.Location = new System.Drawing.Point(25, 155);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(87, 23);
            this.lblDetalles.TabIndex = 4;
            this.lblDetalles.Text = "Detalles";
            // 
            // lstDetalles
            // 
            this.lstDetalles.FormattingEnabled = true;
            this.lstDetalles.Location = new System.Drawing.Point(29, 181);
            this.lstDetalles.Name = "lstDetalles";
            this.lstDetalles.Size = new System.Drawing.Size(237, 108);
            this.lstDetalles.TabIndex = 5;
            this.lstDetalles.SelectedIndexChanged += new System.EventHandler(this.lstDetalles_SelectedIndexChanged);
            // 
            // mrcReunion
            // 
            this.mrcReunion.Controls.Add(this.optSi);
            this.mrcReunion.Controls.Add(this.optNo);
            this.mrcReunion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcReunion.Location = new System.Drawing.Point(29, 315);
            this.mrcReunion.Name = "mrcReunion";
            this.mrcReunion.Size = new System.Drawing.Size(237, 79);
            this.mrcReunion.TabIndex = 6;
            this.mrcReunion.TabStop = false;
            this.mrcReunion.Text = "Reunion";
            // 
            // optSi
            // 
            this.optSi.AutoSize = true;
            this.optSi.Location = new System.Drawing.Point(139, 35);
            this.optSi.Name = "optSi";
            this.optSi.Size = new System.Drawing.Size(47, 27);
            this.optSi.TabIndex = 11;
            this.optSi.TabStop = true;
            this.optSi.Text = "Si";
            this.optSi.UseVisualStyleBackColor = true;
            this.optSi.CheckedChanged += new System.EventHandler(this.optSi_CheckedChanged);
            // 
            // optNo
            // 
            this.optNo.AutoSize = true;
            this.optNo.Location = new System.Drawing.Point(29, 35);
            this.optNo.Name = "optNo";
            this.optNo.Size = new System.Drawing.Size(54, 27);
            this.optNo.TabIndex = 10;
            this.optNo.TabStop = true;
            this.optNo.Text = "No";
            this.optNo.UseVisualStyleBackColor = true;
            // 
            // mrcTareas
            // 
            this.mrcTareas.Controls.Add(this.chkEnmienda);
            this.mrcTareas.Controls.Add(this.chkTratados);
            this.mrcTareas.Controls.Add(this.chkDebate);
            this.mrcTareas.Controls.Add(this.chkNotas);
            this.mrcTareas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcTareas.Location = new System.Drawing.Point(29, 401);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Size = new System.Drawing.Size(237, 93);
            this.mrcTareas.TabIndex = 7;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Tareas";
            // 
            // chkEnmienda
            // 
            this.chkEnmienda.AutoSize = true;
            this.chkEnmienda.Location = new System.Drawing.Point(110, 27);
            this.chkEnmienda.Name = "chkEnmienda";
            this.chkEnmienda.Size = new System.Drawing.Size(133, 27);
            this.chkEnmienda.TabIndex = 10;
            this.chkEnmienda.Text = "Enmiendas";
            this.chkEnmienda.UseVisualStyleBackColor = true;
            this.chkEnmienda.CheckedChanged += new System.EventHandler(this.chkEnmienda_CheckedChanged);
            // 
            // chkTratados
            // 
            this.chkTratados.AutoSize = true;
            this.chkTratados.Location = new System.Drawing.Point(110, 60);
            this.chkTratados.Name = "chkTratados";
            this.chkTratados.Size = new System.Drawing.Size(110, 27);
            this.chkTratados.TabIndex = 11;
            this.chkTratados.Text = "Tratados";
            this.chkTratados.UseVisualStyleBackColor = true;
            // 
            // chkDebate
            // 
            this.chkDebate.AutoSize = true;
            this.chkDebate.Location = new System.Drawing.Point(6, 60);
            this.chkDebate.Name = "chkDebate";
            this.chkDebate.Size = new System.Drawing.Size(96, 27);
            this.chkDebate.TabIndex = 12;
            this.chkDebate.Text = "Debate";
            this.chkDebate.UseVisualStyleBackColor = true;
            // 
            // chkNotas
            // 
            this.chkNotas.AutoSize = true;
            this.chkNotas.Location = new System.Drawing.Point(6, 27);
            this.chkNotas.Name = "chkNotas";
            this.chkNotas.Size = new System.Drawing.Size(83, 27);
            this.chkNotas.TabIndex = 0;
            this.chkNotas.Text = "Notas";
            this.chkNotas.UseVisualStyleBackColor = true;
            this.chkNotas.CheckedChanged += new System.EventHandler(this.chkNotas_CheckedChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(168, 528);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 30);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Confirmar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(29, 528);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 583);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.mrcTareas);
            this.Controls.Add(this.mrcReunion);
            this.Controls.Add(this.lstDetalles);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lstOrgano);
            this.Controls.Add(this.lblOrgano);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTareas";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mrcReunion.ResumeLayout(false);
            this.mrcReunion.PerformLayout();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblOrgano;
        private System.Windows.Forms.ComboBox lstOrgano;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ListBox lstDetalles;
        private System.Windows.Forms.GroupBox mrcReunion;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.CheckBox chkEnmienda;
        private System.Windows.Forms.CheckBox chkTratados;
        private System.Windows.Forms.CheckBox chkDebate;
        private System.Windows.Forms.CheckBox chkNotas;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton optSi;
        private System.Windows.Forms.RadioButton optNo;
    }
}