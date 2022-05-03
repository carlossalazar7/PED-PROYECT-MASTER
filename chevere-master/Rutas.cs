using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevere_master
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }

        private void Rutas_Load(object sender, EventArgs e)
        {

            //******************************************************
            // create a new control
            PictureBox pb = new PictureBox();

            // assign the image
            pb.Image = new Bitmap("C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga.jpeg");

            // stretch the image
            pb.SizeMode = PictureBoxSizeMode.StretchImage;

            // set the size of the picture box
            pb.Height = 140;
            pb.Width = 200;

            // add the control to the container
            panel1.Controls.Add(pb);

            //******************************************************

            // create a new control
            PictureBox pb2 = new PictureBox();

            // assign the image
            pb2.Image = new Bitmap("C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/imagen1.jpg");

            // stretch the image
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;

            // set the size of the picture box
            pb2.Height = 140;
            pb2.Width = 200;
            pb2.Location = new Point(250, 10);

            //******************************************************

            // create a new control
            PictureBox pb3 = new PictureBox();

            // assign the image
            pb3.Image = new Bitmap("C:/Users/carlos/OneDrive/Escritorio/Programación con Estructura de Datos/proyecto/prototipo/descarga (1).jpeg");

            // stretch the image
            pb2.SizeMode = PictureBoxSizeMode.StretchImage;

            // set the size of the picture box
            pb3.Height = 140;
            pb3.Width = 200;
            pb3.Location = new Point(500, 10);

            // add the control to the container
            panel1.Controls.Add(pb);
            panel1.Controls.Add(pb2);
            panel1.Controls.Add(pb3);


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            new Rutas().Hide();
            new frmTouristRouts().Show();
        }


    }
}
