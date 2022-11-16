using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Modelo;

namespace A
{
    public partial class Form1 : Form
    {

        Familia familia1 = new Familia();

        public Form1()
        {
            InitializeComponent();
        }

        private void btCompletar_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvFamilia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaFamilia altaFamilia = new AltaFamilia("A");
            altaFamilia.Text = "Alta Familia";
            altaFamilia.ShowDialog();


            dgvFamilia.DataSource = familia1.llenarFamilia();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            AltaFamilia modificarFamilia = new AltaFamilia("M");
            modificarFamilia.Text = "Modificar Familia";

            

            modificarFamilia.ShowDialog();



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idFamilia = dgvFamilia.SelectedCells[0].Value.ToString();
            familia1.eliminarFamilia(idFamilia);

            dgvFamilia.DataSource = familia1.llenarFamilia();
        }
    }
}
