namespace crudEvidencia
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasYRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarHorarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asociarCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alcaldiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lugaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasYRolesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.alcaldiaToolStripMenuItem,
            this.estadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasYRolesToolStripMenuItem
            // 
            this.personasYRolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.asignarRolToolStripMenuItem,
            this.crearBarrioToolStripMenuItem,
            this.lugaresToolStripMenuItem});
            this.personasYRolesToolStripMenuItem.Name = "personasYRolesToolStripMenuItem";
            this.personasYRolesToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.personasYRolesToolStripMenuItem.Text = "Personas y Roles";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // asignarRolToolStripMenuItem
            // 
            this.asignarRolToolStripMenuItem.Name = "asignarRolToolStripMenuItem";
            this.asignarRolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignarRolToolStripMenuItem.Text = "Asignar Rol";
            // 
            // crearBarrioToolStripMenuItem
            // 
            this.crearBarrioToolStripMenuItem.Name = "crearBarrioToolStripMenuItem";
            this.crearBarrioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearBarrioToolStripMenuItem.Text = "Crear Barrio";
            this.crearBarrioToolStripMenuItem.Click += new System.EventHandler(this.crearBarrioToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosToolStripMenuItem1,
            this.asistenciaToolStripMenuItem,
            this.horarioToolStripMenuItem,
            this.asignarHorarioToolStripMenuItem,
            this.asociarCursoToolStripMenuItem});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.cursosToolStripMenuItem.Text = "Cursos y asistencia";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            // 
            // horarioToolStripMenuItem
            // 
            this.horarioToolStripMenuItem.Name = "horarioToolStripMenuItem";
            this.horarioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.horarioToolStripMenuItem.Text = "Horario";
            this.horarioToolStripMenuItem.Click += new System.EventHandler(this.horarioToolStripMenuItem_Click);
            // 
            // asignarHorarioToolStripMenuItem
            // 
            this.asignarHorarioToolStripMenuItem.Name = "asignarHorarioToolStripMenuItem";
            this.asignarHorarioToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.asignarHorarioToolStripMenuItem.Text = "Asignar Horario";
            // 
            // asociarCursoToolStripMenuItem
            // 
            this.asociarCursoToolStripMenuItem.Name = "asociarCursoToolStripMenuItem";
            this.asociarCursoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.asociarCursoToolStripMenuItem.Text = "Asociar Curso";
            // 
            // alcaldiaToolStripMenuItem
            // 
            this.alcaldiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secretariasToolStripMenuItem,
            this.institutosToolStripMenuItem,
            this.inscritosToolStripMenuItem});
            this.alcaldiaToolStripMenuItem.Name = "alcaldiaToolStripMenuItem";
            this.alcaldiaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.alcaldiaToolStripMenuItem.Text = "Alcaldia";
            // 
            // secretariasToolStripMenuItem
            // 
            this.secretariasToolStripMenuItem.Name = "secretariasToolStripMenuItem";
            this.secretariasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.secretariasToolStripMenuItem.Text = "Secretarias";
            // 
            // institutosToolStripMenuItem
            // 
            this.institutosToolStripMenuItem.Name = "institutosToolStripMenuItem";
            this.institutosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.institutosToolStripMenuItem.Text = "Institutos";
            // 
            // inscritosToolStripMenuItem
            // 
            this.inscritosToolStripMenuItem.Name = "inscritosToolStripMenuItem";
            this.inscritosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inscritosToolStripMenuItem.Text = "Inscritos";
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudesToolStripMenuItem});
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.estadoToolStripMenuItem.Text = "Estado";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            this.solicitudesToolStripMenuItem.Click += new System.EventHandler(this.solicitudesToolStripMenuItem_Click);
            // 
            // lugaresToolStripMenuItem
            // 
            this.lugaresToolStripMenuItem.Name = "lugaresToolStripMenuItem";
            this.lugaresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lugaresToolStripMenuItem.Text = "Lugares";
            this.lugaresToolStripMenuItem.Click += new System.EventHandler(this.lugaresToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 398);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "Evidencia Clase .net";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasYRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarHorarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asociarCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alcaldiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lugaresToolStripMenuItem;
    }
}