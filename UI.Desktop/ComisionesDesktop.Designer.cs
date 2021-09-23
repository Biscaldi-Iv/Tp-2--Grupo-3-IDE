
namespace UI.Desktop
{
    partial class ComisionesDesktop
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
            this.label_id_com = new System.Windows.Forms.Label();
            this.txtIDCom = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txt_anio_Esp = new System.Windows.Forms.TextBox();
            this.anio_especialidad = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.label_id_plan = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.comboBoxPlan = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.10526F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.92105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.29268F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.68903F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Controls.Add(this.label_id_com, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtIDCom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_anio_Esp, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.anio_especialidad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_id_plan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPlan, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_id_com
            // 
            this.label_id_com.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_id_com.AutoSize = true;
            this.label_id_com.Location = new System.Drawing.Point(36, 23);
            this.label_id_com.Name = "label_id_com";
            this.label_id_com.Size = new System.Drawing.Size(72, 15);
            this.label_id_com.TabIndex = 0;
            this.label_id_com.Text = "ID Comision";
            // 
            // txtIDCom
            // 
            this.txtIDCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDCom.Location = new System.Drawing.Point(114, 19);
            this.txtIDCom.Name = "txtIDCom";
            this.txtIDCom.ReadOnly = true;
            this.txtIDCom.Size = new System.Drawing.Size(195, 23);
            this.txtIDCom.TabIndex = 4;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(114, 84);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(195, 23);
            this.txtDesc.TabIndex = 6;
            // 
            // txt_anio_Esp
            // 
            this.txt_anio_Esp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txt_anio_Esp, 2);
            this.txt_anio_Esp.Location = new System.Drawing.Point(434, 84);
            this.txt_anio_Esp.Name = "txt_anio_Esp";
            this.txt_anio_Esp.Size = new System.Drawing.Size(305, 23);
            this.txt_anio_Esp.TabIndex = 7;
            // 
            // anio_especialidad
            // 
            this.anio_especialidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.anio_especialidad.AutoSize = true;
            this.anio_especialidad.Location = new System.Drawing.Point(331, 88);
            this.anio_especialidad.Name = "anio_especialidad";
            this.anio_especialidad.Size = new System.Drawing.Size(97, 15);
            this.anio_especialidad.TabIndex = 3;
            this.anio_especialidad.Text = "Año Especialidad";
            // 
            // labelDesc
            // 
            this.labelDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(39, 88);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(69, 15);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Descripcion";
            // 
            // label_id_plan
            // 
            this.label_id_plan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_id_plan.AutoSize = true;
            this.label_id_plan.Location = new System.Drawing.Point(398, 23);
            this.label_id_plan.Name = "label_id_plan";
            this.label_id_plan.Size = new System.Drawing.Size(30, 15);
            this.label_id_plan.TabIndex = 2;
            this.label_id_plan.Text = "Plan";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(664, 170);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(572, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // comboBoxPlan
            // 
            this.comboBoxPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxPlan, 2);
            this.comboBoxPlan.DisplayMember = "Descripcion";
            this.comboBoxPlan.FormattingEnabled = true;
            this.comboBoxPlan.Location = new System.Drawing.Point(434, 19);
            this.comboBoxPlan.Name = "comboBoxPlan";
            this.comboBoxPlan.Size = new System.Drawing.Size(305, 23);
            this.comboBoxPlan.TabIndex = 10;
            this.comboBoxPlan.ValueMember = "ID";
            // 
            // ComisionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 196);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ComisionesDesktop";
            this.Text = "Comision";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_id_com;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label label_id_plan;
        private System.Windows.Forms.Label anio_especialidad;
        private System.Windows.Forms.TextBox txtIDCom;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txt_anio_Esp;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBoxPlan;
    }
}