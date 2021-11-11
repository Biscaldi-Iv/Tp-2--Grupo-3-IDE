
namespace UI.Desktop
{
    partial class DocentesCursosForm
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
            this.tlDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.cBoxPlan = new System.Windows.Forms.ComboBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxCurso = new System.Windows.Forms.ComboBox();
            this.cBoxDocente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbTipoCargo = new System.Windows.Forms.Label();
            this.cbTipoCargo = new System.Windows.Forms.ComboBox();
            this.tlDocentesCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlDocentesCursos
            // 
            this.tlDocentesCursos.ColumnCount = 3;
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocentesCursos.Controls.Add(this.cBoxPlan, 1, 0);
            this.tlDocentesCursos.Controls.Add(this.lblPlan, 0, 0);
            this.tlDocentesCursos.Controls.Add(this.label2, 0, 1);
            this.tlDocentesCursos.Controls.Add(this.cBoxCurso, 1, 1);
            this.tlDocentesCursos.Controls.Add(this.cBoxDocente, 1, 2);
            this.tlDocentesCursos.Controls.Add(this.label1, 0, 2);
            this.tlDocentesCursos.Controls.Add(this.btnCancelar, 1, 4);
            this.tlDocentesCursos.Controls.Add(this.btnRegistrar, 2, 4);
            this.tlDocentesCursos.Controls.Add(this.lbTipoCargo, 0, 3);
            this.tlDocentesCursos.Controls.Add(this.cbTipoCargo, 1, 3);
            this.tlDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlDocentesCursos.Name = "tlDocentesCursos";
            this.tlDocentesCursos.RowCount = 5;
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentesCursos.Size = new System.Drawing.Size(432, 319);
            this.tlDocentesCursos.TabIndex = 0;
            // 
            // cBoxPlan
            // 
            this.cBoxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxPlan, 2);
            this.cBoxPlan.DisplayMember = "Descripcion";
            this.cBoxPlan.FormattingEnabled = true;
            this.cBoxPlan.Location = new System.Drawing.Point(73, 24);
            this.cBoxPlan.Name = "cBoxPlan";
            this.cBoxPlan.Size = new System.Drawing.Size(356, 23);
            this.cBoxPlan.TabIndex = 0;
            this.cBoxPlan.ValueMember = "ID";
            this.cBoxPlan.SelectedIndexChanged += new System.EventHandler(this.cBoxPlan_SelectedIndexChanged);
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(37, 28);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(30, 15);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Plan";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // cBoxCurso
            // 
            this.cBoxCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxCurso, 2);
            this.cBoxCurso.DisplayMember = "Descripcion";
            this.cBoxCurso.FormattingEnabled = true;
            this.cBoxCurso.Location = new System.Drawing.Point(73, 96);
            this.cBoxCurso.Name = "cBoxCurso";
            this.cBoxCurso.Size = new System.Drawing.Size(356, 23);
            this.cBoxCurso.TabIndex = 3;
            this.cBoxCurso.ValueMember = "ID";
            // 
            // cBoxDocente
            // 
            this.cBoxDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxDocente, 2);
            this.cBoxDocente.DisplayMember = "Apellido";
            this.cBoxDocente.FormattingEnabled = true;
            this.cBoxDocente.Location = new System.Drawing.Point(73, 168);
            this.cBoxDocente.Name = "cBoxDocente";
            this.cBoxDocente.Size = new System.Drawing.Size(356, 23);
            this.cBoxDocente.TabIndex = 4;
            this.cBoxDocente.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Docente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(272, 293);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.Location = new System.Drawing.Point(354, 293);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbTipoCargo
            // 
            this.lbTipoCargo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbTipoCargo.AutoSize = true;
            this.lbTipoCargo.Location = new System.Drawing.Point(28, 244);
            this.lbTipoCargo.Name = "lbTipoCargo";
            this.lbTipoCargo.Size = new System.Drawing.Size(39, 15);
            this.lbTipoCargo.TabIndex = 8;
            this.lbTipoCargo.Text = "Cargo";
            // 
            // cbTipoCargo
            // 
            this.cbTipoCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cbTipoCargo, 2);
            this.cbTipoCargo.DisplayMember = "TipoCargo";
            this.cbTipoCargo.FormattingEnabled = true;
            this.cbTipoCargo.Location = new System.Drawing.Point(73, 240);
            this.cbTipoCargo.Name = "cbTipoCargo";
            this.cbTipoCargo.Size = new System.Drawing.Size(356, 23);
            this.cbTipoCargo.TabIndex = 9;
            this.cbTipoCargo.ValueMember = "ID";
            // 
            // DocentesCursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 319);
            this.Controls.Add(this.tlDocentesCursos);
            this.Name = "DocentesCursosForm";
            this.Text = "DocentesCursosForm";
            this.tlDocentesCursos.ResumeLayout(false);
            this.tlDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlDocentesCursos;
        private System.Windows.Forms.ComboBox cBoxPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxCurso;
        private System.Windows.Forms.ComboBox cBoxDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lbTipoCargo;
        private System.Windows.Forms.ComboBox cbTipoCargo;
    }
}