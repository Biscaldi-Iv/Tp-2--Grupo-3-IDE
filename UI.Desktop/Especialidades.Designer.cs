
namespace UI.Desktop
{
    partial class Especialidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tscEspecialidades = new System.Windows.Forms.ToolStripContainer();
            this.tlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.Id_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsEspecialidades = new System.Windows.Forms.ToolStrip();
            this.toolStripEsp = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscEspecialidades.ContentPanel.SuspendLayout();
            this.tscEspecialidades.TopToolStripPanel.SuspendLayout();
            this.tscEspecialidades.SuspendLayout();
            this.tlEspecialidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.toolStripEsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de especialidades:";
            // 
            // tscEspecialidades
            // 
            // 
            // tscEspecialidades.ContentPanel
            // 
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tlEspecialidades);
            this.tscEspecialidades.ContentPanel.Controls.Add(this.tsEspecialidades);
            this.tscEspecialidades.ContentPanel.Size = new System.Drawing.Size(661, 451);
            this.tscEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tscEspecialidades.Name = "tscEspecialidades";
            this.tscEspecialidades.Size = new System.Drawing.Size(661, 476);
            this.tscEspecialidades.TabIndex = 3;
            this.tscEspecialidades.Text = "toolStripContainer1";
            // 
            // tscEspecialidades.TopToolStripPanel
            // 
            this.tscEspecialidades.TopToolStripPanel.Controls.Add(this.toolStripEsp);
            this.tscEspecialidades.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // tlEspecialidades
            // 
            this.tlEspecialidades.ColumnCount = 2;
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlEspecialidades.Controls.Add(this.btnActualizar, 0, 1);
            this.tlEspecialidades.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidades.Name = "tlEspecialidades";
            this.tlEspecialidades.RowCount = 2;
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidades.Size = new System.Drawing.Size(661, 451);
            this.tlEspecialidades.TabIndex = 1;
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AllowUserToResizeColumns = false;
            this.dgvEspecialidades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvEspecialidades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_especialidad,
            this.desc_especialidad});
            this.tlEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEspecialidades.RowTemplate.Height = 25;
            this.dgvEspecialidades.Size = new System.Drawing.Size(655, 416);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // Id_especialidad
            // 
            this.Id_especialidad.DataPropertyName = "ID";
            this.Id_especialidad.HeaderText = "Id";
            this.Id_especialidad.Name = "Id_especialidad";
            this.Id_especialidad.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            this.desc_especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.desc_especialidad.DataPropertyName = "Descripcion";
            this.desc_especialidad.HeaderText = "Especialidad";
            this.desc_especialidad.Name = "desc_especialidad";
            this.desc_especialidad.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(502, 425);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(583, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsEspecialidades
            // 
            this.tsEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.tsEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tsEspecialidades.Name = "tsEspecialidades";
            this.tsEspecialidades.Size = new System.Drawing.Size(111, 25);
            this.tsEspecialidades.TabIndex = 0;
            this.tsEspecialidades.Text = "toolStrip1";
            // 
            // toolStripEsp
            // 
            this.toolStripEsp.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEsp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.toolStripEsp.Location = new System.Drawing.Point(3, 0);
            this.toolStripEsp.Name = "toolStripEsp";
            this.toolStripEsp.Size = new System.Drawing.Size(81, 25);
            this.toolStripEsp.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = global::UI.Desktop.Properties.Resources.png_clipart_plus_and_minus_signs_computer_icons_symbol_symbol_miscellaneous_logo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            this.tsbEliminar.Text = "toolStripButton1";
            this.tsbEliminar.ToolTipText = "Eliminar";
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 476);
            this.Controls.Add(this.tscEspecialidades);
            this.Controls.Add(this.label1);
            this.Name = "Especialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.ListaEspecialidades_Load);
            this.tscEspecialidades.ContentPanel.ResumeLayout(false);
            this.tscEspecialidades.ContentPanel.PerformLayout();
            this.tscEspecialidades.TopToolStripPanel.ResumeLayout(false);
            this.tscEspecialidades.TopToolStripPanel.PerformLayout();
            this.tscEspecialidades.ResumeLayout(false);
            this.tscEspecialidades.PerformLayout();
            this.tlEspecialidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.toolStripEsp.ResumeLayout(false);
            this.toolStripEsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer tscEspecialidades;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidades;
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_especialidad;
        private System.Windows.Forms.ToolStrip toolStripEsp;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}