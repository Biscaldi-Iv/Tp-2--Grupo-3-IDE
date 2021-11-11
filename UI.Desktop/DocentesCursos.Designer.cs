
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
            this.dgvDocentesCursos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsDocentesCursos = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.tscDocentesCursos.ContentPanel.SuspendLayout();
            this.tscDocentesCursos.TopToolStripPanel.SuspendLayout();
            this.tscDocentesCursos.SuspendLayout();
            this.tlDocentesCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).BeginInit();
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
            this.tlDocentesCursos.Controls.Add(this.dgvDocentesCursos, 0, 1);
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
            // dgvDocentesCursos
            // 
            this.dgvDocentesCursos.AllowUserToAddRows = false;
            this.dgvDocentesCursos.AllowUserToDeleteRows = false;
            this.dgvDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlDocentesCursos.SetColumnSpan(this.dgvDocentesCursos, 3);
            this.dgvDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentesCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvDocentesCursos.MultiSelect = false;
            this.dgvDocentesCursos.Name = "dgvDocentesCursos";
            this.dgvDocentesCursos.ReadOnly = true;
            this.dgvDocentesCursos.RowTemplate.Height = 25;
            this.dgvDocentesCursos.Size = new System.Drawing.Size(794, 390);
            this.dgvDocentesCursos.TabIndex = 2;
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
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsDocentesCursos
            // 
            this.tsDocentesCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocentesCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar});
            this.tsDocentesCursos.Location = new System.Drawing.Point(3, 0);
            this.tsDocentesCursos.Name = "tsDocentesCursos";
            this.tsDocentesCursos.Size = new System.Drawing.Size(66, 25);
            this.tsDocentesCursos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::UI.Desktop.Properties.Resources.png_clipart_plus_and_minus_signs_computer_icons_symbol_symbol_miscellaneous_logo;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agrear";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).EndInit();
            this.tsDocentesCursos.ResumeLayout(false);
            this.tsDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDocentesCursos;
        private System.Windows.Forms.TableLayoutPanel tlDocentesCursos;
        private System.Windows.Forms.DataGridView dgvDocentesCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsDocentesCursos;
        private System.Windows.Forms.ToolStripButton btnAgregar;
    }
}