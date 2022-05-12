namespace chevere_master
{
    partial class frmAddRouts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbclima = new System.Windows.Forms.ComboBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableSitios = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetRout = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSitios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHome
            // 
            this.picHome.Dock = System.Windows.Forms.DockStyle.None;
            this.picHome.Location = new System.Drawing.Point(190, 102);
            this.picHome.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.picHome.Size = new System.Drawing.Size(294, 554);
            // 
            // lbl_init_text
            // 
            this.lbl_init_text.Location = new System.Drawing.Point(766, 258);
            this.lbl_init_text.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox20);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.btnImagen);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbcategoria);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbclima);
            this.panel1.Controls.Add(this.lbldescripcion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tableSitios);
            this.panel1.Controls.Add(this.btnGetRout);
            this.panel1.Controls.Add(this.btnAddPoint);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtLong);
            this.panel1.Controls.Add(this.txtLat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 740);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox20.Image = global::chevere_master.Properties.Resources.Para_mi_amorcito;
            this.pictureBox20.Location = new System.Drawing.Point(422, 68);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(34, 40);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 23;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(400, 146);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(190, 102);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 22;
            this.pictureBox10.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImagen.Location = new System.Drawing.Point(400, 35);
            this.btnImagen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(190, 98);
            this.btnImagen.TabIndex = 20;
            this.btnImagen.Text = "Upload";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subir Imagen";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(166, 265);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(199, 28);
            this.cmbcategoria.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Clima";
            // 
            // cmbclima
            // 
            this.cmbclima.FormattingEnabled = true;
            this.cmbclima.Location = new System.Drawing.Point(166, 228);
            this.cmbclima.Name = "cmbclima";
            this.cmbclima.Size = new System.Drawing.Size(199, 28);
            this.cmbclima.TabIndex = 14;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(68, 180);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 20);
            this.lbldescripcion.TabIndex = 13;
            this.lbldescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(166, 180);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(199, 26);
            this.txtDescripcion.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(166, 51);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 26);
            this.txtnombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sitios Cargados";
            // 
            // tableSitios
            // 
            this.tableSitios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSitios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Latitud,
            this.Longitud});
            this.tableSitios.Location = new System.Drawing.Point(29, 451);
            this.tableSitios.Name = "tableSitios";
            this.tableSitios.RowHeadersWidth = 62;
            this.tableSitios.RowTemplate.Height = 28;
            this.tableSitios.Size = new System.Drawing.Size(561, 151);
            this.tableSitios.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Latitud
            // 
            this.Latitud.HeaderText = "Latitud";
            this.Latitud.MinimumWidth = 8;
            this.Latitud.Name = "Latitud";
            this.Latitud.Width = 150;
            // 
            // Longitud
            // 
            this.Longitud.HeaderText = "Longitud";
            this.Longitud.MinimumWidth = 8;
            this.Longitud.Name = "Longitud";
            this.Longitud.Width = 150;
            // 
            // btnGetRout
            // 
            this.btnGetRout.Location = new System.Drawing.Point(220, 318);
            this.btnGetRout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGetRout.Name = "btnGetRout";
            this.btnGetRout.Size = new System.Drawing.Size(84, 29);
            this.btnGetRout.TabIndex = 7;
            this.btnGetRout.Text = "Get Rout";
            this.btnGetRout.UseVisualStyleBackColor = true;
            this.btnGetRout.Click += new System.EventHandler(this.btnGetRout_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(360, 318);
            this.btnAddPoint.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(84, 29);
            this.btnAddPoint.TabIndex = 6;
            this.btnAddPoint.Text = "Add point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(66, 318);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(84, 29);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(476, 318);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(166, 140);
            this.txtLong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(199, 26);
            this.txtLong.TabIndex = 3;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(166, 95);
            this.txtLat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(199, 26);
            this.txtLat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitud";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.map);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(606, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 740);
            this.panel2.TabIndex = 0;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(610, 740);
            this.map.TabIndex = 8;
            this.map.Zoom = 0D;
            this.map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddRouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmAddRouts";
            this.Text = "frmAddRouts";
            this.Load += new System.EventHandler(this.frmAddRouts_Load);
            this.Controls.SetChildIndex(this.picHome, 0);
            this.Controls.SetChildIndex(this.lbl_init_text, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSitios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetRout;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tableSitios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitud;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbclima;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox20;
    }
}