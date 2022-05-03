
namespace chevere_master
{
    partial class frmChildMenu_GUI
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_init_text = new System.Windows.Forms.Label();
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_init_text
            // 
            this.lbl_init_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_init_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_init_text.Location = new System.Drawing.Point(32, 76);
            this.lbl_init_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_init_text.Name = "lbl_init_text";
            this.lbl_init_text.Size = new System.Drawing.Size(459, 418);
            this.lbl_init_text.TabIndex = 0;
            this.lbl_init_text.Text = "Welcome!\r\nTo every\r\ninch of El Salvador!\r\n";
            this.lbl_init_text.Click += new System.EventHandler(this.lbl_init_text_Click);
            // 
            // picHome
            // 
            this.picHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.picHome.Image = global::chevere_master.Properties.Resources.home;
            this.picHome.Location = new System.Drawing.Point(576, 0);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(506, 707);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 0;
            this.picHome.TabStop = false;
            // 
            // frmChildMenu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 707);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.lbl_init_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChildMenu_GUI";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.PictureBox picHome;
        protected System.Windows.Forms.Label lbl_init_text;
    }
}