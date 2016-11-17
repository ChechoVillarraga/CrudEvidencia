namespace crudEvidencia
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TBcontrasenia = new System.Windows.Forms.TextBox();
            this.TBdocIdentidad = new System.Windows.Forms.TextBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LLcrearCuenta = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBrol = new System.Windows.Forms.ComboBox();
            this.rolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicioAlcaldiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ejercicioAlcaldiaDataSet = new crudEvidencia.EjercicioAlcaldiaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.rolTableAdapter = new crudEvidencia.EjercicioAlcaldiaDataSetTableAdapters.RolTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TBcontrasenia
            // 
            this.TBcontrasenia.Location = new System.Drawing.Point(299, 189);
            this.TBcontrasenia.Name = "TBcontrasenia";
            this.TBcontrasenia.Size = new System.Drawing.Size(204, 20);
            this.TBcontrasenia.TabIndex = 1;
            // 
            // TBdocIdentidad
            // 
            this.TBdocIdentidad.Location = new System.Drawing.Point(299, 141);
            this.TBdocIdentidad.Name = "TBdocIdentidad";
            this.TBdocIdentidad.Size = new System.Drawing.Size(204, 20);
            this.TBdocIdentidad.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(365, 392);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnIngresar.ForeColor = System.Drawing.Color.Black;
            this.BtnIngresar.Location = new System.Drawing.Point(295, 264);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(208, 41);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "¿No tienes cuenta?";
            // 
            // LLcrearCuenta
            // 
            this.LLcrearCuenta.AutoSize = true;
            this.LLcrearCuenta.LinkColor = System.Drawing.Color.DarkGreen;
            this.LLcrearCuenta.Location = new System.Drawing.Point(397, 311);
            this.LLcrearCuenta.Name = "LLcrearCuenta";
            this.LLcrearCuenta.Size = new System.Drawing.Size(69, 13);
            this.LLcrearCuenta.TabIndex = 5;
            this.LLcrearCuenta.TabStop = true;
            this.LLcrearCuenta.Text = "Crear Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Documento Identidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña:";
            // 
            // CBrol
            // 
            this.CBrol.DataSource = this.rolBindingSource;
            this.CBrol.DisplayMember = "Rol";
            this.CBrol.FormattingEnabled = true;
            this.CBrol.Location = new System.Drawing.Point(299, 237);
            this.CBrol.Name = "CBrol";
            this.CBrol.Size = new System.Drawing.Size(204, 21);
            this.CBrol.TabIndex = 2;
            this.CBrol.ValueMember = "idRol";
            // 
            // rolBindingSource
            // 
            this.rolBindingSource.DataMember = "Rol";
            this.rolBindingSource.DataSource = this.ejercicioAlcaldiaDataSetBindingSource;
            // 
            // ejercicioAlcaldiaDataSetBindingSource
            // 
            this.ejercicioAlcaldiaDataSetBindingSource.DataSource = this.ejercicioAlcaldiaDataSet;
            this.ejercicioAlcaldiaDataSetBindingSource.Position = 0;
            // 
            // ejercicioAlcaldiaDataSet
            // 
            this.ejercicioAlcaldiaDataSet.DataSetName = "EjercicioAlcaldiaDataSet";
            this.ejercicioAlcaldiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rol:";
            // 
            // rolTableAdapter
            // 
            this.rolTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::crudEvidencia.Properties.Resources.html5_css_login_forms1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 475);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LLcrearCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TBdocIdentidad);
            this.Controls.Add(this.TBcontrasenia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ejercicioAlcaldiaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBcontrasenia;
        private System.Windows.Forms.TextBox TBdocIdentidad;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LLcrearCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ejercicioAlcaldiaDataSetBindingSource;
        private EjercicioAlcaldiaDataSet ejercicioAlcaldiaDataSet;
        private System.Windows.Forms.BindingSource rolBindingSource;
        private EjercicioAlcaldiaDataSetTableAdapters.RolTableAdapter rolTableAdapter;
    }
}

