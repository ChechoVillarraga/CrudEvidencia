namespace crudEvidencia.CRUD
{
    partial class institutos
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
            System.Windows.Forms.Label idInstitutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(institutos));
            System.Windows.Forms.Label nombreInsLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label idContactoLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.institutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.institutosTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.InstitutosTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.institutosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idInstitutoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.institutosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreInsTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.idContactoTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.institutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idInstitutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreInsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idInstitutoLabel = new System.Windows.Forms.Label();
            nombreInsLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            idContactoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingNavigator)).BeginInit();
            this.institutosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // institutosBindingSource
            // 
            this.institutosBindingSource.DataMember = "Institutos";
            this.institutosBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // institutosTableAdapter
            // 
            this.institutosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.InstitutosTableAdapter = this.institutosTableAdapter;
            this.tableAdapterManager.PersonasTableAdapter = null;
            this.tableAdapterManager.RolPersonasTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SecretariasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // institutosBindingNavigator
            // 
            this.institutosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.institutosBindingNavigator.BindingSource = this.institutosBindingSource;
            this.institutosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.institutosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.institutosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.institutosBindingNavigatorSaveItem});
            this.institutosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.institutosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.institutosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.institutosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.institutosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.institutosBindingNavigator.Name = "institutosBindingNavigator";
            this.institutosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.institutosBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.institutosBindingNavigator.TabIndex = 0;
            this.institutosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idInstitutoLabel
            // 
            idInstitutoLabel.AutoSize = true;
            idInstitutoLabel.Location = new System.Drawing.Point(21, 77);
            idInstitutoLabel.Name = "idInstitutoLabel";
            idInstitutoLabel.Size = new System.Drawing.Size(58, 13);
            idInstitutoLabel.TabIndex = 1;
            idInstitutoLabel.Text = "id Instituto:";
            // 
            // idInstitutoTextBox
            // 
            this.idInstitutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institutosBindingSource, "idInstituto", true));
            this.idInstitutoTextBox.Location = new System.Drawing.Point(122, 70);
            this.idInstitutoTextBox.Name = "idInstitutoTextBox";
            this.idInstitutoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idInstitutoTextBox.TabIndex = 2;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // institutosBindingNavigatorSaveItem
            // 
            this.institutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.institutosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("institutosBindingNavigatorSaveItem.Image")));
            this.institutosBindingNavigatorSaveItem.Name = "institutosBindingNavigatorSaveItem";
            this.institutosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.institutosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.institutosBindingNavigatorSaveItem.Click += new System.EventHandler(this.institutosBindingNavigatorSaveItem_Click);
            // 
            // nombreInsLabel
            // 
            nombreInsLabel.AutoSize = true;
            nombreInsLabel.Location = new System.Drawing.Point(12, 130);
            nombreInsLabel.Name = "nombreInsLabel";
            nombreInsLabel.Size = new System.Drawing.Size(62, 13);
            nombreInsLabel.TabIndex = 3;
            nombreInsLabel.Text = "nombre Ins:";
            // 
            // nombreInsTextBox
            // 
            this.nombreInsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institutosBindingSource, "nombreIns", true));
            this.nombreInsTextBox.Location = new System.Drawing.Point(122, 127);
            this.nombreInsTextBox.Name = "nombreInsTextBox";
            this.nombreInsTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreInsTextBox.TabIndex = 4;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 190);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 5;
            telefonoLabel.Text = "telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institutosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(122, 190);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 6;
            // 
            // idContactoLabel
            // 
            idContactoLabel.AutoSize = true;
            idContactoLabel.Location = new System.Drawing.Point(10, 276);
            idContactoLabel.Name = "idContactoLabel";
            idContactoLabel.Size = new System.Drawing.Size(64, 13);
            idContactoLabel.TabIndex = 7;
            idContactoLabel.Text = "id Contacto:";
            // 
            // idContactoTextBox
            // 
            this.idContactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.institutosBindingSource, "idContacto", true));
            this.idContactoTextBox.Location = new System.Drawing.Point(122, 269);
            this.idContactoTextBox.Name = "idContactoTextBox";
            this.idContactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idContactoTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInstitutoDataGridViewTextBoxColumn,
            this.nombreInsDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.idContactoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.institutosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(290, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 287);
            this.dataGridView1.TabIndex = 9;
            // 
            // institutosBindingSource1
            // 
            this.institutosBindingSource1.DataMember = "Institutos";
            this.institutosBindingSource1.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // idInstitutoDataGridViewTextBoxColumn
            // 
            this.idInstitutoDataGridViewTextBoxColumn.DataPropertyName = "idInstituto";
            this.idInstitutoDataGridViewTextBoxColumn.HeaderText = "idInstituto";
            this.idInstitutoDataGridViewTextBoxColumn.Name = "idInstitutoDataGridViewTextBoxColumn";
            this.idInstitutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreInsDataGridViewTextBoxColumn
            // 
            this.nombreInsDataGridViewTextBoxColumn.DataPropertyName = "nombreIns";
            this.nombreInsDataGridViewTextBoxColumn.HeaderText = "nombreIns";
            this.nombreInsDataGridViewTextBoxColumn.Name = "nombreInsDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // idContactoDataGridViewTextBoxColumn
            // 
            this.idContactoDataGridViewTextBoxColumn.DataPropertyName = "idContacto";
            this.idContactoDataGridViewTextBoxColumn.HeaderText = "idContacto";
            this.idContactoDataGridViewTextBoxColumn.Name = "idContactoDataGridViewTextBoxColumn";
            // 
            // institutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(idContactoLabel);
            this.Controls.Add(this.idContactoTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(nombreInsLabel);
            this.Controls.Add(this.nombreInsTextBox);
            this.Controls.Add(idInstitutoLabel);
            this.Controls.Add(this.idInstitutoTextBox);
            this.Controls.Add(this.institutosBindingNavigator);
            this.Name = "institutos";
            this.Text = "institutos";
            this.Load += new System.EventHandler(this.institutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingNavigator)).EndInit();
            this.institutosBindingNavigator.ResumeLayout(false);
            this.institutosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.institutosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource institutosBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.InstitutosTableAdapter institutosTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator institutosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton institutosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idInstitutoTextBox;
        private System.Windows.Forms.TextBox nombreInsTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox idContactoTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInstitutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource institutosBindingSource1;
    }
}