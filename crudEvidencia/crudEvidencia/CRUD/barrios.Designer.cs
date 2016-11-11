namespace crudEvidencia.CRUD
{
    partial class barrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barrios));
            System.Windows.Forms.Label idBarriosLabel;
            System.Windows.Forms.Label barrioLabel;
            System.Windows.Forms.Label limitesLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.barriosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barriosTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.BarriosTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.barriosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.barriosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idBarriosTextBox = new System.Windows.Forms.TextBox();
            this.barrioTextBox = new System.Windows.Forms.TextBox();
            this.limitesTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barriosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idBarriosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idBarriosLabel = new System.Windows.Forms.Label();
            barrioLabel = new System.Windows.Forms.Label();
            limitesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingNavigator)).BeginInit();
            this.barriosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barriosBindingSource
            // 
            this.barriosBindingSource.DataMember = "Barrios";
            this.barriosBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // barriosTableAdapter
            // 
            this.barriosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarriosTableAdapter = this.barriosTableAdapter;
            this.tableAdapterManager.CursosAsociadosTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.EstadoSolicitudTableAdapter = null;
            this.tableAdapterManager.HorarioIntermediaTableAdapter = null;
            this.tableAdapterManager.HorarioTableAdapter = null;
            this.tableAdapterManager.InscritosTableAdapter = null;
            this.tableAdapterManager.InstitutosTableAdapter = null;
            this.tableAdapterManager.PersonasTableAdapter = null;
            this.tableAdapterManager.RolPersonasTableAdapter = null;
            this.tableAdapterManager.RolTableAdapter = null;
            this.tableAdapterManager.SecretariasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barriosBindingNavigator
            // 
            this.barriosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.barriosBindingNavigator.BindingSource = this.barriosBindingSource;
            this.barriosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.barriosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.barriosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.barriosBindingNavigatorSaveItem});
            this.barriosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.barriosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.barriosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.barriosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.barriosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.barriosBindingNavigator.Name = "barriosBindingNavigator";
            this.barriosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.barriosBindingNavigator.Size = new System.Drawing.Size(704, 25);
            this.barriosBindingNavigator.TabIndex = 0;
            this.barriosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // barriosBindingNavigatorSaveItem
            // 
            this.barriosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barriosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("barriosBindingNavigatorSaveItem.Image")));
            this.barriosBindingNavigatorSaveItem.Name = "barriosBindingNavigatorSaveItem";
            this.barriosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.barriosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.barriosBindingNavigatorSaveItem.Click += new System.EventHandler(this.barriosBindingNavigatorSaveItem_Click);
            // 
            // idBarriosLabel
            // 
            idBarriosLabel.AutoSize = true;
            idBarriosLabel.Location = new System.Drawing.Point(68, 84);
            idBarriosLabel.Name = "idBarriosLabel";
            idBarriosLabel.Size = new System.Drawing.Size(53, 13);
            idBarriosLabel.TabIndex = 1;
            idBarriosLabel.Text = "id Barrios:";
            // 
            // idBarriosTextBox
            // 
            this.idBarriosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barriosBindingSource, "idBarrios", true));
            this.idBarriosTextBox.Location = new System.Drawing.Point(197, 77);
            this.idBarriosTextBox.Name = "idBarriosTextBox";
            this.idBarriosTextBox.Size = new System.Drawing.Size(100, 20);
            this.idBarriosTextBox.TabIndex = 2;
            // 
            // barrioLabel
            // 
            barrioLabel.AutoSize = true;
            barrioLabel.Location = new System.Drawing.Point(68, 140);
            barrioLabel.Name = "barrioLabel";
            barrioLabel.Size = new System.Drawing.Size(37, 13);
            barrioLabel.TabIndex = 3;
            barrioLabel.Text = "Barrio:";
            // 
            // barrioTextBox
            // 
            this.barrioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barriosBindingSource, "Barrio", true));
            this.barrioTextBox.Location = new System.Drawing.Point(197, 133);
            this.barrioTextBox.Name = "barrioTextBox";
            this.barrioTextBox.Size = new System.Drawing.Size(100, 20);
            this.barrioTextBox.TabIndex = 4;
            // 
            // limitesLabel
            // 
            limitesLabel.AutoSize = true;
            limitesLabel.Location = new System.Drawing.Point(68, 212);
            limitesLabel.Name = "limitesLabel";
            limitesLabel.Size = new System.Drawing.Size(42, 13);
            limitesLabel.TabIndex = 5;
            limitesLabel.Text = "Limites:";
            // 
            // limitesTextBox
            // 
            this.limitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barriosBindingSource, "Limites", true));
            this.limitesTextBox.Location = new System.Drawing.Point(197, 205);
            this.limitesTextBox.Name = "limitesTextBox";
            this.limitesTextBox.Size = new System.Drawing.Size(100, 20);
            this.limitesTextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBarriosDataGridViewTextBoxColumn,
            this.barrioDataGridViewTextBoxColumn,
            this.limitesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.barriosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(338, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(354, 270);
            this.dataGridView1.TabIndex = 7;
            // 
            // barriosBindingSource1
            // 
            this.barriosBindingSource1.DataMember = "Barrios";
            this.barriosBindingSource1.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // idBarriosDataGridViewTextBoxColumn
            // 
            this.idBarriosDataGridViewTextBoxColumn.DataPropertyName = "idBarrios";
            this.idBarriosDataGridViewTextBoxColumn.HeaderText = "idBarrios";
            this.idBarriosDataGridViewTextBoxColumn.Name = "idBarriosDataGridViewTextBoxColumn";
            // 
            // barrioDataGridViewTextBoxColumn
            // 
            this.barrioDataGridViewTextBoxColumn.DataPropertyName = "Barrio";
            this.barrioDataGridViewTextBoxColumn.HeaderText = "Barrio";
            this.barrioDataGridViewTextBoxColumn.Name = "barrioDataGridViewTextBoxColumn";
            // 
            // limitesDataGridViewTextBoxColumn
            // 
            this.limitesDataGridViewTextBoxColumn.DataPropertyName = "Limites";
            this.limitesDataGridViewTextBoxColumn.HeaderText = "Limites";
            this.limitesDataGridViewTextBoxColumn.Name = "limitesDataGridViewTextBoxColumn";
            // 
            // barrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 402);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(limitesLabel);
            this.Controls.Add(this.limitesTextBox);
            this.Controls.Add(barrioLabel);
            this.Controls.Add(this.barrioTextBox);
            this.Controls.Add(idBarriosLabel);
            this.Controls.Add(this.idBarriosTextBox);
            this.Controls.Add(this.barriosBindingNavigator);
            this.Name = "barrios";
            this.Text = "barrios";
            this.Load += new System.EventHandler(this.barrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingNavigator)).EndInit();
            this.barriosBindingNavigator.ResumeLayout(false);
            this.barriosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barriosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource barriosBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.BarriosTableAdapter barriosTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator barriosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton barriosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idBarriosTextBox;
        private System.Windows.Forms.TextBox barrioTextBox;
        private System.Windows.Forms.TextBox limitesTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBarriosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource barriosBindingSource1;
    }
}