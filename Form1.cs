using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller.clase;

namespace Taller
{
    public partial class Form1 : Form
    {
        Servicio servicio = new Servicio();
        Trabajo trabajo = new Trabajo();
        public Form1()
        {
            InitializeComponent();
            tbSeguro.Enabled = false;
            Reparaciones();
        }

        private void Reparaciones()
        {
            cbReparacion.Items.Clear();
            string[] reparaciones = {"Motor", "Transmisión", "Frenos", "Electricidad" };
            cbReparacion.Items.AddRange(reparaciones);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                servicio.Marca = tbMarca.Text;
                servicio.Modelo = tbModelo.Text;
                servicio.Año = int.Parse(tbAño.Text);
                servicio.Matricula = int.Parse(tbMatricula.Text);
                servicio.Reparacion = cbReparacion.SelectedItem.ToString();
                servicio.Seguro = tbSeguro.Text;
                trabajo.Agregar(servicio);
                Mostrar();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mostrar()
        {
            dgvSalida.DataSource = null;
            dgvSalida.DataSource = trabajo.Mostrar();
        }

        private void chbSeguro_CheckedChanged(object sender, EventArgs e)
        {
            tbSeguro.Enabled = chbSeguro.Checked;
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btmLimpiar_Click(object sender, EventArgs e)
        {
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbAño.Text = "";
            tbMatricula.Text = "";
            cbReparacion.SelectedIndex = -1;
            tbSeguro.Text = "";
        }
    }
}
