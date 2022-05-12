
namespace chevere_master
{
    partial class frmTouristRouts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTouristRouts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdistancia = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_Comentario = new System.Windows.Forms.Panel();
            this.dgw_Comentarios = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Puntuación = new System.Windows.Forms.Label();
            this.btn_Comentar = new FontAwesome.Sharp.IconButton();
            this.cbx_Puntuación = new System.Windows.Forms.ComboBox();
            this.txb_Comentario = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnl_Comentario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(48, 9);
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
            this.map.Size = new System.Drawing.Size(656, 522);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtdistancia);
            this.panel1.Controls.Add(this.map);
            this.panel1.Location = new System.Drawing.Point(430, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 543);
            this.panel1.TabIndex = 1;
            // 
            // txtdistancia
            // 
            this.txtdistancia.AutoSize = true;
            this.txtdistancia.Location = new System.Drawing.Point(28, 665);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(0, 20);
            this.txtdistancia.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(430, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 65);
            this.panel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 46);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chevere TouristRouts";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::chevere_master.Properties.Resources.close;
            this.pictureBox4.Location = new System.Drawing.Point(784, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbl_description);
            this.panel3.Location = new System.Drawing.Point(42, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 402);
            this.panel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción: ";
            // 
            // lbl_description
            // 
            this.lbl_description.Location = new System.Drawing.Point(31, 101);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(286, 174);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = resources.GetString("lbl_description.Text");
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "seguimiento de ruta";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(96, 112);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_name.TabIndex = 21;
            // 
            // pnl_Comentario
            // 
            this.pnl_Comentario.AutoScroll = true;
            this.pnl_Comentario.Controls.Add(this.dgw_Comentarios);
            this.pnl_Comentario.Controls.Add(this.lbl_Puntuación);
            this.pnl_Comentario.Controls.Add(this.btn_Comentar);
            this.pnl_Comentario.Controls.Add(this.cbx_Puntuación);
            this.pnl_Comentario.Controls.Add(this.txb_Comentario);
            this.pnl_Comentario.Location = new System.Drawing.Point(429, 609);
            this.pnl_Comentario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_Comentario.Name = "pnl_Comentario";
            this.pnl_Comentario.Size = new System.Drawing.Size(788, 257);
            this.pnl_Comentario.TabIndex = 22;
            // 
            // dgw_Comentarios
            // 
            this.dgw_Comentarios.BackgroundColor = System.Drawing.Color.White;
            this.dgw_Comentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_Comentarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_Comentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_Comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Comentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Comentario,
            this.Puntuación});
            this.dgw_Comentarios.EnableHeadersVisualStyles = false;
            this.dgw_Comentarios.GridColor = System.Drawing.Color.White;
            this.dgw_Comentarios.Location = new System.Drawing.Point(4, 102);
            this.dgw_Comentarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgw_Comentarios.Name = "dgw_Comentarios";
            this.dgw_Comentarios.ReadOnly = true;
            this.dgw_Comentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Outlook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_Comentarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_Comentarios.RowHeadersVisible = false;
            this.dgw_Comentarios.RowHeadersWidth = 62;
            this.dgw_Comentarios.Size = new System.Drawing.Size(758, 231);
            this.dgw_Comentarios.TabIndex = 5;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.MinimumWidth = 8;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 145;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.MinimumWidth = 8;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 250;
            // 
            // Puntuación
            // 
            this.Puntuación.HeaderText = "Puntuación";
            this.Puntuación.MinimumWidth = 8;
            this.Puntuación.Name = "Puntuación";
            this.Puntuación.ReadOnly = true;
            this.Puntuación.Width = 80;
            // 
            // lbl_Puntuación
            // 
            this.lbl_Puntuación.AutoSize = true;
            this.lbl_Puntuación.Location = new System.Drawing.Point(660, 28);
            this.lbl_Puntuación.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Puntuación.Name = "lbl_Puntuación";
            this.lbl_Puntuación.Size = new System.Drawing.Size(89, 20);
            this.lbl_Puntuación.TabIndex = 4;
            this.lbl_Puntuación.Text = "Puntuación";
            // 
            // btn_Comentar
            // 
            this.btn_Comentar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Comentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Comentar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Comentar.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btn_Comentar.IconColor = System.Drawing.Color.White;
            this.btn_Comentar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Comentar.IconSize = 25;
            this.btn_Comentar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Comentar.Location = new System.Drawing.Point(4, 23);
            this.btn_Comentar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Comentar.Name = "btn_Comentar";
            this.btn_Comentar.Size = new System.Drawing.Size(136, 69);
            this.btn_Comentar.TabIndex = 3;
            this.btn_Comentar.Text = "Comentar";
            this.btn_Comentar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Comentar.UseVisualStyleBackColor = false;
            this.btn_Comentar.Click += new System.EventHandler(this.btn_Comentar_Click);
            // 
            // cbx_Puntuación
            // 
            this.cbx_Puntuación.FormattingEnabled = true;
            this.cbx_Puntuación.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_Puntuación.Location = new System.Drawing.Point(651, 60);
            this.cbx_Puntuación.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Puntuación.Name = "cbx_Puntuación";
            this.cbx_Puntuación.Size = new System.Drawing.Size(109, 28);
            this.cbx_Puntuación.TabIndex = 2;
            // 
            // txb_Comentario
            // 
            this.txb_Comentario.Location = new System.Drawing.Point(142, 23);
            this.txb_Comentario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Comentario.Multiline = true;
            this.txb_Comentario.Name = "txb_Comentario";
            this.txb_Comentario.Size = new System.Drawing.Size(504, 67);
            this.txb_Comentario.TabIndex = 1;
            // 
            // frmTouristRouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 871);
            this.Controls.Add(this.pnl_Comentario);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTouristRouts";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Info_rutas";
            this.Load += new System.EventHandler(this.Info_rutas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_Comentario.ResumeLayout(false);
            this.pnl_Comentario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Comentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label txtdistancia;
        private System.Windows.Forms.Panel pnl_Comentario;
        private System.Windows.Forms.ComboBox cbx_Puntuación;
        private System.Windows.Forms.TextBox txb_Comentario;
        private FontAwesome.Sharp.IconButton btn_Comentar;
        private System.Windows.Forms.DataGridView dgw_Comentarios;
        private System.Windows.Forms.Label lbl_Puntuación;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuación;
    }
}