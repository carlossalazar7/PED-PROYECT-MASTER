﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevere_master
{
    public partial class Reset : Form
    {
        //conexion bd
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private static Conexion conexion = new Conexion();
        private User usuario = new User();
        public Reset()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar si devuelve un registro
                if (usuario.SeachUser(txtCorreo.Text).Rows.Count == 1)
                {
                    txtMessage.Text = "Ingresa tu nueva contraseña: ";
                    btnSavePassword.Visible = true;
                    txtPassword.Visible = true;
                    lblPassword.Visible = true;
                }
                else
                {
                    txtMessage.Text = "Parece que no tienes cuenta, crea tu cuenta ahora";
                    btnCrearCuenta.Visible = true;
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message.ToString();
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmCreateAccount().Show();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            //call update password

            bool resultado = usuario.ChangePassword(txtCorreo.Text, txtPassword.Text);
             if (resultado)
            {
                txtMessage.Text = "Contraseña actualizada";
                txtMessage.ForeColor = Color.Green;
                new frmLogIn().Show();
            }

            else MessageBox.Show("Error al momento de actualizar la contraseña");


        }

    }
}
