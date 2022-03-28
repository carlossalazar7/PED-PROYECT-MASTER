using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;


namespace chevere_master
{
    public partial class Home : Form
    {
        private IconButton Actual; // se guarda el boton actual para modificarlo
        private Panel leftpanel;
        private Form ActualForm; // Se guarda al formulario mostrado en el panel
                                 // Variables para verificacion de usuarios o admins


        public Home()
        {
            InitializeComponent();
            leftpanel = new Panel();
            leftpanel.Size = new Size(10, 80);
            pnl_left.Controls.Add(leftpanel);
            FormIni();
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

        private void IBtn_Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private struct colors
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

        private void SelectButton(object senderBtn, Color color) // metodo para la visualizacion de los botones
        {

            if (senderBtn != null)
            {
                deselectButton();

                if (Home1.IconColor == colors.color1)
                {
                    Home1.BackColor = Color.FromArgb(74, 104, 213);
                    Home1.IconColor = Color.White;
                    Home1.ImageAlign = ContentAlignment.MiddleCenter;
                }

                Actual = (IconButton)senderBtn;
                Actual.BackColor = Color.FromArgb(0, 113, 115);
                Actual.IconColor = color;
                Actual.ImageAlign = ContentAlignment.MiddleRight;

                leftpanel.BackColor = color;
                leftpanel.Location = new Point(0, Actual.Location.Y);
                leftpanel.BringToFront();
            }
        }

        private void deselectButton()
        {
            if (Actual != null)
            {
                Actual.BackColor = Color.FromArgb(74, 104, 213);
                Actual.IconColor = Color.White;
                Actual.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color1);
            OpenFrm(new Menu());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color2);
            OpenFrm(new Info_rutas());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color3);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color4);
        }

        private void UserList_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color5);
            //OpenFrm(new Administar_usuarios());
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color6);
        }

        private void Maintenance_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color7);
        }

        private void Favorites_Click(object sender, EventArgs e)
        {
            SelectButton(sender, colors.color8);
        }

        private void OpenFrm(Form newForm) //Metodo para abrir un formulario en el panel
        {
            if (ActualForm != null)
            {
                ActualForm.Close();
            }
            ActualForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            FormsPanel.Controls.Add(newForm);
            FormsPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
            lbl_FormInfo.Text = newForm.Text;
        }

        private void FormIni()
        {
            Home1.BackColor = Color.FromArgb(0, 113, 115);
            Home1.IconColor = colors.color1;
            Home1.ImageAlign = ContentAlignment.MiddleRight;

            leftpanel.BackColor = colors.color1;
            leftpanel.Location = new Point(0, Home1.Location.Y);
            leftpanel.BringToFront();
            OpenFrm(new Menu());
        }
    }
}
