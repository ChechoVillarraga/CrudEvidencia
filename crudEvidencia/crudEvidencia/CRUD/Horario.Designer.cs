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
            System.Windows.Forms.Label idHorarioLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label diaLabel;
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horarioTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.HorarioTableAdapter();
            this.tableAdapterManager = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager();
            this.horarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHorarioTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.diaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            idHorarioLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            diaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // horarioDataGridView
            // 
            this.horarioDataGridView.AutoGenerateColumns = false;
            this.horarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.horarioDataGridView.DataSource = this.horarioBindingSource;
            this.horarioDataGridView.Location = new System.Drawing.Point(344, 12);
            this.horarioDataGridView.Name = "horarioDataGridView";
            this.horarioDataGridView.Size = new System.Drawing.Size(625, 425);
            this.horarioDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idHorario";
            this.dataGridViewTextBoxColumn1.HeaderText = "idHorario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dia";
            this.dataGridViewTextBoxColumn3.HeaderText = "dia";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idHorarioLabel
            // 
            idHorarioLabel.AutoSize = true;
            idHorarioLabel.Location = new System.Drawing.Point(25, 108);
            idHorarioLabel.Name = "idHorarioLabel";
            idHorarioLabel.Size = new System.Drawing.Size(55, 13);
            idHorarioLabel.TabIndex = 1;
            idHorarioLabel.Text = "id Horario:";
            // 
            // idHorarioTextBox
            // 
            this.idHorarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horarioBindingSource, "idHorario", true));
            this.idHorarioTextBox.Location = new System.Drawing.Point(86, 105);
            this.idHorarioTextBox.Name = "idHorarioTextBox";
            this.idHorarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.idHorarioTextBox.TabIndex = 2;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Location = new System.Drawing.Point(25, 134);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(31, 13);
            horaLabel.TabIndex = 3;
            horaLabel.Text = "hora:";
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.horarioBindingSource, "hora", true));
            this.horaTextBox.Location = new System.Drawing.Point(86, 131);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaTextBox.TabIndex = 4;
            // 
            // diaLabel
            // 
            diaLabel.AutoSize = true;
            diaLabel.Location = new System.Drawing.Point(25, 161);
            diaLabel.Name = "diaLabel";
            diaLabel.Size = new System.Drawing.Size(24, 13);
            diaLabel.TabIndex = 5;
            diaLabel.Text = "dia:";
            // 
            // diaDateTimePicker
            // 
            this.diaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.horarioBindingSource, "dia", true));
            this.diaDateTimePicker.Location = new System.Drawing.Point(86, 157);
            this.diaDateTimePicker.Name = "diaDateTimePicker";
            this.diaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.diaDateTimePicker.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(45, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 37);
            this.button3.TabIndex = 10;
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
            this.button2.TabIndex = 9;
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
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idHorarioTextBox);
            this.groupBox1.Controls.Add(this.diaDateTimePicker);
            this.groupBox1.Controls.Add(diaLabel);
            this.groupBox1.Controls.Add(this.horaTextBox);
            this.groupBox1.Controls.Add(idHorarioLabel);
            this.groupBox1.Controls.Add(horaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 278);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(981, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.horarioDataGridView);
            this.MinimumSize = new System.Drawing.Size(997, 488);
            this.Name = "Horario";
            this.Text = "Horario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Horario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource horarioBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.HorarioTableAdapter horarioTableAdapter;
        private EjercicioAlcaldiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView horarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idHorarioTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.DateTimePicker diaDateTimePicker;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}