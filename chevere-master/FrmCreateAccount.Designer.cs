namespace chevere_master
{
    partial class FrmCreateAccount
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
            this.components = new System.ComponentModel.Container();
            this.txtapelli = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.DtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmbgen = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbnit = new System.Windows.Forms.MaskedTextBox();
            this.cmbDocument = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirmed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelImagen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImagen
            // 
            this.panelImagen.Size = new System.Drawing.Size(513, 700);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(513, 0);
            this.panel1.Size = new System.Drawing.Size(787, 70);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(735, 20);
            // 
            // btnMaximizise
            // 
            this.btnMaximizise.FlatAppearance.BorderSize = 0;
            this.btnMaximizise.Location = new System.Drawing.Point(672, 20);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(613, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::chevere_master.Properties.Resources.Flags;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(513, 700);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(513, 70);
            this.panel2.Size = new System.Drawing.Size(787, 630);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel2.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel2.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.panel2.Controls.SetChildIndex(this.btnAtras, 0);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Text = "Sign up";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(335, 4);
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAtras.Location = new System.Drawing.Point(40, 560);
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSiguiente.Location = new System.Drawing.Point(611, 560);
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // txtapelli
            // 
            this.txtapelli.Location = new System.Drawing.Point(302, 54);
            this.txtapelli.Margin = new System.Windows.Forms.Padding(4);
            this.txtapelli.Name = "txtapelli";
            this.txtapelli.Size = new System.Drawing.Size(220, 31);
            this.txtapelli.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.DtpBirthDate);
            this.groupBox1.Controls.Add(this.cmbgen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mtbnit);
            this.groupBox1.Controls.Add(this.cmbDocument);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtapelli);
            this.groupBox1.Font = new System.Drawing.Font("Noto Sans SemCond", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(40, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 263);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Informacion Personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Documento:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(497, 217);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 31);
            this.comboBox1.TabIndex = 41;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(158, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 27);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "F";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 202);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 27);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(491, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 23);
            this.label12.TabIndex = 38;
            this.label12.Text = "Naiconalidad:*";
            // 
            // DtpBirthDate
            // 
            this.DtpBirthDate.Location = new System.Drawing.Point(302, 137);
            this.DtpBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpBirthDate.Name = "DtpBirthDate";
            this.DtpBirthDate.Size = new System.Drawing.Size(325, 31);
            this.DtpBirthDate.TabIndex = 37;
            // 
            // cmbgen
            // 
            this.cmbgen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgen.FormattingEnabled = true;
            this.cmbgen.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbgen.Location = new System.Drawing.Point(250, 217);
            this.cmbgen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbgen.Name = "cmbgen";
            this.cmbgen.Size = new System.Drawing.Size(171, 31);
            this.cmbgen.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Genero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Departamento Reside:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "Fecha de Nacimiento*";
            // 
            // mtbnit
            // 
            this.mtbnit.Location = new System.Drawing.Point(111, 137);
            this.mtbnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbnit.Name = "mtbnit";
            this.mtbnit.Size = new System.Drawing.Size(127, 31);
            this.mtbnit.TabIndex = 30;
            // 
            // cmbDocument
            // 
            this.cmbDocument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocument.FormattingEnabled = true;
            this.cmbDocument.Items.AddRange(new object[] {
            "DUI",
            "NIT",
            "Pasaporte"});
            this.cmbDocument.Location = new System.Drawing.Point(18, 137);
            this.cmbDocument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDocument.Name = "cmbDocument";
            this.cmbDocument.Size = new System.Drawing.Size(78, 31);
            this.cmbDocument.TabIndex = 28;
            this.cmbDocument.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellido *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre *";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(18, 54);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(220, 31);
            this.txtname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans SemCond", 12F);
            this.label5.Location = new System.Drawing.Point(35, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 27);
            this.label5.TabIndex = 27;
            this.label5.Text = " Por favor brindanos las siguiente informacion para crear tu cuenta:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtpassword);
            this.groupBox2.Controls.Add(this.txtPasswordConfirmed);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Noto Sans SemCond", 10.2F);
            this.groupBox2.Location = new System.Drawing.Point(40, 370);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(674, 167);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Información de inicio de sesión";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(302, 34);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(341, 31);
            this.txtemail.TabIndex = 5;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(423, 75);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(220, 31);
            this.txtpassword.TabIndex = 4;
            // 
            // txtPasswordConfirmed
            // 
            this.txtPasswordConfirmed.Location = new System.Drawing.Point(423, 116);
            this.txtPasswordConfirmed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordConfirmed.Name = "txtPasswordConfirmed";
            this.txtPasswordConfirmed.Size = new System.Drawing.Size(220, 31);
            this.txtPasswordConfirmed.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Confirmar Contraseña:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Contraseña:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Correo:";
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CreateAccount";
            this.panelImagen.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtapelli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDocument;
        private System.Windows.Forms.MaskedTextBox mtbnit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cmbgen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtPasswordConfirmed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpBirthDate;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}