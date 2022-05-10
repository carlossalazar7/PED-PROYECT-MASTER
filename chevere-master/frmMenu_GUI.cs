using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;


namespace chevere_master
{
    public partial class frmMenu_GUI : Form
    {
        //Campos para trabar con el menu.
        private IconButton currentBtn; // se guarda el boton currentBtn para modificarlo
        private Panel leftBorderBtn;   //Panel para aplicar un borde izquierdo al boton.
        protected Form currentChildForm;   // Se guarda al formulario mostrado en el panel
        protected frmChildMenu_GUI frmHome;

        private SqlCommand command;
        private SqlDataAdapter adapt;
        private Conexion conexion = new Conexion();



        public frmMenu_GUI()
        {
            InitializeComponent();
            names();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 64);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm( frmHome = new frmChildMenu_GUI());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPararm);

        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private struct colorsRGB
        {
            public static Color color1 = Color.FromArgb(7, 228, 0);
            public static Color color2 = Color.FromArgb(177, 23, 193);
            public static Color color3 = Color.FromArgb(6, 244, 154);
            public static Color color4 = Color.FromArgb(218, 249, 114);
            public static Color color5 = Color.FromArgb(0, 252, 244);
            public static Color color6 = Color.FromArgb(183, 196, 179);
            public static Color color7 = Color.FromArgb(116, 135, 252);
            public static Color color8 = Color.FromArgb(251, 255, 0);
        }

        private void ActivateButton(object senderBtn, Color color) // Metodo para la activacion de los botones
        {

            if (senderBtn != null)
            {
                deselectButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 113, 115);
                currentBtn.IconColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child form
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;

            }
        }

        private void deselectButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(74, 104, 213);
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void OpenChildForm(Form childForm) //Metodo para abrir un formulario en el panel
        {
            if (currentChildForm != null)
            {
                //Open only one form
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


           
        }

        private void btnTouristRouts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color1);
            OpenChildForm(new frmTouristRouts());

        }

        private void btnFavoriteRouts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color2);
            OpenChildForm(new frmFavoriteRouts());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color3);
            OpenChildForm(new FrmActualizar_info());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color4);
            //OpenChildForm(new frmSetting());
        }

        private void btnAddRout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color5);
            //OpenChildForm(new frmRout());
        }

        private void btnCheckUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color6);
            //OpenChildForm(new frmCheckUsers());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, colorsRGB.color7);
            DialogResult resultado = MessageBox.Show("Seguro que desea salir?","Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                new frmLogIn().Show();
                this.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null) currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            deselectButton();
            leftBorderBtn.Visible = false;
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.Lime;
            lblTitleChildForm.Text = "Home";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizise_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void names()
        {
            conexion.Conectar();
            string sql = "SELECT users.first_name, Country.name From users INNER JOIN Country ON users.country_id = Country.id where email = @mail";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("mail", frmLogIn.user);

            adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            lbl_Username.Text = dt.Rows[0][0].ToString();
            lbl_Country.Text = dt.Rows[0][1].ToString();


            conexion.Cerrar();
        }




    }
}
