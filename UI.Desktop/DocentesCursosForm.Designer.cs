
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
            this.tlDocentesCursos.Controls.Add(this.btnCancelar, 1, 3);
            this.tlDocentesCursos.Controls.Add(this.btnRegistrar, 2, 3);
            this.tlDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlDocentesCursos.Name = "tlDocentesCursos";
            this.tlDocentesCursos.RowCount = 4;
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocentesCursos.Size = new System.Drawing.Size(432, 319);
            this.tlDocentesCursos.TabIndex = 0;
            // 
            // cBoxPlan
            // 
            this.cBoxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxPlan, 2);
            this.cBoxPlan.FormattingEnabled = true;
            this.cBoxPlan.Location = new System.Drawing.Point(73, 36);
            this.cBoxPlan.Name = "cBoxPlan";
            this.cBoxPlan.Size = new System.Drawing.Size(356, 23);
            this.cBoxPlan.TabIndex = 0;
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(37, 40);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(30, 15);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Plan";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso";
            // 
            // cBoxCurso
            // 
            this.cBoxCurso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxCurso, 2);
            this.cBoxCurso.FormattingEnabled = true;
            this.cBoxCurso.Location = new System.Drawing.Point(73, 132);
            this.cBoxCurso.Name = "cBoxCurso";
            this.cBoxCurso.Size = new System.Drawing.Size(356, 23);
            this.cBoxCurso.TabIndex = 3;
            // 
            // cBoxDocente
            // 
            this.cBoxDocente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDocentesCursos.SetColumnSpan(this.cBoxDocente, 2);
            this.cBoxDocente.FormattingEnabled = true;
            this.cBoxDocente.Location = new System.Drawing.Point(73, 228);
            this.cBoxDocente.Name = "cBoxDocente";
            this.cBoxDocente.Size = new System.Drawing.Size(356, 23);
            this.cBoxDocente.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 232);
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
    }
}