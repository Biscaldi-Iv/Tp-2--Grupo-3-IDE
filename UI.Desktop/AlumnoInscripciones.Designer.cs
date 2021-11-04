
namespace UI.Desktop
{
    partial class AlumnoInscripciones
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
            this.tcAlumnosInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tlpOrden = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvAlumnoIncripciones = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsAlumnosIncripciones = new System.Windows.Forms.ToolStrip();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcAlumnosInscripciones.ContentPanel.SuspendLayout();
            this.tcAlumnosInscripciones.TopToolStripPanel.SuspendLayout();
            this.tcAlumnosInscripciones.SuspendLayout();
            this.tlpOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoIncripciones)).BeginInit();
            this.tsAlumnosIncripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAlumnosInscripciones
            // 
            // 
            // tcAlumnosInscripciones.ContentPanel
            // 
            this.tcAlumnosInscripciones.ContentPanel.Controls.Add(this.tlpOrden);
            this.tcAlumnosInscripciones.ContentPanel.Size = new System.Drawing.Size(745, 426);
            this.tcAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlumnosInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tcAlumnosInscripciones.Name = "tcAlumnosInscripciones";
            this.tcAlumnosInscripciones.Size = new System.Drawing.Size(745, 451);
            this.tcAlumnosInscripciones.TabIndex = 0;
            this.tcAlumnosInscripciones.Text = "toolStripContainer1";
            // 
            // tcAlumnosInscripciones.TopToolStripPanel
            // 
            this.tcAlumnosInscripciones.TopToolStripPanel.Controls.Add(this.tsAlumnosIncripciones);
            // 
            // tlpOrden
            // 
            this.tlpOrden.ColumnCount = 3;
            this.tlpOrden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOrden.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOrden.Controls.Add(this.btnSalir, 2, 1);
            this.tlpOrden.Controls.Add(this.dgvAlumnoIncripciones, 0, 0);
            this.tlpOrden.Controls.Add(this.btnActualizar, 1, 1);
            this.tlpOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrden.Location = new System.Drawing.Point(0, 0);
            this.tlpOrden.Name = "tlpOrden";
            this.tlpOrden.RowCount = 2;
            this.tlpOrden.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOrden.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOrden.Size = new System.Drawing.Size(745, 426);
            this.tlpOrden.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(673, 401);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 22);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAlumnoIncripciones
            // 
            this.dgvAlumnoIncripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoIncripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Curso,
            this.Alumno,
            this.Condicion,
            this.Nota});
            this.tlpOrden.SetColumnSpan(this.dgvAlumnoIncripciones, 3);
            this.dgvAlumnoIncripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnoIncripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnoIncripciones.Name = "dgvAlumnoIncripciones";
            this.dgvAlumnoIncripciones.RowTemplate.Height = 25;
            this.dgvAlumnoIncripciones.Size = new System.Drawing.Size(739, 392);
            this.dgvAlumnoIncripciones.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 40;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 85;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 100;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Alumno
            // 
            this.Alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.MinimumWidth = 100;
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            // 
            // Condicion
            // 
            this.Condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Condicion.HeaderText = "Condicion";
            this.Condicion.MinimumWidth = 100;
            this.Condicion.Name = "Condicion";
            this.Condicion.ReadOnly = true;
            this.Condicion.Width = 130;
            // 
            // Nota
            // 
            this.Nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 45;
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Width = 85;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(599, 401);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(68, 22);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // tsAlumnosIncripciones
            // 
            this.tsAlumnosIncripciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlumnosIncripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditar,
            this.tsbEliminar});
            this.tsAlumnosIncripciones.Location = new System.Drawing.Point(3, 0);
            this.tsAlumnosIncripciones.Name = "tsAlumnosIncripciones";
            this.tsAlumnosIncripciones.Size = new System.Drawing.Size(58, 25);
            this.tsAlumnosIncripciones.TabIndex = 0;
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = global::UI.Desktop.Properties.Resources._45406;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = global::UI.Desktop.Properties.Resources.png_transparent_computer_icons_delete_icon_white_text_logo;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            // 
            // AlumnoInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 451);
            this.Controls.Add(this.tcAlumnosInscripciones);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 333);
            this.Name = "AlumnoInscripciones";
            this.Text = "AlumnoInscripciones";
            this.tcAlumnosInscripciones.ContentPanel.ResumeLayout(false);
            this.tcAlumnosInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnosInscripciones.TopToolStripPanel.PerformLayout();
            this.tcAlumnosInscripciones.ResumeLayout(false);
            this.tcAlumnosInscripciones.PerformLayout();
            this.tlpOrden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoIncripciones)).EndInit();
            this.tsAlumnosIncripciones.ResumeLayout(false);
            this.tsAlumnosIncripciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcAlumnosInscripciones;
        private System.Windows.Forms.TableLayoutPanel tlpOrden;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvAlumnoIncripciones;
        private System.Windows.Forms.ToolStrip tsAlumnosIncripciones;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}