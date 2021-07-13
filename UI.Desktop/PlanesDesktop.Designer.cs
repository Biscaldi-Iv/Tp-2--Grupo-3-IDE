
namespace UI.Desktop
{
    partial class PlanesDesktop
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
            this.tlPlanes_desktop = new System.Windows.Forms.TableLayoutPanel();
            this.cbEspecialidades = new System.Windows.Forms.ComboBox();
            this.txtBDesc_Plan = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tlPlanes_desktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPlanes_desktop
            // 
            this.tlPlanes_desktop.ColumnCount = 3;
            this.tlPlanes_desktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlPlanes_desktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.1875F));
            this.tlPlanes_desktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.6875F));
            this.tlPlanes_desktop.Controls.Add(this.cbEspecialidades, 1, 2);
            this.tlPlanes_desktop.Controls.Add(this.txtBDesc_Plan, 1, 1);
            this.tlPlanes_desktop.Controls.Add(this.btnGuardar, 2, 4);
            this.tlPlanes_desktop.Controls.Add(this.btnCancelar, 1, 4);
            this.tlPlanes_desktop.Controls.Add(this.label2, 0, 2);
            this.tlPlanes_desktop.Controls.Add(this.label1, 0, 1);
            this.tlPlanes_desktop.Controls.Add(this.txtD, 1, 0);
            this.tlPlanes_desktop.Controls.Add(this.label3, 0, 0);
            this.tlPlanes_desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlanes_desktop.Location = new System.Drawing.Point(0, 0);
            this.tlPlanes_desktop.Name = "tlPlanes_desktop";
            this.tlPlanes_desktop.RowCount = 5;
            this.tlPlanes_desktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.84099F));
            this.tlPlanes_desktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.78092F));
            this.tlPlanes_desktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72085F));
            this.tlPlanes_desktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.65725F));
            this.tlPlanes_desktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlPlanes_desktop.Size = new System.Drawing.Size(288, 321);
            this.tlPlanes_desktop.TabIndex = 0;
            // 
            // cbEspecialidades
            // 
            this.cbEspecialidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPlanes_desktop.SetColumnSpan(this.cbEspecialidades, 2);
            this.cbEspecialidades.DisplayMember = "Descripcion";
            this.cbEspecialidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidades.FormattingEnabled = true;
            this.cbEspecialidades.Location = new System.Drawing.Point(98, 87);
            this.cbEspecialidades.Name = "cbEspecialidades";
            this.cbEspecialidades.Size = new System.Drawing.Size(187, 23);
            this.cbEspecialidades.TabIndex = 4;
            this.cbEspecialidades.ValueMember = "ID";
            // 
            // txtBDesc_Plan
            // 
            this.txtBDesc_Plan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPlanes_desktop.SetColumnSpan(this.txtBDesc_Plan, 2);
            this.txtBDesc_Plan.Location = new System.Drawing.Point(98, 50);
            this.txtBDesc_Plan.Name = "txtBDesc_Plan";
            this.txtBDesc_Plan.Size = new System.Drawing.Size(187, 23);
            this.txtBDesc_Plan.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Location = new System.Drawing.Point(219, 295);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(138, 295);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Especialidad:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plan:";
            // 
            // txtD
            // 
            this.txtD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPlanes_desktop.SetColumnSpan(this.txtD, 2);
            this.txtD.Location = new System.Drawing.Point(98, 9);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(187, 23);
            this.txtD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id:";
            // 
            // PlanesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 321);
            this.Controls.Add(this.tlPlanes_desktop);
            this.Name = "PlanesDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlanesDesktop";
            this.tlPlanes_desktop.ResumeLayout(false);
            this.tlPlanes_desktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPlanes_desktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbEspecialidades;
        private System.Windows.Forms.TextBox txtBDesc_Plan;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label3;
    }
}