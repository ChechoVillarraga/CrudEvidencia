namespace crudEvidencia.CRUD
{
    partial class asistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textidAsistencia = new System.Windows.Forms.TextBox();
            this.textNCurso = new System.Windows.Forms.TextBox();
            this.textNpersonas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.asistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asistenciaTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.AsistenciaTableAdapter();
            this.idAsistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAsistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asistioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSolicitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumeroAsistencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asistio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NumeroCurso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NumeroPersona";
            // 
            // textidAsistencia
            // 
            this.textidAsistencia.Location = new System.Drawing.Point(272, 68);
            this.textidAsistencia.Name = "textidAsistencia";
            this.textidAsistencia.Size = new System.Drawing.Size(100, 20);
            this.textidAsistencia.TabIndex = 4;
            // 
            // textNCurso
            // 
            this.textNCurso.Location = new System.Drawing.Point(272, 153);
            this.textNCurso.Name = "textNCurso";
            this.textNCurso.Size = new System.Drawing.Size(100, 20);
            this.textNCurso.TabIndex = 6;
            // 
            // textNpersonas
            // 
            this.textNpersonas.Location = new System.Drawing.Point(272, 110);
            this.textNpersonas.Name = "textNpersonas";
            this.textNpersonas.Size = new System.Drawing.Size(100, 20);
            this.textNpersonas.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(272, 235);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(33, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(392, 234);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "No";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(77, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(77, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(271, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Actualizar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(77, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 37);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsistenciaDataGridViewTextBoxColumn,
            this.idPersonaDataGridViewTextBoxColumn,
            this.idCursoDataGridViewTextBoxColumn,
            this.fechaAsistenciaDataGridViewTextBoxColumn,
            this.asistioDataGridViewTextBoxColumn,
            this.estadoSolicitudDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asistenciaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(416, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asistenciaBindingSource
            // 
            this.asistenciaBindingSource.DataMember = "Asistencia";
            this.asistenciaBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            // 
            // asistenciaTableAdapter
            // 
            this.asistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // idAsistenciaDataGridViewTextBoxColumn
            // 
            this.idAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "idAsistencia";
            this.idAsistenciaDataGridViewTextBoxColumn.HeaderText = "idAsistencia";
            this.idAsistenciaDataGridViewTextBoxColumn.Name = "idAsistenciaDataGridViewTextBoxColumn";
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona";
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            // 
            // idCursoDataGridViewTextBoxColumn
            // 
            this.idCursoDataGridViewTextBoxColumn.DataPropertyName = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.HeaderText = "idCurso";
            this.idCursoDataGridViewTextBoxColumn.Name = "idCursoDataGridViewTextBoxColumn";
            // 
            // fechaAsistenciaDataGridViewTextBoxColumn
            // 
            this.fechaAsistenciaDataGridViewTextBoxColumn.DataPropertyName = "fechaAsistencia";
            this.fechaAsistenciaDataGridViewTextBoxColumn.HeaderText = "fechaAsistencia";
            this.fechaAsistenciaDataGridViewTextBoxColumn.Name = "fechaAsistenciaDataGridViewTextBoxColumn";
            // 
            // asistioDataGridViewTextBoxColumn
            // 
            this.asistioDataGridViewTextBoxColumn.DataPropertyName = "Asistio";
            this.asistioDataGridViewTextBoxColumn.HeaderText = "Asistio";
            this.asistioDataGridViewTextBoxColumn.Name = "asistioDataGridViewTextBoxColumn";
            // 
            // estadoSolicitudDataGridViewTextBoxColumn
            // 
            this.estadoSolicitudDataGridViewTextBoxColumn.DataPropertyName = "estadoSolicitud";
            this.estadoSolicitudDataGridViewTextBoxColumn.HeaderText = "estadoSolicitud";
            this.estadoSolicitudDataGridViewTextBoxColumn.Name = "estadoSolicitudDataGridViewTextBoxColumn";
            // 
            // asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 440);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNpersonas);
            this.Controls.Add(this.textNCurso);
            this.Controls.Add(this.textidAsistencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "asistencia";
            this.Text = "asistencia";
            this.Load += new System.EventHandler(this.asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textidAsistencia;
        private System.Windows.Forms.TextBox textNCurso;
        private System.Windows.Forms.TextBox textNpersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource asistenciaBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.AsistenciaTableAdapter asistenciaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAsistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asistioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSolicitudDataGridViewTextBoxColumn;
    }
}