namespace crudEvidencia.CRUD
{
    partial class Persona
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
            System.Windows.Forms.Label RolLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.personasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personasTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.documentoIdentidadTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.claveAntiguaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.habeasDataTextBox = new System.Windows.Forms.ComboBox();
            this.estadoTextBox = new System.Windows.Forms.ComboBox();
            this.barrioTextBox = new System.Windows.Forms.ComboBox();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idSecretariaTextBox = new System.Windows.Forms.ComboBox();
            this.secretariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.barriosTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.BarriosTableAdapter();
            this.secretariasTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.SecretariasTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RolCheckList = new System.Windows.Forms.CheckedListBox();
            this.RolbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.RolTableAdapter();
            this.limpiarBtn = new System.Windows.Forms.Button();
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
            RolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentoIdentidadLabel
            // 
            documentoIdentidadLabel.AutoSize = true;
            documentoIdentidadLabel.Location = new System.Drawing.Point(6, 16);
            documentoIdentidadLabel.Name = "documentoIdentidadLabel";
            documentoIdentidadLabel.Size = new System.Drawing.Size(112, 13);
            documentoIdentidadLabel.TabIndex = 2;
            documentoIdentidadLabel.Text = "Documento Identidad:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(6, 42);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(6, 68);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "Apellidos:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(6, 94);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // barrioLabel
            // 
            barrioLabel.AutoSize = true;
            barrioLabel.Location = new System.Drawing.Point(6, 120);
            barrioLabel.Name = "barrioLabel";
            barrioLabel.Size = new System.Drawing.Size(37, 13);
            barrioLabel.TabIndex = 10;
            barrioLabel.Text = "Barrio:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(6, 146);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 12;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.Location = new System.Drawing.Point(6, 172);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 14;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Location = new System.Drawing.Point(6, 198);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 16;
            claveLabel.Text = "Clave:";
            // 
            // claveAntiguaLabel
            // 
            claveAntiguaLabel.AutoSize = true;
            claveAntiguaLabel.Location = new System.Drawing.Point(6, 224);
            claveAntiguaLabel.Name = "claveAntiguaLabel";
            claveAntiguaLabel.Size = new System.Drawing.Size(76, 13);
            claveAntiguaLabel.TabIndex = 18;
            claveAntiguaLabel.Text = "Clave Antigua:";
            // 
            // idSecretariaLabel
            // 
            idSecretariaLabel.AutoSize = true;
            idSecretariaLabel.Location = new System.Drawing.Point(6, 250);
            idSecretariaLabel.Name = "idSecretariaLabel";
            idSecretariaLabel.Size = new System.Drawing.Size(58, 13);
            idSecretariaLabel.TabIndex = 20;
            idSecretariaLabel.Text = "Secretaria:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(6, 276);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 22;
            estadoLabel.Text = "Estado:";
            // 
            // habeasDataLabel
            // 
            habeasDataLabel.AutoSize = true;
            habeasDataLabel.Location = new System.Drawing.Point(6, 302);
            habeasDataLabel.Name = "habeasDataLabel";
            habeasDataLabel.Size = new System.Drawing.Size(73, 13);
            habeasDataLabel.TabIndex = 24;
            habeasDataLabel.Text = "Habeas Data:";
            // 
            // RolLabel
            // 
            RolLabel.AutoSize = true;
            RolLabel.Location = new System.Drawing.Point(12, 16);
            RolLabel.Name = "RolLabel";
            RolLabel.Size = new System.Drawing.Size(26, 13);
            RolLabel.TabIndex = 30;
            RolLabel.Text = "Rol:";
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
            // documentoIdentidadTextBox
            // 
            this.documentoIdentidadTextBox.Location = new System.Drawing.Point(122, 13);
            this.documentoIdentidadTextBox.Name = "documentoIdentidadTextBox";
            this.documentoIdentidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoIdentidadTextBox.TabIndex = 0;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(122, 39);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombresTextBox.TabIndex = 1;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Location = new System.Drawing.Point(122, 65);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 2;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(122, 91);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(122, 143);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 5;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(122, 169);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.correoElectronicoTextBox.TabIndex = 6;
            // 
            // claveTextBox
            // 
            this.claveTextBox.Location = new System.Drawing.Point(122, 195);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveTextBox.TabIndex = 7;
            // 
            // claveAntiguaTextBox
            // 
            this.claveAntiguaTextBox.Location = new System.Drawing.Point(122, 221);
            this.claveAntiguaTextBox.Name = "claveAntiguaTextBox";
            this.claveAntiguaTextBox.Size = new System.Drawing.Size(100, 20);
            this.claveAntiguaTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.habeasDataTextBox);
            this.groupBox1.Controls.Add(this.estadoTextBox);
            this.groupBox1.Controls.Add(this.barrioTextBox);
            this.groupBox1.Controls.Add(this.idSecretariaTextBox);
            this.groupBox1.Controls.Add(habeasDataLabel);
            this.groupBox1.Controls.Add(documentoIdentidadLabel);
            this.groupBox1.Controls.Add(this.documentoIdentidadTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(idSecretariaLabel);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Controls.Add(this.claveAntiguaTextBox);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(claveAntiguaLabel);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(this.claveTextBox);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(claveLabel);
            this.groupBox1.Controls.Add(barrioLabel);
            this.groupBox1.Controls.Add(this.correoElectronicoTextBox);
            this.groupBox1.Controls.Add(correoElectronicoLabel);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 333);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // habeasDataTextBox
            // 
            this.habeasDataTextBox.FormattingEnabled = true;
            this.habeasDataTextBox.Location = new System.Drawing.Point(122, 299);
            this.habeasDataTextBox.Name = "habeasDataTextBox";
            this.habeasDataTextBox.Size = new System.Drawing.Size(100, 21);
            this.habeasDataTextBox.TabIndex = 11;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.FormattingEnabled = true;
            this.estadoTextBox.Location = new System.Drawing.Point(122, 273);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 21);
            this.estadoTextBox.TabIndex = 10;
            // 
            // barrioTextBox
            // 
            this.barrioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.barriosBindingSource, "idBarrios", true));
            this.barrioTextBox.DataSource = this.barriosBindingSource;
            this.barrioTextBox.DisplayMember = "Barrio";
            this.barrioTextBox.FormattingEnabled = true;
            this.barrioTextBox.Location = new System.Drawing.Point(122, 116);
            this.barrioTextBox.Name = "barrioTextBox";
            this.barrioTextBox.Size = new System.Drawing.Size(100, 21);
            this.barrioTextBox.TabIndex = 4;
            this.barrioTextBox.ValueMember = "idBarrios";
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataMember = "Barrios";
            this.barriosBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // idSecretariaTextBox
            // 
            this.idSecretariaTextBox.DataSource = this.secretariasBindingSource;
            this.idSecretariaTextBox.DisplayMember = "nombreSec";
            this.idSecretariaTextBox.FormattingEnabled = true;
            this.idSecretariaTextBox.Location = new System.Drawing.Point(122, 247);
            this.idSecretariaTextBox.Name = "idSecretariaTextBox";
            this.idSecretariaTextBox.Size = new System.Drawing.Size(100, 21);
            this.idSecretariaTextBox.TabIndex = 9;
            this.idSecretariaTextBox.ValueMember = "idSecretaria";
            // 
            // secretariasBindingSource
            // 
            this.secretariasBindingSource.DataMember = "Secretarias";
            this.secretariasBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(272, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(439, 354);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(434, 380);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 14;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(515, 380);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 15;
            this.BtnBorrar.Text = "Eliminar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(353, 380);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 13;
            this.BtnNuevo.Text = "Guardar";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // barriosTableAdapter
            // 
            this.barriosTableAdapter.ClearBeforeFill = true;
            // 
            // secretariasTableAdapter
            // 
            this.secretariasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(RolLabel);
            this.groupBox2.Controls.Add(this.RolCheckList);
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 108);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // RolCheckList
            // 
            this.RolCheckList.FormattingEnabled = true;
            this.RolCheckList.Location = new System.Drawing.Point(128, 6);
            this.RolCheckList.Name = "RolCheckList";
            this.RolCheckList.Size = new System.Drawing.Size(100, 94);
            this.RolCheckList.TabIndex = 12;
            // 
            // RolbindingSource
            // 
            this.RolbindingSource.DataMember = "Rol";
            this.RolbindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(272, 380);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 32;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 540);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Persona";
            this.Text = "Personas";
            this.Load += new System.EventHandler(this.RegistroPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secretariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RolbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource personasBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.PersonasTableAdapter personasTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox documentoIdentidadTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox claveAntiguaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ComboBox habeasDataTextBox;
        private System.Windows.Forms.ComboBox estadoTextBox;
        private System.Windows.Forms.ComboBox barrioTextBox;
        private System.Windows.Forms.ComboBox idSecretariaTextBox;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.BarriosTableAdapter barriosTableAdapter;
        private System.Windows.Forms.BindingSource secretariasBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.SecretariasTableAdapter secretariasTableAdapter;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox RolCheckList;
        private System.Windows.Forms.BindingSource RolbindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.RolTableAdapter rolTableAdapter;
        private System.Windows.Forms.Button limpiarBtn;
    }
}