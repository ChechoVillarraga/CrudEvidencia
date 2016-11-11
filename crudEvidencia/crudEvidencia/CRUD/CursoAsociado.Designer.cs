namespace crudEvidencia.CRUD
{
    partial class CursoAsociado
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
            System.Windows.Forms.Label idSecretariaLabel;
            System.Windows.Forms.Label idCursoLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.cursosAsociadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosAsociadosTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.CursosAsociadosTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.cursosAsociadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSecretariaTextBox = new System.Windows.Forms.TextBox();
            this.idCursoTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            idSecretariaLabel = new System.Windows.Forms.Label();
            idCursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosAsociadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosAsociadosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosAsociadosBindingSource
            // 
            this.cursosAsociadosBindingSource.DataMember = "CursosAsociados";
            this.cursosAsociadosBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // cursosAsociadosTableAdapter
            // 
            this.cursosAsociadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AsistenciaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BarriosTableAdapter = null;
            this.tableAdapterManager.CursosAsociadosTableAdapter = this.cursosAsociadosTableAdapter;
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
            // cursosAsociadosDataGridView
            // 
            this.cursosAsociadosDataGridView.AutoGenerateColumns = false;
            this.cursosAsociadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cursosAsociadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.cursosAsociadosDataGridView.DataSource = this.cursosAsociadosBindingSource;
            this.cursosAsociadosDataGridView.Location = new System.Drawing.Point(345, 12);
            this.cursosAsociadosDataGridView.Name = "cursosAsociadosDataGridView";
            this.cursosAsociadosDataGridView.Size = new System.Drawing.Size(441, 411);
            this.cursosAsociadosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idSecretaria";
            this.dataGridViewTextBoxColumn1.HeaderText = "idSecretaria";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCurso";
            this.dataGridViewTextBoxColumn2.HeaderText = "idCurso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // idSecretariaLabel
            // 
            idSecretariaLabel.AutoSize = true;
            idSecretariaLabel.Location = new System.Drawing.Point(65, 111);
            idSecretariaLabel.Name = "idSecretariaLabel";
            idSecretariaLabel.Size = new System.Drawing.Size(69, 13);
            idSecretariaLabel.TabIndex = 2;
            idSecretariaLabel.Text = "id Secretaria:";
            // 
            // idSecretariaTextBox
            // 
            this.idSecretariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosAsociadosBindingSource, "idSecretaria", true));
            this.idSecretariaTextBox.Location = new System.Drawing.Point(140, 108);
            this.idSecretariaTextBox.Name = "idSecretariaTextBox";
            this.idSecretariaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idSecretariaTextBox.TabIndex = 3;
            // 
            // idCursoLabel
            // 
            idCursoLabel.AutoSize = true;
            idCursoLabel.Location = new System.Drawing.Point(65, 137);
            idCursoLabel.Name = "idCursoLabel";
            idCursoLabel.Size = new System.Drawing.Size(48, 13);
            idCursoLabel.TabIndex = 4;
            idCursoLabel.Text = "id Curso:";
            // 
            // idCursoTextBox
            // 
            this.idCursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosAsociadosBindingSource, "idCurso", true));
            this.idCursoTextBox.Location = new System.Drawing.Point(140, 134);
            this.idCursoTextBox.Name = "idCursoTextBox";
            this.idCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idCursoTextBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(46, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(46, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idSecretariaTextBox);
            this.groupBox1.Controls.Add(this.idCursoTextBox);
            this.groupBox1.Controls.Add(idCursoLabel);
            this.groupBox1.Controls.Add(idSecretariaLabel);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 278);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // CursoAsociado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 455);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cursosAsociadosDataGridView);
            this.Name = "CursoAsociado";
            this.Text = "CursoAsociado";
            this.Load += new System.EventHandler(this.CursoAsociado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosAsociadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosAsociadosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource cursosAsociadosBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.CursosAsociadosTableAdapter cursosAsociadosTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cursosAsociadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox idSecretariaTextBox;
        private System.Windows.Forms.TextBox idCursoTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}