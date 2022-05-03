namespace chevere_master
{
    partial class frmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linklblPassBack = new System.Windows.Forms.LinkLabel();
            this.btnVerContrasenia = new System.Windows.Forms.PictureBox();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ipicpass = new FontAwesome.Sharp.IconPictureBox();
            this.ipicuser = new FontAwesome.Sharp.IconPictureBox();
            this.panelImagen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicuser)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.Size = new System.Drawing.Size(566, 495);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(634, 70);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(583, 20);
            // 
            // btnMaximizise
            // 
            this.btnMaximizise.FlatAppearance.BorderSize = 0;
            this.btnMaximizise.Location = new System.Drawing.Point(531, 20);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(479, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::chevere_master.Properties.Resources.imagen1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(566, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ipicuser);
            this.panel2.Controls.Add(this.ipicpass);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.linklblPassBack);
            this.panel2.Controls.Add(this.btnVerContrasenia);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(634, 425);
            this.panel2.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.panel2.Controls.SetChildIndex(this.btnAtras, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.txtUsuario, 0);
            this.panel2.Controls.SetChildIndex(this.txtPass, 0);
            this.panel2.Controls.SetChildIndex(this.txtMessage, 0);
            this.panel2.Controls.SetChildIndex(this.btnVerContrasenia, 0);
            this.panel2.Controls.SetChildIndex(this.linklblPassBack, 0);
            this.panel2.Controls.SetChildIndex(this.linkLabel2, 0);
            this.panel2.Controls.SetChildIndex(this.ipicpass, 0);
            this.panel2.Controls.SetChildIndex(this.ipicuser, 0);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Location = new System.Drawing.Point(93, 14);
            this.lblTitleChildForm.Size = new System.Drawing.Size(163, 38);
            this.lblTitleChildForm.Text = "Welcome!";
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Route;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(28, 12);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(268, 3);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(-202, 189);
            this.btnAtras.Text = "Salir";
            this.btnAtras.Visible = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSiguiente.Location = new System.Drawing.Point(243, 257);
            this.btnSiguiente.Text = "Log in";
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(176, 332);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(253, 17);
            this.linkLabel2.TabIndex = 37;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Aún sin cuenta?Crea tu cuenta ahora";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linklblPassBack
            // 
            this.linklblPassBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linklblPassBack.AutoSize = true;
            this.linklblPassBack.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblPassBack.Location = new System.Drawing.Point(215, 309);
            this.linklblPassBack.Name = "linklblPassBack";
            this.linklblPassBack.Size = new System.Drawing.Size(154, 17);
            this.linklblPassBack.TabIndex = 36;
            this.linklblPassBack.TabStop = true;
            this.linklblPassBack.Text = "Recuperar Contraseña";
            this.linklblPassBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPassBack_LinkClicked);
            // 
            // btnVerContrasenia
            // 
            this.btnVerContrasenia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerContrasenia.Image = global::chevere_master.Properties.Resources._495_4950508_show_password_show_password_icon_png_transparent_png;
            this.btnVerContrasenia.Location = new System.Drawing.Point(445, 214);
            this.btnVerContrasenia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerContrasenia.Name = "btnVerContrasenia";
            this.btnVerContrasenia.Size = new System.Drawing.Size(27, 22);
            this.btnVerContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVerContrasenia.TabIndex = 35;
            this.btnVerContrasenia.TabStop = false;
            this.btnVerContrasenia.Click += new System.EventHandler(this.btnVerContrasenia_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMessage.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(176, 257);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(0, 16);
            this.txtMessage.TabIndex = 34;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(176, 214);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(249, 22);
            this.txtPass.TabIndex = 31;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.Location = new System.Drawing.Point(176, 161);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(249, 22);
            this.txtUsuario.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "¿Tienes pensado un nuevo sitio para conocer?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "¡Hola de nuevo!";
            // 
            // ipicpass
            // 
            this.ipicpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ipicpass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipicpass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.ipicpass.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipicpass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipicpass.Location = new System.Drawing.Point(124, 214);
            this.ipicpass.Name = "ipicpass";
            this.ipicpass.Size = new System.Drawing.Size(32, 32);
            this.ipicpass.TabIndex = 38;
            this.ipicpass.TabStop = false;
            // 
            // ipicuser
            // 
            this.ipicuser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ipicuser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ipicuser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ipicuser.IconColor = System.Drawing.SystemColors.ControlText;
            this.ipicuser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipicuser.Location = new System.Drawing.Point(124, 161);
            this.ipicuser.Name = "ipicuser";
            this.ipicuser.Size = new System.Drawing.Size(32, 32);
            this.ipicuser.TabIndex = 39;
            this.ipicuser.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 495);
            this.Name = "frmLogIn";
            this.panelImagen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipicuser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linklblPassBack;
        private System.Windows.Forms.PictureBox btnVerContrasenia;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ipicuser;
        private FontAwesome.Sharp.IconPictureBox ipicpass;
    }
}

