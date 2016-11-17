namespace crudEvidencia.CRUD
{
    partial class Horario
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
            this.components = new System.ComponentModel.Container();
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horarioTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.HorarioTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.gpInformacion = new System.Windows.Forms.GroupBox();
            this.txtDia = new System.Windows.Forms.Label();
            this.lblValorId = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.DtpDia = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            this.gpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horarioBindingSource
            // 
            this.horarioBindingSource.DataMember = "Horario";
            this.horarioBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // horarioTableAdapter
            // 
            this.horarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarriosTableAdapter = null;
            this.tableAdapterManager.CursosAsociadosTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.EstadoSolicitudTableAdapter = null;
            this.tableAdapterManager.HorarioIntermediaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = this.horarioTableAdapter;
            this.tableAdapterManager.InscritosTableAdapter = null;
            this.tableAdapterManager.InstitutosTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = null;
            this.tableAdapterManager.RolPersonasTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SecretariasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(224, 317);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 41);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(224, 364);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 41);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Location = new System.Drawing.Point(21, 364);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(178, 41);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(21, 317);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(178, 41);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // gpInformacion
            // 
            this.gpInformacion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gpInformacion.Controls.Add(this.DtpDia);
            this.gpInformacion.Controls.Add(this.cmbHora);
            this.gpInformacion.Controls.Add(this.txtDia);
            this.gpInformacion.Controls.Add(this.lblNombre);
            this.gpInformacion.Controls.Add(this.lblValorId);
            this.gpInformacion.Controls.Add(this.lblid);
            this.gpInformacion.Location = new System.Drawing.Point(21, 11);
            this.gpInformacion.Name = "gpInformacion";
            this.gpInformacion.Size = new System.Drawing.Size(375, 179);
            this.gpInformacion.TabIndex = 7;
            this.gpInformacion.TabStop = false;
            this.gpInformacion.Text = "Información";
            // 
            // txtDia
            // 
            this.txtDia.AutoSize = true;
            this.txtDia.Location = new System.Drawing.Point(33, 129);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(23, 13);
            this.txtDia.TabIndex = 4;
            this.txtDia.Text = "Dia";
            // 
            // lblValorId
            // 
            this.lblValorId.AutoSize = true;
            this.lblValorId.Location = new System.Drawing.Point(110, 50);
            this.lblValorId.Name = "lblValorId";
            this.lblValorId.Size = new System.Drawing.Size(16, 13);
            this.lblValorId.TabIndex = 1;
            this.lblValorId.Text = "---";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(33, 50);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(53, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id Horario";
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(431, 12);
            this.dgvResumen.MultiSelect = false;
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.ReadOnly = true;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(730, 425);
            this.dgvResumen.TabIndex = 6;
            this.dgvResumen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumen_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(30, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Hora";
            // 
            // cmbHora
            // 
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(133, 86);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(212, 21);
            this.cmbHora.TabIndex = 5;
            // 
            // DtpDia
            // 
            this.DtpDia.Location = new System.Drawing.Point(133, 123);
            this.DtpDia.Name = "DtpDia";
            this.DtpDia.Size = new System.Drawing.Size(212, 20);
            this.DtpDia.TabIndex = 6;
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1201, 449);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.gpInformacion);
            this.Controls.Add(this.dgvResumen);
            this.MinimumSize = new System.Drawing.Size(997, 488);
            this.Name = "Horario";
            this.Text = "Horario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            this.gpInformacion.ResumeLayout(false);
            this.gpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.HorarioTableAdapter horarioTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox gpInformacion;
        private System.Windows.Forms.Label txtDia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValorId;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.DateTimePicker DtpDia;
        private System.Windows.Forms.ComboBox cmbHora;
    }
}