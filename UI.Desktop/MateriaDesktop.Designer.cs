
namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lPlan = new System.Windows.Forms.Label();
            this.lHoraSemana = new System.Windows.Forms.Label();
            this.lHoraTotal = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHorasSem = new System.Windows.Forms.TextBox();
            this.txtHorasTot = new System.Windows.Forms.TextBox();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00827F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.32231F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00826F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.66116F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.lDescripcion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lPlan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lHoraSemana, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lHoraTotal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHorasSem, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHorasTot, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPlan, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lDescripcion
            // 
            this.lDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(17, 37);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lDescripcion.TabIndex = 2;
            this.lDescripcion.Text = "Descripcion";
            // 
            // lPlan
            // 
            this.lPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPlan.AutoSize = true;
            this.lPlan.Location = new System.Drawing.Point(36, 67);
            this.lPlan.Name = "lPlan";
            this.lPlan.Size = new System.Drawing.Size(30, 15);
            this.lPlan.TabIndex = 3;
            this.lPlan.Text = "Plan";
            // 
            // lHoraSemana
            // 
            this.lHoraSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lHoraSemana.AutoSize = true;
            this.lHoraSemana.Location = new System.Drawing.Point(331, 37);
            this.lHoraSemana.Name = "lHoraSemana";
            this.lHoraSemana.Size = new System.Drawing.Size(97, 15);
            this.lHoraSemana.TabIndex = 4;
            this.lHoraSemana.Text = "Horas Semanales";
            // 
            // lHoraTotal
            // 
            this.lHoraTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lHoraTotal.AutoSize = true;
            this.lHoraTotal.Location = new System.Drawing.Point(341, 67);
            this.lHoraTotal.Name = "lHoraTotal";
            this.lHoraTotal.Size = new System.Drawing.Size(76, 15);
            this.lHoraTotal.TabIndex = 5;
            this.lHoraTotal.Text = "Horas totales";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Location = new System.Drawing.Point(106, 33);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(219, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // txtHorasSem
            // 
            this.txtHorasSem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtHorasSem, 2);
            this.txtHorasSem.Location = new System.Drawing.Point(434, 33);
            this.txtHorasSem.Name = "txtHorasSem";
            this.txtHorasSem.Size = new System.Drawing.Size(198, 23);
            this.txtHorasSem.TabIndex = 7;
            // 
            // txtHorasTot
            // 
            this.txtHorasTot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtHorasTot, 2);
            this.txtHorasTot.Location = new System.Drawing.Point(434, 63);
            this.txtHorasTot.Name = "txtHorasTot";
            this.txtHorasTot.Size = new System.Drawing.Size(198, 23);
            this.txtHorasTot.TabIndex = 8;
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPlan.DisplayMember = "Descripcion";
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Location = new System.Drawing.Point(106, 63);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(219, 23);
            this.comboBoxPlan.TabIndex = 9;
            this.comboBoxPlan.ValueMember = "ID";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Location = new System.Drawing.Point(551, 124);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(465, 124);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 152);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lPlan;
        private System.Windows.Forms.Label lHoraSemana;
        private System.Windows.Forms.Label lHoraTotal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHorasSem;
        private System.Windows.Forms.TextBox txtHorasTot;
        private System.Windows.Forms.ComboBox comboBoxPlan;
    }
}