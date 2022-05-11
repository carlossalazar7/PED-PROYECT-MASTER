namespace chevere_master
{
    partial class frmReset
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblprincipal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelImagen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.Size = new System.Drawing.Size(411, 576);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(411, 0);
            this.panel1.Size = new System.Drawing.Size(727, 70);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(681, 12);
            // 
            // btnMaximizise
            // 
            this.btnMaximizise.FlatAppearance.BorderSize = 0;
            this.btnMaximizise.Location = new System.Drawing.Point(618, 12);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(559, 12);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::chevere_master.Properties.Resources.Turismo_en_El_Salvador;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(411, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCrearCuenta);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.lblprincipal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(411, 70);
            this.panel2.Size = new System.Drawing.Size(727, 506);
            this.panel2.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.panel2.Controls.SetChildIndex(this.btnAtras, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.lblprincipal, 0);
            this.panel2.Controls.SetChildIndex(this.txtCorreo, 0);
            this.panel2.Controls.SetChildIndex(this.btnBuscar, 0);
            this.panel2.Controls.SetChildIndex(this.txtMessage, 0);
            this.panel2.Controls.SetChildIndex(this.txtPassword, 0);
            this.panel2.Controls.SetChildIndex(this.lblPassword, 0);
            this.panel2.Controls.SetChildIndex(this.btnCrearCuenta, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Location = new System.Drawing.Point(88, 12);
            this.lblTitleChildForm.Size = new System.Drawing.Size(279, 38);
            this.lblTitleChildForm.Text = "Password Change";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(386, 7);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(95, 427);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(378, 316);
            this.btnSiguiente.Text = "Guardar Contraseña";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 37);
            this.label2.TabIndex = 30;
            this.label2.Text = "Recuperar Contraseña";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPassword.Location = new System.Drawing.Point(92, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(89, 18);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Contraseña:";
            this.lblPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(187, 224);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 22);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Visible = false;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(213)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCrearCuenta.Location = new System.Drawing.Point(193, 314);
            this.btnCrearCuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCrearCuenta.Size = new System.Drawing.Size(103, 34);
            this.btnCrearCuenta.TabIndex = 26;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Visible = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(161, 257);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 16);
            this.txtMessage.TabIndex = 25;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(104)))), ((int)(((byte)(213)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(154, 171);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBuscar.Size = new System.Drawing.Size(103, 32);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(154, 123);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(288, 22);
            this.txtCorreo.TabIndex = 23;
            // 
            // lblprincipal
            // 
            this.lblprincipal.AutoSize = true;
            this.lblprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblprincipal.Location = new System.Drawing.Point(92, 124);
            this.lblprincipal.Name = "lblprincipal";
            this.lblprincipal.Size = new System.Drawing.Size(56, 18);
            this.lblprincipal.TabIndex = 22;
            this.lblprincipal.Text = "correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(90, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ingrese su correo asociado a la cuenta";
            // 
            // frmReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 576);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReset";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Reset Password";
            this.panelImagen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblprincipal;
        private System.Windows.Forms.Label label1;
    }
}