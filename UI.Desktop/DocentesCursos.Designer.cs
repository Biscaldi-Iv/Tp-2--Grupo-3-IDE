
namespace UI.Desktop
{
    partial class DocentesCursos
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
            this.tscDocentesCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPlan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsDocentesCursos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.IDCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscDocentesCursos.ContentPanel.SuspendLayout();
            this.tscDocentesCursos.TopToolStripPanel.SuspendLayout();
            this.tscDocentesCursos.SuspendLayout();
            this.tlDocentesCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsDocentesCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscDocentesCursos
            // 
            // 
            // tscDocentesCursos.ContentPanel
            // 
            this.tscDocentesCursos.ContentPanel.Controls.Add(this.tlDocentesCursos);
            this.tscDocentesCursos.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tscDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tscDocentesCursos.Name = "tscDocentesCursos";
            this.tscDocentesCursos.Size = new System.Drawing.Size(800, 450);
            this.tscDocentesCursos.TabIndex = 0;
            this.tscDocentesCursos.Text = "toolStripContainer1";
            // 
            // tscDocentesCursos.TopToolStripPanel
            // 
            this.tscDocentesCursos.TopToolStripPanel.Controls.Add(this.tsDocentesCursos);
            // 
            // tlDocentesCursos
            // 
            this.tlDocentesCursos.ColumnCount = 3;
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocentesCursos.Controls.Add(this.label1, 0, 0);
            this.tlDocentesCursos.Controls.Add(this.cBoxPlan, 1, 0);
            this.tlDocentesCursos.Controls.Add(this.dataGridView1, 0, 1);
            this.tlDocentesCursos.Controls.Add(this.btnActualizar, 2, 2);
            this.tlDocentesCursos.Controls.Add(this.btnSalir, 1, 2);
            this.tlDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlDocentesCursos.Name = "tlDocentesCursos";
            this.tlDocentesCursos.RowCount = 3;
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentesCursos.Size = new System.Drawing.Size(800, 425);
            this.tlDocentesCursos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan";
            // 
            // cBoxPlan
            // 
            this.cBoxPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxPlan.FormattingEnabled = true;
            this.cBoxPlan.Location = new System.Drawing.Point(39, 3);
            this.cBoxPlan.Name = "cBoxPlan";
            this.cBoxPlan.Size = new System.Drawing.Size(233, 23);
            this.cBoxPlan.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCurso,
            this.Curso,
            this.IDDocente,
            this.NombreDocente,
            this.ApellidoDocente,
            this.Cargo,
            this.IDDictado});
            this.tlDocentesCursos.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(794, 361);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(722, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(641, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tsDocentesCursos
            // 
            this.tsDocentesCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocentesCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsDocentesCursos.Location = new System.Drawing.Point(3, 0);
            this.tsDocentesCursos.Name = "tsDocentesCursos";
            this.tsDocentesCursos.Size = new System.Drawing.Size(81, 25);
            this.tsDocentesCursos.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UI.Desktop.Properties.Resources.png_clipart_plus_and_minus_signs_computer_icons_symbol_symbol_miscellaneous_logo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::UI.Desktop.Properties.Resources._45406;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::UI.Desktop.Properties.Resources.png_transparent_computer_icons_delete_icon_white_text_logo;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // IDCurso
            // 
            this.IDCurso.HeaderText = "ID Curso";
            this.IDCurso.Name = "IDCurso";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // IDDocente
            // 
            this.IDDocente.HeaderText = "ID Docente";
            this.IDDocente.Name = "IDDocente";
            // 
            // NombreDocente
            // 
            this.NombreDocente.HeaderText = "Nombre del Docente";
            this.NombreDocente.Name = "NombreDocente";
            // 
            // ApellidoDocente
            // 
            this.ApellidoDocente.HeaderText = "Apellido del Docente";
            this.ApellidoDocente.Name = "ApellidoDocente";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            // 
            // IDDictado
            // 
            this.IDDictado.HeaderText = "Dictado";
            this.IDDictado.Name = "IDDictado";
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscDocentesCursos);
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.tscDocentesCursos.ContentPanel.ResumeLayout(false);
            this.tscDocentesCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscDocentesCursos.TopToolStripPanel.PerformLayout();
            this.tscDocentesCursos.ResumeLayout(false);
            this.tscDocentesCursos.PerformLayout();
            this.tlDocentesCursos.ResumeLayout(false);
            this.tlDocentesCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsDocentesCursos.ResumeLayout(false);
            this.tsDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDocentesCursos;
        private System.Windows.Forms.TableLayoutPanel tlDocentesCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPlan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsDocentesCursos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDictado;
    }
}