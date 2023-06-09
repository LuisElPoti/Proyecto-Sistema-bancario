﻿using CoreServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CORE_INTERFACES
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            CargarClientes();
            CargarPerfiles();
        }

        wsReferenceUsuario.WSUsuarioClient Referencia = new wsReferenceUsuario.WSUsuarioClient();
        wsReferencePerfil.WSPerfilClient Referencia1 = new wsReferencePerfil.WSPerfilClient();
        wsReferenceCliente.WSClienteClient Referencia2 = new wsReferenceCliente.WSClienteClient();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int ClienteID = (int)cbCliente.SelectedValue;
            int PerfilID = (int)cbPerfil.SelectedValue;
            if (Referencia.ValidarSeguridad(tbClave.Text))
            {
                Referencia.CrearUsuario(PerfilID, ClienteID, tbNombre.Text, tbClave.Text);
                MostrarInfo();
                MessageBox.Show("Usuario Registrado!");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("La clave no es segura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // no realizar acción deseada
            }
            
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbID.Text);
                List<Usuario>  usuarios = new List<Usuario>();
                usuarios = Referencia.BuscarUsuario(id);
                //List<Cliente> clientes = client.BuscarCliente(id);

                if (usuarios != null && usuarios.Count > 0)
                {
                    
                    dgvUsuario.DataSource = usuarios;
                    dgvUsuario.AutoGenerateColumns = true;
                    MessageBox.Show("Cliente encontrado.");
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar cliente: " + ex.Message);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Referencia.ActualizarUsuario(int.Parse(tbID.Text), int.Parse(cbPerfil.Text), int.Parse(cbCliente.SelectedValue.ToString()), tbNombre.Text, tbClave.Text);
            MessageBox.Show("Cliente Modificado!");
            LimpiarCampos();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Referencia.EliminarUsuario(int.Parse(tbID.Text));
            MessageBox.Show("Usuario Eliminado!");
            LimpiarCampos();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (Referencia.ValidarSeguridad(tbClave.Text))
            {
                lblSeguridad.Text = "La clave cumple con los criterios de seguridad.";
                lblSeguridad.ForeColor = Color.Green;
            }
            else
            {
                lblSeguridad.Text = "La clave no cumple con los criterios de seguridad.";
                lblSeguridad.ForeColor = Color.Red;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        void LimpiarCampos()
        {
            foreach (Control c in panel1.Controls) //Recorremos cada elemento del contenedor que posee los campos
                if (typeof(TextBox) == c.GetType()) //Si es un textbox
                {
                    c.Text = ""; //Limpia el contenido del control
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CargarClientes()
        {
            List<Cliente> clientes  = new List<Cliente>();
            clientes = Referencia2.MostrarClientes();
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "idCliente";

        }
        private void CargarPerfiles()
        {
            List<Perfil> perfil = new List<Perfil>();
            perfil = Referencia1.MostrarPerfiles();
            cbPerfil.DataSource = perfil;
            cbPerfil.DisplayMember = "Nombre";
            cbPerfil.ValueMember = "idPerfil";
        }

        private void cbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cbPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void MostrarInfo()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = Referencia.MostrarUsuarios();
            dgvUsuario.DataSource = usuarios;
            dgvUsuario.AutoGenerateColumns = true;
            
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
