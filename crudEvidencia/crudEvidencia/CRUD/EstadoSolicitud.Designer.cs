namespace crudEvidencia.CRUD
{
    partial class EstadoSolicitud
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
            System.Windows.Forms.Label idEstadoSolicitudLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label descripcionLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.estadoSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSolicitudTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.EstadoSolicitudTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.estadoSolicitudDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoSolicitudTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            idEstadoSolicitudLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSolicitudDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idEstadoSolicitudLabel
            // 
            idEstadoSolicitudLabel.AutoSize = true;
            idEstadoSolicitudLabel.Location = new System.Drawing.Point(31, 98);
            idEstadoSolicitudLabel.Name = "idEstadoSolicitudLabel";
            idEstadoSolicitudLabel.Size = new System.Drawing.Size(97, 13);
            idEstadoSolicitudLabel.TabIndex = 2;
            idEstadoSolicitudLabel.Text = "id Estado Solicitud:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(31, 124);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "Estado:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(31, 150);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 6;
            descripcionLabel.Text = "Descripcion:";
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoSolicitudBindingSource
            // 
            this.estadoSolicitudBindingSource.DataMember = "EstadoSolicitud";
            this.estadoSolicitudBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // estadoSolicitudTableAdapter
            // 
            this.estadoSolicitudTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarriosTableAdapter = null;
            this.tableAdapterManager.CursosAsociadosTableAdapter = null;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.EstadoSolicitudTableAdapter = this.estadoSolicitudTableAdapter;
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
            // estadoSolicitudDataGridView
            // 
            this.estadoSolicitudDataGridView.AutoGenerateColumns = false;
            this.estadoSolicitudDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estadoSolicitudDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.estadoSolicitudDataGridView.DataSource = this.estadoSolicitudBindingSource;
            this.estadoSolicitudDataGridView.Location = new System.Drawing.Point(344, 12);
            this.estadoSolicitudDataGridView.Name = "estadoSolicitudDataGridView";
            this.estadoSolicitudDataGridView.Size = new System.Drawing.Size(488, 412);
            this.estadoSolicitudDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEstadoSolicitud";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEstadoSolicitud";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idEstadoSolicitudTextBox
            // 
            this.idEstadoSolicitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoSolicitudBindingSource, "idEstadoSolicitud", true));
            this.idEstadoSolicitudTextBox.Location = new System.Drawing.Point(134, 95);
            this.idEstadoSolicitudTextBox.Name = "idEstadoSolicitudTextBox";
            this.idEstadoSolicitudTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEstadoSolicitudTextBox.TabIndex = 3;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoSolicitudBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(134, 121);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estadoSolicitudBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(134, 147);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(45, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 37);
            this.button3.TabIndex = 11;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(45, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(45, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idEstadoSolicitudTextBox);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.estadoTextBox);
            this.groupBox1.Controls.Add(idEstadoSolicitudLabel);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 278);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // EstadoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.estadoSolicitudDataGridView);
            this.Name = "EstadoSolicitud";
            this.Text = "EstadoSolicitud";
            this.Load += new System.EventHandler(this.EstadoSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSolicitudDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource estadoSolicitudBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.EstadoSolicitudTableAdapter estadoSolicitudTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView estadoSolicitudDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idEstadoSolicitudTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}