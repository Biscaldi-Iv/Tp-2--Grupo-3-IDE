
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.lID = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lClave = new System.Windows.Forms.Label();
            this.lApellido = new System.Windows.Forms.Label();
            this.lUsuario = new System.Windows.Forms.Label();
            this.lCclave = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNomber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.chkHabilitado, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lNombre, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lClave, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lApellido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lUsuario, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lCclave, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNomber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtClave, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuario, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtApellido, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 173);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAceptar.Location = new System.Drawing.Point(310, 142);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 25);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(391, 142);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(299, 7);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(81, 19);
            this.chkHabilitado.TabIndex = 2;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // lID
            // 
            this.lID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(39, 9);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 15);
            this.lID.TabIndex = 3;
            this.lID.Text = "ID";
            // 
            // lNombre
            // 
            this.lNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(23, 43);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(51, 15);
            this.lNombre.TabIndex = 4;
            this.lNombre.Text = "Nombre";
            // 
            // lEmail
            // 
            this.lEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(30, 77);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(36, 15);
            this.lEmail.TabIndex = 5;
            this.lEmail.Text = "Email";
            // 
            // lClave
            // 
            this.lClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lClave.AutoSize = true;
            this.lClave.Location = new System.Drawing.Point(30, 111);
            this.lClave.Name = "lClave";
            this.lClave.Size = new System.Drawing.Size(36, 15);
            this.lClave.TabIndex = 6;
            this.lClave.Text = "Clave";
            // 
            // lApellido
            // 
            this.lApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lApellido.AutoSize = true;
            this.lApellido.Location = new System.Drawing.Point(314, 43);
            this.lApellido.Name = "lApellido";
            this.lApellido.Size = new System.Drawing.Size(51, 15);
            this.lApellido.TabIndex = 7;
            this.lApellido.Text = "Apellido";
            // 
            // lUsuario
            // 
            this.lUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(316, 77);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(47, 15);
            this.lUsuario.TabIndex = 8;
            this.lUsuario.Text = "Usuario";
            // 
            // lCclave
            // 
            this.lCclave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lCclave.AutoSize = true;
            this.lCclave.Location = new System.Drawing.Point(307, 104);
            this.lCclave.Name = "lCclave";
            this.lCclave.Size = new System.Drawing.Size(64, 30);
            this.lCclave.TabIndex = 9;
            this.lCclave.Text = "Confirmar Clave";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(120, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(148, 23);
            this.txtID.TabIndex = 10;
            // 
            // txtNomber
            // 
            this.txtNomber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomber.Location = new System.Drawing.Point(120, 39);
            this.txtNomber.Name = "txtNomber";
            this.txtNomber.Size = new System.Drawing.Size(148, 23);
            this.txtNomber.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(120, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 23);
            this.txtEmail.TabIndex = 12;
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Location = new System.Drawing.Point(120, 107);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(148, 23);
            this.txtClave.TabIndex = 13;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmarClave.Location = new System.Drawing.Point(391, 107);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(188, 23);
            this.txtConfirmarClave.TabIndex = 14;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(391, 73);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(188, 23);
            this.txtUsuario.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.Location = new System.Drawing.Point(391, 39);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 23);
            this.txtApellido.TabIndex = 16;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 191);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(598, 230);
            this.MinimumSize = new System.Drawing.Size(598, 230);
            this.Name = "UsuarioDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioDesktop";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lClave;
        private System.Windows.Forms.Label lApellido;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.Label lCclave;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNomber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
    }
}