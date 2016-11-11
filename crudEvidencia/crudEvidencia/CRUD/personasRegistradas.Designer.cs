namespace crudEvidencia.CRUD
{
    partial class personasRegistradas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoIdentidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveAntiguaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSecretariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habeasDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonaDataGridViewTextBoxColumn,
            this.documentoIdentidadDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.barrioDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.claveAntiguaDataGridViewTextBoxColumn,
            this.idSecretariaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.habeasDataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(610, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personasBindingSource
            // 
            this.personasBindingSource.DataMember = "Personas";
            this.personasBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // personasTableAdapter
            // 
            this.personasTableAdapter.ClearBeforeFill = true;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            // 
            // documentoIdentidadDataGridViewTextBoxColumn
            // 
            this.documentoIdentidadDataGridViewTextBoxColumn.DataPropertyName = "documentoIdentidad";
            this.documentoIdentidadDataGridViewTextBoxColumn.HeaderText = "documentoIdentidad";
            this.documentoIdentidadDataGridViewTextBoxColumn.Name = "documentoIdentidadDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            this.barrioDataGridViewTextBoxColumn.DataPropertyName = "Barrio";
            this.barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            this.barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "correoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // claveAntiguaDataGridViewTextBoxColumn
            // 
            this.claveAntiguaDataGridViewTextBoxColumn.DataPropertyName = "claveAntigua";
            this.claveAntiguaDataGridViewTextBoxColumn.HeaderText = "claveAntigua";
            this.claveAntiguaDataGridViewTextBoxColumn.Name = "claveAntiguaDataGridViewTextBoxColumn";
            // 
            // idSecretariaDataGridViewTextBoxColumn
            // 
            this.idSecretariaDataGridViewTextBoxColumn.DataPropertyName = "idSecretaria";
            this.idSecretariaDataGridViewTextBoxColumn.HeaderText = "idSecretaria";
            this.idSecretariaDataGridViewTextBoxColumn.Name = "idSecretariaDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // habeasDataDataGridViewTextBoxColumn
            // 
            this.habeasDataDataGridViewTextBoxColumn.DataPropertyName = "HabeasData";
            this.habeasDataDataGridViewTextBoxColumn.HeaderText = "HabeasData";
            this.habeasDataDataGridViewTextBoxColumn.Name = "habeasDataDataGridViewTextBoxColumn";
            // 
            // personasRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 338);
            this.Controls.Add(this.dataGridView1);
            this.Name = "personasRegistradas";
            this.Text = "personasRegistradas";
            this.Load += new System.EventHandler(this.personasRegistradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoIdentidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveAntiguaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSecretariaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habeasDataDataGridViewTextBoxColumn;
    }
}