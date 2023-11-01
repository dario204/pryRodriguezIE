﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryRodriguezIE
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           ValidarDatos();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
        public void ValidarDatos()
        {
            if (txtUsuario.Text!= "" && txtContraseña.Text!="" )
            {
                btnInicioSesion.Enabled = true;
            }
            else
            {
                btnInicioSesion.Enabled = false;
            }
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            clsLogs ObjBd = new clsLogs();
            ObjBd.RegistrarLogs();
            
            StreamWriter sw = new StreamWriter("logInicio", true);
            sw.WriteLine(txtUsuario.Text + "-Fecha:" + DateTime.Now);
            sw.Close();

            this.Hide();
            frmMain Main = new frmMain();
            Main.ShowDialog();

            clsLogs clsUsuarios = new clsLogs();

            if (clsUsuarios.Validarusuarios(txtUsuario.Text, txtContraseña.Text))
            {
                this.Hide();
                frmMain frminicio = new frmMain();
                frminicio.lblUsuario.Text = txtUsuario.Text;
                frminicio.Gestion.Enabled = false;
                frminicio.ShowDialog();
            }
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
