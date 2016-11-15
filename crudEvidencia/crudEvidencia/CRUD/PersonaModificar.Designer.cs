namespace crudEvidencia.CRUD
{
    partial class PersonaModificar
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
            System.Windows.Forms.Label idPersonaLabel;
            System.Windows.Forms.Label documentoIdentidadLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label barrioLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label claveAntiguaLabel;
            System.Windows.Forms.Label idSecretariaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label habeasDataLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.personasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaTextBox = new System.Windows.Forms.TextBox();
            this.documentoIdentidadTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.claveAntiguaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.habeasDataTextBox = new System.Windows.Forms.ComboBox();
            this.estadoTextBox = new System.Windows.Forms.ComboBox();
            this.barrioTextBox = new System.Windows.Forms.ComboBox();
            this.idSecretariaTextBox = new System.Windows.Forms.ComboBox();
            idPersonaLabel = new System.Windows.Forms.Label();
            documentoIdentidadLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            barrioLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            claveAntiguaLabel = new System.Windows.Forms.Label();
            idSecretariaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            habeasDataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarriosTableAdapter = null;
            this.tableAdapterManager.CursosAsociadosTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.EstadoSolicitudTableAdapter = null;
            this.tableAdapterManager.HorarioIntermediaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InscritosTableAdapter = null;
            this.tableAdapterManager.InstitutosTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = this.personasTableAdapter;
            this.tableAdapterManager.RolPersonasTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SecretariasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personasDataGridView
            // 
            this.personasDataGridView.AllowUserToAddRows = false;
            this.personasDataGridView.AllowUserToDeleteRows = false;
            this.personasDataGridView.AutoGenerateColumns = false;
            this.personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.personasDataGridView.DataSource = this.personasBindingSource;
            this.personasDataGridView.Location = new System.Drawing.Point(12, 141);
            this.personasDataGridView.Name = "personasDataGridView";
            this.personasDataGridView.ReadOnly = true;
            this.personasDataGridView.Size = new System.Drawing.Size(948, 318);
            this.personasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPersona";
            this.dataGridViewTextBoxColumn1.HeaderText = "idPersona";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "documentoIdentidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "documentoIdentidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombres";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombres";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn4.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Barrio";
            this.dataGridViewTextBoxColumn6.HeaderText = "Barrio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn7.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "correoElectronico";
            this.dataGridViewTextBoxColumn8.HeaderText = "correoElectronico";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "clave";
            this.dataGridViewTextBoxColumn9.HeaderText = "clave";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "claveAntigua";
            this.dataGridViewTextBoxColumn10.HeaderText = "claveAntigua";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "idSecretaria";
            this.dataGridViewTextBoxColumn11.HeaderText = "idSecretaria";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn12.HeaderText = "estado";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HabeasData";
            this.dataGridViewTextBoxColumn13.HeaderText = "HabeasData";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // idPersonaLabel
            // 
            idPersonaLabel.AutoSize = true;
            idPersonaLabel.Location = new System.Drawing.Point(6, 16);
            idPersonaLabel.Name = "idPersonaLabel";
            idPersonaLabel.Size = new System.Drawing.Size(60, 13);
            idPersonaLabel.TabIndex = 2;
            idPersonaLabel.Text = "id Persona:";
            // 
            // idPersonaTextBox
            // 
            this.idPersonaTextBox.BackColor = System.Drawing.Color.White;
            this.idPersonaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "idPersona", true));
            this.idPersonaTextBox.Enabled = false;
            this.idPersonaTextBox.Location = new System.Drawing.Point(122, 13);
            this.idPersonaTextBox.Name = "idPersonaTextBox";
            this.idPersonaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPersonaTextBox.TabIndex = 3;
            // 
            // documentoIdentidadLabel
            // 
            documentoIdentidadLabel.AutoSize = true;
            documentoIdentidadLabel.Location = new System.Drawing.Point(6, 42);
            documentoIdentidadLabel.Name = "documentoIdentidadLabel";
            documentoIdentidadLabel.Size = new System.Drawing.Size(110, 13);
            documentoIdentidadLabel.TabIndex = 4;
            documentoIdentidadLabel.Text = "documento Identidad:";
            // 
            // documentoIdentidadTextBox
            // 
            this.documentoIdentidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "documentoIdentidad", true));
            this.documentoIdentidadTextBox.Location = new System.Drawing.Point(122, 39);
            this.documentoIdentidadTextBox.Name = "documentoIdentidadTextBox";
            this.documentoIdentidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoIdentidadTextBox.TabIndex = 5;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(6, 68);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(50, 13);
            nombresLabel.TabIndex = 6;
            nombresLabel.Text = "nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(122, 65);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 7;
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(244, 16);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 8;
            apellidosLabel.Text = "apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(360, 13);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 9;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(244, 42);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(53, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(360, 39);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // barrioLabel
            // 
            barrioLabel.AutoSize = true;
            barrioLabel.Location = new System.Drawing.Point(244, 68);
            barrioLabel.Name = "barrioLabel";
            barrioLabel.Size = new System.Drawing.Size(37, 13);
            barrioLabel.TabIndex = 12;
            barrioLabel.Text = "Barrio:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(484, 16);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 14;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(600, 13);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 15;
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(484, 42);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(96, 13);
            correoElectronicoLabel.TabIndex = 16;
            correoElectronicoLabel.Text = "correo Electronico:";
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "correoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(600, 39);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoElectronicoTextBox.TabIndex = 17;
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(484, 68);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(36, 13);
            claveLabel.TabIndex = 18;
            claveLabel.Text = "clave:";
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(600, 65);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 19;
            // 
            // claveAntiguaLabel
            // 
            claveAntiguaLabel.AutoSize = true;
            claveAntiguaLabel.Location = new System.Drawing.Point(726, 16);
            claveAntiguaLabel.Name = "claveAntiguaLabel";
            claveAntiguaLabel.Size = new System.Drawing.Size(75, 13);
            claveAntiguaLabel.TabIndex = 20;
            claveAntiguaLabel.Text = "clave Antigua:";
            // 
            // claveAntiguaTextBox
            // 
            this.claveAntiguaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personasBindingSource, "claveAntigua", true));
            this.claveAntiguaTextBox.Location = new System.Drawing.Point(842, 13);
            this.claveAntiguaTextBox.Name = "claveAntiguaTextBox";
            this.claveAntiguaTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveAntiguaTextBox.TabIndex = 21;
            // 
            // idSecretariaLabel
            // 
            idSecretariaLabel.AutoSize = true;
            idSecretariaLabel.Location = new System.Drawing.Point(726, 42);
            idSecretariaLabel.Name = "idSecretariaLabel";
            idSecretariaLabel.Size = new System.Drawing.Size(69, 13);
            idSecretariaLabel.TabIndex = 22;
            idSecretariaLabel.Text = "id Secretaria:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(726, 68);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(42, 13);
            estadoLabel.TabIndex = 24;
            estadoLabel.Text = "estado:";
            // 
            // habeasDataLabel
            // 
            habeasDataLabel.AutoSize = true;
            habeasDataLabel.Location = new System.Drawing.Point(726, 94);
            habeasDataLabel.Name = "habeasDataLabel";
            habeasDataLabel.Size = new System.Drawing.Size(73, 13);
            habeasDataLabel.TabIndex = 26;
            habeasDataLabel.Text = "Habeas Data:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habeasDataTextBox);
            this.groupBox1.Controls.Add(this.VolverBtn);
            this.groupBox1.Controls.Add(this.GuardarBtn);
            this.groupBox1.Controls.Add(this.estadoTextBox);
            this.groupBox1.Controls.Add(idPersonaLabel);
            this.groupBox1.Controls.Add(claveAntiguaLabel);
            this.groupBox1.Controls.Add(this.idSecretariaTextBox);
            this.groupBox1.Controls.Add(this.barrioTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.claveAntiguaTextBox);
            this.groupBox1.Controls.Add(idSecretariaLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(correoElectronicoLabel);
            this.groupBox1.Controls.Add(this.idPersonaTextBox);
            this.groupBox1.Controls.Add(habeasDataLabel);
            this.groupBox1.Controls.Add(this.correoElectronicoTextBox);
            this.groupBox1.Controls.Add(barrioLabel);
            this.groupBox1.Controls.Add(claveLabel);
            this.groupBox1.Controls.Add(documentoIdentidadLabel);
            this.groupBox1.Controls.Add(this.claveTextBox);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(this.documentoIdentidadTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 123);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(9, 94);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(75, 23);
            this.GuardarBtn.TabIndex = 28;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(90, 94);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(75, 23);
            this.VolverBtn.TabIndex = 29;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // habeasDataTextBox
            // 
            this.habeasDataTextBox.FormattingEnabled = true;
            this.habeasDataTextBox.Location = new System.Drawing.Point(842, 91);
            this.habeasDataTextBox.Name = "habeasDataTextBox";
            this.habeasDataTextBox.Size = new System.Drawing.Size(100, 21);
            this.habeasDataTextBox.TabIndex = 33;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.FormattingEnabled = true;
            this.estadoTextBox.Location = new System.Drawing.Point(842, 65);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 21);
            this.estadoTextBox.TabIndex = 32;
            // 
            // barrioTextBox
            // 
            this.barrioTextBox.DisplayMember = "Barrio";
            this.barrioTextBox.FormattingEnabled = true;
            this.barrioTextBox.Location = new System.Drawing.Point(360, 68);
            this.barrioTextBox.Name = "barrioTextBox";
            this.barrioTextBox.Size = new System.Drawing.Size(100, 21);
            this.barrioTextBox.TabIndex = 30;
            this.barrioTextBox.ValueMember = "idBarrios";
            // 
            // idSecretariaTextBox
            // 
            this.idSecretariaTextBox.DisplayMember = "nombreSec";
            this.idSecretariaTextBox.FormattingEnabled = true;
            this.idSecretariaTextBox.Location = new System.Drawing.Point(842, 39);
            this.idSecretariaTextBox.Name = "idSecretariaTextBox";
            this.idSecretariaTextBox.Size = new System.Drawing.Size(100, 21);
            this.idSecretariaTextBox.TabIndex = 31;
            this.idSecretariaTextBox.ValueMember = "idSecretaria";
            // 
            // PersonaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.personasDataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(988, 510);
            this.MinimumSize = new System.Drawing.Size(988, 510);
            this.Name = "PersonaModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar una Persona";
            this.Load += new System.EventHandler(this.PersonaModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.TextBox idPersonaTextBox;
        private System.Windows.Forms.TextBox documentoIdentidadTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox claveAntiguaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.ComboBox habeasDataTextBox;
        private System.Windows.Forms.ComboBox estadoTextBox;
        private System.Windows.Forms.ComboBox barrioTextBox;
        private System.Windows.Forms.ComboBox idSecretariaTextBox;
    }
}