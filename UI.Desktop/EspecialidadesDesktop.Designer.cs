
namespace UI.Desktop
{
    partial class EspecialidadesDesktop
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
            this.tlEspecialidadesDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxEspecialidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxId = new System.Windows.Forms.TextBox();
            this.tlEspecialidadesDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlEspecialidadesDesktop
            // 
            this.tlEspecialidadesDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlEspecialidadesDesktop.ColumnCount = 3;
            this.tlEspecialidadesDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.10938F));
            this.tlEspecialidadesDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.89063F));
            this.tlEspecialidadesDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlEspecialidadesDesktop.Controls.Add(this.label1, 0, 1);
            this.tlEspecialidadesDesktop.Controls.Add(this.tboxEspecialidad, 1, 1);
            this.tlEspecialidadesDesktop.Controls.Add(this.label2, 0, 0);
            this.tlEspecialidadesDesktop.Controls.Add(this.tboxId, 1, 0);
            this.tlEspecialidadesDesktop.Controls.Add(this.btnCancelar, 2, 2);
            this.tlEspecialidadesDesktop.Controls.Add(this.btnGuardar, 1, 2);
            this.tlEspecialidadesDesktop.Location = new System.Drawing.Point(-2, 1);
            this.tlEspecialidadesDesktop.Name = "tlEspecialidadesDesktop";
            this.tlEspecialidadesDesktop.RowCount = 3;
            this.tlEspecialidadesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.87156F));
            this.tlEspecialidadesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.12844F));
            this.tlEspecialidadesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlEspecialidadesDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlEspecialidadesDesktop.Size = new System.Drawing.Size(520, 150);
            this.tlEspecialidadesDesktop.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Location = new System.Drawing.Point(353, 124);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(442, 124);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Especialidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tboxEspecialidad
            // 
            this.tboxEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlEspecialidadesDesktop.SetColumnSpan(this.tboxEspecialidad, 2);
            this.tboxEspecialidad.Location = new System.Drawing.Point(163, 68);
            this.tboxEspecialidad.Name = "tboxEspecialidad";
            this.tboxEspecialidad.Size = new System.Drawing.Size(332, 23);
            this.tboxEspecialidad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // tboxId
            // 
            this.tboxId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlEspecialidadesDesktop.SetColumnSpan(this.tboxId, 2);
            this.tboxId.Location = new System.Drawing.Point(163, 13);
            this.tboxId.Name = "tboxId";
            this.tboxId.ReadOnly = true;
            this.tboxId.Size = new System.Drawing.Size(332, 23);
            this.tboxId.TabIndex = 5;
            // 
            // EspecialidadesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(517, 148);
            this.Controls.Add(this.tlEspecialidadesDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EspecialidadesDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidad";
            this.tlEspecialidadesDesktop.ResumeLayout(false);
            this.tlEspecialidadesDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlEspecialidadesDesktop;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxId;
    }
}